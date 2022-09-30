using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaseAlumnos;
namespace MetodosAdicionales
{
    public class Medotos
    {
        private static string SetString () 
        {
            string nombre = Console.ReadLine();
            return nombre;
        }

        private static int SetInt ()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        private static Alumno CargarAlumno(int id, string curso)
        {
            var alum = new Alumno();
            alum.Id = id + 1;
            System.Console.WriteLine("Nombre");
            alum.Nombre = SetString();
            System.Console.WriteLine("Apellido");
            alum.Apellido = SetString();
            System.Console.WriteLine("DNI");
            alum.Dni = SetInt();
            alum.Curso = curso;
            return alum;
        }

        public static List<Alumno> SetList (int cantAlum, string curso)
        {
            var listCurso = new List<Alumno>();
            for (int cant = 0; cant < cantAlum; cant++)
            {
                listCurso.Add(CargarAlumno(cant, curso));
            }
            return listCurso;
        }
    }
}