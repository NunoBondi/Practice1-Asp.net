using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea1
{
    public partial class CreateCanciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = Request.Form["Nombre"];
            if(nombre != null)
            {
                int id = int.Parse(Request.Form["Id"]);
                int albumId = int.Parse(Request.Form["AlbumId"]);
                string duracion = Request.Form["Duracion"];
                string genero = Request.Form["Genero"];
                Global.Canciones.Add(new Cancion(id, nombre, duracion, genero,albumId));
                Response.Write("<script>alert('Se agrego un nuevo registro')</script>");
                Response.Redirect("Canciones.cshtml");

            }
            else
            {
                Response.Write("<script>alert('Escriba en todos los campos')</script>");

            }
        }
    }
}