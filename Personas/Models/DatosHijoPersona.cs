using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.CommandStack.Models
{
    public class DatosHijoPersona
    {
        private Guid hijoId;
        private string nombreCompleto;
        private int edadHijo = 0;

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int EdadHijo {
            get => edadHijo;
            set {
                if (value > 0) {
                    edadHijo = value;
                }
            }
        }
        public Guid HijoId { get => hijoId; private set => hijoId = value; }

        public DatosHijoPersona() { }

        public DatosHijoPersona(string nombreCompleto, int edadHijo) {
            HijoId = Guid.NewGuid();
            NombreCompleto = nombreCompleto;
            EdadHijo = edadHijo;
        }
    }
}
