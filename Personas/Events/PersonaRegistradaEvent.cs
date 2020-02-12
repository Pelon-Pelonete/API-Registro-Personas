using MementoFX;
using Personas.CommandStack.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.CommandStack.Events
{
    public class PersonaRegistradaEvent : DomainEvent
    {
        private Guid personaId;
        private DatosGeneralesPersona generalidadesPersona;
        private DatosFamiliaresPersona familiaresPersona;
        private List<DatosDomiciliosPersona> domicilioPersona;
        private List<TelefonoPersona> telefonosPersona;
        private List<CorreoPersona> correosPersona;

        public Guid PersonaId { get => personaId; set => personaId = value; }
        public DatosGeneralesPersona GeneralidadesPersona { get => generalidadesPersona; set => generalidadesPersona = value; }
        public DatosFamiliaresPersona FamiliaresPersona { get => familiaresPersona; set => familiaresPersona = value; }
        public List<DatosDomiciliosPersona> DomicilioPersona { get => domicilioPersona; set => domicilioPersona = value; }
        public List<TelefonoPersona> TelefonosPersona { get => telefonosPersona; set => telefonosPersona = value; }
        public List<CorreoPersona> CorreosPersona { get => correosPersona; set => correosPersona = value; }

        public PersonaRegistradaEvent(Guid personaId,DatosGeneralesPersona generalidadesPersona,DatosFamiliaresPersona familiaresPersona, List<DatosDomiciliosPersona> domicilioPersona,List<TelefonoPersona> telefonosPersona,List<CorreoPersona> correosPersona)
        {
            PersonaId = personaId;
            GeneralidadesPersona = generalidadesPersona;
            FamiliaresPersona = familiaresPersona;
            DomicilioPersona = domicilioPersona;
            TelefonosPersona = telefonosPersona;
            CorreosPersona = correosPersona;
        }
    }
}
