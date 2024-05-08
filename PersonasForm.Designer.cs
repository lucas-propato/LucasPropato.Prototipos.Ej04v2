namespace LucasPropato.Prototipos.Ej04v2
{
    partial class PersonasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListaGroup = new GroupBox();
            PersonasList = new ListView();
            DocumentoCol = new ColumnHeader();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            TelefonoCol = new ColumnHeader();
            EditarBoton = new Button();
            NuevoBoton = new Button();
            EliminarBoton = new Button();
            ListaGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ListaGroup
            // 
            ListaGroup.Controls.Add(PersonasList);
            ListaGroup.Location = new Point(12, 12);
            ListaGroup.Name = "ListaGroup";
            ListaGroup.Size = new Size(776, 196);
            ListaGroup.TabIndex = 10;
            ListaGroup.TabStop = false;
            // 
            // PersonasList
            // 
            PersonasList.Columns.AddRange(new ColumnHeader[] { DocumentoCol, NombreCol, ApellidoCol, TelefonoCol });
            PersonasList.FullRowSelect = true;
            PersonasList.GridLines = true;
            PersonasList.Location = new Point(9, 14);
            PersonasList.MultiSelect = false;
            PersonasList.Name = "PersonasList";
            PersonasList.Size = new Size(758, 168);
            PersonasList.TabIndex = 0;
            PersonasList.UseCompatibleStateImageBehavior = false;
            PersonasList.View = View.Details;
            // 
            // DocumentoCol
            // 
            DocumentoCol.Text = "Documento";
            DocumentoCol.Width = 90;
            // 
            // NombreCol
            // 
            NombreCol.Text = "Nombre";
            NombreCol.Width = 180;
            // 
            // ApellidoCol
            // 
            ApellidoCol.Text = "Apellido";
            ApellidoCol.Width = 180;
            // 
            // TelefonoCol
            // 
            TelefonoCol.Text = "Telefono";
            TelefonoCol.Width = 180;
            // 
            // EditarBoton
            // 
            EditarBoton.Location = new Point(554, 226);
            EditarBoton.Name = "EditarBoton";
            EditarBoton.Size = new Size(113, 27);
            EditarBoton.TabIndex = 13;
            EditarBoton.Text = "&Editar";
            EditarBoton.UseVisualStyleBackColor = true;
            EditarBoton.Click += EditarBoton_Click;
            // 
            // NuevoBoton
            // 
            NuevoBoton.Location = new Point(435, 226);
            NuevoBoton.Name = "NuevoBoton";
            NuevoBoton.Size = new Size(113, 27);
            NuevoBoton.TabIndex = 12;
            NuevoBoton.Text = "&Nuevo";
            NuevoBoton.UseVisualStyleBackColor = true;
            NuevoBoton.Click += NuevoBoton_Click;
            // 
            // EliminarBoton
            // 
            EliminarBoton.Location = new Point(673, 226);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(113, 27);
            EliminarBoton.TabIndex = 11;
            EliminarBoton.Text = "&Eliminar";
            EliminarBoton.UseVisualStyleBackColor = true;
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 273);
            Controls.Add(ListaGroup);
            Controls.Add(EditarBoton);
            Controls.Add(NuevoBoton);
            Controls.Add(EliminarBoton);
            MaximizeBox = false;
            Name = "PersonasForm";
            Text = "PersonasForm";
            Load += PersonasForm_Load;
            ListaGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ListaGroup;
        private ListView PersonasList;
        private ColumnHeader DocumentoCol;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader TelefonoCol;
        private Button EditarBoton;
        private Button NuevoBoton;
        private Button EliminarBoton;
    }
}