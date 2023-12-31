using System;
namespace CalculadoraPianoPiano.Shared
{
	public class ListasSabores
	{
        public List<Setup>? ListaSetup { get; set; }
        public List<Ongoing>? ListaOngoing { get; set; }

        public ListasSabores()
        {
            ListaSetup = new List<Setup>();
            ListaOngoing = new List<Ongoing>();
        }

	}
}

