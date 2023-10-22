<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateArtista.aspx.cs" Inherits="Tarea1.CreateArtista" %>

<link href="Content/bootstrap.min.css" rel="stylesheet" />

    <nav class="navbar-light bg-dark">
        <div class="container-xl">
            <a class="navbar-brand text-white fs-2 " id="1" href="~/Home.cshtml">Inicio</a>
            <a class="navbar-brand text-white ms-3 " id="2" href="~/Canciones.cshtml">Canciones</a>
            <a class="navbar-brand text-white ms-3" id="3" href="~/Albumes.cshtml">Albumes</a>
            <a class="navbar-brand text-white ms-3" id="4" href="~/Artistas.cshtml">Artistas</a>
        </div>
    </nav>


    <form class="form container-sm" id="form1" runat="server">
        <div>
            <p>Id: <input type="number" name="Id" id="Id" /></p>
            <p>Nombre: <input type="text" name="Nombre" id="Nombre" /></p>
            <p>Fecha de Nacimiento: <input type="text" name="FechaNacimiento" id="FechaNacimiento" /></p>
    <input class="btn btn-success" type="submit"  value="Agregar" />

        </div>
    </form>