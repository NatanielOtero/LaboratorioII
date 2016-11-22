using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace Animal
{
    [XmlInclude(typeof(Gato))]
    [XmlInclude(typeof(Pez))]
    [XmlInclude(typeof(Araña))]
    [XmlInclude(typeof(Animal))]
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Gato mauri = new Gato(4, "Mauricio");
            List<Araña> arañas = new List<Araña>();

        
            xml<Gato> xmlGen = new xml<Gato>();
            if (xmlGen.serializar("Animales.xml", mauri))
                Console.WriteLine("Serializado");



            while( i < 5)
            {
                arañas.Add(new Araña(i.ToString(),8));
                i++;
            }
            xml<List<Araña>> xmlLista = new xml<List<Araña>>();
            if(xmlLista.serializar("Arañas.xml",arañas))
            Console.WriteLine("Arañas serializadas");


            Console.ReadKey();
        
        }
    }
}
