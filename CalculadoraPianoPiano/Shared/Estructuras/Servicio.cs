/// Cada servicio del ongoing tiene un nombre y un costo asignado
/// TODO: creo que tambien necesita una variable tipo? (si es 7x24 o 5x8)
using System;
namespace CalculadoraPianoPiano.Shared
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public double Costo { get; set; }
    
        public Servicio()
		{
		}
	}
}

