namespace LucasPropato.Prototipos.Ej04v2
{
    public class PersonasModelo
    {
        public List<Persona> Personas { get; set; } // de ahi crear clase Persona

        public Persona? PersonaEnEdicion { get; set; } // para botón aceptar (signo pq la persona puede ser nula)

        public PersonasModelo() // creo constructor
        {
            Personas = new List<Persona> // crear lista de personas para hacer prueba de prototipo
            {
                new Persona { Apellido = "Perez", Nombre = "Ramiro", Documento = 44333222, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 31794445 } }, // esto después se va a borrar
                new Persona { Apellido = "González", Nombre = "María", Documento = 12345678, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 311234567 } },
                new Persona { Apellido = "Martínez", Nombre = "Carlos", Documento = 23456789, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 322345678 } },
                new Persona { Apellido = "López", Nombre = "Ana", Documento = 34567890, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 333456789 } },
                new Persona { Apellido = "Rodríguez", Nombre = "José", Documento = 45678901, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 344567890 } },
                new Persona { Apellido = "Gómez", Nombre = "Laura", Documento = 56789012, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 355678012 } },
                new Persona { Apellido = "Díaz", Nombre = "Diego", Documento = 67890123, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 366790123 } },
                new Persona { Apellido = "Fernández", Nombre = "Paula", Documento = 78901234, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 377801234 } },
                new Persona { Apellido = "Sánchez", Nombre = "Javier", Documento = 89012345, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 388012345 } },
                new Persona { Apellido = "Romero", Nombre = "Lucía", Documento = 90123456, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 399012456 } },
                new Persona { Apellido = "Torres", Nombre = "Mario", Documento = 12345678, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 300134567 } }
            };
        }

        public string Nuevo(Persona nuevaPersona)
        {
            string error = nuevaPersona.Validar(); // primero validar persona (objeto en sí mismo)
            if (error != null)
            {
                return error;
            }

            // validaciones de negocio para adición (que no puede hacer el objeto en sí mismo):

            foreach (var personaExistente in Personas) // Ej. no quiero 2 personas con el mismo documento.
            {
                if (personaExistente.Documento == nuevaPersona.Documento)
                {
                    return "Ya existe una persona con el documento indicado.";
                }
            }

            Personas.Add(nuevaPersona);

            return null;
        }

        public string Modificar(Persona nuevosDatosPersona)
        {
            string error = nuevosDatosPersona.Validar(); // primero validar persona (objeto en sí mismo)
            if(error != null)
            {
                return error;
            }

            // validaciones de negocio para modificación (que no puede hacer el objeto en sí mismo):

            if(PersonaEnEdicion.Documento != nuevosDatosPersona.Documento) // Ej. no se puede modificar nro de documento.
            {
                return "No puede modificar el documento.";
            }

            PersonaEnEdicion.ActualizarCon(nuevosDatosPersona); // pisar los datos sin cambiar el objeto

            return null;
        }
    }
}