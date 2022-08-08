using System;

namespace POO
{
    public class Curso
    {
        private static int contadorIdCurso;
        private const int DEFAULT_TOTAL_ESTUDIANTES = 20;
        private const string DEFAULT_NOMBRE = "Sin nombre";
        private const string DEFAULT_DESCRIPCION = "Sin descripción";
        private const int DEFAULT_NIVEL = 1;
        private int id_Curso;
        private string curso_Nombre;
        private string curso_Descripcion;
        private int curso_Nivel;
        private int total_Estudiantes;
        private Habilitado curso_Activo;

        public int Id_Curso
        {
            get
            {
                return id_Curso;
            }
            private set
            {
                id_Curso = value;
            }
        }
        public string Curso_Nombre
        {
            get
            {
                return curso_Nombre;
            }
            set
            {
                curso_Nombre = value;
            }
        }
        public string Curso_Descripcion
        {
            get
            {
                return curso_Descripcion;
            }
            set
            {
                curso_Descripcion = value;
            }
        }
        public int Curso_Nivel
        {
            get
            {
                return curso_Nivel;
            }
            set
            {
                if (value >= 1 && value <= 10)
                    curso_Nivel = value;
                else
                {
                    throw new ArgumentOutOfRangeException("Los valores de los niveles van de 1 a 10");
                }
            }
        }
        public int Total_Estudiantes
        {
            get
            {
                return total_Estudiantes;
            }
            set
            {
                if (value >= 1 && value <= 30)
                    total_Estudiantes = value;
                else
                {
                    throw new ArgumentOutOfRangeException("El número total de estudiantes puede ser de 1 a 30");
                }
            }
        }
        public Habilitado Curso_Activo
        {
            get
            {
                return curso_Activo;
            }
            set
            {
                curso_Activo = value;
            }
        }

        public Curso()
            : this(DEFAULT_NOMBRE, DEFAULT_TOTAL_ESTUDIANTES)
        {

        }

        public Curso(string cursoNombre, int totalEstudiantes)
            : this(cursoNombre, DEFAULT_DESCRIPCION, DEFAULT_NIVEL, totalEstudiantes, Habilitado.Inactivo)
        {

        }

        public Curso(string cursoNombre, string cursoDescripcion, int cursoNivel, int totalEstudiantes, Habilitado activo)
        {
            Curso_Nombre = cursoNombre;
            Curso_Descripcion = cursoDescripcion;
            Curso_Nivel = cursoNivel;
            Total_Estudiantes = totalEstudiantes;
            Curso_Activo = activo;
            Id_Curso = ++contadorIdCurso;
        }

        public void Imprimir()
        {
            Console.WriteLine("\nDatos del curso");
            Console.WriteLine($"Id del curso: {id_Curso}");
            Console.WriteLine($"Nombre del curso: {curso_Nombre}");
            Console.WriteLine($"Detalle del curso: {curso_Descripcion}");
            Console.WriteLine($"Nivel del curso: {curso_Nivel}");
            Console.WriteLine($"Número de estudiantes: {total_Estudiantes}");
            Console.WriteLine($"Estado del curso: {Curso_Activo}");
        }

        public static void ImprimirValoresDefault()
        {
            Console.WriteLine("\nValores por defecto de un curso");
            Console.WriteLine($"Default nombre del curso: {DEFAULT_NOMBRE}" + $"\nDefault descripción del curso: {DEFAULT_DESCRIPCION}" + $"\nDefault nivel del curso: {DEFAULT_NIVEL}" + $"\nDefault total de estudiantes del curso: {DEFAULT_TOTAL_ESTUDIANTES}");
        }
    }
}
