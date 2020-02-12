using System;
using System.Collections.Generic;
using System.Text;

namespace SharedElements
{
    public class Resultado : IResultado
    {
        public bool Correcto { get; set; }
        public string Mensaje { get; set; }
    }
    public class Resultado<T> : IResultado<T>
    {
        public bool Correcto { get; set; }
        public string Mensaje { get; set; }
        public T Entidad { get; set; }
    }
    public static class ResultadoFactory
    {
        public static Resultado Error(string mensaje)
        {
            return new Resultado { Mensaje = mensaje, Correcto = false };
        }
        public static Resultado Correcto()
        {
            return new Resultado { Correcto = true };
        }
    }
}
