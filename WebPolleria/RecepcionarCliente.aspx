<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecepcionarCliente.aspx.cs" Inherits="WebPolleria.RecepcionarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recepcionar cliente</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>RESERVAS</h3>
            <asp:Label ID="Label1" runat="server" Text="Nombres:" Width="130px"></asp:Label>
            <asp:TextBox ID="TxtNombre" runat="server" Width="367px"></asp:TextBox>
            <asp:Button ID="BtnBuscarRes" runat="server" Text="Buscar" Style="margin-left: 30px" Width="92px" OnClick="Button1_Click" />
        </div>
        <div style="margin-top: 40px">
            <asp:Label ID="Label2" runat="server" Text="Hora Reserva:" Width="130px"></asp:Label>
            <asp:TextBox ID="TxtHoraRes" runat="server" Width="152px" Style="margin-right: 48px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Telefono:" Width="130px"></asp:Label>
            <asp:TextBox ID="TextTel" runat="server" Width="152px"></asp:TextBox>
        <br />
            <asp:Label ID="Label4" runat="server" Text="Correo Reservante:" Width="130px"></asp:Label>
            <asp:TextBox ID="TxtCorreoRes" runat="server" Width="490px"></asp:TextBox>
        <br />
            <asp:Label ID="Label5" runat="server" Text="Nro. Reserva:" Width="130px"></asp:Label>
            <asp:TextBox ID="TxtNroRes" runat="server" Width="152px" Style="margin-right: 48px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Mesa Asignada:" Width="130px"></asp:Label>
            <asp:TextBox ID="TxtMesa" runat="server" Width="152px"></asp:TextBox>
        </div>

        <div style="margin-top: 50px">
            <h3>MESAS DISPONIBLES</h3>
            <asp:Label ID="Label7" runat="server" Text="Mesa:" Width="130px"></asp:Label>
            <asp:DropDownList ID="DropDownListMesas" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        <br />
            <asp:Label ID="Label8" runat="server" Text="Horario:" Width="130px"></asp:Label>
            <asp:DropDownList ID="DropDownListHorarios" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
        <br />
            <asp:Button ID="Button1" runat="server" Text="Buscar Mesa Disponible" Style="margin-top: 30px" Width="200px" OnClick="Button1_Click" />
        </div>
        <div style="margin-top: 50px">
            <asp:Button ID="BtnSalir" runat="server" Text="Salir" Width="86px" />
            <asp:Button ID="BtnAsignar" runat="server" Text="Asignar Mesa" />
        </div>
    </form>
</body>
</html>
