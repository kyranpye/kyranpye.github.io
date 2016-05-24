<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="PiccyPic.Web.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadArea" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainArea" runat="server">
    <asp:Panel ID="pnlError" runat="server" Visible="false" EnableViewState="false">
        <div class="error">
            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
        </div>
    </asp:Panel>
    <div id="SignIn">
        <p> Sign In </p>
        <p>Welcome back</p>
        <p>
            <label>Email</label>
            <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" />
        </p>
        <p>
            <label>Password</label>
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
        </p>
        <p>
            <label></label>
            <asp:Button runat="server" ID="butLogIn" Text="Sign In" />
        </p>
    </div>
</asp:Content>

