<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterVisit1.aspx.cs" Inherits="WebApplication1.RegisterVisit1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.16/jquery.mask.js"></script>

    <script type="text/javascript">
        $(function () {

            $("#<%= tbPESEL.ClientID %>").mask("99999999999");
        });

        function isValidPesel(sender, args) {
            args.isValid = args.Value.length == 11;
        }
    </script>
    <h3>Nowa wizyta</h3>
    <table class="table" align="center">
        <tr>
            <td>Imię:</td>
            <td>
                <asp:TextBox ID="tbFName" Width="250px" runat="server"></asp:TextBox>
                </BR>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ErrorMessage="Podaj imię!!!!! " ControlToValidate="tbFName" Display="Dynamic"
                    ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td>Nazwisko:</td>
            <td>
                <asp:TextBox ID="tbLName" Width="250px" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ErrorMessage="Podaj nazwisko " ControlToValidate="tbFName" Display="Dynamic"
                    ForeColor="Red">  *</asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td>PESEL:</td>

            <td>
                <asp:TextBox ID="tbPESEL" Width="250px" runat="server"></asp:TextBox>

                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Podaj PESEL" ControlToValidate="tbPESEL"
                    OnServerValidate ="Validate_PESEL" Display="Dynamic"
                    ForeColor="Red" ClientValidationFunction="isValidPesel">*</asp:CustomValidator>

               <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ErrorMessage="Podaj PESEL" ControlToValidate="tbPESEL"
                    ForeColor="Red">  </asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td>
                <asp:TextBox ID="tbEmail" Width="250px" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                    ErrorMessage="Podaj poprawny mail" ForeColor="Red"
                    ControlToValidate="tbEmail" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ErrorMessage="Podaj email" ControlToValidate="tbEmail"
                    ForeColor="Red">  </asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td>Lekarz:</td>
            <td>
                <asp:DropDownList ID="ddDoctor" runat="server">
                    <asp:ListItem Value="-1">Wybierz lekarza</asp:ListItem>
                    <asp:ListItem Value="1">Jan Kowalski - pediatra</asp:ListItem>
                    <asp:ListItem Value="2">Janina Zięek - dermatolog</asp:ListItem>
                    <asp:ListItem Value="3">Mirosław Baka - Kardiolog</asp:ListItem>
                </asp:DropDownList><asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Wybierz lekarza"
                    ControlToValidate="ddDoctor" Display="Dynamic"
                    ForeColor="Red" Type="Integer" MinimumValue="1" MaximumValue="3">*


                </asp:RangeValidator>
            </td>

        </tr>

        <tr>
            <td>Data wizyty:</td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>

        </tr>

        <tr>
            <td>Klient VIP:</td>
            <td>
                <asp:CheckBox ID="cbVIP" runat="server" AutoPostBack="True" OnCheckedChanged="cbVIP_CheckedChanged" />
                </BR>
                <asp:TextBox ID="tbVIPNumber" Width="250px" Visible="false" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>

        </tr>


        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnOK" runat="server" Text="Dalej" Width="10%" OnClick="btnOK_Click" /></td>


        </tr>
    </table>
</asp:Content>
