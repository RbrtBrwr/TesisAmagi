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

