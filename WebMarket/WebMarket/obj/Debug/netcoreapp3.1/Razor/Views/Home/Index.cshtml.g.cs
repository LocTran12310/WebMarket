#pragma checksum "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4293c46b026d31c8af4f43b6027fc5133896f3bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\_ViewImports.cshtml"
using WebMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\_ViewImports.cshtml"
using WebMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4293c46b026d31c8af4f43b6027fc5133896f3bb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("background", async() => {
                WriteLiteral("\r\n    <!-- main-slider -->\r\n    <ul id=\"demo1\">\r\n");
#nullable restore
#line 10 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
         foreach (var item in ViewBag.background)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 243, "\"", 267, 2);
                WriteAttributeValue("", 249, "images/", 249, 7, true);
#nullable restore
#line 13 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 256, item.Image, 256, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 268, "\"", 284, 1);
#nullable restore
#line 13 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 274, item.Name, 274, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <!--Slider Description example-->\r\n                <div class=\"slide-desc\">\r\n                    <h3>Buy Rice Products Are Now On Line With Us</h3>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 19 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <!-- //main-slider -->\r\n");
            }
            );
#nullable restore
#line 23 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("TopSelling"));

#line default
#line hidden
#nullable disable
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
