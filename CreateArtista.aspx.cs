using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea1
{
    public partial class CreateArtista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string nombre = Request.Form["Nombre"];
            if (nombre != null)
            {
                int id = int.Parse(Request.Form["Id"]);
                string fechaNacimiento = Request.Form["FechaNacimiento"];
                Global.Artistas.Add(new Artista(id, nombre,fechaNacimiento));
                Response.Write("<script>alert('Se agrego un nuevo registro')</script>");
                Response.Redirect("Artistas.cshtml");
            }
            else
            {
                Response.Write("<script>alert('Escriba en todos los campos')</script>");

            }
        }
    }
}