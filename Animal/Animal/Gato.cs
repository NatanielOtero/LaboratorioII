using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Animal
{
    [Serializable]
    public class Gato:Animal,Mascota
    {
        private string _nombre;

        public Gato()
        {

        }
        public Gato(int patas,string nombre):base(patas)            
        {
            this._nombre = nombre;
        }

        public override void Comer()
        {
            Console.WriteLine("Come comida de gato");
        }
        public override void Caminar()
        {
            Console.WriteLine("Camina con " + this._patas);
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
            Console.WriteLine("Juega con ratones");
        }
    }
}
