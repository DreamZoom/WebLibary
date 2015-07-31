<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%
    List<SelectListItem> list = new List<SelectListItem>();
    foreach (string name in Enum.GetNames(Html.ViewData.ModelMetadata.ModelType))
    {
        var value = Enum.Parse(Html.ViewData.ModelMetadata.ModelType, name);
        list.Add(new SelectListItem()
        {
            Text = name,
            Value = value.ToString(),
            Selected = (Html.ViewData.ModelMetadata.Model == value)
        });
    }
%>
<%:Html.DropDownList(Html.ViewData.ModelMetadata.PropertyName,list,"请选择...") %>