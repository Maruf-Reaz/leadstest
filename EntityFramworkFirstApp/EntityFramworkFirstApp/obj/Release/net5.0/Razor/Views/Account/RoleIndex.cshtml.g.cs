#pragma checksum "C:\Courses\Leads-Training B-2\17-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\RoleIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e960eb45ade99e66f9ef79b8affe130f53f2ce48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RoleIndex), @"mvc.1.0.view", @"/Views/Account/RoleIndex.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Courses\Leads-Training B-2\17-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\_ViewImports.cshtml"
using EntityFramworkFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Courses\Leads-Training B-2\17-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\_ViewImports.cshtml"
using EntityFramworkFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e960eb45ade99e66f9ef79b8affe130f53f2ce48", @"/Views/Account/RoleIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0fe3a548e22d9cb533470a8cde79fe3e713255", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RoleIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Courses\Leads-Training B-2\17-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\RoleIndex.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Role Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Role Name\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Courses\Leads-Training B-2\17-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\RoleIndex.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "C:\Courses\Leads-Training B-2\17-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\RoleIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Courses\Leads-Training B-2\17-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\RoleIndex.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
