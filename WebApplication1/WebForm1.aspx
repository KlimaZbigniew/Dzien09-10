<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h3>Lista wizyt</h3>
<asp:GridView ID="gridView" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="id" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
<Columns>
<asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
<asp:BoundField DataField="fname" HeaderText="Imię" SortExpression="fname" />
<asp:BoundField DataField="lname" HeaderText="Nazwisko" SortExpression="lname" />
<asp:BoundField DataField="pesel" HeaderText="PESEL" SortExpression="pesel" />
<asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
<asp:BoundField DataField="doctor" HeaderText="Lekarz" SortExpression="doctor" />
<asp:BoundField DataField="card" HeaderText="Nr karty" SortExpression="card" />
<asp:BoundField DataField="visit_date" HeaderText="Data" SortExpression="visit_date" />
<asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
<asp:BoundField DataField="descr" HeaderText="Opis" SortExpression="descr" />
<asp:BoundField DataField="image" HeaderText="Obraz" SortExpression="image" />
</Columns>
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#E9E7E2" />
    <SortedAscendingHeaderStyle BackColor="#506C8C" />
    <SortedDescendingCellStyle BackColor="#FFFDF8" />
    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:edoctorConnectionString %>" ProviderName="<%$ ConnectionStrings:edoctorConnectionString.ProviderName %>" SelectCommand="SELECT * FROM visits"></asp:SqlDataSource>
<div>
    <a href="/Logout">Logout</a>
</div>
</asp:Content>

