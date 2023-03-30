<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GenOrdenInsumo.aspx.cs" Inherits="WebPolleria.GenOrdenInsumo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 30px">
        <asp:Label ID="Label6" runat="server" Width="160px" Text="Nro. O. Insumo:"></asp:Label>
        <asp:TextBox ID="TxtNroIns" runat="server" Width="128px"></asp:TextBox>
        <asp:TextBox style="position:relative; float: right; margin-right: 50px" ID="TxtJefe" runat="server" Width="118px"></asp:TextBox>
        <asp:Label style="position:relative; float: right;" ID="Label7" runat="server" Width="160px" Text="Jefe de Cocina:"></asp:Label>

    </div>
    <h4>BUSCAR INSUMO:</h4>    
        <asp:Label ID="Label3" runat="server" Width="160px" Text="Nombre de insumo: "></asp:Label>
        <asp:TextBox ID="TxtInsumoDesc" runat="server"></asp:TextBox>
        <asp:Button style="margin-left: 50px" ID="btnBuscar" runat="server" Text="Buscar" Width="68px" OnClick="btnBuscar_Click"/>
        <br />
    <h4>DATOS INSUMO:</h4>  
        <asp:GridView HorizontalAlign="Center" ID="GvDatos" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="460px">
            <Columns>

                <asp:BoundField  DataField="NumInsumo" HeaderText="ID" />
                <asp:BoundField  DataField="DesIns" HeaderText="DESCRIPCIÓN" />
                <asp:BoundField  DataField="Categoria" HeaderText="CATEGORÍA" />
                <asp:BoundField  DataField="Unidad" HeaderText="UNIDAD" />
                <asp:BoundField  DataField="Cantidad" HeaderText="CANTIDAD" />
                <asp:CommandField HeaderText="SELECCIÓN" SelectText="Seleccionar" ShowSelectButton="True"/>
                <asp:TemplateField HeaderText="IdPropietario" Visible="false">
                            <ItemTemplate>
<%--                                <asp:Label ID="lblpro" runat="server" Text='<%# Eval("Propietarioid") %>'></asp:Label>--%>
                            </ItemTemplate>
                </asp:TemplateField>
           
            
            </Columns>
            

            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <asp:Button style="float: right; margin-right: 50px" ID="btnAgregar" runat="server" Width="60px" Text="Agregar" />
    <h4>DETALLE ORDEN DE INSUMO:</h4>  
        <asp:GridView HorizontalAlign="Center" ID="GvOrden" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateColumns="False" Width="460px">
            <Columns>
                <asp:BoundField  DataField="NumInsumo" HeaderText="ID" />
                <asp:BoundField  DataField="DesIns" HeaderText="DESCRIPCIÓN" />
                <asp:BoundField  DataField="Categoria" HeaderText="CATEGORÍA" />
                <asp:TemplateField HeaderText="Cantidad">
                  <ItemTemplate>
                    <asp:TextBox runat="server" ID="txtCantGv" Text="1"></asp:TextBox>
                    <asp:Button runat="server" ID="btnIncrementar" Text="+" OnClick="btnIncrementar_Click" />
                    <asp:Button runat="server" ID="btnDisminuir" Text="-" OnClick="btnDisminuir_Click" />
                  </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField  DataField="Unidad" HeaderText="UNIDAD" />
                <asp:TemplateField HeaderText="Cantidad">
                  <ItemTemplate>
                      <asp:CheckBox runat="server" ID="cbEliminar" />
                  </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    <div>
        <asp:Button style="position:absolute; float: left; margin-left: 50px" ID="btnSalir" runat="server" Width="60px" Text="Salir" />
        <asp:Button style="position:relative; float: right; margin-right: 50px" ID="btnGenerar" runat="server" Width="60px" Text="Generar" />
    </div>
</asp:Content>
