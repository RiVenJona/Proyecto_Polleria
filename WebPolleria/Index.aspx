<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebPolleria.WebForm1" %>

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
            <h3>LOGIN</h3>
            <h5>Usuario</h5>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br /><br />
            <h5>Contraseña</h5>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="passInput"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCambio" runat="server" Text="cambio" OnClick="btnCambio_Click" />
            <br /><br /><br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="No hay datos" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <Columns>
                        <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
