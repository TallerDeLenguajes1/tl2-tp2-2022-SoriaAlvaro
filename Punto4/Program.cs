
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NLog;
using ClaseAlumnos;
using MetodosAdicionales;
using Helper;
using Exceptions;
string[] cursos = {"Atletimo","Voley","Futbol"};
List<Alumno>[] L_Cursos = new List<Alumno>[3];

//NLog
var logger = LogManager.GetCurrentClassLogger();

try
{
    
    logger.Info("Escogiendo Categorias");
    System.Console.WriteLine("1)Atletimo\n2)Voley\n3)Futbol");
    int option = Convert.ToInt32(Console.ReadLine());
    logger.Info("Entrando a las opciones de borrado o carga de datos");
    if(!(option > 0 && option <4))
    {
        throw new ExceptionClass("Se ingresó un numero incorrecto");
    }
        HelperDeArchivos.DeleteOrAdd(L_Cursos[option-1], cursos[option-1]);
}catch(FormatException ex)
{
    logger.Error("(Se ingresó una letra)" + ex.Message);
}catch(ExceptionClass ex)
{
    logger.Error(ex.Message);
}
catch(Exception ex)
{
    logger.Error(ex.Message);
}