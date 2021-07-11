<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Relatorios.aspx.cs" Inherits="LoginFlitzWeb.Relatorios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="index.css">
    <title>FlitzWeb</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Titulo">
           <a href="Index.aspx">
               <asp:Image ID="img_logo" runat="server" ImageUrl="~/images/flitz_logo_final.png" /></a>
    </div>
        <br /> <br /><br /> <br />

        <nav class="navbar navbar-expand-lg navbar-dark" style="background-color:#1C196A; font-family: Roboto, sans-serif">
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo03" aria-controls="navbarTogglerDemo03" aria-expanded="false" aria-label="Alterna navegação">
    <span class="navbar-toggler-icon"></span>
  </button>
            <a class="navbar-brand" href="#">Flitz-Web</a>

  <div class="collapse navbar-collapse" id="navbarTogglerDemo03">
    <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
      <li class="nav-item">
        <a class="nav-link" href=Index.aspx>Home</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href=Consultas.aspx>Consultas</a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href=Relatorios.aspx>Relatórios</a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="#">Rastreamento(BETA)</a>
      <li class="nav-item">
        <a class="nav-link" href="#">Ajuda</a>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0">
      <input class="form-control mr-sm-2" type="search" placeholder="Pesquisar" aria-label="Pesquisar">
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit" style="background-color:ghostwhite; color:#1C196A;">Pesquisar</button>
    </form>
  </div>
</nav>

        <div class="container">
	
        <h3>Relatório de Motoristas</h3>
        <asp:Label ID="Label2" runat="server" Text="Status"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Ativo" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Inativo" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="UF"></asp:Label>
        <asp:DropDownList ID="CB_uf" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        Prioridade do Serviço <asp:CheckBox ID="CheckBox3" runat="server" Text="Alta" />
        <asp:CheckBox ID="CheckBox4" runat="server" Text="Média" />
        <asp:CheckBox ID="CheckBox5" runat="server" Text="Baixa" />
    </div>

        <footer>        <div class="rodape">


        </div>
            </footer>

    </form>
</body>
</html>
