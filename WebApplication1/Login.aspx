<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h3>Logowanie</h3> 
    <table class="table" align="center" width ="50%">
       <tr>
           <td width ="10%">Login</td>
           <td>
               <asp:TextBox ID="tbLogin" width="250px" runat ="server"></asp:TextBox></td>

       </tr>

        <tr>
           <td>Hasło</td>
           <td>
               <asp:TextBox ID="tbPassword"  TextMode ="Password" Width ="250px" runat ="server"></asp:TextBox></td>

       </tr>
        <tr>
           
           <td colspan="2">    <asp:Label ID="lblResult" ForeColor ="Red" runat="server" Text=""></asp:Label>       </td>

       </tr>
                <tr>
           
           <td colspan="2" align="center">   <asp:Button ID="btnLogin" runat="server" Text="Zaloguj" OnClick="btnLogin_Click" /> </td>

       </tr>

    </table>
</asp:Content>
