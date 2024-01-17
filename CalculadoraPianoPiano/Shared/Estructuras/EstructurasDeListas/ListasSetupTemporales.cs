using System;
using Microsoft.AspNetCore.Components;

namespace CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas
{
	public class ListasSetupTemporales
	{
        //Listas para TIC
        public List<Setup> ListaTICTelecomunicaciones { get; set; }
        public List<Setup> ListaTICBasesDeDatos { get; set; }
        public List<Setup> ListaTICServidoresFisicos { get; set; }
        public List<Setup> ListaTICServidoresVirtuales { get; set; }
        public List<Setup> ListaTICPlataformasCentralizadas { get; set; }

        public ListasSetupTemporales()
		{
            ListaTICTelecomunicaciones = new List<Setup>();
            ListaTICBasesDeDatos = new List<Setup>();
            ListaTICServidoresFisicos = new List<Setup>();
            ListaTICServidoresVirtuales = new List<Setup>();
            ListaTICPlataformasCentralizadas = new List<Setup>();
        }

        public void resetListasTIC()
        {
            ListaTICTelecomunicaciones = new List<Setup>();
            ListaTICBasesDeDatos = new List<Setup>();
            ListaTICServidoresFisicos = new List<Setup>();
            ListaTICServidoresVirtuales = new List<Setup>();
            ListaTICPlataformasCentralizadas = new List<Setup>();
        }

        public double calcularCostoTotal(string sabor)
        {
            double costoTotal = 0;
            switch (sabor) {
                case "TIC":
                    foreach (Setup setup in ListaTICBasesDeDatos)
                    {
                        costoTotal += setup.Costo;
                    }
                    foreach (Setup setup in ListaTICTelecomunicaciones)
                    {
                        costoTotal += setup.Costo;
                    }
                    foreach (Setup setup in ListaTICServidoresFisicos)
                    {
                        costoTotal += setup.Costo;
                    }
                    foreach (Setup setup in ListaTICServidoresVirtuales)
                    {
                        costoTotal += setup.Costo;
                    }
                    foreach (Setup setup in ListaTICPlataformasCentralizadas)
                    {
                        costoTotal += setup.Costo;
                    }
                    break;

                case "IoT":
                    break;
                case "PMO":
                    break;
                case "Ciber Seguridad":
                    break;
                default:
                    break;
            }
            return costoTotal;

        }
	}
}

