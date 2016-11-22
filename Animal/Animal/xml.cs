﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace Animal
{
    public class xml<T>:ISerializable<T>
    {
        public bool serializar(string archivo, T datos)
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8);
                serializador.Serialize(escritor, datos);
                escritor.Close();
                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException.Message);
                return false;
            }
        }
       
    }
}
