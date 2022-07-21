using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Models
{
    public class Persona
    {
        public Persona() { }

        public Persona(string nombre, DateTime fechaNacimiento, Color colorFavorito, String imagenfavorita = "")
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            this.colorFavorito = colorFavorito;
            ImagenFavorita = imagenfavorita;

        }


        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Color colorFavorito { get; set; }

        public String ImagenFavorita { get; set; }

    }
}
