using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades
{   // Clase base
    public class Vehiculo
    {
        
        // propiedades de la clase 
        private string modelo = string.Empty;
        private int autonomia = 0;
        private int service = 0;
        private int año = 0;
        private string color = string.Empty;
        private string propietario = string.Empty;


        /// <summary>
        /// Constructor de la clase Vehiculo que recibe parámetros para inicializar las propiedades de la clase.
        /// </summary>
        /// <param name="modelo">modelo del automovil.</param>
        /// <param name="autonomia">autonomía del automovil.</param>
        /// <param name="service"> número de servicios realizados automovil.</param>
        /// <param name="año">año del automovil.</param>
        /// <param name="color">color del automovil.</param>
        /// <param name="propietario">propietario del automovil.</param>

        public Vehiculo(string modelo, int autonomia, int service, int año, string color, string propietario)
        {
            this.modelo = modelo;
            this.autonomia = autonomia;
            this.service = service;
            this.año = año;
            this.color = color;
            this.propietario = propietario;
        }

        // Encapsulamiento de las variables
        public string Modelo { get => modelo; set => modelo = value; }
        public int Autonomia { get => autonomia; set => autonomia = value; }
        public int Service { get => service; set => service = value; }
        public int Año { get => año; set => año = value; }
        public string Color { get => color; set => color = value; }
        public string Propietario { get => propietario; set => propietario = value; }

    }
}
