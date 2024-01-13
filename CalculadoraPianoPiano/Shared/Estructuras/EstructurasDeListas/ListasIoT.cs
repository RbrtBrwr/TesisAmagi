using System;
namespace CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas
{
	public class ListasIoT
	{
		public ListaSetupIoT ListaSetupIoT { get; set; }
		public ListaOngoingIoT ListaOngoingIoT { get; set; }
		public ListasIoT()
		{
			ListaSetupIoT = new ListaSetupIoT();
			ListaOngoingIoT = new ListaOngoingIoT();
		}
	}
}

