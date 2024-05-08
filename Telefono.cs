using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasPropato.Prototipos.Ej04v2
{
    public class Telefono
    {
        public TipoTelefono Tipo { get; set; } // de ahí crear clase especial de enumeración TipoTelefono
        public int CodPais { get; set; }
        public int CodArea { get; set; }
        public int Numero { get; set; }
        public string Descripcion()
        {
            return $"({Tipo}) +{CodPais:00} {CodArea:00}–{Numero:0000}";
        }

        public void ActualizarCon(Telefono datos)
        {
            Tipo = datos.Tipo;
            CodPais = datos.CodPais;
            CodArea = datos.CodArea;
            Numero = datos.Numero;
        }
    }
}
