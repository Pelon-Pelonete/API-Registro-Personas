using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.API.Models
{
    public class PersonaInput
    {
        private Guid personaId;
        private DatosGeneralesPersonaInput generalidadesPersona;
        private DatosFamiliaresPersonaInput familiaresPersona;
        private List<DatosDomiciliosPersonaInput> domicilioPersona;
        private List<TelefonoPersonaInput> telefonosPersona;
        private List<CorreoPersonaInput> correosPersona;

        public DatosGeneralesPersonaInput GeneralidadesPersona { get => generalidadesPersona; set => generalidadesPersona = value; }
        public DatosFamiliaresPersonaInput FamiliaresPersona { get => familiaresPersona; set => familiaresPersona = value; }

        private List<DatosDomiciliosPersonaInput> GetDatosDomiciliosPersonas()
        {
            return domicilioPersona ?? (domicilioPersona = new List<DatosDomiciliosPersonaInput>());
        }

        private List<TelefonoPersonaInput> GetTelefonoPersonas()
        {
            return telefonosPersona ?? (telefonosPersona = new List<TelefonoPersonaInput>());
        }

        private List<CorreoPersonaInput> GetCorreoPersonas()
        {
            return correosPersona ?? (correosPersona = new List<CorreoPersonaInput>());
        }

        public PersonaInput(){}

        public IReadOnlyCollection<DatosDomiciliosPersonaInput> DomiciliosPersona => GetDatosDomiciliosPersonas();
        public IReadOnlyCollection<TelefonoPersonaInput> TelefonosPersona => GetTelefonoPersonas();
        public IReadOnlyCollection<CorreoPersonaInput> CorreosPersona => GetCorreoPersonas();

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
