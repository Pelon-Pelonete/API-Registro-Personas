using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.CommandStack.Models
{
    public class DatosFamiliaresPersona
    {
        private int personaId;
        private bool tieneHijos;
        private string nombresHijo;
        private int edadHijo;
        private string nombreConyuge;
        private string nombreMadre;
        private string nombrePadre;

        public int PersonaId { get => personaId; set => personaId = value; }
        public bool TieneHijos { get => tieneHijos; set => tieneHijos = value; }
        public string GetTieneHijos() {  return TieneHijos ? "Si" : "No"; }
        public void SetTieneHijos(bool tieneHijos) { this.TieneHijos = tieneHijos; }
        public string NombresHijo { get => nombresHijo; set => nombresHijo = value; }
        public int EdadHijo { get => edadHijo; set => edadHijo = value; }
        public string NombreConyuge { get => nombreConyuge; set => nombreConyuge = value; }
        public string NombreMadre { get => nombreMadre; set => nombreMadre = value; }
        public string NombrePadre { get => nombrePadre; set => nombrePadre = value; }

        public DatosFamiliaresPersona(){ }

        public DatosFamiliaresPersona(int personaId,bool tieneHijos,string nombresHijo,int edadHijo,string nombreConyuge,string nombreMadre,string nombrePadre)
        {
            PersonaId = personaId;
            TieneHijos = tieneHijos;
            NombresHijo = nombresHijo;
            EdadHijo = edadHijo;
            NombreConyuge = nombreConyuge;
            NombreMadre = nombreMadre;
            NombrePadre = nombrePadre;
        }
    }
}
