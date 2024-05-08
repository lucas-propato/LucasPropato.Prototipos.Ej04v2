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
    public partial class PersonasForm : Form
    {
        PersonasModelo modelo = new();

        public PersonasForm()
        {
            InitializeComponent();
        }

        private void PersonasForm_Load(object sender, EventArgs e) // lo que quiero para que carge la pantalla
        {
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
            modelo.PersonaEnEdicion = personaAEditar; // para boton aceptar

            var formEdicion = new PersonaEditarForm();
            formEdicion.Modelo = modelo;
            formEdicion.ShowDialog(); // el código se detiene

            // hasta que el formulario se cierra
            CargarLista();
        }

        private void NuevoBoton_Click(object sender, EventArgs e) // hay que habilitar edición, pero no cargarle nada
        {
            var formNuevo = new PersonaNuevoForm();
            formNuevo.Modelo = modelo; // para compartir modelo, que se vean los cambios
            formNuevo.ShowDialog(); // mostrar nueva ventana

            CargarLista(); // actualizo los datos
        }
    }
}
