
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ClaseAlumnos;
using MetodosAdicionales;
using Helper;

string[] cursos = {"Atletimo","Voley","Futbol"};
List<Alumno> L_Atletismo =new List<Alumno>(),
    L_Voley =new List<Alumno>(),
    L_Futbol =new List<Alumno>();

try
{
    
    System.Console.WriteLine("1)Atletimo\n2)Voley\n3)Futbol");
    int option = Convert.ToInt32(Console.ReadLine());

    if(option == 1){
        HelperDeArchivos.DeleteOrAdd(L_Atletismo, cursos[0]);
    }
    if(option == 2){
        HelperDeArchivos.DeleteOrAdd(L_Voley, cursos[1]);
    }
    if(option == 3){
        HelperDeArchivos.DeleteOrAdd(L_Futbol, cursos[2]);
    }
}catch(Exception ex)
{
    System.Console.WriteLine(ex.Message);
}