using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Animal
{
    [Serializable]
    public class Araña:Animal,Mascota
    {
        private string _nombre;

        public Araña()
        {

        }

        public Araña(string nombre, int patas)
            : base(patas)
        {
            this._nombre = nombre;
        }

        public override void Caminar()
        {
            Console.WriteLine("Camina con " + this._patas);
        }
        public override void Comer()
        {
            Console.WriteLine("come bichos");
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public void Jugar()
        {
            Console.WriteLine("Juega como araña");
        }
    }
}
