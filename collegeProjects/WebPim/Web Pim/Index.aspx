<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web_Pim.Index" %>

<!DOCTYPE html>

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="index.css">
    <title>FLITZ</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Titulo">
            <h1><a href="Index.aspx">FLITZ</a></h1>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-3"><button>Inicio</button></div>
            <div class="col-lg-3"><button>Gerenciadores</button></div>
            <div class="col-lg-3"><button>Relatórios</button></div>
            <div class="col-lg-3"><button>Ajuda</button></div>
        </div>
    </div>
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
    </form>
</body>
</html>
