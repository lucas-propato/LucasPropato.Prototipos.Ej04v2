using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasPropato.Prototipos.Ej04v2
{
    public class Persona
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Telefono Telefono { get; set; } // de ahi crear clase Telefono

        public string Validar() // se ejecuta sobre cada objeto
        {
            //Ej.: verificar que el documento sea > 999.999
            if (Documento < 999.999)
            {
                return "El documento debe tener eal menos 7 cifras.";
            }

            if (string.IsNullOrEmpty(Nombre))
            {
                return "El nombre es requerido";
            }

            //etc... IMPORTANTE: SOLO utilizo MIS propiedades (de arriba get y set)

            return null;
        }

        public void ActualizarCon(Persona datos) // la persona actualiza los datos de la persona
        {
            Documento = datos.Documento;
            Nombre = datos.Nombre;
            Apellido = datos.Apellido;
            Telefono.ActualizarCon(datos.Telefono); // el telefono actualiza los datos del telefono
        }
    }
}
