/// Informacion del cliente, sector creo que va a ser utilizado para las estimaciones
/// madurez podria tener una variable de esfuerzo adicional
/// 
using System;
namespace CalculadoraPianoPiano.Shared
{
    public class InfoCliente
    {
        public string Nombre { get; set; }
        public string Sector { get; set; }
        public string Madurez { get; set; }

    
        public InfoCliente(string nombre, string sector, string madurez)
		{
            Nombre = nombre;
            Sector = sector;
            Madurez = madurez;
		}
	}
}

