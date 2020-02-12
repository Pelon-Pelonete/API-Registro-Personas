using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.API.Models
{
    public class PersonaInput
    {
        private DatosGeneralesPersonaInput generalidadesPersona;
        private DatosFamiliaresPersonaInput familiaresPersona;
        private List<DatosDomiciliosPersonaInput> domiciliosPersona;
        private List<TelefonoPersonaInput> telefonosPersona;
        private List<CorreoPersonaInput> correosPersona;

        public DatosGeneralesPersonaInput GeneralidadesPersona { get => generalidadesPersona; set => generalidadesPersona = value; }
        public DatosFamiliaresPersonaInput FamiliaresPersona { get => familiaresPersona; set => familiaresPersona = value; }
        public List<DatosDomiciliosPersonaInput> DomiciliosPersona { get => domiciliosPersona; set => domiciliosPersona = value; }
        public List<TelefonoPersonaInput> TelefonosPersona { get => telefonosPersona; set => telefonosPersona = value; }
        public List<CorreoPersonaInput> CorreosPersona { get => correosPersona; set => correosPersona = value; }

        /*private List<DatosDomiciliosPersonaInput> GetDatosDomiciliosPersonas()
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
        public IReadOnlyCollection<CorreoPersonaInput> CorreosPersona => GetCorreoPersonas();*/
    }
}
