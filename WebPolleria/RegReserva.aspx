<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegReserva.aspx.cs" Inherits="WebPolleria.RegReserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="DNI"></asp:Label>
        <asp:TextBox ID="TxtBDni" runat="server" style="margin-left: 15px" Width="102px"></asp:TextBox>
        <asp:Button ID="BtnDni" runat="server" Text="Buscar Cliente" OnClick="BtnDni_Click" />
        <asp:Label ID="Label1" runat="server" Text="Fecha de reserva"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Date" Height="16px"></asp:TextBox>
        <asp:Button ID="BtnDispo" runat="server" Text="Buscar Disponibilidad" />
        <br />
        <br />
         <br />
        <asp:GridView ID="GvHorario" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="437px">
            <Columns>
            <asp:BoundField  DataField="DescHorario" HeaderText="Horario" />
            <asp:TemplateField HeaderText="Mesa N°1">
            <ItemTemplate>
            <asp:CheckBox runat="server" ID="cbItem1" />
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mesa N°2">
            <ItemTemplate>
            <asp:CheckBox runat="server" ID="cbItem2"/>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mesa N°3">
            <ItemTemplate>
            <asp:CheckBox runat="server" ID="cbItem3" />
            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle ForeColor="#8C4510" BackColor="#FFF7E7" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Apellidos:"></asp:Label>
        <asp:TextBox ID="TxtApellidos" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Dni:"></asp:Label>
        <asp:TextBox ID="TxtDni" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Correo:"></asp:Label>
        <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnSalir" runat="server" Text="Salir" />
        <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" style="margin-left: 177px" Width="122px" />
        <br />
        <br />
</asp:Content>
