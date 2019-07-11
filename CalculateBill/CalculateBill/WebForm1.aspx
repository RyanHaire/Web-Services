<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculateBill.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Online Store<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbProduct" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQuantity" runat="server" OnTextChanged="tbQuantity_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cost"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbCost" runat="server"></asp:TextBox>
            <br />
            <br />
            Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="drdCategory" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Amount"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbAmount" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
            Discount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbDiscount" runat="server"></asp:TextBox>
            <br />
            <br />
            Net Amount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbNetAmount" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate Bill" />
            <br />
        </div>
    </form>
</body>
</html>
