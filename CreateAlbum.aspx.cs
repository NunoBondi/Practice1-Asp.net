using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea1
{
    public partial class CreateAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = Request.Form["Nombre"];
            if (nombre != null)
            {
                int id = int.Parse(Request.Form["Id"]);
                int artistaId = int.Parse(Request.Form["artistaId"]);
           
                Global.Albumes.Add(new Album(id, nombre, artistaId));
                Response.Write("<script>alert('Se agrego un nuevo registro')</script>");
                Response.Redirect("Albumes.cshtml");

            }
            else
            {
                Response.Write("<script>alert('Escriba en todos los campos')</script>");

            }
        }
    }
}