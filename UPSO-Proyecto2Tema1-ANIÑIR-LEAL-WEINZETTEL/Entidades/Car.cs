using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades
{
    // Clase que representa un automóvil y hereda de la clase 'Padre'.
    public class Car : Vehiculo
    {
      
        private int asientos = 0;
        private int km = 0;

        public int Asientos { get => asientos; set => asientos = value; }
        public int Km { get => km; set => km = value; }


        /// <summary>
        /// Constructor de la clase Car que recibe parámetros para inicializar las propiedades de la clase base 'Padre'
        /// y las propiedades específicas de la clase 'Car'.
        /// </summary>
        /// <param name="modelo"> modelo del automóvil.</param>
        /// <param name="autonomia"> autonomía del automóvil.</param>
        /// <param name="service"> número de servicios realizados al automóvil.</param>
        /// <param name="año"> año de fabricación del automóvil.</param>
        /// <param name="color"> color del automóvil.</param>
        /// <param name="propietario"> propietario del automóvil.</param>
        public Car(string modelo,int autonomia, int service, int año, string color, string propietario) : base(modelo, autonomia, service, año, color, propietario)
        {

        }



        /// <summary>
        /// Constructor de la clase Car que recibe parámetros para inicializar las propiedades de la clase base 'Padre'
        /// y las propiedades específicas de la clase 'Car'.
        /// </summary>
        /// <param name="modelo"> modelo del automóvil.</param>
        /// <param name="asientos"> número de asientos del automóvil.</param>
        /// <param name="km">kilómetros recorridos por el automóvil.</param>
        /// <param name="autonomia">Autonomía del automóvil.</param>
        /// <param name="service">Número de servicios realizados al automóvil.</param>
        /// <param name="año">año de fabricación del automóvil.</param>
        /// <param name="color">color del automóvil.</param>
        /// <param name="propietario">Propietario del automóvil.</param>
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
