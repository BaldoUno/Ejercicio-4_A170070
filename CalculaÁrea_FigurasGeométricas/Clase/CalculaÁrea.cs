using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculaÁrea_FigurasGeométricas.Clase
{
    public class CalculaÁrea
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public Double CalculaAreaCuadrado(double Valor1)
        {
            return Math.Pow(Valor1, 2);
        }

        public decimal CalculaAreaTriangulo(decimal valor1, decimal valor2)
        {
            return (valor1 * valor2) / 2;
        }
    }
}