#pragma checksum "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Type\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a6fa14baac646a6ee9486c727b61a1f0d2cdc80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Type_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Type/Default.cshtml")]
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
#line 1 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\_ViewImports.cshtml"
using WebMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\_ViewImports.cshtml"
using WebMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6fa14baac646a6ee9486c727b61a1f0d2cdc80", @"/Views/Shared/Components/Type/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Type_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebMarket.Entities.Type>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Type\Default.cshtml"
  

    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"categories\">\r\n    <h2>");
#nullable restore
#line 9 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Type\Default.cshtml"
   Write(ViewBag.namecate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <ul class=\"cate\">\r\n");
#nullable restore
#line 11 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Type\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 239, "\"", 333, 1);
#nullable restore
#line 13 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Type\Default.cshtml"
WriteAttributeValue("", 246, Url.Action("ProductByType","Category",new { name = ViewBag.namecate,type = item.Name}), 246, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"type\"><i class=\"fa fa-arrow-right\" aria-hidden=\"true\"></i>");
#nullable restore
#line 13 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Type\Default.cshtml"
                                                                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 14 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Type\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebMarket.Entities.Type>> Html { get; private set; }
    }
}
#pragma warning restore 1591
