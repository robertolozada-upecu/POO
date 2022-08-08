using POO.Personas;
using System;
using System.Collections.Generic;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase estudiante
            Estudiante nuevoEstudiante = new Estudiante();
            nuevoEstudiante.Persona_Cedula = "1712345678";
            nuevoEstudiante.Persona_Apellidos = "Martinez";
            nuevoEstudiante.Persona_Nombres = "Roberto";
            nuevoEstudiante.Persona_Correo = "rfll@upecu.edu.ec";
            nuevoEstudiante.Persona_Usuario = "rfll";

            Estudiante otroEstudiante = new Estudiante()
            {
                Persona_Cedula = "1702345678",
                Persona_Apellidos = "Martinez",
                Persona_Nombres = "Franklin",
                Persona_Correo = "fjll@upecu.edu.ec",
                Persona_Usuario = "fjll"
            };

            Estudiante algunEstudiante = new Estudiante("1712345670", "Martinez", "Alexander", "fall@upecu.edu.ec", "fall");
            Estudiante estudiante = new Estudiante();

            //Clase docente
            Docente nuevoDocente = new Docente("1712345670","Lozada","Roberto","rfll@upecu.edu.ec","rfll");
            Docente otroDocente = new Docente();

            //Clase Administrativo
            Administrativo nuevoAdministrativo = new Administrativo("1234567890","Viana","Juan","jviana@upecu.edu.ec","jviana","Académico");
            Administrativo algunAdministrativo = new Administrativo("1788888888", "Terán", "Cristian", "cteran@upecu.edu.ec", "cteran", "Adminsitrativo");
            try
            {
                Administrativo otroAdministrativo = new Administrativo("0123456789", "Dávila", "Carlos", "cdavilaupecu.edu.ec", "cdavila", "Académico");
            }
            catch (FormatException ex)
            {
                //Mensaje de la excepción, no se instancia el objeto
                Console.WriteLine(ex.Message);
            }

            //Clase persona
            Persona nuevapersona = new Persona();

            //Clase curso
            Curso nuevoCurso = new Curso("Ofimática", "Ofimática Básica", 1, 25, Habilitado.Activo);
            try
            {
                Curso otroCurso = new Curso("Algebra", "Algebra Básica", 11, 15, Habilitado.Activo);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //Mensaje de la excepción, no se instancia el objeto
                Console.WriteLine(ex.Message);
            }
            try
            {
                Curso curso = new Curso("Cálculo", 31);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //Mensaje de la excepción, no se instancia el objeto
                Console.WriteLine(ex.Message);
            }

            Curso algunCurso = new Curso();
            Curso otroCursoMas = new Curso("Programación", 24);

            //Impresión de campos directamente
            Console.WriteLine($"\nCorreo del Estudiante: {nuevoEstudiante.Persona_Correo}");
            Console.WriteLine($"Nombre del Docente: {nuevoDocente.Persona_Nombres}");
            Console.WriteLine($"Nombre del Curso: {nuevoCurso.Curso_Nombre}");
            //Campo y propiedad heredada
            Console.WriteLine($"Nombre del Administrativo: {nuevoAdministrativo.Persona_Nombres}");

            //Impresión usando métodos de las clases
            nuevoEstudiante.Imprimir();
            otroEstudiante.Imprimir();
            algunEstudiante.Imprimir();
            estudiante.Imprimir();
            nuevoDocente.Imprimir();
            otroDocente.Imprimir();
            nuevoCurso.Imprimir();
            algunCurso.Imprimir();
            otroCursoMas.Imprimir();
            Curso.ImprimirValoresDefault();
            nuevoAdministrativo.Imprimir();
            algunAdministrativo.Imprimir();
            nuevapersona.Imprimir();
            var nuevaListaPersonas = new List<Persona>
            {
                nuevoDocente,otroDocente,
                nuevoAdministrativo,algunAdministrativo
            };
            var nuevaLista = new List<ITrabajador>();
            foreach (var persona in nuevaListaPersonas)
            {
                if(persona is Docente || persona is Administrativo)
                {
                    nuevaLista.Add((ITrabajador)persona);
                }
            }
            PagarSueldo(nuevaLista);
        }
        private static void PagarSueldo(List<ITrabajador> nomina)
        {
            Console.WriteLine("\nReporte de nómina:");
            foreach (ITrabajador trabajador in nomina)
            {
                trabajador.RecibirSueldo();
            }
        }
    }
}
