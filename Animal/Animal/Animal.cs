using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Animal
{
    [Serializable]
    public abstract class Animal
    {
        protected int _patas;

        public Animal()
        {
 
        }
        public Animal(int patas)
        {
            this._patas = patas;
        }

        public virtual void Caminar()
        {
            Console.WriteLine("Este animal camina en: " + this._patas);
        }
        public int Patas
        {
            get     
            {
                return this._patas;

            }
            set
            {
                this._patas = value;
            }
        }
        public abstract void Comer();
        
    }
}
