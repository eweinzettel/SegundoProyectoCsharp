using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL
{
    public partial class FrmAltasSpace : Form
    {
        public FrmAltasSpace()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                       
        }

        private void limpiarTexbox()
        {
            txtaño.Clear();
            txtHorasDeVuelo.Clear();
            txtColor.Clear();
            txtPropietario.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltasSpace_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

            int año = 0;
            int horasVuelo = 0;
            string color = string.Empty;
            string propietario = string.Empty;

            año = Convert.ToInt32(txtaño.Text);
            horasVuelo = Convert.ToInt32(txtHorasDeVuelo.Text);
            color = txtColor.Text;
            propietario = txtPropietario.Text;

            // public Car(string modelo, int autonomia, int service, int año, string color, string propietario);

            horasVuelo = Convert.ToInt32(txtHorasDeVuelo.Text);
            Space NaveNuevo = new Space(horasVuelo, "STARSHIP", 500, 1000, año, color, propietario);
            limpiarTexbox();
            
        }

        private void btnAceptarMS_Click(object sender, EventArgs e)
        {
            int año = 0;
            int horasVuelo = 0;
            string color = string.Empty;
            string propietario = string.Empty;

            año = Convert.ToInt32(txtaño.Text);
            horasVuelo = Convert.ToInt32(txtHorasDeVuelo.Text);
            color = txtColor.Text;
            propietario = txtPropietario.Text;

            // public Car(string modelo, int autonomia, int service, int año, string color, string propietario);

            horasVuelo = Convert.ToInt32(txtHorasDeVuelo.Text);
            Space NaveNuevo = new Space(horasVuelo, "FALCON9", 200, 400, año, color, propietario);
            limpiarTexbox();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarMS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
