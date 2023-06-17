using System.Drawing;
using UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> diccionarioServiceAuto = new Dictionary<string, int>();
        private Dictionary<string, int> diccionarioServiceSpace = new Dictionary<string, int>();

        struct InformacionTesla
        {
            public string modelo;
            public int año;
            public int autonomia;
            public int asientos;
            public int kmActual;
            public string color;
            public string propietario;
            public int serviceCada;

            public InformacionTesla(string modelo, int año, int autonomia, int asientos, int kmActual, string color, string propietario, int serviceCada)
            {
                this.modelo = modelo;
                this.año = año;
                this.autonomia = autonomia;
                this.asientos = asientos;
                this.kmActual = kmActual;
                this.color = color;
                this.propietario = propietario;
                this.serviceCada = serviceCada;
            }
        }

            List<Car> listaAutosTesla = new List<Car>();
            List<Space> listaCohetes= new List<Space>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            diccionarioServiceAuto.Add("(1) Control Cinturones de Seguridad", 1000);
            diccionarioServiceAuto.Add("(2) Control de Baterias", 2000);
            diccionarioServiceAuto.Add("(3) Control del sistema de navegacionAuto", 2500);
            diccionarioServiceAuto.Add("(4) Control del sistema de Traccion", 3000);
            diccionarioServiceAuto.Add("(5) Control del motor", 3000);

            diccionarioServiceSpace.Add("(1) Control del sistema de propulsion", 1000);
            diccionarioServiceSpace.Add("(2) Control del sistema de navegacionSpace", 500);


            Car tesla = new();  
            Space Spacex= new Space();

            // A variable is created that is a list of objects with the defined structure.
            List<InformacionTesla> TodosLosAutos = new List<InformacionTesla>();

            // Starting data for TESLA cars.
            TodosLosAutos.Add(new InformacionTesla { modelo = "MODELO X", año = 2021, autonomia = 560 , asientos = 7, kmActual = 31000,  color = "CELESTE", propietario = "BILL GATES" , serviceCada = 1000 });
            TodosLosAutos.Add(new InformacionTesla { modelo = "MODELO X", año = 2021, autonomia = 560, asientos = 7, kmActual = 16000,  color = "ROJO", propietario = "LIONEL MESSI",serviceCada = 1000 });
            TodosLosAutos.Add(new InformacionTesla { modelo = "MODELO S", año = 2019, autonomia = 650, asientos = 5, kmActual = 12000,  color = "BLANCO", propietario = "DONALD TRUMP",serviceCada = 2000 });
            TodosLosAutos.Add(new InformacionTesla { modelo = "MODELO S", año = 2023, autonomia = 650, asientos = 5, kmActual = 7500,  color = "NEGRO", propietario = "CRISTIANO RONALDO",serviceCada = 2000 });
            TodosLosAutos.Add(new InformacionTesla { modelo = "CYBERTRUCK", año = 2003, autonomia = 800, asientos = 6, kmActual = 15000,  color = "AZUL", propietario = "VIN DIESEL",serviceCada = 3000 });
            TodosLosAutos.Add(new InformacionTesla { modelo = "CYBERTRUCK", año = 2020, autonomia = 800, asientos = 6, kmActual = 61000,  color = "TURQUEZA", propietario = "JASON STATHAM",serviceCada = 3000 });

        }

        private void autosTESLAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aLTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void eSCANEOVEHICULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int> elemento in diccionarioServiceAuto)
            {
                
                Form3 form3 = new Form3();
             // form3.textbox1.
                
                Console.WriteLine("Clave: " + elemento.Key + ", Valor: " + elemento.Value);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}