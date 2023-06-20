using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL.Entidades
{
    public class Space : Padre
    {
        private int horasDeVuelo;

        public int HorasDeVuelo { get => horasDeVuelo; set => horasDeVuelo = value; }

        public Space(string modelo, int autonomia, int service, int año, string color, string propietario): base(modelo, autonomia, service, año, color, propietario) 
        { 
        
        }

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
