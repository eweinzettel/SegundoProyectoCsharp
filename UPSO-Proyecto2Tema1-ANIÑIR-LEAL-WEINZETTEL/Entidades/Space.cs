using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades
{
    // Representa una clase que describe una nave espacial o de cualquier otro tipo.
    // Hereda de la clase base 'Vehiculo' que contiene propiedades comunes a vehículos.

    public class Space : Vehiculo
    {
        // declaracion de las propiedades del objeto
        private int horasDeVuelo;

        // Encapsulamiento de las variables
        public int HorasDeVuelo { get => horasDeVuelo; set => horasDeVuelo = value; }


        /// <summary>
        /// Inicializa una nueva instancia de la clase 'Space' con los valores proporcionados.
        /// </summary>
        /// <param name="modelo">Modelo de la nave espacial.</param>
        /// <param name="autonomia">Autonomía de la nave espacial.</param>
        /// <param name="service">Número de servicios realizados en la nave espacial.</param>
        /// <param name="año">Año de fabricación de la nave espacial.</param>
        /// <param name="color">Color de la nave espacial.</param>
        /// <param name="propietario">Propietario de la nave espacial.</param>
        public Space(string modelo, int autonomia, int service, int año, string color, string propietario): base(modelo, autonomia, service, año, color, propietario) 
        { 
        
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase 'Space' con los valores proporcionados, incluyendo las horas de vuelo.
        /// </summary>
        /// <param name="horasDeVuelo">horas de vuelo de la nave espacial.</param>
        /// <param name="modelo">modelo de la nave espacial.</param>
        /// <param name="autonomia">Autonomía de la nave espacial.</param>
        /// <param name="service">Número de servicios realizados en la nave espacial.</param>
        /// <param name="año">Año de fabricación de la nave espacial.</param>
        /// <param name="color">Color de la nave espacial.</param>
        /// <param name="propietario">Propietario de la nave espacial.</param>
        public Space(int horasDeVuelo, string modelo, int autonomia, int service, int año, string color, string propietario) : base(modelo, autonomia, service, año, color, propietario)
        {
            this.horasDeVuelo = horasDeVuelo;
            this.Modelo = modelo;
            this.Autonomia = autonomia; 
            this.Service = service;
            this.Año = Año;
            this.Color = color;
            this.Propietario= propietario;
        }

    }



}
