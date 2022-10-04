using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaseAlumnos;
using MetodosAdicionales;
using Exceptions;
namespace Helper
{
    public class HelperDeArchivos
    {
        public static void CrearCarpeta ()
        {
            string target = Directory.GetCurrentDirectory() + @"\Cursos";
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }
        }
        private static int CountList (List<Alumno> lista, string path)
        {
            int count = 0;
            foreach (string line in File.ReadLines(path))
            {
                count++;
            }
            return count;
        }
        private static void EscrivirArchivo (List<Alumno> lista, string curso)
        {
            string archivo = curso + ".csv",
                path = Directory.GetCurrentDirectory() + @"/Cursos/" + archivo;
            if(!File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path))
                {
                    foreach(var elemet in lista)
                    {
                        sw.WriteLine(elemet.Id + "," + elemet.Apellido+"," + elemet.Nombre + "," + elemet.Dni);
                    }
                }
            }else
            {
                int newId = CountList(lista, path);
                using(StreamWriter sw = File.AppendText(path))
                {
                    foreach(var elemet in lista)
                    {
                        newId += 1;
                        sw.WriteLine((newId + "," + elemet.Apellido+"," + elemet.Nombre + "," + elemet.Dni));
                    }
                }
            }
        }
        private static void ClearFile (string curso)
        {
            string path = Directory.GetCurrentDirectory() + @"/Cursos/"+curso+".csv";
            File.Delete(path);
        }

        public static void DeleteOrAdd (List<Alumno> lista, string curso)
        {
            System.Console.WriteLine("1)Agregar\n2)Borrar Lista");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option < 1 || option > 2)
            {
                throw new ExceptionClass("Se ingresó un numero incorrecto");
            }
            if(option == 1)
            {
                CrearCarpeta();
                System.Console.WriteLine("Ingrese la cantidad de Alumnos para este curso:");
                int cantAlum = Convert.ToInt32(Console.ReadLine());
                if(cantAlum <= 0)
                {
                    throw new ExceptionClass("Se ingresó un numero menor o igual que 0");
                }
                lista = Medotos.SetList(cantAlum,curso);
                EscrivirArchivo(lista,curso);
            }
            if(option == 2)
            {
                ClearFile(curso);
            }
        }
    }
}