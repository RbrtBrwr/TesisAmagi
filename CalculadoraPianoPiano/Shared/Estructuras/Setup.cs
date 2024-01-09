using System;
namespace CalculadoraPianoPiano.Shared
{
    public class Setup
    {
        public int Cantidad { get; set; }
        public Tuple<string, double> TipoEquipo { get; set; }
        public Tuple<string, double>? Actualizacion { get; set; }
        public Tuple<string, double>? Distribucion { get; set; }
        public Tuple<string, double>? Atencion { get; set; }
        public Tuple<string, double>? Contrato { get; set; }
        public Tuple<string, double>? Estabilizacion { get; set; }

        // TODO: variables de servicio

        //public Tuple<string, double> variableEquipo { get; set; }
        //public Tuple<string, double> variableActualizacion { get; set; }
        //public Tuple<string, double> variableDistribucion { get; set; }
        //public Tuple<string, double> variableAtencion { get; set; }
        //public Tuple<string, double> variableAtencionDistribucion { get; set; }
        //public Tuple<string, double> variableContrato { get; set; }
        //public Tuple<string, double> variableEstabilizacion { get; set; }


        public Setup()
        {
        }

        //public void AgregarVariablesDeServicio(Dictionary<string, double> variablesDeServicio)
        //{
        //    variableEquipo = new Tuple<string, double>(variablesDeServicio.ElementAt(0).Key, variablesDeServicio.ElementAt(0).Value);
        //    variableActualizacion = new Tuple<string, double>(variablesDeServicio.ElementAt(1).Key, variablesDeServicio.ElementAt(1).Value);
        //    variableDistribucion = new Tuple<string, double>(variablesDeServicio.ElementAt(2).Key, variablesDeServicio.ElementAt(2).Value);
        //    variableAtencion = new Tuple<string, double>(variablesDeServicio.ElementAt(3).Key, variablesDeServicio.ElementAt(3).Value);
        //    variableAtencionDistribucion = new Tuple<string, double>(variablesDeServicio.ElementAt(4).Key, variablesDeServicio.ElementAt(4).Value);
        //    variableContrato = new Tuple<string, double>(variablesDeServicio.ElementAt(5).Key, variablesDeServicio.ElementAt(5).Value);
        //    variableEstabilizacion = new Tuple<string, double>(variablesDeServicio.ElementAt(6).Key, variablesDeServicio.ElementAt(6).Value);
        //}
	}
}

