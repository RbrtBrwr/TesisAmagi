using System;
namespace CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas
{
	public class ListasTIC
	{
		public ListaSetupTIC ListaSetupTIC { get; set; }
		public ListaOngoingTIC ListaOngoingTIC { get; set; }
        public ListasTIC()
		{
			ListaSetupTIC = new ListaSetupTIC();
			ListaOngoingTIC = new ListaOngoingTIC();
		}
	}
}

