using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.CommandStack.Models
{
    public class DatosFamiliaresPersona
    {
        private Guid personaId;
        private bool tieneHijos;
        private string nombreConyuge;
        private string nombreMadre;
        private string nombrePadre;
        private List<DatosHijoPersona> hijos;

        public Guid PersonaId { get => personaId; set => personaId = value; }
        public bool TieneHijos { get => tieneHijos; set => tieneHijos = value; }
        public string GetTieneHijos() {  return TieneHijos ? "Si" : "No"; }
        public void SetTieneHijos(bool tieneHijos) { this.TieneHijos = tieneHijos; }
        public string NombreConyuge { get => nombreConyuge; set => nombreConyuge = value; }
        public string NombreMadre { get => nombreMadre; set => nombreMadre = value; }
        public string NombrePadre { get => nombrePadre; set => nombrePadre = value; }
        public List<DatosHijoPersona> Hijos { get => hijos; set => hijos = value; }

        public DatosFamiliaresPersona(){ }

        public DatosFamiliaresPersona(Guid personaId,bool tieneHijos,List<DatosHijoPersona> hijos,string nombreConyuge,string nombreMadre,string nombrePadre)
        {
            PersonaId = personaId;
            TieneHijos = tieneHijos;
            Hijos = hijos;
            NombreConyuge = nombreConyuge;
            NombreMadre = nombreMadre;
            NombrePadre = nombrePadre;
        }
    }
}
