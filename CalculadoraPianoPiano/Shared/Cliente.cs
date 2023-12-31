using System;
namespace CalculadoraPianoPiano.Shared
{
    public class Cliente
    {
        public InfoCliente InfoCliente { get; set; }
        //public GIATIC? GIATIC { get; set; }
        //public GIAPMO? GIAPMO { get; set; }
        //public GIAIoT? GIAIoT { get; set; }
        //public GIACiberSeguridad? GIACiberSeguridad { get; set; }

        public Cliente()
        {
            InfoCliente = new InfoCliente();
        }
    }
}

