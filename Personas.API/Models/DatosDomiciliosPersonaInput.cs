﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.API.Models
{
    public class DatosDomiciliosPersonaInput
    {
        private Guid personaId;
        private Guid domicilioId;
        private int departamento;
        private int municipio;
        private int ciudad;
        private int barrioColoniaResidencia;
        private string direccion;
        private bool aquiRecibeCitacion;

        public int Departamento { get => departamento; set => departamento = value; }
        public int Municipio { get => municipio; set => municipio = value; }
        public int Ciudad { get => ciudad; set => ciudad = value; }
        public int BarrioColoniaResidencia { get => barrioColoniaResidencia; set => barrioColoniaResidencia = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool AquiRecibeCitacion { get => aquiRecibeCitacion; set => aquiRecibeCitacion = value; }
        public Guid PersonaId { get => personaId; set => personaId = value; }
        public Guid DomicilioId { get => domicilioId; set => domicilioId = value; }

        public DatosDomiciliosPersonaInput(){}

        public DatosDomiciliosPersonaInput(Guid personaId,Guid domicilioId,int departamento,int municipio,int ciudad,int barrioColoniaResidencia,string direccion,bool aquiRecibeCitacion)
        {
            PersonaId = personaId;
            DomicilioId = domicilioId;
            Departamento = departamento;
            Municipio = municipio;
            Ciudad = ciudad;
            BarrioColoniaResidencia = barrioColoniaResidencia;
            Direccion = direccion;
            AquiRecibeCitacion = aquiRecibeCitacion;
        }
    }
}