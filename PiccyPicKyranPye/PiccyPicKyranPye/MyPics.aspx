<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MyPics.aspx.cs" Inherits="PiccyPic.Web.MyPics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadArea" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainArea" runat="server">
    <div id="MyPics">
    <p>
        All uploaded and purchased Pics.
    </p>
    <%  if (LoggedInUser.Servers.Count == 0)
        { %>
            <p>You have no Pics</p>
    <%  } 
        else
        { %>
            <ul>
    <%      foreach (var server in LoggedInUser.Servers)
	        { %>
		        <li><a href="EditPics.aspx?id=<%= server.Id %>"><%= server.Name %> (<%= server.IPAddress %>)</a></li>
	<%      } %>
            </ul>
    <%   } %>
    <a href="AddPic.aspx">Upload a Pic</a>
    </div>
</asp:Content>