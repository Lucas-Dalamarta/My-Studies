<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginFlitzWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="estilos.css" />
    <title>FlitzWeb</title>
    </head>
  
<body id="txt_box_user">
    <form id="login" runat="server">
    <div id="main">
        <p class="conteiner"><asp:Image ID="img_logo" runat="server" ImageUrl="~/images/flitzlogofinal.jpg" Width="220px" /></p>
            <p class="conteiner">
                <asp:Label class="lbl_login" ID="lbl_user" runat="server" Text="Usuário" Width="64px" CssClass="auto-style3"></asp:Label>
                <asp:TextBox class="input_field" ID="txtbox_user" runat="server" placeHolder="Insira o usuario" Width="214px" CssClass="input_field"></asp:TextBox>
            </p>
            <p class="conteiner">
                <asp:Label class="lbl_login" ID="lbl_pwd" runat="server" Text="Senha" Width="64px" CssClass="auto-style4"></asp:Label>
                <asp:TextBox class="input_field" ID="txtbox_pwd" runat="server" placeHolder="Insira a senha" Width="214px" CssClass="input_field"></asp:TextBox>
            </p>
            <p class="conteiner"><asp:Button ID="btn_entrar" runat="server" Text="Entrar" OnClick="btn_entrar_Click" Width="287px" /></p>
            <p class="conteiner"><asp:Label ID="lblStatus" runat="server" Text="[Status]" Visible="False"></asp:Label></p>
        </div>
    </form>
</body>
</html>
