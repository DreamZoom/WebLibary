<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page - My ASP.NET MVC Application
</asp:Content>

<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
    
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <% List<ListItem> list = new List<ListItem>();

       for (var i = 0; i < 20; i++)
       {
           list.Add(new ListItem() { Text = "哈哈哈" + i, Value = "呵呵呵" + i });
       }
    %>
    <%:Html.EasyUIGrid(list) %>


    <ul class="easyui-datalist" title="DataList" style="width: 400px; height: 250px" chexkbox="true">
        <li value="AL">Alabama</li>
        <li value="AK">Alaska</li>
        <li value="AZ">Arizona</li>
        <li value="AR">Arkansas</li>
        <li value="CA">California</li>
        <li value="CO">Colorado</li>
    </ul>
</asp:Content>
