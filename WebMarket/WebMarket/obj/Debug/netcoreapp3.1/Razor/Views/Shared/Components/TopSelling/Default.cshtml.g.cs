#pragma checksum "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ad9e7ba8707876bea57022a8d3b5ca1cdd62eee"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad9e7ba8707876bea57022a8d3b5ca1cdd62eee", @"/Views/Shared/Components/TopSelling/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopSelling_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebMarket.Models.ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/offer.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: block; max-width: 200px; max-height: 95px; width: auto; height: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" display: block; max-width: 200px; max-height: 95px; width: auto; height: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
  
    ViewData["Title"] = "TopSelling";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- top-brands -->
<h1></h1>
<div class=""top-brands"">
    <div class=""container"">
        <h2>Top selling offers</h2>
        <div class=""grid_3 grid_5"">
            <div class=""bs-example bs-example-tabs"" role=""tabpanel"" data-example-id=""togglable-tabs"">
                <ul id=""myTab"" class=""nav nav-tabs"" role=""tablist"">
                    <li role=""presentation"" class=""active""><a href=""#expeditions"" id=""expeditions-tab"" role=""tab"" data-toggle=""tab"" aria-controls=""expeditions"" aria-expanded=""true"">Advertised offers</a></li>
                    <li role=""presentation""><a href=""#tours"" role=""tab"" id=""tours-tab"" data-toggle=""tab"" aria-controls=""tours"">Today Offers</a></li>
                </ul>
                <div id=""myTabContent"" class=""tab-content"">
                    <div role=""tabpanel"" class=""tab-pane fade in active"" id=""expeditions"" aria-labelledby=""expeditions-tab"">
                        <div class=""agile-tp"">
                            <h5>Advertised this week</h5>
           ");
            WriteLiteral("                 <p class=\"w3l-ad\">We\'ve pulled together all our advertised offers into one place, so you won\'t miss out on a great deal.</p>\r\n                        </div>\r\n                        <div class=\"agile_top_brands_grids\">\r\n");
#nullable restore
#line 26 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                             foreach (var item in Model.TakeLast(6))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-4 top_brand_left"" style="" margin-bottom :20px"">
                                    <div class=""hover14 column"">
                                        <div class=""agile_top_brand_left_grid"">
                                            <div class=""agile_top_brand_left_grid_pos"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ad9e7ba8707876bea57022a8d3b5ca1cdd62eee8661", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ad9e7ba8707876bea57022a8d3b5ca1cdd62eee10317", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2381, "~/images/img-products/", 2381, 22, true);
#nullable restore
#line 38 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
AddHtmlAttributeValue("", 2403, item.Image, 2403, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                            <p>");
#nullable restore
#line 39 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
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
#line 47 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                           Write(item.NewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 47 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                                        </div>\r\n                                                        <div class=\"snipcart-details top_brand_home_details\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ad9e7ba8707876bea57022a8d3b5ca1cdd62eee14121", async() => {
                WriteLiteral(@"
                                                                <fieldset>
                                                                    <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                                                    <input type=""hidden"" name=""add"" value=""1"" />
                                                                    <input type=""hidden"" name=""business"" value="" "" />
                                                                    <input type=""hidden"" name=""item_name"" value=""Fortune Sunflower Oil"" />
                                                                    <input type=""hidden"" name=""amount"" value=""20.99"" />
                                                                    <input type=""hidden"" name=""discount_amount"" value=""1.00"" />
                                                                    <input type=""hidden"" name=""currency_code"" value=""USD"" />
                                                                    <input type");
                WriteLiteral(@"=""hidden"" name=""return"" value="" "" />
                                                                    <input type=""hidden"" name=""cancel_return"" value="" "" />
                                                                    <input type=""submit"" name=""submit"" value=""Add to cart"" class=""button"" />
                                                                </fieldset>
                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 71 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div role=""tabpanel"" class=""tab-pane fade"" id=""tours"" aria-labelledby=""tours-tab"">
                        <div class=""agile-tp"">
                            <h5>This week</h5>
                            <p class=""w3l-ad"">We've pulled together all our advertised offers into one place, so you won't miss out on a great deal.</p>
                        </div>
                        <div class=""agile_top_brands_grids"">
");
#nullable restore
#line 82 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                             foreach (var item in ViewBag.offeritems)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-4 top_brand_left"" style="" margin-bottom :20px"">
                                    <div class=""hover14 column"">
                                        <div class=""agile_top_brand_left_grid"">
                                            <div class=""agile_top_brand_left_grid_pos"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ad9e7ba8707876bea57022a8d3b5ca1cdd62eee19027", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ad9e7ba8707876bea57022a8d3b5ca1cdd62eee20684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7138, "~/images/img-products/", 7138, 22, true);
#nullable restore
#line 95 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
AddHtmlAttributeValue("", 7160, item.Image, 7160, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                            <p>");
#nullable restore
#line 96 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
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
#line 104 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                           Write(item.NewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 104 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n\r\n                                                        </div>\r\n                                                        <div class=\"snipcart-details top_brand_home_details\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ad9e7ba8707876bea57022a8d3b5ca1cdd62eee24493", async() => {
                WriteLiteral(@"
                                                                <fieldset>
                                                                    <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                                                    <input type=""hidden"" name=""add"" value=""1"" />
                                                                    <input type=""hidden"" name=""business"" value="" "" />
                                                                    <input type=""hidden"" name=""item_name"" value=""Fortune Sunflower Oil"" />
                                                                    <input type=""hidden"" name=""amount"" value=""35.99"" />
                                                                    <input type=""hidden"" name=""discount_amount"" value=""1.00"" />
                                                                    <input type=""hidden"" name=""currency_code"" value=""USD"" />
                                                                    <input type");
                WriteLiteral(@"=""hidden"" name=""return"" value="" "" />
                                                                    <input type=""hidden"" name=""cancel_return"" value="" "" />
                                                                    <input type=""submit"" name=""submit"" value=""Add to cart"" class=""button"" />
                                                                </fieldset>
                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 129 "D:\webFinal\WebMarket\WebMarket\WebMarket\Views\Shared\Components\TopSelling\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
