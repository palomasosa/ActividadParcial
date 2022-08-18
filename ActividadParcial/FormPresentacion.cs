using Entidads;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadParcial
{
    public partial class FormPresentacion : Form
    {
        public FormPresentacion()
        {
            InitializeComponent();
        }
        Persona PersonaNueva;
        private void btnAgregarPer_Click(object sender, EventArgs e)
        {
            bool esValido = true;
            if (txtbxDNI.Text.Length != 7 && txtbxDNI.Text.Length != 8)
            {
                esValido = false;
            }
            for (int i = 0; i < txtbxDNI.Text.Length; i++)
            {
                if (!Char.IsNumber(txtbxDNI.Text, i)) { esValido = false; }
                
            }

            if (esValido == true)
            {
                PersonaNueva = new Persona(txtbxNombre.Text.ToString(), Convert.ToInt32(txtbxDNI.Text), Convert.ToDateTime(dtpFechaNac.Text));
                lblPrueba.Text = PersonaNueva.NombreProp.ToString();
                btnCalcEdad.Enabled = true;
            }
            else
            {
                MessageBox.Show("DNI no válido");
            }
        }

        private void btnCalcEdad_Click(object sender, EventArgs e)
        {
            int Edad = PersonaNueva.devolverEdad();
            lblEdad.Text = Edad.ToString();
        }
    }
}
