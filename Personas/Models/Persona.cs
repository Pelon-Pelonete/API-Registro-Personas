using MementoFX.Domain;
using Personas.CommandStack.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.CommandStack.Models
{
    public class Persona : Aggregate,
        IApplyEvent<PersonaRegistradaEvent>
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

        public IReadOnlyCollection<DatosDomiciliosPersona> DomiciliosPersona => GetDatosDomiciliosPersonas();
        public IReadOnlyCollection<TelefonoPersona> TelefonosPersona => GetTelefonoPersonas();
        public IReadOnlyCollection<CorreoPersona> CorreosPersona => GetCorreoPersonas();

        public Guid PersonaId { get => personaId; set => personaId = value; }

        public Persona() { }

        public void ApplyEvent(PersonaRegistradaEvent @event)
        {
            PersonaId = @event.PersonaId;
            GeneralidadesPersona = @event.GeneralidadesPersona;
            FamiliaresPersona = @event.FamiliaresPersona;
            GetDatosDomiciliosPersonas().AddRange(@event.DomicilioPersona);
            GetTelefonoPersonas().AddRange(@event.TelefonosPersona);
            GetCorreoPersonas().AddRange(@event.CorreosPersona);
        }

        /*public Persona(Guid personaId,DatosGeneralesPersona generalidadesPersona,DatosFamiliaresPersona familiaresPersona, List<DatosDomiciliosPersona> domicilioPersona,List<TelefonoPersona> telefonosPersona,List<CorreoPersona> correosPersona)
        {
            this.personaId = personaId;
            GeneralidadesPersona = generalidadesPersona;
            FamiliaresPersona = familiaresPersona;
        }*/

        public class Factory {
            /// <summary>
            /// 'Levanrtar' el evento de una persona registrada.
            /// </summary>
            /// <param name="personaId">Id de la nueva persona</param>
            /// <param name="generalidadesPersona">Datos generales de la persona.</param>
            /// <param name="familiaresPersona">Datos familiares de la persona.</param>
            /// <param name="domicilioPersona">Domicilios de la persona.</param>
            /// <param name="telefonosPersona">Telefonos de la persona.</param>
            /// <param name="correosPersona">Correos de la persona.</param>
            /// <returns>Un objeto de persona.</returns>
            public static Persona RegistrarPersona(Guid personaId, DatosGeneralesPersona generalidadesPersona, DatosFamiliaresPersona familiaresPersona, List<DatosDomiciliosPersona> domicilioPersona, List<TelefonoPersona> telefonosPersona, List<CorreoPersona> correosPersona)
            {
                Persona persona = new Persona();
                var @event = new PersonaRegistradaEvent(personaId,generalidadesPersona,familiaresPersona,domicilioPersona,telefonosPersona,correosPersona);
                persona.RaiseEvent(@event);
                return persona;
            }
        }
    }
}
