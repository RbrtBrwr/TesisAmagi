/// Contiene una lista con las variables (nombre y esfuerzo). Se usa para conseguir el esfuerzo de cada variable
/// y ademas puedo usarla para obtener una lista de las variables para los menus desplegables.

using System;
namespace CalculadoraPianoPiano.Shared
{
	public class VariablesDeServicio
	{
		List<Variable> Variables { get; set; }
		//TODO: Este es un constructor de prueba. tengo que trabajar con el deserializer y ver como hago esto en verdad
		public VariablesDeServicio(List<string> nombres)
		{
			Variables = new List<Variable>();
			foreach (string nombre in nombres)
			{
				Variable nuevaVariable = new Variable(nombre, 1.1);
				Variables.Add(nuevaVariable);
			}
		}
		public double getEsfuerzoVariable(string variable)
		{
			if (Variables != null)
			{
				foreach (Variable i in Variables)
				{
					if (i.Nombre == variable)
					{
						return i.Esfuerzo;
					}
				}
				return 1.0;
			}
			else
			{
				return 1.0;
			}
		}

		public List<string> getVariables()
		{
			List<string> listaVariables = new List<string>();
			if (Variables != null)
			{
				foreach (var p in Variables)
				{
					listaVariables.Add(p.Nombre);
				}
			}

			return listaVariables;
		}
	}
}

