using System;

namespace POO.Personas
{
    public class Administrativo : Persona, ITrabajador
    {
        private string admin_Departamento;
        private static int contadorIdAdministrativo;
        private readonly int id_Administrativo;

        public Administrativo(string personaCedula, string personaApellidos, string personaNombres, string personaCorreo, string personaUsuario, string adminDepartamento)
            : base(personaCedula,personaApellidos,personaNombres,personaCorreo,personaUsuario)
        {
            this.admin_Departamento = adminDepartamento;
            this.id_Administrativo = ++contadorIdAdministrativo;
        }

        public override void Imprimir(string tipo="Administrativo")
        {
            base.Imprimir(tipo);
            Console.WriteLine($"Id de Administrativo: {id_Administrativo}");
            Console.WriteLine($"Departamento de {tipo}: {admin_Departamento}");
        }

        public void RecibirSueldo()
        {
            Console.WriteLine("¡Ya recibió el sueldo, Administrativo!");
        }
    }
}
