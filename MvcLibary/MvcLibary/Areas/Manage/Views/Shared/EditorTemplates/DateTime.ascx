<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<object>" %>
<%:Html.TextBox("", Model)%>
<%:Html.TextBox("", Model, new { @class="easyui-datetimebox" })%>