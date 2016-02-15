namespace Manejo_Archivos_Caballero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CajaTextoEnriquecido = new System.Windows.Forms.RichTextBox();
            this.btnCrearTexto = new System.Windows.Forms.Button();
            this.btnLeerTexto = new System.Windows.Forms.Button();
            this.btnModificarTexto = new System.Windows.Forms.Button();
            this.btnGuardarTexto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrarTexto = new System.Windows.Forms.Button();
            this.btnSalirAplicación = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Introducción (descripción) del taller ",
            "Elaborar una aplicación que permita crear, leer y escribir en un archivo de texto" +
                ".",
            "Condiciones:",
            "-          Trabajo individual.",
            "-          Entorno de desarrollo libre, así como el lenguaje de programación, per" +
                "o con interfaz gráfica.",
            "-          El nombre y ubicación del archivo de texto que se cree, debe ser deter" +
                "minado por el usuario como una funcionalidad de la aplicación.",
            "-          El texto que se escriba en el archivo debe ser aquel que previamente e" +
                "l usuario proporcionó en algún control de entrada de texto.",
            resources.GetString("listBox1.Items"),
            "-          El día último para envío de la práctica es el lunes 15 de febrero a me" +
                "dia noche."});
            this.listBox1.Location = new System.Drawing.Point(36, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(949, 121);
            this.listBox1.TabIndex = 0;
            // 
            // CajaTextoEnriquecido
            // 
            this.CajaTextoEnriquecido.Location = new System.Drawing.Point(36, 200);
            this.CajaTextoEnriquecido.Name = "CajaTextoEnriquecido";
            this.CajaTextoEnriquecido.Size = new System.Drawing.Size(481, 298);
            this.CajaTextoEnriquecido.TabIndex = 1;
            this.CajaTextoEnriquecido.Text = "";
            this.CajaTextoEnriquecido.Visible = false;
            // 
            // btnCrearTexto
            // 
            this.btnCrearTexto.Location = new System.Drawing.Point(6, 28);
            this.btnCrearTexto.Name = "btnCrearTexto";
            this.btnCrearTexto.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTexto.TabIndex = 2;
            this.btnCrearTexto.Text = "CREAR";
            this.btnCrearTexto.UseVisualStyleBackColor = true;
            this.btnCrearTexto.Click += new System.EventHandler(this.btnCrearTexto_Click);
            // 
            // btnLeerTexto
            // 
            this.btnLeerTexto.Location = new System.Drawing.Point(86, 28);
            this.btnLeerTexto.Name = "btnLeerTexto";
            this.btnLeerTexto.Size = new System.Drawing.Size(75, 23);
            this.btnLeerTexto.TabIndex = 3;
            this.btnLeerTexto.Text = "LEER";
            this.btnLeerTexto.UseVisualStyleBackColor = true;
            this.btnLeerTexto.Click += new System.EventHandler(this.btnLeerTexto_Click);
            // 
            // btnModificarTexto
            // 
            this.btnModificarTexto.Location = new System.Drawing.Point(87, 57);
            this.btnModificarTexto.Name = "btnModificarTexto";
            this.btnModificarTexto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTexto.TabIndex = 4;
            this.btnModificarTexto.Text = "MODIFICAR";
            this.btnModificarTexto.UseVisualStyleBackColor = true;
            this.btnModificarTexto.Click += new System.EventHandler(this.btnModificarTexto_Click);
            // 
            // btnGuardarTexto
            // 
            this.btnGuardarTexto.Location = new System.Drawing.Point(6, 57);
            this.btnGuardarTexto.Name = "btnGuardarTexto";
            this.btnGuardarTexto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTexto.TabIndex = 5;
            this.btnGuardarTexto.Text = "GUARDAR";
            this.btnGuardarTexto.UseVisualStyleBackColor = true;
            this.btnGuardarTexto.Click += new System.EventHandler(this.btnGuardarTexto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Manejo_Archivos_Caballero.Properties.Resources._2016_02_08_11_38_23;
            this.pictureBox1.Image = global::Manejo_Archivos_Caballero.Properties.Resources.UT_Puebla;
            this.pictureBox1.Location = new System.Drawing.Point(696, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrarTexto);
            this.groupBox1.Controls.Add(this.btnCrearTexto);
            this.groupBox1.Controls.Add(this.btnGuardarTexto);
            this.groupBox1.Controls.Add(this.btnModificarTexto);
            this.groupBox1.Controls.Add(this.btnLeerTexto);
            this.groupBox1.Location = new System.Drawing.Point(523, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // btnCerrarTexto
            // 
            this.btnCerrarTexto.Location = new System.Drawing.Point(44, 86);
            this.btnCerrarTexto.Name = "btnCerrarTexto";
            this.btnCerrarTexto.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarTexto.TabIndex = 6;
            this.btnCerrarTexto.Text = "CERRAR";
            this.btnCerrarTexto.UseVisualStyleBackColor = true;
            this.btnCerrarTexto.Click += new System.EventHandler(this.btnCerrarTexto_Click);
            // 
            // btnSalirAplicación
            // 
            this.btnSalirAplicación.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalirAplicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAplicación.ForeColor = System.Drawing.Color.Red;
            this.btnSalirAplicación.Location = new System.Drawing.Point(567, 441);
            this.btnSalirAplicación.Name = "btnSalirAplicación";
            this.btnSalirAplicación.Size = new System.Drawing.Size(75, 23);
            this.btnSalirAplicación.TabIndex = 7;
            this.btnSalirAplicación.Text = "SALIR";
            this.btnSalirAplicación.UseVisualStyleBackColor = false;
            this.btnSalirAplicación.Click += new System.EventHandler(this.btnSalirAplicación_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 510);
            this.Controls.Add(this.btnSalirAplicación);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CajaTextoEnriquecido);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Aplicación 1: Manejo de archivos (Caballero Morales Osvaldo) 15/2/2016";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox CajaTextoEnriquecido;
        private System.Windows.Forms.Button btnCrearTexto;
        private System.Windows.Forms.Button btnLeerTexto;
        private System.Windows.Forms.Button btnModificarTexto;
        private System.Windows.Forms.Button btnGuardarTexto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrarTexto;
        private System.Windows.Forms.Button btnSalirAplicación;
    }
}

