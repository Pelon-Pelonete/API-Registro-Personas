using MediatR;
using MementoFX.Persistence;
using Personas.CommandStack.Commands;
using Personas.CommandStack.Models;
using SharedElements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Personas.CommandStack.Sagas
{
    public class PersonaSaga : IRequestHandler<RegistrarPersonaCommand, Resultado>, 
                               IRequestHandler<AgregarDomicilioPersonaCommand, Resultado>
    {
        private readonly IRepository repository;
        private readonly IEventStore eventStore;

        public PersonaSaga(IRepository repository, IEventStore eventStore)
        {
            this.repository = repository;
            this.eventStore = eventStore;
        }
        public async Task<Resultado> Handle(RegistrarPersonaCommand request, CancellationToken cancellationToken)
        {
            var persona = Persona.Factory.RegistrarPersona(request.PersonaId,request.GeneralidadesPersona, request.FamiliaresPersona,request.DomicilioPersona,request.TelefonosPersona,request.CorreosPersona);
            await repository.SaveAsync(persona);
            return ResultadoFactory.Correcto();
        }

        public Task<Resultado> Handle(AgregarDomicilioPersonaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
