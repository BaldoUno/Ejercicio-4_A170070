using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CalculaÁrea_FigurasGeométricas.Clase;

namespace CalculaÁrea_FigurasGeométricas
{
    /// <summary>
    /// Descripción breve de CalculaÁrea_FiguraGeométricaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculaÁrea_FiguraGeométricaWebService : System.Web.Services.WebService
    {

        [WebMethod (Description = "Este metodo devuelve un Saludo en tipo de dato String")]
        public string Saludo()
        {
            return "¡Hola!";
        }
        private Clase.CalculaÁrea cafg = new Clase.CalculaÁrea();
        public static Double area;

        [WebMethod(Description = "Este método devuelve el área de un Cuadrado en tipo de dato Double")]
        public Double CalculaÁreaCuadrado(int Val1)
        {
            area = cafg.CalculaAreaCuadrado(Val1);
            return area;
        }

        [WebMethod(Description = "Este método devuelve el área de un Triagulo en tipo de dato Decimal")]
        public Decimal CalculaÁreaTriangulo(int Val1, int Val2)
        {
            var areat = cafg.CalculaAreaTriangulo(Val1, Val2);
            return areat;
        }

        [WebMethod(Description = "Este método devuelve el área de un Circulo en tipo de dato Double")]
        public Double CalculaÁreaCirculo(int  Val1)
        {
            return Math.PI * Val1 * Val1;
        }
    }
}
