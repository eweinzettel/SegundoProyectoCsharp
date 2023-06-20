using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades
{
    public class Padre
    {
        private string modelo = string.Empty;
        private int autonomia = 0;
        private int service = 0;
        private int año = 0;
        private string color = string.Empty;
        private string propietario = string.Empty;

        public Padre(string modelo, int autonomia, int service, int año, string color, string propietario)
        {
            this.modelo = modelo;
            this.autonomia = autonomia;
            this.service = service;
            this.año = año;
            this.color = color;
            this.propietario = propietario;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public int Autonomia { get => autonomia; set => autonomia = value; }
        public int Service { get => service; set => service = value; }
        public int Año { get => año; set => año = value; }
        public string Color { get => color; set => color = value; }
        public string Propietario { get => propietario; set => propietario = value; }


        //public Padre(string modelo, int autonomia, int service, int año, string color, string propietario)
        //{
        //    this.modelo = modelo;
        //    this.Autonomia = autonomia;
        //    this.Service = service;
        //    this.Año = año;
        //    this.Color = color;
        //    this.Propietario = propietario;
        //}

        //public string modelo { get => modelo; set => modelo = value; }
        //public int Autonomia { get => autonomia; set => autonomia = value; }
        //public int Service { get => service; set => service = value; }
        //public int Año { get => año; set => año = value; }
        //public string Color { get => color; set => color = value; }
        //public string Propietario { get => propietario; set => propietario = value; }

    }
}
