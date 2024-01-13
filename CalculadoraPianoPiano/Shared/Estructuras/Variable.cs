/// Esta clase es para las variables de servicio, cada variable tiene un nombre y un esfuerzo que requiere.

using System;
namespace CalculadoraPianoPiano.Shared
{
	public class Variable
	{
		public string Nombre { get; set; }
		public double Esfuerzo { get; set; }
		public Variable(string name, double esfuerzo)
		{
			Nombre = name;
			Esfuerzo = esfuerzo;
		}
	}
}

