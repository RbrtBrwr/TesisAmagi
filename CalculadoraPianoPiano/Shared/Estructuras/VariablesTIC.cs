/// Creo que ya no lo estoy usando
using System;
namespace CalculadoraPianoPiano.Shared
{
	public class VariablesTIC
	{
		//Cada uno va a ser un diccionario con el nombre del equipo/bd/etc. y un arreglo con el esfuerzo de setup y despues ongoing
		public Dictionary<string, Tuple<double>> EquiposTelco;
		public Dictionary<string, Tuple<double>> BasesDeDatos;
		public Dictionary<string, Tuple<double>> Servidores;
		public Dictionary<string, Tuple<double>> PlataformasCentralizadas;
		public Dictionary<string, Tuple<double>> Nubes;

        public VariablesTIC(Dictionary<string, Tuple<double>> equiposTelco, Dictionary<string, Tuple<double>> basesDeDatos,
            Dictionary<string, Tuple<double>> servidores, Dictionary<string,
			Tuple<double>> plataformasCentralizadas, Dictionary<string, Tuple<double>> nubes)
		{
			EquiposTelco = equiposTelco;
			BasesDeDatos = basesDeDatos;
			Servidores = servidores;
			PlataformasCentralizadas = plataformasCentralizadas;
			Nubes = nubes;
		}

		public List<string> getOptions(string option)
		{
			switch (option)
			{
				case "Telco":
                    List<string> telcoKeys = new List<string>(EquiposTelco.Keys);
					return telcoKeys;
				case "Bases de Datos":
                    List<string> bdKeys = new List<string>(EquiposTelco.Keys);
                    return bdKeys;
				case "Servidores":
                    List<string> serverKeys = new List<string>(EquiposTelco.Keys);
                    return serverKeys;
				case "Plataformas Centralizadas":
                    List<string> centralizadasKeys = new List<string>(EquiposTelco.Keys);
                    return centralizadasKeys;
				case "Nubes":
                    List<string> nubesKeys = new List<string>(EquiposTelco.Keys);
                    return nubesKeys;
				default:
					Console.WriteLine("Error Opciones Variables Tic");
					return null;
            }
		}
	}
}

