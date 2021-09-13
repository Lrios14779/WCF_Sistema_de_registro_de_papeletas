<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebImpagas.aspx.cs" Inherits="Web_Final_01.TestPapeletas.WebImpagas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
    Listado de papeletas</p>
<p>
    Numero de placa:</p>
<p>
    <asp:TextBox ID="txtPlaca01" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="dtgListarPapeletas" runat="server" AutoGenerateColumns="False" DataKeyNames="Num_Papeleta" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
        <Columns>
            <asp:BoundField DataField="Num_Papeleta" HeaderText="Numero de papeleta" ReadOnly="True" SortExpression="Num_Papeleta" />
            <asp:BoundField DataField="Fec_Papeleta" HeaderText="Fecha de papeleta" SortExpression="Fec_Papeleta" />
            <asp:BoundField DataField="Num_Placa" HeaderText="Numero de placa" SortExpression="Num_Placa" />
            <asp:BoundField DataField="Cod_Infraccion" HeaderText="Codigo de infraccion" SortExpression="Cod_Infraccion" />
            <asp:BoundField DataField="Est_Papeleta" HeaderText="Estado de papeleta" SortExpression="Est_Papeleta" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InfraccionesConnectionString2 %>" SelectCommand="SELECT DISTINCT [Num_Papeleta], [Fec_Papeleta], [Num_Placa], [Cod_Infraccion], [Est_Papeleta] FROM [Tb_Papeleta]"></asp:SqlDataSource>
</p>
<p>
    &nbsp;</p>
</asp:Content>
