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

        private List<Car> listaDeAutos;


        public FrmAltasAutos(List<Car> lista)
        {
            InitializeComponent();

            listaDeAutos = lista;

            

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

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

            // public Car(string modelo, int asientos, int km, int autonomia, int service, int año, string color, string propietario);


            // listaDeAutos.Add(new Car("MODELO X", 7, 50000, 560, 1000, 2022, "CELESTE", "BILL GATES"));

            listaDeAutos.Add(new Car("MODELO X", 7, km, 560, 1000, año, color, propietario));
            limpiarTexbox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int año = 0;
            int km = 0;
            string color = string.Empty;
            string propietario = string.Empty;

            año = Convert.ToInt32(txtaño.Text);
            km = Convert.ToInt32(txtKmActual.Text);
            color = txtColor.Text;
            propietario = txtPropietario.Text;

            // public Car(string modelo, int asientos, int km, int autonomia, int service, int año, string color, string propietario);

            Car autoNuevo = new Car("MODELO X", 7, km, 560, 1000, año, color, propietario);
            limpiarTexbox();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int año = 0;
            int km = 0;
            string color = string.Empty;
            string propietario = string.Empty;

            año = Convert.ToInt32(txtaño.Text);
            km = Convert.ToInt32(txtKmActual.Text);
            color = txtColor.Text;
            propietario = txtPropietario.Text;

            // public Car(string modelo, int asientos, int km, int autonomia, int service, int año, string color, string propietario);

            Car autoNuevo = new Car("MODELO X", 7, km, 560, 1000, año, color, propietario);
            limpiarTexbox();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            limpiarTexbox();
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
    }
}
