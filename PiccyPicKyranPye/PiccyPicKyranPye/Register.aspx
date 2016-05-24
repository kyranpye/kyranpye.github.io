<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PiccyPic.Web.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadArea" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainArea" runat="server">
    <asp:Panel ID="pnlError" runat="server" Visible="false" EnableViewState="false">
        <div class="error">
            <h1>Error!</h1>
            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
        </div>
    </asp:Panel>
    <div id="contentArea">
    </div>
    <div id="Register">
        <p> Registering with kyranpye.com </p>
        <p>Thankyou for registering. (Clients may only register)</p>
        <p>
            <label>Forename</label>
            <asp:TextBox runat="server" ID="txtForename" required="required" />
        </p>
        <p>
            <label>Surname</label>
            <asp:TextBox runat="server" ID="txtSurname" required="required" />
        </p>
        <p>
            <label>Email</label>
            <asp:TextBox runat="server" ID="txtEmail" required="required" TextMode="Email" />
        </p>
        <p>
            <label>Password</label>
            <asp:TextBox runat="server" ID="txtPassword" required="required" TextMode="Password" />
        </p>
        <p>
            <label></label>
            <asp:Button runat="server" ID="butRegister" Text="Register" />
        </p>
    </div>
</asp:Content>
