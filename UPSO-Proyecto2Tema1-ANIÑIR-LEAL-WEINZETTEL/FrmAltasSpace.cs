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
        public event EventHandler naveAgregado;
        private List<Space> listaDeNaves;

        public FrmAltasSpace(List<Space> lista)
        {
            InitializeComponent();
            listaDeNaves = lista;
            this.ActiveControl = txtaño;
        }        


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarMS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltasSpace_Load(object sender, EventArgs e)
        {
            txtaño.Focus();
        }

        // ******************** MODELO SPACE X STARTSHIP *****************
        // PRIMER TEXTBOX

        private void txtaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                txtHorasDeVuelo.Select();
                txtHorasDeVuelo.TabStop = true;
            }
        }

        // SEGUNDO TEXTBOX

        private void txtHorasDeVuelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                txtColor.Select();
                txtColor.TabStop = true;
            }
        }

        // TERCER TEXTBOX

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y letras.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                txtPropietario.Select();
                txtPropietario.TabStop = true;
            }
        }

        // CUARTO TEXTBOX

        private void txtPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y letras.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                btnAceptar.Select();
                btnAceptar.TabStop = true;
            }
        }

        // BOTTON ACEPTAR MODELO STARTSHIP

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
            horasVuelo = Convert.ToInt32(txtHorasDeVuelo.Text);

            listaDeNaves.Add(new Space(horasVuelo, "STARSHIP", 500, 1000, año, color, propietario));

            naveAgregado?.Invoke(this, EventArgs.Empty);

            this.Close();

        }

        // ******************** MODELO SPACE X FALCON 9 *****************
        // PRIMER TEXTBOX
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                textBox3.Select();
                textBox3.TabStop = true;
            }
        }

        // SEGUNDO TEXTBOX
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                textBox2.Select();
                textBox2.TabStop = true;
            }
        }

        // TERCER TEXTBOX
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y letras.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                textBox1.Select();
                textBox1.TabStop = true;
            }
        }

        // CUARTO TEXTBOX
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y letras.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                btnAceptarMS.Select();
                btnAceptarMS.TabStop = true;
            }
        }

        // BOTON ACEPTAR MODELO FALCON 9
        private void btnAceptarMS_Click(object sender, EventArgs e)
        {
            int año = 0;
            int horasVuelo = 0;
            string color = string.Empty;
            string propietario = string.Empty;

            año = Convert.ToInt32(textBox4.Text);
            color = textBox2.Text;
            propietario = textBox1.Text;
            horasVuelo = Convert.ToInt32(textBox3.Text);

            listaDeNaves.Add(new Space(horasVuelo, "FALCON9", 200, 400, año, color, propietario));

            naveAgregado?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

    }
}
