using System;

namespace POO.Personas
{
    public class Estudiante : Persona
    {
        private static int contadorIdEstudiante;
        private readonly int id_Estudiante;


        public Estudiante()
        {
            id_Estudiante = ++contadorIdEstudiante;
        }

        public Estudiante(string estudiante_Cedula, string estudiante_Nombres, string estudiante_Apellidos, string estudiante_Correo, string estudiante_Usuario)
            : base(estudiante_Cedula,estudiante_Nombres,estudiante_Apellidos, estudiante_Correo, estudiante_Usuario)
        {
            this.id_Estudiante = ++contadorIdEstudiante;
        }

        public override void Imprimir(string tipo = "Estudiante")
        {
            base.Imprimir(tipo);
            Console.WriteLine($"Id de {tipo}: {id_Estudiante}");
        }
    }
}
