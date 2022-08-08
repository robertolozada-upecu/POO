using System;

namespace POO.Personas
{
    public class Docente : Persona, ITrabajador
    {
        private static int contadorIdDocente;
        private readonly int id_Docente;

        public Docente()
        {
            id_Docente = ++contadorIdDocente;
        }
        public Docente(string docente_Cedula, string docente_Apellidos, string docente_Nombres, string docente_Correo, string docente_Usuario)
            : base(docente_Cedula, docente_Apellidos, docente_Nombres, docente_Correo, docente_Usuario)
        {
            this.id_Docente = ++contadorIdDocente;
        }

        public override void Imprimir(string tipo = "Docente")
        {
            base.Imprimir(tipo);
            Console.WriteLine($"Id del docente: {id_Docente}");
        }

        public void RecibirSueldo()
        {
            Console.WriteLine("¡Ya recibió el sueldo, Docente!");
        }
    }
}
