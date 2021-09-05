<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterVisit2.aspx.cs" Inherits="WebApplication1.RegisterVisit2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3 align="center">Nowa wizyta - informacje dodatkowe</h3>
    <table class="table" border="10" align="center">

        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="lblInfo" runat="server" Text="AAAA BBBB 0" Font-Bold="true" ForeColor="Blue"></asp:Label>
            </td>
        </tr>


        <tr>
            <td width="10%">Opis:</td>
            <td width="90%">
                <asp:TextBox ID="tbDesc" Width="90%" runat="server" TextMode="MultiLine" Rows="10"></asp:TextBox>

            </td>

        </tr>

        <tr>
            <td>Zdjęcie:</td>
            <td>
                <asp:FileUpload ID="fuImage" runat="server" />

            </td>

        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="lblResult" runat="server" Text="Label" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnOK" runat="server" Text="Zapisz" Width="10%" OnClick="btnOK_Click" /></td>


        </tr>
    </table>
</asp:Content>
