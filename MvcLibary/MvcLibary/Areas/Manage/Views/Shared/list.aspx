<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/IFrame.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <%:Html.EasyUIGrid(Model) %>
</asp:Content>
