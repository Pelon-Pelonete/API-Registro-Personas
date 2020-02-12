using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.API.Models
{
    public class CorreoPersonaInput
    {
        private Guid personaId;
        private Guid correoId;
        private string correo;

        public Guid PersonaId { get => personaId; set => personaId = value; }
        public string Correo { get => correo; set => correo = value; }
        public Guid CorreoId { get => correoId; set => correoId = value; }

        public CorreoPersonaInput(){}

        public CorreoPersonaInput(Guid personaId, Guid correoId,string correo)
        {
            PersonaId = personaId;
            CorreoId = correoId;
            Correo = correo;
        }
    }
}
