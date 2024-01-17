/// La informacion requerida para el setup de un tipo de equipo.
/// TODO: creo que esta esta bastante dirigida a TIC, voy a tener que refactorear.

using System;
namespace CalculadoraPianoPiano.Shared
{
    public class Setup
    {
        public int Cantidad { get; set; }
        public Variable TipoEquipo { get; set; }
        public Variable Actualizacion { get; set; }
        public Variable Distribucion { get; set; }
        public Variable Atencion { get; set; }
        public Variable Contrato { get; set; }
        public Variable Estabilizacion { get; set; }
        public Variable VariableAtencionDistribucion { get; set; }
        public double Costo { get; set; }
        public double CostoSector { get; set; }

        // TODO: variables de servicio

        //public Variable variableEquipo { get; set; }
        //public Variable variableActualizacion { get; set; }
        //public Variable variableDistribucion { get; set; }
        //public Variable variableAtencion { get; set; }
        //public Variable variableAtencionDistribucion { get; set; }
        //public Variable variableContrato { get; set; }
        //public Variable variableEstabilizacion { get; set; }


        public Setup(string sector)
        {
            Variable variableBase = new Variable("", 1.0);
            TipoEquipo = Actualizacion = Distribucion = Atencion = Contrato = Estabilizacion = VariableAtencionDistribucion = variableBase;

            //TODO: tengo que tener los costos base por sector para calcular esto.
            switch (sector)
            {
                default:
                    CostoSector = 10.0;
                    break;
            }
        }

        public void calcularCostoConEsfuerzo()
        {

            calcularVariableAtencionDistribucion();
            double esfuerzoTotal = TipoEquipo.Esfuerzo * Actualizacion.Esfuerzo * Distribucion.Esfuerzo * Atencion.Esfuerzo * Contrato.Esfuerzo * Estabilizacion.Esfuerzo * VariableAtencionDistribucion.Esfuerzo;
            Costo = CostoSector * Cantidad;
            Costo *= esfuerzoTotal;
            Costo = Double.Round(Costo, 2);

        }

        //TODO: el esfuerzo de estos lo tengo que jalar de algun lado
        public void calcularVariableAtencionDistribucion()
        {
            if (Distribucion.Nombre == "Centralizado" || Atencion.Nombre == "Remoto")
            {
                VariableAtencionDistribucion.Nombre = "No Aplica";
                VariableAtencionDistribucion.Esfuerzo = 1.0;
            }
            else if (Distribucion.Nombre == "No Centralizado")
            {
                if (Atencion.Nombre == "On-Site")
                {
                    VariableAtencionDistribucion.Nombre = "Servicio On-Site No Centralizado";
                    VariableAtencionDistribucion.Esfuerzo = 1.2;
                }
                else
                {
                    VariableAtencionDistribucion.Nombre = "Servicio Hibrido No Centralizado";
                    VariableAtencionDistribucion.Esfuerzo = 1.15;
                }

            }
            else
            {
                if (Atencion.Nombre == "On-Site")
                {
                    VariableAtencionDistribucion.Nombre = "Servicio On-Site Parcialmente Centralizado";
                    VariableAtencionDistribucion.Esfuerzo = 1.15;
                }
                else
                {
                    VariableAtencionDistribucion.Nombre = "Servicio Hibrido Parcialmente Centralizado";
                    VariableAtencionDistribucion.Esfuerzo = 1.1;
                }

            }
        }

	}
}

