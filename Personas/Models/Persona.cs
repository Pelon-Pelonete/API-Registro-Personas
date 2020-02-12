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

        private List<DatosDomiciliosPersona> GetDatosDomiciliosPersonas()
        {
            return domicilioPersona ?? (domicilioPersona = new List<DatosDomiciliosPersona>());
        }

        private List<TelefonoPersona> GetTelefonoPersonas()
        {
            return telefonosPersona ?? (telefonosPersona = new List<TelefonoPersona>());
        }

        public DatosGeneralesPersona GeneralidadesPersona { get => generalidadesPersona; set => generalidadesPersona = value; }
        public List<DatosDomiciliosPersona> DomicilioPersona { get => domicilioPersona; set => domicilioPersona = value; }
        public List<TelefonoPersona> TelefonosPersona { get => telefonosPersona; set => telefonosPersona = value; }
        public DatosFamiliaresPersona FamiliaresPersona { get => familiaresPersona; set => familiaresPersona = value; }
        public List<CorreoPersona> CorreosPersona { get => correosPersona; set => correosPersona = value; }

        public Persona(){}

        public Persona(Guid personaId,DatosGeneralesPersona generalidadesPersona,DatosFamiliaresPersona familiaresPersona, List<DatosDomiciliosPersona> domicilioPersona,List<TelefonoPersona> telefonosPersona,List<CorreoPersona> correosPersona)
        {
            this.personaId = personaId;
            GeneralidadesPersona = generalidadesPersona;
            FamiliaresPersona = familiaresPersona;
            DomicilioPersona = domicilioPersona;
            TelefonosPersona = telefonosPersona;
            CorreosPersona = correosPersona;
        }
    }
}
