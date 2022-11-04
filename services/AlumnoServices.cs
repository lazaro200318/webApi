using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyectox.Models;

namespace proyectox.Services
{
    public class AlumnoService
    {
        static List<Alumno> Alumnos {get;}

        static int nextId = 3;

        static AlumnoService ()
        {
            Alumnos = new List <Alumno> {
                new Alumno
                {
                    Id = 1, 
                    Nombres = "lazaro ",
                    apellido = "sanchez",  
                    Matricula = "8521100107", 
                    Carrera = "T.S.U. en Tecnologias de la informacion",
                    Correo = "sanchez27.2021@gmail.com", 
                    Telefono = "3122665119", 
                    Lugar_Origen = "san manuel canutillo", 
                    Lugar_Estancia = "Candelaria" 
                },
               
            };
        }

        internal static void Add(object alumno)
        {
                  throw new NotImplementedException(); 
        }
        internal object create(Alumno newAlumno)
        {
            throw new NotImplementedException();
        }

        public static List<Alumno> Get()=> Alumnos;

    public static Alumno Get(int Id) => Alumnos.FirstOrDefault(p => p.Id == Id);


    public static void Add(Alumno alumno)
    {
        alumno.Id = nextId++;
        Alumnos.Add(alumno);

    }
    public async void Delete(int Id )
    {
        var alumno = Get(Id);
        if(alumno is null)
            return;

            Alumnos.Remove(alumno);
           
    }

    public async void Update(Alumno alumno)
    {
        var index = Alumnos.FindIndex(p => p.Id == alumno.Id);
        if (index == -1)
        return;

        Alumnos[index] = alumno;
    }


    }
}