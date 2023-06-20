using System.Drawing;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL
{
    
    public partial class FrmPrincipalMenu : Form
    {
        private Dictionary<string, int> diccionarioServiceAuto = new Dictionary<string, int>();
        private Dictionary<string, int> diccionarioServiceSpace = new Dictionary<string, int>();

        private List<Car> listaDeAutos;
        
        // List<Car> listaDeAutos = new List<Car>();
        List<Space> listaDeNaves = new List<Space>();

        public FrmPrincipalMenu()
        {
            InitializeComponent();

            listaDeAutos= new List<Car>();



            diccionarioServiceAuto.Add("(1) Control Cinturones de Seguridad", 1000);
            diccionarioServiceAuto.Add("(2) Control de Baterias", 2000);
            diccionarioServiceAuto.Add("(3) Control del sistema de navegacionAuto", 2500);
            diccionarioServiceAuto.Add("(4) Control del sistema de Traccion", 3000);
            diccionarioServiceAuto.Add("(5) Control del motor", 3000);
            diccionarioServiceSpace.Add("(1) Control del sistema de propulsion", 1000);
            diccionarioServiceSpace.Add("(2) Control del sistema de navegacionSpace", 500);

            // A variable is created that is a list of objects with the defined structure.
            
            // public Car(string modelo, int asientos, int km, int autonomia, int service, int año, string color, string propietario);

            listaDeAutos.Add(new Car("MODELO X", 7, 50000, 560, 1000, 2022, "CELESTE", "BILL GATES"));
            listaDeAutos.Add(new Car("MODELO X", 7, 25000, 560, 1000, 2023, "ROSA", "LIONEL MESSI"));
            listaDeAutos.Add(new Car("MODELO S", 5, 10000, 650, 2000, 2022, "BLANCO", "DONALD TRUMP"));
            listaDeAutos.Add(new Car("MODELO S", 5, 20000, 650, 2000, 2022, "AZUL", "CRISTIANO RONALDO"));
            listaDeAutos.Add(new Car("CYBERTRUCK", 6, 50000, 800, 3000, 2020, "NARANJA", "VIN DIESEL"));
            listaDeAutos.Add(new Car("CYBERTRUCK", 6, 50000, 800, 3000, 2020, "VERDE", "JASON STATHAM"));

            listaDeNaves.Add(new Space("FALCON9X", 200, 400, 2020, "NEGRO", "ELION MUSK"));
            listaDeNaves.Add(new Space("FALCON9X", 200, 400, 2021, "AZUL", "ELION MUSK"));
            listaDeNaves.Add(new Space("STARSHIP", 500, 1000, 2022, "VERDE", "ELION MUSK"));
            listaDeNaves.Add(new Space("STARSHIPII", 500, 1000, 2023, "ROJO", "ELION MUSK"));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void autosTESLAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aLTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasAutos form2 = new FrmAltasAutos(listaDeAutos);
            form2.Show();

        }

        private void eSCANEOVEHICULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int> elemento in diccionarioServiceAuto)
            {
                
                Form3 form3 = new Form3();
                MessageBox.Show("Clave: " + elemento.Key + ", Valor: " + elemento.Value);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasSpace frmAltasSpace = new FrmAltasSpace();
            frmAltasSpace.Show();
        }

        private void mOSTRARTESLAMASANTIGUOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var autoMasAntiguo = listaDeAutos.OrderBy(auto => auto.Año).First();

            MessageBox.Show(autoMasAntiguo.Modelo + " Año " + autoMasAntiguo.Año + " Propietario " + autoMasAntiguo.Propietario + " Color " + autoMasAntiguo.Color );

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var NaveMasNueva = listaDeNaves.OrderBy(auto => auto.Año).Last();

            MessageBox.Show(NaveMasNueva.Modelo + " Año " + NaveMasNueva.Año + " Propietario " + NaveMasNueva.Propietario + " Color " + NaveMasNueva.Color);

        }
    }
}