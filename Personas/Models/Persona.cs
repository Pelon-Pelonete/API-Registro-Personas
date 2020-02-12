using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.CommandStack.Models
{
    public class Persona
    {
        private Guid personaId;
        private DatosGeneralesPersona generalidadesPersona;
        private DatosFamiliaresPersona familiaresPersona;
        private List<DatosDomiciliosPersona> domicilioPersona;
        private List<TelefonoPersona> telefonosPersona;
        private List<CorreoPersona> correosPersona;

        public DatosGeneralesPersona GeneralidadesPersona { get => generalidadesPersona; set => generalidadesPersona = value; }
        public DatosFamiliaresPersona FamiliaresPersona { get => familiaresPersona; set => familiaresPersona = value; }

        private List<DatosDomiciliosPersona> GetDatosDomiciliosPersonas()
        {
            return domicilioPersona ?? (domicilioPersona = new List<DatosDomiciliosPersona>());
        }

        private List<TelefonoPersona> GetTelefonoPersonas()
        {
            return telefonosPersona ?? (telefonosPersona = new List<TelefonoPersona>());
        }

        private List<CorreoPersona> GetCorreoPersonas()
        {
            return correosPersona ?? (correosPersona = new List<CorreoPersona>());
        }

        public Persona(){}

        public IReadOnlyCollection<DatosDomiciliosPersona> DomiciliosPersona => GetDatosDomiciliosPersonas();
        public IReadOnlyCollection<TelefonoPersona> TelefonosPersona => GetTelefonoPersonas();
        public IReadOnlyCollection<CorreoPersona> CorreosPersona => GetCorreoPersonas();

        /*public Persona(Guid personaId,DatosGeneralesPersona generalidadesPersona,DatosFamiliaresPersona familiaresPersona, List<DatosDomiciliosPersona> domicilioPersona,List<TelefonoPersona> telefonosPersona,List<CorreoPersona> correosPersona)
        {
            this.personaId = personaId;
            GeneralidadesPersona = generalidadesPersona;
            FamiliaresPersona = familiaresPersona;
        }*/

        public class Factory {

        }
    }
}
