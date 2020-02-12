using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.CommandStack.Models
{
    public class CorreoPersona
    {
        private Guid personaId;
        private Guid correoId;
        private string correo;

        public Guid PersonaId { get => personaId; set => personaId = value; }
        public string Correo { get => correo; set => correo = value; }
        public Guid CorreoId { get => correoId; set => correoId = value; }

        public CorreoPersona(){}

        public CorreoPersona(Guid personaId, string correo)
        {
            PersonaId = personaId;
            CorreoId = Guid.NewGuid();
            Correo = correo;
        }
    }
}
