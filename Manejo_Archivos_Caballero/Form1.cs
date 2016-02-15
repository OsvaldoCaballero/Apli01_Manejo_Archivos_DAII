using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Manejo_Archivos_Caballero
{
    public partial class Form1 : Form
    {
        string Documento="";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearTexto_Click(object sender, EventArgs e)
        {
            CajaTextoEnriquecido.Visible = true;
            CajaTextoEnriquecido.Clear();
            CajaTextoEnriquecido.Focus();
            CajaTextoEnriquecido.ReadOnly = false;
            Documento = null;
        }

        private void btnLeerTexto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Buscar = new OpenFileDialog();
            Buscar.Filter = "Texto|*.txt";

            if (Buscar.ShowDialog() == DialogResult.OK)
            {
                Documento = Buscar.FileName;
                using (StreamReader leer = new StreamReader(Documento))
                {
                    CajaTextoEnriquecido.Text = leer.ReadToEnd(); 
                }
            }

            CajaTextoEnriquecido.Visible = true;
            CajaTextoEnriquecido.ReadOnly = true;
        }

        private void btnModificarTexto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Buscar = new OpenFileDialog();
            Buscar.Filter = "Texto|*.txt";

            if (Buscar.ShowDialog() == DialogResult.OK)
            {
                Documento = Buscar.FileName;
                using (StreamReader leer = new StreamReader(Documento))
                {
                    CajaTextoEnriquecido.Text = leer.ReadToEnd();
                }
            }
            CajaTextoEnriquecido.ReadOnly = false;
            CajaTextoEnriquecido.Visible = true;
        }

        private void btnGuardarTexto_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Filter = "Texto|*.txt";
            if (Documento != null)
            {
                using (StreamWriter escribir = new StreamWriter(Documento))
                { escribir.Write(CajaTextoEnriquecido.Text); }
            }

            else
            {
                if (Guardar.ShowDialog() == DialogResult.OK)
                {
                    Documento = Guardar.FileName;
                    using (StreamWriter escribir = new StreamWriter(Guardar.FileName))
                    { escribir.Write(CajaTextoEnriquecido.Text); }
                }
            }
        }

        private void btnCerrarTexto_Click(object sender, EventArgs e)
        {
            CajaTextoEnriquecido.Visible = false;
        }

        private void btnSalirAplicación_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}