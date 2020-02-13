using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Personas.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IMediator mediator;
        //private readonly IServiceProvider serviceProvider;

        public PersonasController(IMediator mediator)//, IServiceProvider serviceProvider)
        {
            this.mediator = mediator;
            //this.serviceProvider = serviceProvider;
        }

        [HttpPost]
        public async Task<IActionResult> guardarNuevaPersona(PersonaInput persona)
        {
            if (ModelState.IsValid)
            {
                Guid idPersona = Guid.NewGuid();
                persona.FamiliaresPersona.PersonaId = idPersona;
                var generalidadesPersona = new CommandStack.Models.DatosGeneralesPersona(persona.GeneralidadesPersona.TipoIdentificacion, persona.GeneralidadesPersona.Identificacion, 
                                                                                         persona.GeneralidadesPersona.NombreCompleto, persona.GeneralidadesPersona.FechaNacimiento, 
                                                                                         persona.GeneralidadesPersona.Departamento, persona.GeneralidadesPersona.Municipio, 
                                                                                         persona.GeneralidadesPersona.Sexo, persona.GeneralidadesPersona.EstadoCivil, 
                                                                                         persona.GeneralidadesPersona.ProfesionOficio, persona.GeneralidadesPersona.GrupoVulnerable, 
                                                                                         persona.GeneralidadesPersona.GrupoEtnico, persona.GeneralidadesPersona.Nacionalidad, 
                                                                                         persona.GeneralidadesPersona.EstructuraCriminal
                                                                                         );

                var hijos = new List<CommandStack.Models.DatosHijoPersona>();

                foreach (var hijo in persona.FamiliaresPersona.Hijos)
                {
                    hijos.Add(new CommandStack.Models.DatosHijoPersona(hijo.NombreCompleto,hijo.EdadHijo));
                }

                var familiaresPersona = new CommandStack.Models.DatosFamiliaresPersona(persona.FamiliaresPersona.PersonaId, persona.FamiliaresPersona.TieneHijos,
                                                                                       hijos, persona.FamiliaresPersona.NombreConyuge,
                                                                                       persona.FamiliaresPersona.NombreMadre, persona.FamiliaresPersona.NombrePadre
                                                                                       );
                var domiciliosPersona = new List<CommandStack.Models.DatosDomiciliosPersona>();
                var telefonosPersona = new List<CommandStack.Models.TelefonoPersona>();
                var correosPersona = new List<CommandStack.Models.CorreoPersona>();
                
                foreach (var domicilio in persona.DomiciliosPersona)
                {
                    domiciliosPersona.Add(new CommandStack.Models.DatosDomiciliosPersona(idPersona, domicilio.Departamento, domicilio.Municipio,domicilio.Ciudad, domicilio.BarrioColoniaResidencia, domicilio.Direccion, domicilio.AquiRecibeCitacion));
                }

                foreach (var telefono in persona.TelefonosPersona) {
                    telefono.TelefonoId = Guid.NewGuid();
                    telefonosPersona.Add(new CommandStack.Models.TelefonoPersona(idPersona,telefono.TipoTelefono,telefono.Telefono));
                }

                foreach(var correo in persona.CorreosPersona)
                {
                    correo.CorreoId = Guid.NewGuid();
                    correosPersona.Add(new CommandStack.Models.CorreoPersona(idPersona,correo.Correo));
                }

                var nuevaPersona = new CommandStack.Commands.RegistrarPersonaCommand(idPersona,generalidadesPersona,familiaresPersona,domiciliosPersona,telefonosPersona,correosPersona);

                var result=await mediator.Send(nuevaPersona);
                //var saga=(Personas.CommandStack.Sagas.PersonaSaga)serviceProvider.GetService(typeof(Personas.CommandStack.Sagas.PersonaSaga));
                //await saga.Handle(nuevaPersona, new System.Threading.CancellationToken());

                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
