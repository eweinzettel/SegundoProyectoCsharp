using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades
{
    public class Car : Padre
    {
      
        private int asientos = 0;
        private int km = 0;

        public int Asientos { get => asientos; set => asientos = value; }
        public int Km { get => km; set => km = value; }

        public Car(string modelo,int autonomia, int service, int año, string color, string propietario) : base(modelo, autonomia, service, año, color, propietario)
        {

        }

        public Car(string modelo, int asientos, int km, int autonomia, int service, int año, string color, string propietario): base(modelo,autonomia, service, año, color, propietario)
        {
            this.Modelo = modelo;
            this.Asientos = asientos;
            this.Km = km;
            this.Autonomia= autonomia;
            this.Service= service;
            this.Año = año; 
            this.Color= color;
            this.Propietario= propietario;
        }
    }
}
