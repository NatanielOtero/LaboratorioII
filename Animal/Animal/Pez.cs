using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace Animal
{
    [Serializable]
    public class Pez:Animal,Mascota
    {
        private string _nombre;

        public Pez()
        {
 
        }
        public Pez(int patas,string nombre):base(patas)
        {
            this._nombre = nombre;
        }

        public override void Comer()
        {
            Console.WriteLine("come comida para pez");
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
        public override void Caminar()
        {
            Console.WriteLine("Nada");
        }
        public void Jugar()
        {
            Console.WriteLine("juega como pez");
        }
    }
}
