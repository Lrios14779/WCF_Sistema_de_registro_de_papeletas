<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFechas.aspx.cs" Inherits="Web_Final_01.TestPapeletas.WebFechas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Mi papeleta por fecha</p>
    <p>
        &nbsp;</p>
    <p>
        Fecha de inicio:&nbsp;
        <asp:TextBox ID="txtFecini" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMostrar" runat="server" OnClick="Button1_Click" Text="Mostrar" />
    </p>
    <p>
        Fecha de fin:&nbsp;&nbsp;
        <asp:TextBox ID="txtFecfin" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="dtgFechas01" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Num_Papeleta" DataSourceID="SqlDataSource1" Height="189px" Width="561px">
            <Columns>
                <asp:BoundField DataField="Num_Papeleta" HeaderText="Papeleta" ReadOnly="True" SortExpression="Num_Papeleta" />
                <asp:BoundField DataField="Fec_Papeleta" HeaderText="Fecha de papeletas" SortExpression="Fec_Papeleta" />
                <asp:BoundField DataField="Cod_Infraccion" HeaderText="Codigo de infraccion" SortExpression="Cod_Infraccion" />
                <asp:BoundField DataField="Num_Placa" HeaderText="Numero de placa" SortExpression="Num_Placa" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InfraccionesConnectionString %>" SelectCommand="SELECT DISTINCT [Num_Papeleta], [Fec_Papeleta], [Cod_Infraccion], [Num_Placa] FROM [Tb_Papeleta]"></asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
