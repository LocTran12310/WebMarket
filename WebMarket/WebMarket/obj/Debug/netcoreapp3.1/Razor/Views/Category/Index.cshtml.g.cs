#pragma checksum "E:\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ae22b4dd9bb91390c88ec9347e5af1bba21f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "E:\WebMarket\WebMarket\WebMarket\Views\_ViewImports.cshtml"
using WebMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\WebMarket\WebMarket\WebMarket\Views\_ViewImports.cshtml"
using WebMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ae22b4dd9bb91390c88ec9347e5af1bba21f97", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("background", async() => {
                WriteLiteral(@"
    <!-- breadcrumbs -->
    <div class=""breadcrumbs"">
        <div class=""container"">
            <ol class=""breadcrumb breadcrumb1 animated wow slideInLeft"" data-wow-delay="".5s"">
                <li><a href=""index.html""><span class=""glyphicon glyphicon-home"" aria-hidden=""true""></span>Home</a></li>
                <li class=""active"">");
#nullable restore
#line 13 "E:\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                              Write(ViewBag.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            </ol>\r\n        </div>\r\n    </div>\r\n    <!-- //breadcrumbs -->\r\n");
            }
            );
            WriteLiteral("<div class=\"products\">\r\n    <div class=\"container\">\r\n        <div class=\"col-md-4 products-left\">\r\n            ");
#nullable restore
#line 22 "E:\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
       Write(await Component.InvokeAsync("Type", new { name = ViewBag.name }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-8 products-right\">\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
