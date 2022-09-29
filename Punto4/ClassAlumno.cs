using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseAlumnos
{
    public class Alumno
    {
        private int id;
        private string? nombre;
        private string? apellido;
        private int dni;
        private string? curso;
        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string? Curso { get => curso; set => curso = value; }
    }
}