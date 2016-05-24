<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="AddPic.aspx.cs" Inherits="PiccyPic.Web.AddPic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadArea" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainArea" runat="server">
        <div id="AddPic">
            <p>Add a pic to your Piccy Pic account. </p>
            <p>
            <label>Pic name</label>
            <asp:TextBox runat="server" ID="PicName" required="required" />
            </p>
            <p>
            <label>Describe your pic</label>
            <asp:TextBox runat="server" ID="PicDesc" required="required" />
            </p>
            <asp:FileUpload ID="PiccyPicUpload" runat="server" />
            <p>
            <asp:Button runat="server" ID="butAddPic" Text="Add Pic" />
            </p>
        </div>
</asp:Content>