using System;

namespace POO.Personas
{
    public class Persona
    {
        private static int contadorIdPersona;
        private const string DEFAULT_CEDULA = "1122334455";
        private const string DEFAULT_NOMBRE = "Sin nombre";
        private const string DEFAULT_APELLIDO = "Sin apellido";
        private const string DEFAULT_CORREO = "usuario@upecu.edu.ec";
        private const string DEFAULT_USUARIO = "usuario";
        private int id_Persona;
        private string persona_Cedula;
        private string persona_Apellidos;
        private string persona_Nombres;
        private string persona_Correo;
        private string persona_Usuario;

        public string Persona_Cedula
        {
            get
            {
                return persona_Cedula;
            }
            set
            {
                this.persona_Cedula = value;
            }
        }

        public string Persona_Apellidos
        {
            get
            {
                return persona_Apellidos;
            }
            set
            {
                this.persona_Apellidos = value;
            }
        }

        public string Persona_Nombres
        {
            get
            {
                return persona_Nombres;
            }
            set
            {
                this.persona_Nombres = value;
            }
        }

        public string Persona_Correo
        {
            get
            {
                return persona_Correo;
            }
            set
            {
                if (value.Contains('@') == true)
                    this.persona_Correo = value;
                else
                {
                    throw new FormatException("¡El correo electrónico debe tener el formato correcto!");
                }
            }
        }

        public string Persona_Usuario
        {
            get
            {
                return persona_Usuario;
            }
            set
            {
                this.persona_Usuario = value;
            }
        }

        public int Id_Persona { 
            get 
            {
                return id_Persona;
            } 
            private set 
            {
                id_Persona = value;
            } 
        }

        public Persona()
            : this(DEFAULT_CEDULA,DEFAULT_APELLIDO,DEFAULT_NOMBRE,DEFAULT_CORREO,DEFAULT_USUARIO)
        {

        }

        public Persona(string personaCedula, string personaApellidos, string personaNombres, string personaCorreo, string personaUsuario)
        {
            this.Persona_Cedula = personaCedula;
            this.Persona_Apellidos = personaApellidos;
            this.Persona_Nombres = personaNombres;
            this.Persona_Correo = personaCorreo;
            this.Persona_Usuario = personaUsuario;
            this.id_Persona = ++contadorIdPersona;
            this.Id_Persona = id_Persona;
        }

        public virtual void Imprimir(string tipo="Persona")
        {
            Console.WriteLine($"\nDatos de {tipo}");
            Console.WriteLine($"Id de Persona: {id_Persona}");
            Console.WriteLine($"Cédula de {tipo}: {persona_Cedula}");
            Console.WriteLine($"Apellidos de {tipo}: {persona_Apellidos}");
            Console.WriteLine($"Nombres de {tipo}: {persona_Nombres}");
            Console.WriteLine($"Correo de {tipo}: {persona_Correo}");
            Console.WriteLine($"Usuario de {tipo}: {persona_Usuario}");
        }
    }
}
