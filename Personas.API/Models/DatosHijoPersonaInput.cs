using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personas.API.Models
{
    public class DatosHijoPersonaInput
    {
        private string nombreCompleto;
        private int edadHijo = 0;

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int EdadHijo
        {
            get => edadHijo;
            set
            {
                if (value > 0)
                {
                    edadHijo = value;
                }
            }
        }

        public DatosHijoPersonaInput() { }

        public DatosHijoPersonaInput(string nombreCompleto, int edadHijo)
        {
            NombreCompleto = nombreCompleto;
            EdadHijo = edadHijo;
        }
    }
}
