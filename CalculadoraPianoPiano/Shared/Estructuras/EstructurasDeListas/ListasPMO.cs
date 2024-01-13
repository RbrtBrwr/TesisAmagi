using System;
namespace CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas
{
	public class ListasPMO
	{
		public ListaSetupPMO ListaSetupPMO { get; set; }
		public ListaOngoingPMO ListaOngoingPMO { get; set; }
		public ListasPMO()
		{
			ListaSetupPMO = new ListaSetupPMO();
			ListaOngoingPMO = new ListaOngoingPMO();
		}
	}
}

