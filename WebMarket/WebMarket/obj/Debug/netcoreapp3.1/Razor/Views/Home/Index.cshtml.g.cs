#pragma checksum "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7c7d1fa5a42fc786b6fc6ca071aa6c484c4544b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c7d1fa5a42fc786b6fc6ca071aa6c484c4544b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebMarket.Models.ProductVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("background", async() => {
                WriteLiteral("\r\n    <!-- main-slider -->\r\n    <ul id=\"demo1\">\r\n");
#nullable restore
#line 14 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
         foreach (var item in ViewBag.background)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 290, "\"", 314, 2);
                WriteAttributeValue("", 296, "images/", 296, 7, true);
#nullable restore
#line 17 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 303, item.Image, 303, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 315, "\"", 331, 1);
#nullable restore
#line 17 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 321, item.Name, 321, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <!--Slider Description example-->\r\n                <div class=\"slide-desc\">\r\n                    <h3>Buy Rice Products Are Now On Line With Us</h3>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 23 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <!-- //main-slider -->\r\n");
            }
            );
#nullable restore
#line 27 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("TopSelling"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- //top-brands -->
<!-- Carousel
  ================================================== -->
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
    <!-- Indicators -->
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
            <a href=""beverages.html""> <img class=""first-slide"" src=""images/b1.jpg"" alt=""First slide""></a>

        </div>
        <div class=""item"">
            <a href=""personalcare.html""> <img class=""second-slide "" src=""images/b3.jpg"" alt=""Second slide""></a>

        </div>
        <div class=""item"">
            <a href=""household.html""><img class=""third-slide "" src=""images/b1.jpg"" alt=""Third slide""></a>

        </div>
    </div>

</div><!-- /.carousel -->
<!--banner-bottom--");
            WriteLiteral(">\r\n<div class=\"ban-bottom-w3l\">\r\n    <div class=\"container\">\r\n        <div class=\"col-md-6 ban-bottom3\">\r\n            <div class=\"ban-top\">\r\n                <img src=\"images/p2.jpg\" class=\"img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 1868, "\"", 1874, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            </div>\r\n            <div class=\"ban-img\">\r\n                <div class=\" ban-bottom1\">\r\n                    <div class=\"ban-top\">\r\n                        <img src=\"images/p3.jpg\" class=\"img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 2095, "\"", 2101, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"ban-bottom2\">\r\n                    <div class=\"ban-top\">\r\n                        <img src=\"images/p4.jpg\" class=\"img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 2318, "\"", 2324, 0);
            EndWriteAttribute();
            WriteLiteral(@" />

                    </div>
                </div>
                <div class=""clearfix""></div>
            </div>
        </div>
        <div class=""col-md-6 ban-bottom"">
            <div class=""ban-top"">
                <img src=""images/111.jpg"" class=""img-responsive""");
            BeginWriteAttribute("alt", " alt=\"", 2608, "\"", 2614, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n</div>\r\n<!--banner-bottom-->\r\n<!--brand store-->\r\n<!--brands-->\r\n<div class=\"brands\">\r\n    <div class=\"container\">\r\n        <h3>Brand Store</h3>\r\n");
#nullable restore
#line 95 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
          
            foreach (var item in ViewBag.type2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"brands-agile\">\r\n                    <div class=\"col-md-2 w3layouts-brand\">\r\n                        <div class=\"brands-w3l\">\r\n                            <p><a href=\"#\">");
#nullable restore
#line 101 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
                                      Write(item.type1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 105 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<!--//brands-->\r\n<!--brand store-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebMarket.Models.ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
