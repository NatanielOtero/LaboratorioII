using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal
{

    public interface Mascota
    {
        string Nombre { get; set; }
        void Jugar();
    }
}
