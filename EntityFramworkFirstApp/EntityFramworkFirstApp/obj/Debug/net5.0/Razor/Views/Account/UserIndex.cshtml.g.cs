#pragma checksum "C:\Courses\Leads-Training B-2\10-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\UserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86673c71f0293981d844c05ede5ed683f4f07ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserIndex), @"mvc.1.0.view", @"/Views/Account/UserIndex.cshtml")]
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
#line 1 "C:\Courses\Leads-Training B-2\10-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\_ViewImports.cshtml"
using EntityFramworkFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Courses\Leads-Training B-2\10-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\_ViewImports.cshtml"
using EntityFramworkFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86673c71f0293981d844c05ede5ed683f4f07ab", @"/Views/Account/UserIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0fe3a548e22d9cb533470a8cde79fe3e713255", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Courses\Leads-Training B-2\10-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\UserIndex.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>User Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                User Name\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Courses\Leads-Training B-2\10-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\UserIndex.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "C:\Courses\Leads-Training B-2\10-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\UserIndex.cshtml"
               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Courses\Leads-Training B-2\10-10-21\EntityFramworkFirstApp\EntityFramworkFirstApp\Views\Account\UserIndex.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591