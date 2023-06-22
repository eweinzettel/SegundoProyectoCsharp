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
    public partial class FrmAltasAutos : Form
    {

        public event EventHandler autoAgregado;
        private List<Car> listaDeAutos;

        public FrmAltasAutos(List<Car> lista)
        {
            InitializeComponent();
            listaDeAutos = lista;
            this.ActiveControl = txtaño;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            limpiarTexbox();
            txtaño.Focus();
        }

        


        // ********************* MODELO X ******************************
        // control de los objetos texbox y de la informacion introducida

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
                txtKmActual.Select();
                txtKmActual.TabStop = true;
            }
        }

        // SEGUNDO TEXTBOX
        private void txtKmActual_KeyPress(object sender, KeyPressEventArgs e)
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

        // BOTON ACEPTAR MODELO X
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int año = 0;
            int km = 0;
            string color = string.Empty;
            string propietario = string.Empty;

            año = Convert.ToInt32(txtaño.Text);
            km = Convert.ToInt32(txtKmActual.Text);
            color = txtColor.Text;
            propietario = txtPropietario.Text;

            listaDeAutos.Add(new Car("MODELO X", 7, km, 560, 1000, año, color, propietario));

            autoAgregado?.Invoke(this, EventArgs.Empty);

            limpiarTexbox();

            this.Close();
        }

        // ************************ MODELO S ******************************
        // control de los objetos texbox y de la informacion introducida

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
                textBox3.TabStop= false;
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
                textBox2.TabStop= false;

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
                textBox1.TabStop= false;
            }
        }

        //CUARTO TEXTBOX

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
                btnAceptarMS.TabStop= false;

            }
        }

        // BOTON ACEPTAR MODELO S

        private void button2_Click(object sender, EventArgs e)
        {
            int año = 0;
            int km = 0;
            string color = string.Empty;
            string propietario = string.Empty;

            año = Convert.ToInt32(textBox4.Text);
            km = Convert.ToInt32(textBox3.Text);
            color = textBox3.Text;
            propietario = textBox1.Text;

            listaDeAutos.Add(new Car("MODELO S", 5, km, 650, 2000, año, color, propietario));

            autoAgregado?.Invoke(this, EventArgs.Empty);

            limpiarTexbox();

            this.Close();





        }

        // ************************ MODELO CIBERTRUCK *************************
        // control de los objetos texbox y de la informacion introducida

        // PRIMER TEXTBOX


        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                textBox7.Select();
                textBox7.TabStop= true;

            }
        }

        // SEGUNDO TEXTBOX

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                textBox6.Select(); 
                textBox6.TabStop= true;


            }
        }

        // TERCER TEXTBOX
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y letras.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                textBox5.Select(); 
                textBox5.TabStop= true;

            }
        }

        // CUARTO TEXTBOX

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y letras.");
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true; // Evita que se ingrese el Enter o Tab en el TextBox actual
                button8.Select();
                button8.TabStop= true;

            }
        }

        // BOTON ACEPTAR MODELO CYBERTRUCK

        private void button8_Click(object sender, EventArgs e)
        {
            int año = 0;
            int km = 0;
            string color = string.Empty;
            string propietario = string.Empty;

            año = Convert.ToInt32(textBox8.Text);
            km = Convert.ToInt32(textBox7.Text);
            color = textBox6.Text;
            propietario = textBox5.Text;

            listaDeAutos.Add(new Car("CYBERTRUCK", 6, km, 800, 3000, año, color, propietario));

            autoAgregado?.Invoke(this, EventArgs.Empty);

            limpiarTexbox();

            this.Close();




        }

        private void limpiarTexbox()
        {
            txtaño.Clear();
            txtKmActual.Clear();
            txtColor.Clear();
            txtPropietario.Clear();
        }

        private void btnCancelarMS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
