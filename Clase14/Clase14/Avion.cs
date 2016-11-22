using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioInterfaces
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        private double _velocidadMaxima;
    
        public Avion(double precio, double velMax):base(precio)
        {
            this._velocidadMaxima = velMax;
        }



        public double CalcularImpuesto()
        {
            return this._precio * 1.33;
        }

        public override double Precio
        {
            get
            {
                return base.Precio + this.CalcularImpuesto();
            }
            set
            {
                base.Precio = value;
            }
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this.Precio);
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 1.27;
        }
    }
}
