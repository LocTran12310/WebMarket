#pragma checksum "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66219a62dfe6b8d025cae4ecbbf759d24fb611fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navigation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navigation/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66219a62dfe6b8d025cae4ecbbf759d24fb611fb", @"/Views/Shared/Components/Navigation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Navigation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebMarket.Entities.Type>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("act"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- navigation -->
<div class=""navigation-agileits"">
    <div class=""container"">
        <nav class=""navbar navbar-default"">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class=""navbar-header nav_2"">
                <button type=""button"" class=""navbar-toggle collapsed navbar-toggle1"" data-toggle=""collapse"" data-target=""#bs-megadropdown-tabs"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <div class=""collapse navbar-collapse"" id=""bs-megadropdown-tabs"">
                <ul class=""nav navbar-nav"">
                    <li class=""active"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66219a62dfe6b8d025cae4ecbbf759d24fb611fb5005", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <!-- Mega Menu -->\r\n");
#nullable restore
#line 23 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
                     foreach (var cate in ViewBag.categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"dropdown\">\r\n                            <a class=\"dropdown-toggle\" data-toggle=\"dropdown\">");
#nullable restore
#line 26 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
                                                                         Write(cate.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<b class=""caret""></b></a>
                            <ul class=""dropdown-menu multi-column columns-3"">
                                <div class=""row"">
                                    <div class=""multi-gd-img"">
                                        <ul class=""multi-column-dropdown"">
                                            <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66219a62dfe6b8d025cae4ecbbf759d24fb611fb7283", async() => {
                WriteLiteral("All ");
#nullable restore
#line 31 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
                                                                               Write(cate.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1582, "~/Category/", 1582, 11, true);
#nullable restore
#line 31 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
AddHtmlAttributeValue("", 1593, cate.Name, 1593, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 32 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
                                             foreach (var t in Model.Where(a => a.IdCategory == cate.Id))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li><a");
            BeginWriteAttribute("href", "  href=\"", 1839, "\"", 1925, 1);
#nullable restore
#line 34 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 1847, Url.Action("ProductByType","Category",new { name =cate.Name ,type = @t.Name}), 1847, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                                                                         Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 35 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </ul>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 43 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\Navigation\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li><a href=""gourmet.html"">Gourmet</a></li>
                    <li><a href=""offers.html"">Offers</a></li>
                    <li><a href=""contact.html"">Contact</a></li>
                </ul>
            </div>
        </nav>
    </div>
</div>
<!-- //navigation -->
");
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
