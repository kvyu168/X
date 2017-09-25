﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 1 "..\..\Views\Shared\_List_Data_Action.cshtml"
    using System.Text;
    
    #line default
    #line hidden
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Action.cshtml")]
    public partial class _Views_Shared__List_Data_Action_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Action_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_List_Data_Action.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var fi = fact.Fields.FirstOrDefault(e => e.Name.EqualIgnoreCase("Deleted", "IsDelete", "IsDeleted"));
    var entity = Model as IEntity;

    var rv = entity.GetRouteKey();

    var user = ViewBag.User as IUser ?? User.Identity as IUser;

    var ajax = true;
    if (ViewBag.AjaxDelete is Boolean)
    {
        ajax = (Boolean)ViewBag.AjaxDelete;
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Views\Shared\_List_Data_Action.cshtml"
 if (user.Has(PermissionFlags.Update))
{

            
            #line default
            #line hidden
WriteLiteral("    <i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral(" style=\"color: blue;\"");

WriteLiteral("></i>\r\n");

WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 566), Tuple.Create("\"", 596)
            
            #line 20 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 573), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", rv)
            
            #line default
            #line hidden
, 573), false)
);

WriteLiteral(" class=\"editcell\"");

WriteLiteral(">编辑</a>\r\n");

            
            #line 21 "..\..\Views\Shared\_List_Data_Action.cshtml"
}
else if (user.Has(PermissionFlags.Detail))
{

            
            #line default
            #line hidden
WriteLiteral("    <i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral(" style=\"color: blue;\"");

WriteLiteral("></i>\r\n");

WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 746), Tuple.Create("\"", 778)
            
            #line 25 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 753), Tuple.Create<System.Object, System.Int32>(Url.Action("Detail", rv)
            
            #line default
            #line hidden
, 753), false)
);

WriteLiteral(" class=\"editcell\"");

WriteLiteral(">查看</a>\r\n");

            
            #line 26 "..\..\Views\Shared\_List_Data_Action.cshtml"
}

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Shared\_List_Data_Action.cshtml"
 if (user.Has(PermissionFlags.Delete))
{
    if (fi != null && fi.Type == typeof(Boolean) && (Boolean)entity[fi.Name])
    {

            
            #line default
            #line hidden
WriteLiteral("        <i");

WriteLiteral(" class=\"glyphicon glyphicon-transfer\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></i>\r\n");

            
            #line 32 "..\..\Views\Shared\_List_Data_Action.cshtml"
        if (ajax)
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1057), Tuple.Create("\"", 1093)
            
            #line 34 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 1064), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteAjax", rv)
            
            #line default
            #line hidden
, 1064), false)
);

WriteLiteral(" data-action=\"delete\"");

WriteLiteral(" data-ajax=\"1\"");

WriteLiteral(" onclick=\"return confirm(\'确认恢复？\');\"");

WriteLiteral(">恢复</a>\r\n");

            
            #line 35 "..\..\Views\Shared\_List_Data_Action.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1223), Tuple.Create("\"", 1255)
            
            #line 38 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 1230), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", rv)
            
            #line default
            #line hidden
, 1230), false)
);

WriteLiteral(" onclick=\"return confirm(\'确认恢复？\');\"");

WriteLiteral(">恢复</a>\r\n");

            
            #line 39 "..\..\Views\Shared\_List_Data_Action.cshtml"
        }
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></i>\r\n");

            
            #line 44 "..\..\Views\Shared\_List_Data_Action.cshtml"
        if (ajax)
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1451), Tuple.Create("\"", 1487)
            
            #line 46 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 1458), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteAjax", rv)
            
            #line default
            #line hidden
, 1458), false)
);

WriteLiteral(" data-action=\"delete\"");

WriteLiteral(" data-ajax=\"1\"");

WriteLiteral(" onclick=\"return confirm(\'确认删除？\');\"");

WriteLiteral(">删除</a>\r\n");

            
            #line 47 "..\..\Views\Shared\_List_Data_Action.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1617), Tuple.Create("\"", 1649)
            
            #line 50 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", rv)
            
            #line default
            #line hidden
, 1624), false)
);

WriteLiteral(" onclick=\"return confirm(\'确认删除？\');\"");

WriteLiteral(">删除</a>\r\n");

            
            #line 51 "..\..\Views\Shared\_List_Data_Action.cshtml"
        }
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
