#pragma checksum "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e0349ff6ff290fd06f5a41d061d79398f023edc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopSelling_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopSelling/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0349ff6ff290fd06f5a41d061d79398f023edc", @"/Views/Shared/Components/TopSelling/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopSelling_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebMarket.Models.ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/offer.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
  
    ViewData["Title"] = "TopSelling";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""top-brands"">
    <div class=""container"">
        <h2>Top selling offers</h2>
        <div class=""grid_3 grid_5"">
            <div class=""bs-example bs-example-tabs"" role=""tabpanel"" data-example-id=""togglable-tabs"">
                <ul id=""myTab"" class=""nav nav-tabs"" role=""tablist"">
                    <li role=""presentation"" class=""active""><a href=""#expeditions"" id=""expeditions-tab"" role=""tab"" data-toggle=""tab"" aria-controls=""expeditions"" aria-expanded=""true"">All Products</a></li>
                    <li role=""presentation""><a href=""#tours"" role=""tab"" id=""tours-tab"" data-toggle=""tab"" aria-controls=""tours"">Daily Offers</a></li>
                </ul>
                <div id=""myTabContent"" class=""tab-content"">
                    <div role=""tabpanel"" class=""tab-pane fade in active"" id=""expeditions"" aria-labelledby=""expeditions-tab"">
                        <div class=""agile-tp"">
                            <h5>All Products</h5>
                            <p class=""w3l-ad"">We've pulled");
            WriteLiteral(" together all our advertised offers into one place, so you won\'t miss out on a great deal.</p>\r\n                        </div>\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 23 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                             foreach (var item in Model.TakeLast(6))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-4 top_brand_left"" style=""margin-top:20px;"">
                                    <div class=""hover14 column"">
                                        <div class=""agile_top_brand_left_grid"">
                                            <div class=""agile_top_brand_left_grid_pos"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e0349ff6ff290fd06f5a41d061d79398f023edc7705", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                            <div class=""agile_top_brand_left_grid1"">
                                                <figure>
                                                    <div class=""snipcart-item block"">
                                                        <div class=""snipcart-thumb"">
                                                            <a href=""products.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e0349ff6ff290fd06f5a41d061d79398f023edc9361", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2311, "~/images/img-products/", 2311, 22, true);
#nullable restore
#line 35 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
AddHtmlAttributeValue("", 2333, item.Image, 2333, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                            <p>");
#nullable restore
#line 36 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                            <div class=""stars"">
                                                                <i class=""fa fa-star blue-star"" aria-hidden=""true""></i>
                                                                <i class=""fa fa-star blue-star"" aria-hidden=""true""></i>
                                                                <i class=""fa fa-star blue-star"" aria-hidden=""true""></i>
                                                                <i class=""fa fa-star blue-star"" aria-hidden=""true""></i>
                                                                <i class=""fa fa-star gray-star"" aria-hidden=""true""></i>
                                                            </div>
                                                            <h4>");
#nullable restore
#line 44 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                           Write(item.NewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>\r\n");
#nullable restore
#line 45 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                                 if(item.Discount>0)
                                                                {
                                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                                           
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            </span></h4>
                                                        </div>
                                                        <div class=""snipcart-details top_brand_home_details"">
                                                            <fieldset>
                                                                <input type=""submit"" name=""submit"" value=""Add to cart"" class=""button"" />
                                                            </fieldset>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 62 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        </div>
                    <div role=""tabpanel"" class=""tab-pane fade"" id=""tours"" aria-labelledby=""tours-tab"">
                        <div class=""agile-tp"">
                            <h5>Daily Offers</h5>
                            <p class=""w3l-ad"">We've pulled together all our advertised offers into one place, so you won't miss out on a great deal.</p>
                        </div>
");
#nullable restore
#line 70 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                         foreach (var item in ViewBag.offeritems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-4 top_brand_left"" style=""margin-top:20px;"">
                                    <div class=""hover14 column"">
                                        <div class=""agile_top_brand_left_grid"">
                                            <div class=""agile_top_brand_left_grid_pos"">
                                                <img src=""images/offer.png"" alt="" "" class=""img-responsive"" />
                                            </div>
                                            <div class=""agile_top_brand_left_grid1"">
                                                <figure>
                                                    <div class=""snipcart-item block"">
                                                        <div class=""snipcart-thumb"">
                                                            <a href=""products.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e0349ff6ff290fd06f5a41d061d79398f023edc16796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5996, "~/images/img-products/", 5996, 22, true);
#nullable restore
#line 82 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
AddHtmlAttributeValue("", 6018, item.Image, 6018, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                            <p>");
#nullable restore
#line 83 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                            <div class=""stars"">
                                                                <i class=""fa fa-star blue-star"" aria-hidden=""true""></i>
                                                                <i class=""fa fa-star blue-star"" aria-hidden=""true""></i>
                                                                <i class=""fa fa-star blue-star"" aria-hidden=""true""></i>
                                                                <i class=""fa fa-star blue-star"" aria-hidden=""true""></i>
                                                                <i class=""fa fa-star gray-star"" aria-hidden=""true""></i>
                                                            </div>
                                                            <h4>
                                                                ");
#nullable restore
#line 92 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                           Write(item.NewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>\r\n");
#nullable restore
#line 93 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                                 if (item.Discount > 0)
                                                                {
                                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                                               
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            </span>
                                                        </h4>
                                                        </div>
                                                        <div class=""snipcart-details top_brand_home_details"">
                                                            <fieldset>
                                                                <input type=""submit"" name=""submit"" value=""Add to cart"" class=""button"" />
                                                            </fieldset>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 111 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
