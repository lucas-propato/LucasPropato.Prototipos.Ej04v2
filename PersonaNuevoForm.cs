using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucasPropato.Prototipos.Ej04v2
{
    public partial class PersonaNuevoForm : Form
    {
        public PersonasModelo Modelo { get; set; }

        public PersonaNuevoForm()
        {
            InitializeComponent();
        }

        private void PersonaNuevoForm_Load(object sender, EventArgs e)
        {
            TipoCombo.Items.Add(TipoTelefono.Casa.ToString());
            TipoCombo.Items.Add(TipoTelefono.Trabajo.ToString());
            TipoCombo.Items.Add(TipoTelefono.Otro.ToString());
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarBoton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DocumentoText.Text, out var doc)) // primero validar
            {
                MessageBox.Show("El documento no es válido.");
                return;
            }

            Persona persona = new() // la única responsabilidad de la pantalla es armar un paquete con los datos..
            {
                Documento = doc,
                Apellido = ApellidoText.Text,
                Nombre = NombreText.Text,
                Telefono = new Telefono
                {
                    Tipo = Enum.Parse<TipoTelefono>(TipoCombo.Text), // no hace falta validar ComboBox
                    CodPais = int.Parse(CodPaisText.Text),
                    CodArea = int.Parse(CodAreaText.Text),
                    Numero = int.Parse(NumeroText.Text)
                }
            };

            string error = Modelo.Nuevo(persona); // ..y pasárselo al modelo (para que haga en este caso modificaciones)
            if (error != null) // si tengo error
            {
                MessageBox.Show(error); // no hace nada y lo muestro
                return;
            }

            this.Close();
        }
    }
}
