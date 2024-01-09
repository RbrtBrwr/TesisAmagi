using System;
namespace CalculadoraPianoPiano.Shared
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
		}
	}
}

