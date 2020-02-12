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
    public interface IResultado<T> : IResultado
    {
        T Entidad { get; set; }
    }
}
