using System;
using System.Collections.Generic;
using System.Text;

namespace SharedElements
{
    public interface IResultado
    {
        bool Correcto { get; set; }
        string Mensaje { get; set; }
    }
}
