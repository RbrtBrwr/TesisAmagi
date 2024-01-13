/// Estructura principal de la aplicacion, tiene la informacion del cliente y las listas de los servicios que se quieren para
/// cada uno de los GIA

using System;
using CalculadoraPianoPiano.Shared.Estructuras.EstructurasDeListas;
namespace CalculadoraPianoPiano.Shared
{
    public class Cliente
    {
        public InfoCliente? InfoCliente { get; set; }
        public ListasGIA ListasGIA { get; set; }


        public Cliente()
        {
            ListasGIA = new ListasGIA();
        }
    }
}

