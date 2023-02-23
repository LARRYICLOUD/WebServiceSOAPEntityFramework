using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceSOAPEntityFramework.Modelo;

namespace WebServiceSOAPEntityFramework.Servicios
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        empleadossEntities emp= new empleadossEntities(); 

        [WebMethod]
        public List<usuarios> GetAllUser(empleadossEntities empleadossEntities)
        {
            return empleadossEntities.usuarios.ToList();
        }
        [WebMethod]
        public string HelloWorld()
        {
            return "SOY UN PROGRAMADOR EXCELENTE";

        }


    }
}
