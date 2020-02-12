using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.API.Models
{
    public class TelefonoPersonaInput
    {
        private Guid personaId;
        private Guid telefonoId;
        private int tipoTelefono;
        private string telefono;

        public int TipoTelefono { get => tipoTelefono; set => tipoTelefono = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public Guid PersonaId { get => personaId; set => personaId = value; }
        public Guid TelefonoId { get => telefonoId; set => telefonoId = value; }

        public TelefonoPersonaInput(Guid personaId,Guid telefonoId,int tipoTelefono, string telefono)
        {
            PersonaId = personaId;
            TelefonoId = telefonoId;
            this.TipoTelefono = tipoTelefono;
            this.Telefono = telefono;
        }
    }
}
