using System.Drawing;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL
{

    public partial class FrmPrincipalMenu : Form
    {
        private BindingSource bindingSourceAutos, bindingSourceNaves;

        private Dictionary<string, int> diccionarioServiceAuto = new Dictionary<string, int>();
        private Dictionary<string, int> diccionarioServiceSpace = new Dictionary<string, int>();

        private List<Car> listaDeAutos;
        private List<Space> listaDeNaves;

        private string cellValueAutonomia;
        private string cellValueKm;

        private string cellValueHorasVuelo;
        private string cellValueAutonomiaVuelo;


        public FrmPrincipalMenu()
        {
            InitializeComponent();

            listaDeAutos = new List<Car>();
            listaDeNaves = new List<Space>();

            diccionarioServiceAuto.Add("(1) Control Cinturones de Seguridad", 1000);
            diccionarioServiceAuto.Add("(2) Control de Baterias", 2000);
            diccionarioServiceAuto.Add("(3) Control del sistema de navegacionAuto", 2500);
            diccionarioServiceAuto.Add("(4) Control del sistema de Traccion", 3000);
            diccionarioServiceAuto.Add("(5) Control del motor", 3000);
            diccionarioServiceSpace.Add("(1) Control del sistema de propulsion", 1000);
            diccionarioServiceSpace.Add("(2) Control del sistema de navegacionSpace", 500);

            // A variable is created that is a list of objects with the defined structure.

            // public Car(string modelo, int asientos, int km, int autonomia, int service, int año, string color, string propietario);

            listaDeAutos.Add(new Car("MODELO X", 7, 4200, 560, 1000, 2022, "CELESTE", "BILL GATES"));
            listaDeAutos.Add(new Car("MODELO X", 7, 5600, 560, 1000, 2023, "ROSA", "LIONEL MESSI"));
            listaDeAutos.Add(new Car("MODELO S", 5, 12500, 650, 2000, 2022, "BLANCO", "DONALD TRUMP"));
            listaDeAutos.Add(new Car("MODELO S", 5, 2000, 650, 2000, 2022, "AZUL", "CRISTIANO RONALDO"));
            listaDeAutos.Add(new Car("CYBERTRUCK", 6, 1500, 800, 3000, 2020, "NARANJA", "VIN DIESEL"));
            listaDeAutos.Add(new Car("CYBERTRUCK", 6, 5800, 800, 3000, 2020, "VERDE", "JASON STATHAM"));

            listaDeNaves.Add(new Space(500,"FALCON9X", 200, 400, 2020, "NEGRO", "ELION MUSK"));
            listaDeNaves.Add(new Space(600,"FALCON9X", 200, 400, 2021, "AZUL", "ELION MUSK"));
            listaDeNaves.Add(new Space(750,"STARSHIP", 500, 1000, 2022, "VERDE", "ELION MUSK"));
            listaDeNaves.Add(new Space(1000,"STARSHIPII", 500, 1000, 2023, "ROJO", "ELION MUSK"));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listaDeAutos;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dataGridView2.DataSource = listaDeNaves;
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            bindingSourceAutos = new BindingSource();
            bindingSourceNaves = new BindingSource();

            bindingSourceAutos.DataSource = listaDeAutos;
            bindingSourceNaves.DataSource = listaDeNaves;

            dataGridView1.DataSource = bindingSourceAutos;
            dataGridView2.DataSource = bindingSourceNaves;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAltasAuto_Click(object sender, EventArgs e)
        {
            FrmAltasAutos frmAltasAutos = new FrmAltasAutos(listaDeAutos);
            frmAltasAutos.autoAgregado += actualizarGrillaAutos;
            frmAltasAutos.Show();
        }

        private void btnAltaNave_Click(object sender, EventArgs e)
        {
            FrmAltasSpace frmAltasSpace = new FrmAltasSpace(listaDeNaves);
            frmAltasSpace.naveAgregado += actualizarGrillaNaves;
            frmAltasSpace.Show();
        }

        private void btnMostarCarga_Click(object sender, EventArgs e)
        {
            var autoMasAntiguo = listaDeAutos.OrderBy(auto => auto.Año).First();
            var listaFiltrada = listaDeAutos.Where(auto => auto == autoMasAntiguo).ToList();
            dataGridView1.DataSource = listaFiltrada;
        }

        private void btnMostarnaveMasNueva_Click(object sender, EventArgs e)
        {
            var naveMasNueva = listaDeNaves.OrderBy(nave => nave.Año).Last();
            var listaFiltrada = listaDeNaves.Where(nave => nave == naveMasNueva).ToList();
            dataGridView2.DataSource = listaFiltrada;
        }


        private void btnEliminarNave_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView2.SelectedRows[0];

                // Verificar si la fila está enlazada a un objeto
                if (filaSeleccionada.DataBoundItem != null)
                {
                    // Obtener el objeto asociado a la fila seleccionada
                    Space elementoAEliminar = (Space)filaSeleccionada.DataBoundItem;

                    // Remover el elemento de la lista original
                    listaDeNaves.Remove(elementoAEliminar);

                    // Volver a asignar la lista actualizada al BindingSource
                    bindingSourceAutos.DataSource = null;
                    bindingSourceAutos.DataSource = listaDeNaves;

                    // Volver a asignar el BindingSource al DataGridView
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = bindingSourceNaves;

                    actualizarGrillaNaves(sender, e);
                }
            }
        }

        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Verificar si la fila está enlazada a un objeto
                if (filaSeleccionada.DataBoundItem != null)
                {
                    // Obtener el objeto asociado a la fila seleccionada
                    Car elementoAEliminar = (Car)filaSeleccionada.DataBoundItem;

                    // Remover el elemento de la lista original
                    listaDeAutos.Remove(elementoAEliminar);

                    // Volver a asignar la lista actualizada al BindingSource
                    bindingSourceAutos.DataSource = null;
                    bindingSourceAutos.DataSource = listaDeAutos;

                    // Volver a asignar el BindingSource al DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bindingSourceAutos;

                    actualizarGrillaAutos(sender, e);
                }
            }

        }

        private void btnMostrarTodosAutos_Click(object sender, EventArgs e)
        {
            actualizarGrillaAutos(sender, e);
        }

        private void btnMostarTodasNaves_Click(object sender, EventArgs e)
        {
            actualizarGrillaNaves(sender, e);
        }
        
        private void actualizarGrillaNaves(object sender, EventArgs e)
        {
            // Actualizar la vista del DataGridView
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaDeNaves;
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void btnCargaBateria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cellValueKm) && !string.IsNullOrEmpty(cellValueAutonomia))
            {
                int km = Convert.ToInt32(cellValueKm);
                int autonomia = Convert.ToInt32(cellValueAutonomia);

                if (autonomia != 0)
                {
                    int resultado = km / autonomia;
                    MessageBox.Show("La cantida de cargas de baterias es de " + resultado.ToString());
                }
                else
                {
                    MessageBox.Show("El valor de autonomía no puede ser cero.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una fila o las celdas son nulas.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Obtiene el valor de la celda en la columna 1 de la fila seleccionada (Km)
                object kmCellValue = selectedRow.Cells[1].Value;
                cellValueKm = kmCellValue?.ToString();

                // Obtiene el valor de la celda en la columna 3 de la fila seleccionada (Autonomía)
                object autonomiaCellValue = selectedRow.Cells[3].Value;
                cellValueAutonomia = autonomiaCellValue?.ToString();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Obtiene el valor de la celda en la columna 1 de la fila seleccionada (Km)
                object horasVueloCellValue = selectedRow.Cells[0].Value;
                cellValueHorasVuelo = horasVueloCellValue?.ToString();

                // Obtiene el valor de la celda en la columna 3 de la fila seleccionada (Autonomía)
                object autonomiaVueloCellValue = selectedRow.Cells[2].Value;
                cellValueAutonomiaVuelo = autonomiaVueloCellValue?.ToString();
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnCargaCombustibleNave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cellValueHorasVuelo) && !string.IsNullOrEmpty(cellValueAutonomiaVuelo))
            {
                int horasVuelo = Convert.ToInt32(cellValueHorasVuelo);
                int autonomiaVuelo = Convert.ToInt32(cellValueAutonomiaVuelo);

                if (autonomiaVuelo != 0)
                {
                    int resultado = horasVuelo / autonomiaVuelo;
                    MessageBox.Show("La cantida de cargas de combustible fue de " + resultado.ToString());
                }
                else
                {
                    MessageBox.Show("El valor de autonomía no puede ser cero.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una fila o las celdas son nulas.");
            }
        }

        private void btnEscaneo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Car autoSeleccionado = (Car)filaSeleccionada.DataBoundItem;

                // Calcular la cantidad de servicios basados en el kilometraje del auto
                int kilometraje = autoSeleccionado.Km;
                int serviceCada = autoSeleccionado.Service;
                int cantidadServicios = kilometraje / serviceCada;

                // Crear una lista para almacenar los servicios realizados
                List<string> serviciosRealizados = new List<string>();

                for (int i = 1; i <= cantidadServicios; i++)
                {
                    // Realizar las verificaciones necesarias según el número de servicio
                    if (kilometraje >= 1000)
                    {
                        serviciosRealizados.Add("(1) Control Cinturones de Seguridad");
                    }

                    if (kilometraje >= 2000)
                    {
                        serviciosRealizados.Add("(2) Control de Baterias");
                    }

                    if (kilometraje >= 2500)
                    {
                        serviciosRealizados.Add("(4) Control del Sistema de Navegacion");
                    }

                    if (kilometraje >= 3000)
                    {
                        serviciosRealizados.Add("(5) Control del Sistema de Traccion");
                        serviciosRealizados.Add("(6) Control del motor");
                    }
                }

                if (cantidadServicios > 0)
                {
                    string mensaje = $"Se realizaron {cantidadServicios} servicio(s) al {autoSeleccionado.Modelo} con {kilometraje} km:\n";
                    foreach (string servicio in serviciosRealizados)
                    {
                        mensaje += $"- {servicio}\n";
                    }
                    MessageBox.Show(mensaje);
                }

            }
        }

        private void btnEscaneoNave_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView2.SelectedRows[0];
                Space naveSeleccionado = (Space)filaSeleccionada.DataBoundItem;

                // Calcular la cantidad de servicios basados en el kilometraje del auto
                int horasVuelo = naveSeleccionado.HorasDeVuelo;
                int serviceNaveCada = naveSeleccionado.Service;
                int cantidadServiciosNaves = horasVuelo / serviceNaveCada;

                // Crear una lista para almacenar los servicios realizados
                List<string> serviciosRealizadosNaves = new List<string>();

                for (int i = 1; i <= cantidadServiciosNaves; i++)
                {
                    // Realizar las verificaciones necesarias según el número de servicio
                    if (horasVuelo >= 1000)
                    {
                        serviciosRealizadosNaves.Add("3) Control del Sistema de Propulsion");
                    }

                    if (horasVuelo >= 500)
                    {
                        serviciosRealizadosNaves.Add("(4) Control del Sistema de Navegacion");
                    }
                }

                if (cantidadServiciosNaves > 0)
                {
                    string mensaje = $"Se realizaron {cantidadServiciosNaves} servicio(s) al {naveSeleccionado.Modelo} con {horasVuelo} Hs:\n";
                    foreach (string servicio in serviciosRealizadosNaves)
                    {
                        mensaje += $"- {servicio}\n";
                    }
                    MessageBox.Show(mensaje);
                }

            }
        }

        private void actualizarGrillaAutos(object sender, EventArgs e)
        {
            // Actualizar la vista del DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDeAutos;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            
        }
    }
   
}