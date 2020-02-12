using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.API.Models
{
    public class DatosGeneralesPersonaInput
    {
        private Int32 tipoIdentificacion = -1;
        private string identificacion;
        private string nombreCompleto;
        private DateTime fechaNacimiento;
        private int departamento;
        private int municipio;
        private int sexo = -1;
        private int estadoCivil = -1;
        private int profesionOficio = -1;
        private int grupoVulnerable = -1;
        private int grupoEtnico = -1;
        private int nacionalidad = -1;
        private int estructuraCriminal = -1;


        public int TipoIdentificacion {
            get => tipoIdentificacion;
            set {
                if (value > 0)
                {
                    tipoIdentificacion = value;
                }
            }
        }

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Sexo
        {
            get => sexo;
            set
            {
                if (value > 0)
                { sexo = value; }
            }
        }
        public int EstadoCivil {
            get => estadoCivil;
            set
            {
                if (value > 0)
                   {estadoCivil = value; }
            }
        }
        public int ProfesionOficio
        {
            get => profesionOficio; set
            {
                if (value > 0)
                { profesionOficio = value; }
            }
        }
        public int GrupoVulnerable
        {
            get => grupoVulnerable; set
            {
                if (value > 0)
                { grupoVulnerable = value; }
            }
        }
        public int GrupoEtnico
        {
            get => grupoEtnico; set
            {
                if (value > 0)
                { grupoEtnico = value; }
            }
        }
        public int Nacionalidad
        {
            get => nacionalidad; set
            {
                if (value > 0)
                { nacionalidad = value; }
            }
        }
        public int EstructuraCriminal
        {
            get => estructuraCriminal; set
            {
                if (value > 0)
                { estructuraCriminal = value; }
            }
        }

        public int Departamento
        {
            get => departamento; 
            set
            {
                if (value > 0)
                { departamento = value; }
            }
        }
        public int Municipio
        {
            get => municipio; 
            set
            {
                if (value > 0)
                { municipio = value; }
            }
        }

       public DatosGeneralesPersonaInput(){}

       public DatosGeneralesPersonaInput(Int32 tipoIdentificacion, string identificacion,string nombreCompleto,DateTime fechaNacimiento,int departamento,int municipio,int sexo,int estadoCivil,int profesionOficio,int grupoVulnerable,int grupoEtnico,int nacionalidad,int estructuraCriminal)
        {
            TipoIdentificacion = tipoIdentificacion;
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
            Departamento = departamento;
            Municipio = municipio;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            ProfesionOficio = profesionOficio;
            GrupoVulnerable = grupoVulnerable;
            GrupoEtnico = grupoEtnico;
            Nacionalidad = nacionalidad;
            EstructuraCriminal = estructuraCriminal;
        }
    }
}
