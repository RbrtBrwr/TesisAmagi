using System;
namespace CalculadoraPianoPiano.Shared
{
    public class Cliente
    {
        public InfoCliente InfoCliente { get; set; }
        public GIASabor GIATIC { get; set; }
        public GIASabor GIAPMO { get; set; }
        public GIASabor GIAIoT { get; set; }
        public GIASabor GIACiberSeguridad { get; set; }


        public Cliente()
        {
            InfoCliente = new InfoCliente();
        }
    }
}

