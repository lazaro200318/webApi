using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectox.Models
{
    public class Alumno
    {
        [PrimaryKey,AutoIncrement]
        public int Id  {get; set;}
        [MaxLength(50)]
        public string Nombres {get; set;}
        public string apellido {get; set;}
        public string Matricula  {get; set;}
        public string Carrera {get; set;}
        public string Correo {get; set;}
        public string Telefono {get; set;}
        public string Lugar_Origen {get; set;}
        public string Lugar_Estancia {get; set;}

        private class PrimaryKeyAttribute : Attribute
        {}
        private class AutoIncrementAttribute : Attribute
        {}
        private class MaxLengthAttribute : Attribute
        {
            public MaxLengthAttribute(int v)
            {}
        }

    }
}