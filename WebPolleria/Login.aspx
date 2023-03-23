<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebPolleria.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/estilos/Login.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>INICIO DE SESION - EL BUEN SABOR</h3>
            <div>
            <h5>Usuario</h5>
            <asp:TextBox ID="txtUser" runat="server" CssClass="passInput"></asp:TextBox>
            </div>
            <div>
            <h5>Contraseña</h5>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="passInput"></asp:TextBox>
            </div>
            <div>
            <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
