using System;
namespace CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas
{
	public class ListasCiberSeguridad
	{
		public ListaSetupCiberSeguridad ListaSetupCiberSeguridad { get; set; }
		public ListaOngoingCiberSeguridad ListaOngoingCiberSeguridad { get; set; }
		public ListasCiberSeguridad()
		{
			ListaSetupCiberSeguridad = new ListaSetupCiberSeguridad();
			ListaOngoingCiberSeguridad = new ListaOngoingCiberSeguridad();
		}
	}
}

