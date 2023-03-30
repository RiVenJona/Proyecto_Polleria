﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebPolleria.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>EL BUEN SABOR</title>
    <link rel="stylesheet" type="text/css" href="/estilos/Login.css" />
</head>
<body>
    <form id="form1" runat="server" >
        <div class="container" style="display:flex; 
border-radius:15px;
flex-direction:column; align-content:center; align-items:center;width:300px;
background: #F7971E;  /* fallback for old browsers */
background: -webkit-linear-gradient(to right, #FFD200, #F7971E);  /* Chrome 10-25, Safari 5.1-6 */
background: linear-gradient(to right, #FFD200, #F7971E); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
">
            <h3 style="text-align:center; color:#fff">|INICIO DE SESION - EL BUEN SABOR</h3>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Logo.jpg" Width="100px" CssClass="imgLogo"/>
            <div>
            <h5>Usuario</h5>
            <asp:TextBox ID="txtUser" runat="server" CssClass="passInput"></asp:TextBox>
            </div>
            <div>
            <h5>Contraseña</h5>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="passInput"></asp:TextBox>
            </div>
            <div style="margin-bottom:20px">
                <br />
            No recuerda su Password?<a href="Recuperar.aspx">Ingrese aquí</a>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" CssClass="btnenviar" />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
