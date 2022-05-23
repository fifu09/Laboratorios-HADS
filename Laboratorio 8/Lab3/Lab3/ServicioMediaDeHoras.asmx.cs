using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab3
{
    /// <summary>
    /// Descripción breve de ServicioMediaDeHoras
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioMediaDeHoras : System.Web.Services.WebService
    {

        [WebMethod]
        public int getHorasMedias(string codigo)
        {
            Funciones.Class1.conectar();
            int media = Funciones.Class1.mediaDeHoras(codigo);
            Funciones.Class1.desconectar();
            return media;
        }
    }
}
