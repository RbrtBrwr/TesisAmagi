/// Creo que esto ya no va
/// 
using System;
namespace CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas
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

        //public checkIfNewSetupInList(Setup nuevoSetup, ListasSabores)
        //{

        //}

    }
}

