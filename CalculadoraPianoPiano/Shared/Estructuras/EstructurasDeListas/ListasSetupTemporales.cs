using System;
using Microsoft.AspNetCore.Components;

namespace CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas
{
	public class ListasSetupTemporales
	{
        //Listas para TIC
        public List<Setup>? ListaTICTelecomunicaciones { get; set; }
        public List<Setup>? ListaTICBasesDeDatos { get; set; }
        public List<Setup>? ListaTICServidoresFisicos { get; set; }
        public List<Setup>? ListaTICServidoresVirtuales { get; set; }
        public List<Setup>? ListaTICPlataformasCentralizadas { get; set; }

        public ListasSetupTemporales()
		{
            //ListaTICTelecomunicaciones = new List<Setup>();
            //ListaTICBasesDeDatos = new List<Setup>();
            //ListaTICServidoresFisicos = new List<Setup>();
            //ListaTICServidoresVirtuales = new List<Setup>();
            //ListaTICPlataformasCentralizadas = new List<Setup>();
		}
	}
}

