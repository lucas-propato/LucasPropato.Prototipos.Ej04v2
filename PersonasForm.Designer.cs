namespace LucasPropato.Prototipos.Ej04
{
    partial class PersonasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListaGroup = new GroupBox();
            PersonasList = new ListView();
            DocumentoCol = new ColumnHeader();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            TelefonoCol = new ColumnHeader();
            EliminarBoton = new Button();
            NuevoBoton = new Button();
            EditarBoton = new Button();
            EdicionGroup = new GroupBox();
            CodAreaText = new TextBox();
            CancelarBoton = new Button();
            AceptarBoton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            NumeroText = new TextBox();
            CodPaisText = new TextBox();
            TipoCombo = new ComboBox();
            ApellidoText = new TextBox();
            NombreText = new TextBox();
            DocumentoText = new TextBox();
            ListaGroup.SuspendLayout();
            EdicionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ListaGroup
            // 
            ListaGroup.Controls.Add(PersonasList);
            ListaGroup.Location = new Point(12, 12);
            ListaGroup.Name = "ListaGroup";
            ListaGroup.Size = new Size(776, 188);
            ListaGroup.TabIndex = 0;
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
            // EliminarBoton
            // 
            EliminarBoton.Location = new Point(666, 206);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(113, 27);
            EliminarBoton.TabIndex = 1;
            EliminarBoton.Text = "&Eliminar";
            EliminarBoton.UseVisualStyleBackColor = true;
            // 
            // NuevoBoton
            // 
            NuevoBoton.Location = new Point(428, 206);
            NuevoBoton.Name = "NuevoBoton";
            NuevoBoton.Size = new Size(113, 27);
            NuevoBoton.TabIndex = 2;
            NuevoBoton.Text = "&Nuevo";
            NuevoBoton.UseVisualStyleBackColor = true;
            NuevoBoton.Click += NuevoBoton_Click;
            // 
            // EditarBoton
            // 
            EditarBoton.Location = new Point(547, 206);
            EditarBoton.Name = "EditarBoton";
            EditarBoton.Size = new Size(113, 27);
            EditarBoton.TabIndex = 3;
            EditarBoton.Text = "&Editar";
            EditarBoton.UseVisualStyleBackColor = true;
            EditarBoton.Click += EditarBoton_Click;
            // 
            // EdicionGroup
            // 
            EdicionGroup.Controls.Add(CodAreaText);
            EdicionGroup.Controls.Add(CancelarBoton);
            EdicionGroup.Controls.Add(AceptarBoton);
            EdicionGroup.Controls.Add(label7);
            EdicionGroup.Controls.Add(label6);
            EdicionGroup.Controls.Add(label5);
            EdicionGroup.Controls.Add(label4);
            EdicionGroup.Controls.Add(label3);
            EdicionGroup.Controls.Add(label2);
            EdicionGroup.Controls.Add(label1);
            EdicionGroup.Controls.Add(NumeroText);
            EdicionGroup.Controls.Add(CodPaisText);
            EdicionGroup.Controls.Add(TipoCombo);
            EdicionGroup.Controls.Add(ApellidoText);
            EdicionGroup.Controls.Add(NombreText);
            EdicionGroup.Controls.Add(DocumentoText);
            EdicionGroup.Enabled = false;
            EdicionGroup.Location = new Point(27, 239);
            EdicionGroup.Name = "EdicionGroup";
            EdicionGroup.Size = new Size(761, 199);
            EdicionGroup.TabIndex = 4;
            EdicionGroup.TabStop = false;
            // 
            // CodAreaText
            // 
            CodAreaText.Location = new Point(331, 106);
            CodAreaText.Name = "CodAreaText";
            CodAreaText.Size = new Size(131, 23);
            CodAreaText.TabIndex = 14;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(520, 144);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(113, 27);
            CancelarBoton.TabIndex = 5;
            CancelarBoton.Text = "&Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(639, 144);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(113, 27);
            AceptarBoton.TabIndex = 6;
            AceptarBoton.Text = "&Aceptar";
            AceptarBoton.UseVisualStyleBackColor = true;
            AceptarBoton.Click += AceptarBoton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(492, 88);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "Número";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 88);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 12;
            label6.Text = "Código Área";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 88);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 11;
            label5.Text = "Código País";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 10;
            label4.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 35);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 35);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 7;
            label1.Text = "Documento";
            // 
            // NumeroText
            // 
            NumeroText.Location = new Point(492, 106);
            NumeroText.Name = "NumeroText";
            NumeroText.Size = new Size(260, 23);
            NumeroText.TabIndex = 6;
            // 
            // CodPaisText
            // 
            CodPaisText.Location = new Point(175, 106);
            CodPaisText.Name = "CodPaisText";
            CodPaisText.Size = new Size(131, 23);
            CodPaisText.TabIndex = 4;
            // 
            // TipoCombo
            // 
            TipoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TipoCombo.FormattingEnabled = true;
            TipoCombo.Location = new Point(6, 106);
            TipoCombo.Name = "TipoCombo";
            TipoCombo.Size = new Size(146, 23);
            TipoCombo.TabIndex = 3;
            // 
            // ApellidoText
            // 
            ApellidoText.Location = new Point(492, 53);
            ApellidoText.Name = "ApellidoText";
            ApellidoText.Size = new Size(260, 23);
            ApellidoText.TabIndex = 2;
            // 
            // NombreText
            // 
            NombreText.Location = new Point(202, 53);
            NombreText.Name = "NombreText";
            NombreText.Size = new Size(260, 23);
            NombreText.TabIndex = 1;
            // 
            // DocumentoText
            // 
            DocumentoText.Location = new Point(6, 53);
            DocumentoText.Name = "DocumentoText";
            DocumentoText.Size = new Size(165, 23);
            DocumentoText.TabIndex = 0;
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EdicionGroup);
            Controls.Add(EditarBoton);
            Controls.Add(NuevoBoton);
            Controls.Add(EliminarBoton);
            Controls.Add(ListaGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PersonasForm";
            Text = "Form1";
            Load += PersonasForm_Load;
            ListaGroup.ResumeLayout(false);
            EdicionGroup.ResumeLayout(false);
            EdicionGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ListaGroup;
        private Button EliminarBoton;
        private ListView PersonasList;
        private ColumnHeader DocumentoCol;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader TelefonoCol;
        private Button NuevoBoton;
        private Button EditarBoton;
        private GroupBox EdicionGroup;
        private TextBox NumeroText;
        private TextBox CodPaisText;
        private ComboBox TipoCombo;
        private TextBox ApellidoText;
        private TextBox NombreText;
        private TextBox DocumentoText;
        private Button CancelarBoton;
        private Button AceptarBoton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CodAreaText;
    }
}
