
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ClaseAlumnos;
using MetodosAdicionales;

string[] cursos = {"Atletimo","Voley","Futbol"};
List<Alumno> L_Atletismo =new List<Alumno>(),
    L_Voley =new List<Alumno>(),
    L_Futbol =new List<Alumno>();

System.Console.WriteLine("1)Atletimo\n2)Voley\n3)Futbol");
int option = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ingrese la cantidad de Alumnos para este curso:");
int cantAlum = Convert.ToInt32(Console.ReadLine());

if(option == 1){
    L_Atletismo = Medotos.SetList(cantAlum,cursos[0]);
}
if(option == 2){
    L_Voley = Medotos.SetList(cantAlum,cursos[1]);
}
if(option == 3){
    L_Futbol = Medotos.SetList(cantAlum,cursos[2]);
}