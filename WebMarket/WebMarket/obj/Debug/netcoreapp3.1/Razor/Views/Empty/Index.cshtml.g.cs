#pragma checksum "E:\WebMarket\WebMarket\WebMarket\Views\Empty\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "982f1d62c55f04db8724bde35d220f22ec8f6c71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empty_Index), @"mvc.1.0.view", @"/Views/Empty/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"982f1d62c55f04db8724bde35d220f22ec8f6c71", @"/Views/Empty/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Empty_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\WebMarket\WebMarket\WebMarket\Views\Empty\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("background", async() => {
                WriteLiteral("\r\n    <!-- main-slider -->\r\n    <ul id=\"demo1\">\r\n");
#nullable restore
#line 10 "E:\WebMarket\WebMarket\WebMarket\Views\Empty\Index.cshtml"
         foreach (var item in ViewBag.background)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 243, "\"", 267, 2);
                WriteAttributeValue("", 249, "images/", 249, 7, true);
#nullable restore
#line 13 "E:\WebMarket\WebMarket\WebMarket\Views\Empty\Index.cshtml"
WriteAttributeValue("", 256, item.Image, 256, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 268, "\"", 284, 1);
#nullable restore
#line 13 "E:\WebMarket\WebMarket\WebMarket\Views\Empty\Index.cshtml"
WriteAttributeValue("", 274, item.Name, 274, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <!--Slider Description example-->\r\n                <div class=\"slide-desc\">\r\n                    <h3>Buy Rice Products Are Now On Line With Us</h3>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 19 "E:\WebMarket\WebMarket\WebMarket\Views\Empty\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <!-- //main-slider -->\r\n");
            }
            );
            WriteLiteral(" ");
#nullable restore
#line 23 "E:\WebMarket\WebMarket\WebMarket\Views\Empty\Index.cshtml"
Write(await Component.InvokeAsync("TopSelling"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
