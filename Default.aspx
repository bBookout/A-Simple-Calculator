<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 141px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <br />
        <table border="1">
        <tr>
        <td class="auto-style1">
        <br />
            <div style="height: 154px; width: 137px; position: relative;">
                <asp:TextBox ID="displayTextBox" runat="server" BackColor="Black" ForeColor="Lime" Style="margin-right: 7px" Width="123px"></asp:TextBox>

                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="1" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="2" OnClick="Button2_Click" /><asp:Button ID="Button3" runat="server" Text="3" OnClick="Button3_Click" /><asp:Button ID="addButton" runat="server" Text="+" Width="21px" OnClick="addButton_Click" /><asp:Button ID="clearButton" runat="server" Text="clear" Width="42px" OnClick="clearButton_Click" />
                <br />
                <asp:Button ID="Button4" runat="server" Text="4" OnClick="Button4_Click" /><asp:Button ID="Button5" runat="server" Text="5" OnClick="Button5_Click" /><asp:Button ID="Button6" runat="server" Text="6" OnClick="Button6_Click" /><asp:Button ID="subtractButton" runat="server" Text="-" Width="21px" OnClick="subtractButton_Click" /><asp:Button ID="deleteButton" runat="server" Text="del" Width="42px" OnClick="deleteButton_Click" />
                <br />
                <asp:Button ID="Button7" runat="server" Text="7" OnClick="Button7_Click" /><asp:Button ID="Button8" runat="server" Text="8" OnClick="Button8_Click" /><asp:Button ID="Button9" runat="server" Text="9" OnClick="Button9_Click" /><asp:Button ID="multiplyButton" runat="server" Text="x" Width="21px" OnClick="multiplyButton_Click" />
                <asp:Button ID="equalsButton" runat="server" Text="=" OnClick="equalsButton_Click" Width="42px" />
                <br />
                <asp:Button ID="Button0" runat="server" Text="0" OnClick="Button0_Click" Width="21px" />
                <asp:Button ID="divideButton" runat="server" Text="/" Width="42px" OnClick="divideButton_Click" />
            </div>
            </td>
            </tr>
            </table>
        <br />

        <div>
            <h1 id="instruction" runat="server">Please enter an addition, subtraction, multiplication, or division problem.</h1>

        </div>
    </form>
</body>
</html>
