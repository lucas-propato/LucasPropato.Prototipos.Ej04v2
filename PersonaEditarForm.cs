using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucasPropato.Prototipos.Ej04v2
{
    public partial class PersonaEditarForm : Form
    {
        public PersonasModelo Modelo { get; set; }

        public PersonaEditarForm()
        {
            InitializeComponent();
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

            string error = Modelo.Modificar(persona); // si al modificar el modelo da un error
            if (error != null) // esto es un "fi", porque es un "if" al revés.
            {
                MessageBox.Show(error); // lo muestro
                return;
            }

            this.Close(); // y sino cierro
        }

        private void PersonaEditarForm_Load(object sender, EventArgs e)
        {
            TipoCombo.Items.Add(TipoTelefono.Casa.ToString());
            TipoCombo.Items.Add(TipoTelefono.Trabajo.ToString());
            TipoCombo.Items.Add(TipoTelefono.Otro.ToString());

            DocumentoText.Text = Modelo.PersonaEnEdicion.Documento.ToString(); // le doy funcionalidad para editar los textboxs
            ApellidoText.Text = Modelo.PersonaEnEdicion.Apellido;
            NombreText.Text = Modelo.PersonaEnEdicion.Nombre;

            TipoCombo.SelectedItem = Modelo.PersonaEnEdicion.Telefono.Tipo.ToString(); // cuando son cadenas es SelectedItem
            CodAreaText.Text = Modelo.PersonaEnEdicion.Telefono.CodArea.ToString();
            CodPaisText.Text = Modelo.PersonaEnEdicion.Telefono.CodPais.ToString();
            NumeroText.Text = Modelo.PersonaEnEdicion.Telefono.Numero.ToString();
        }
    }
}
