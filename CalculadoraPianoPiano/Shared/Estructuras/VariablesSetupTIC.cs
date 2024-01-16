using System;
namespace CalculadoraPianoPiano.Shared
{
	public class VariablesSetupTIC
	{

		public VariablesDeServicio? Telecomunicaciones;
		public VariablesDeServicio? BasesDeDatos;
		public VariablesDeServicio? ServidoresFisicos;
		public VariablesDeServicio? ServidoresVirtuales;
		public VariablesDeServicio? PlataformasCentralizadas;
		public VariablesDeServicio? Actualizacion;
		public VariablesDeServicio? Nubes;
		public VariablesDeServicio? Distribucion;
		public VariablesDeServicio? Atencion;
		public VariablesDeServicio? Estabilizacion;
		public VariablesDeServicio? Contratos;

        public VariablesSetupTIC()
		{
		}

		public void setVariablesTelco(string area, List<string> variables)
		{
			switch (area)
			{
				case "Telecomunicaciones":
					Telecomunicaciones = new VariablesDeServicio(variables);
					break;
				case "Bases de Datos":
					BasesDeDatos = new VariablesDeServicio(variables);
					break;
				case "Servidores Fisicos":
                    ServidoresFisicos = new VariablesDeServicio(variables);
                    break;
				case "Servidores Virtuales":
                    ServidoresVirtuales = new VariablesDeServicio(variables);
                    break;
				case "Plataformas Centralizadas":
                    PlataformasCentralizadas = new VariablesDeServicio(variables);
                    break;
				case "Actualizacion":
					Actualizacion = new VariablesDeServicio(variables);
					break;
				case "Nubes":
					Nubes = new VariablesDeServicio(variables);
					break;
				case "Distribucion":
					Distribucion = new VariablesDeServicio(variables);
					break;
				case "Atencion":
					Atencion = new VariablesDeServicio(variables);
					break;
				case "Estabilizacion":
					Estabilizacion = new VariablesDeServicio(variables);
					break;
				case "Contratos":
					Contratos = new VariablesDeServicio(variables);
					break;
				default:
					Console.Write("Error");
					break;
			}
		
		}

	}
}

