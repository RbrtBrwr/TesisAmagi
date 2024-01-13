/// Listas de los sectores de TIC. Necesita metodos para eliminar un Setup de la lista, mostrar la info de
/// todos los setups y calcular el costo total de la lista.

using System;
namespace CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas
{
	public class ListaSetupTIC
	{
		public List<Setup> ListaTelecomunicaciones { get; set; }
		public List<Setup> ListaBasesDeDatos { get; set; }
		public List<Setup> ListaServidoresFisicos { get; set; }
		public List<Setup> ListaServidoresVirtuales { get; set; }
		public List<Setup> ListaPlataformasCentralizadas { get; set; }

        public ListaSetupTIC()
		{
			ListaTelecomunicaciones = new List<Setup>();
			ListaBasesDeDatos = new List<Setup>();
			ListaServidoresFisicos = new List<Setup>();
			ListaServidoresVirtuales = new List<Setup>();
			ListaPlataformasCentralizadas = new List<Setup>();
		}
	}
}

