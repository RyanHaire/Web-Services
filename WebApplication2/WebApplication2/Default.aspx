<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
       
    &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="21px" OnTextChanged="TextBox1_TextChanged" Width="123px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
       
    </div>

</asp:Content>
