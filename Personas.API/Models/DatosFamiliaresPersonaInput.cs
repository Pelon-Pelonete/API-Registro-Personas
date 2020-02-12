using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.API.Models
{
    public class DatosFamiliaresPersonaInput
    {
        private Guid personaId;
        private bool tieneHijos;
        private string nombreConyuge;
        private string nombreMadre;
        private string nombrePadre;
        private List<DatosHijoPersonaInput> hijos;

        public Guid PersonaId { get => personaId; set => personaId = value; }
        public bool TieneHijos { get => tieneHijos; set => tieneHijos = value; }
        public string GetTieneHijos() {  return TieneHijos ? "Si" : "No"; }
        public void SetTieneHijos(bool tieneHijos) { this.TieneHijos = tieneHijos; }
        public string NombreConyuge { get => nombreConyuge; set => nombreConyuge = value; }
        public string NombreMadre { get => nombreMadre; set => nombreMadre = value; }
        public string NombrePadre { get => nombrePadre; set => nombrePadre = value; }
        public List<DatosHijoPersonaInput> Hijos { get => hijos; set => hijos = value; }

        public DatosFamiliaresPersonaInput(){ }

        public DatosFamiliaresPersonaInput(Guid personaId,bool tieneHijos,List<DatosHijoPersonaInput> hijos,string nombreConyuge,string nombreMadre,string nombrePadre)
        {
            PersonaId = personaId;
            TieneHijos = tieneHijos;
            NombreConyuge = nombreConyuge;
            NombreMadre = nombreMadre;
            NombrePadre = nombrePadre;
        }
    }
}
