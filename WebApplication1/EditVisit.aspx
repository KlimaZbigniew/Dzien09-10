<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditVisit.aspx.cs" Inherits="WebApplication1.EditVisit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3 align="center">Zmiana statusu wizyty</h3>
    <table class="table" border="10" align="center">

        <tr>
            <td align="center">Zmiana statusu
            </td>
            <td>
                <asp:DropDownList ID="ddStatus" runat="server">
                    <asp:ListItem Value="0">----</asp:ListItem>
                    <asp:ListItem Value="1">Akceptacja</asp:ListItem>
                    <asp:ListItem Value="-1">Anulowano</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <asp:Label ID="lblResult"
                ForeColor="Red"
                runat="server"
                Text="Label">
            </asp:Label>
        </tr>
        <asp:HiddenField ID="tbHidenId" runat="server" />
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>

        </tr>
    </table>

</asp:Content>
