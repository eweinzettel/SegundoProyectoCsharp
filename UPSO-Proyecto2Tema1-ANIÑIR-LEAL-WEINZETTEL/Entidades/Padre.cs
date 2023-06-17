using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades
{
    public class Padre
    {
        int autonomia = 0;
        int service = 0;
        int año = 0;
        string color = string.Empty;
        string propietario = string.Empty;
        private int horasDeVuelo;

        public Padre() { }

        public Padre(int horasDeVuelo)
        {
            this.horasDeVuelo = horasDeVuelo;
        }

        public Padre(int autonomia, int service, int año, string color, string propietario)
        {
            this.Autonomia = autonomia;
            this.Service = service;
            this.Año = año;
            this.Color = color;
            this.Propietario = propietario;
        }

        public int Autonomia { get => autonomia; set => autonomia = value; }
        public int Service { get => service; set => service = value; }
        public int Año { get => año; set => año = value; }
        public string Color { get => color; set => color = value; }
        public string Propietario { get => propietario; set => propietario = value; }
    }
}
