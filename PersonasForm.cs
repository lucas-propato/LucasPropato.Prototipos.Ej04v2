using System.Drawing.Text;

namespace LucasPropato.Prototipos.Ej04
{
    public partial class PersonasForm : Form
    {
        PersonasModelo modelo = new();

        public PersonasForm()
        {
            InitializeComponent();
        }

        private void PersonasForm_Load(object sender, EventArgs e) // lo que quiero para que carge la pantalla
        {
            TipoCombo.Items.Add(TipoTelefono.Casa.ToString());
            TipoCombo.Items.Add(TipoTelefono.Trabajo.ToString());
            TipoCombo.Items.Add(TipoTelefono.Otro.ToString());

            CargarLista();
        }

        private void CargarLista()
        {
            PersonasList.Items.Clear();
            
            foreach (var persona in modelo.Personas) // para cada persona en mi modelo
            {
                var fila = new ListViewItem(); // cada fila de la lista
                fila.Text = persona.Documento.ToString(); // la primera columna es la propiedad text
                fila.SubItems.Add(persona.Nombre); // las subsiguientes columnas son subitems
                fila.SubItems.Add(persona.Apellido);
                fila.SubItems.Add(persona.Telefono.Descripcion()); // consta de cuatro datos separados, hablo con mis amigos (para que no afecte a la pantalla si necesito corregir algo), no meterse en el capot del auto (en los detalles)
                fila.Tag = persona;
                PersonasList.Items.Add(fila); // agregarla/cargarla a la lista
            }
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            if (PersonasList.SelectedItems.Count == 0) // si no selecciono
            {
                MessageBox.Show("Seleccione un ítem de la lista primero.");
                return;
            }

            var personaAEditar = (Persona)PersonasList.SelectedItems[0].Tag; // tag hace referencia a objeto Persona (caasteo), 0 porque seleccióna una fila

            DocumentoText.Text = personaAEditar.Documento.ToString(); // le doy funcionalidad para editar los textboxs
            ApellidoText.Text = personaAEditar.Apellido;
            NombreText.Text = personaAEditar.Nombre;

            TipoCombo.SelectedItem = personaAEditar.Telefono.Tipo; // cuando son cadenas es SelectedItem
            CodAreaText.Text = personaAEditar.Telefono.CodArea.ToString();
            CodPaisText.Text = personaAEditar.Telefono.CodPais.ToString();
            NumeroText.Text = personaAEditar.Telefono.Numero.ToString();

            ListaGroup.Enabled = false; // deshabilito lista
            EdicionGroup.Enabled = true; // habilito para editar

            modelo.PersonaEnEdicion = personaAEditar; // para boton aceptar
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            DocumentoText.Text = string.Empty;
            ApellidoText.Text = string.Empty;
            NombreText.Text = string.Empty;

            TipoCombo.SelectedItem = string.Empty;
            CodAreaText.Text = string.Empty;
            CodPaisText.Text = string.Empty;
            NumeroText.Text = string.Empty;

            ListaGroup.Enabled = true; // habilitamos lista
            EdicionGroup.Enabled = false; // deshabilitamos edición
        }

        private void NuevoBoton_Click(object sender, EventArgs e) // hay que habilitar edición, pero no cargarle nada
        {
            ListaGroup.Enabled = false;
            EdicionGroup.Enabled = true;

            modelo.PersonaEnEdicion = null; // para boton aceptar
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

            string error = modelo.Modificar(persona); // ..y pasárselo al modelo (para que haga en este caso modificaciones)
            if (error != null) // si tengo error
            {
                MessageBox.Show(error); // no hace nada y lo muestro
                return;
            }

            CargarLista(); // refrescar lista
        }
    }
}
