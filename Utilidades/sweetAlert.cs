using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Cliente_WS_gen12.Utilidades
{
    public class sweetAlert
    {
        public static void Sweet_Alert(string title, string msg, string type, Page pg, Object obj)
        {
            string sa = "<script languaje='javascript'>" +
                "Swal.fire({" +
                    "title: '" + title + "'," +
                    "text: '" + msg + "'," +
                    "icon: '" + type + "'" +
                "});" +
                "</script>";

            //Type hace referencia al tipo de objeto que voy a trabjaar
            Type cstype = obj.GetType();
            //ClientScriptManager me ayuda a incrustar bloques de código de JS en tiempo real dentro de Formulario Web Form de ASP
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, sa, sa);
        }

        public static void Sweet_Alert(string title, string msg, string type, Page pg, Object obj, string dir)
        {
            string sa = "<script languaje='javascript'>" +
                           "Swal.fire({" +
                           "title: '" + title + "'," +
                           "text: '" + msg + "'," +
                           "icon: '" + type + "'" +
                           "}).then((result)=>{" +
                           "if(result.isConfirmed){" +
                           "window.location.href = '" + dir + "'" +
                           "}" +
                           "});" +
                           "</script>";

            //Type hace referencia al tipo de objeto que voy a trabjaar
            Type cstype = obj.GetType();
            //ClientScriptManager me ayuda a incrustar bloques de código de JS en tiempo real dentro de Formulario Web Form de ASP
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, sa, sa);
        }
    }
}