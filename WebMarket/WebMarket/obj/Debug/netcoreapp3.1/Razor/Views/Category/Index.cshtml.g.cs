#pragma checksum "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30750bf11a8d6b81a2a20924d7d2b70fa788b77e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30750bf11a8d6b81a2a20924d7d2b70fa788b77e", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebMarket.Models.ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sort.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
  
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
#line 13 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                              Write(ViewBag.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            </ol>\r\n        </div>\r\n    </div>\r\n    <!-- //breadcrumbs -->\r\n");
            }
            );
            DefineSection("css", async() => {
                WriteLiteral(@"
    <style>
        .sort {
            position: relative;
            background-color: #fafafa;
            padding-bottom: 100px;
        }

        .sort-heading {
            position: absolute;
            top: 4px;
            right: 4px;
            border: 1px solid rgb(172,172,172);
            padding: 8px 65px;
            border-radius: 2px;
            cursor: pointer;
        }

            .sort-heading:hover {
                background-color: #ccc;
            }

                .sort-heading:hover .sort-box__list,
                .sort-box__list:focus .search-box__item {
                    display: block;
                }

        .sort-box__list {
            position: absolute;
            top: 4px;
            right: 194px;
            list-style: none;
            border: 1px solid #cacaca;
            box-shadow: 0 10px 10px #ccc;
            line-height: 2;
            display: none;
            width: 100%;
        }

        .search-box__it");
                WriteLiteral(@"em {
            padding: 8px 13px;
        }

            .search-box__item:hover {
                background-color: #cacaca;
            }

            .search-box__item a {
                text-decoration: none;
            }
        /*filter*/
        .filter {
            margin-top: 20px;
        }

        .filter-heading {
            font-size: 1rem;
            font-family: 'FontAwesome';
            font-weight: 600;
            border-bottom: 1px solid #ccc;
            display: block;
            margin-left: 4px;
            margin-bottom: 4px;
        }

        .filter-list {
            list-style: none;
        }

        .filter-item {
            line-height: 3;
            margin-left: 5px;
            padding: 0 4px;
            cursor: pointer;
            transition: all linear 0.3s;
        }

            .filter-item:hover {
                background-color: #cacaca;
                color: white;
            }

            .filter-item.filt");
                WriteLiteral("er-item__link {\r\n                text-decoration: none;\r\n                color: none;\r\n                display: block;\r\n            }\r\n    </style>\r\n");
            }
            );
#nullable restore
#line 108 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"products\">\r\n    <div class=\"container\">\r\n        <div class=\"col-md-3 products-left\">\r\n\r\n            ");
#nullable restore
#line 113 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
       Write(await Component.InvokeAsync("Type", new { name = ViewBag.name }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"filter\">\r\n                <span class=\"filter-heading\">Mệnh Giá</span>\r\n                <ul class=\"filter-list\">\r\n");
#nullable restore
#line 118 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                     if (ViewBag.type != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3278, "\"", 3385, 1);
#nullable restore
#line 121 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 3285, Url.Action("ProductByType", "Category", new { data = ViewBag.da, minPrice = 1, maxPrice = 100000 }), 3285, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Từ 0đ  đến 100.000đ</a>\r\n                        </li>\r\n                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3549, "\"", 3661, 1);
#nullable restore
#line 124 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 3556, Url.Action("ProductByType", "Category", new { data = ViewBag.da, minPrice = 100000, maxPrice = 500000 }), 3556, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Từ 100.00đ đến 500.000đ</a>\r\n                        </li>\r\n                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3829, "\"", 3942, 1);
#nullable restore
#line 127 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 3836, Url.Action("ProductByType", "Category", new { data = ViewBag.da, minPrice = 500000, maxPrice = 1000000 }), 3836, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Từ 500.000đ đến 1.000.000đ</a>\r\n                        </li>\r\n                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4113, "\"", 4227, 1);
#nullable restore
#line 130 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 4120, Url.Action("ProductByType", "Category", new { data = ViewBag.da, minPrice = 1000000, maxPrice = 2000000 }), 4120, 107, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Từ 1.000.000đ đến 2.000.000đ</a>\r\n                        </li>\r\n                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4400, "\"", 4494, 1);
#nullable restore
#line 133 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 4407, Url.Action("ProductByType", "Category", new { data = ViewBag.da, minPrice = 2000000 }), 4407, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Trên 2.000.000đ</a>\r\n                        </li>\r\n");
#nullable restore
#line 135 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4726, "\"", 4825, 1);
#nullable restore
#line 139 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 4733, Url.Action("Index", "Category", new { data = ViewBag.da, minPrice = 1, maxPrice = 100000 }), 4733, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Từ 0đ  đến 100.000đ</a>\r\n                        </li>\r\n                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4989, "\"", 5093, 1);
#nullable restore
#line 142 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 4996, Url.Action("Index", "Category", new { data = ViewBag.da, minPrice = 100000, maxPrice = 500000 }), 4996, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Từ 100.00đ đến 500.000đ</a>\r\n                        </li>\r\n                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5261, "\"", 5366, 1);
#nullable restore
#line 145 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 5268, Url.Action("Index", "Category", new { data = ViewBag.da, minPrice = 500000, maxPrice = 1000000 }), 5268, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Từ 500.000đ đến 1.000.000đ</a>\r\n                        </li>\r\n                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5537, "\"", 5643, 1);
#nullable restore
#line 148 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 5544, Url.Action("Index", "Category", new { data = ViewBag.da, minPrice = 1000000, maxPrice = 2000000 }), 5544, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Từ 1.000.000đ đến 2.000.000đ</a>\r\n                        </li>\r\n                        <li class=\"filter-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5816, "\"", 5903, 2);
#nullable restore
#line 151 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 5823, Url.Action("Index", "Category", new { data = ViewBag.da, minPrice = 2000000 }), 5823, 79, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5902, ",", 5902, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"filter-item__link\">Trên 2.000.000đ</a>\r\n                        </li>\r\n");
#nullable restore
#line 153 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
        </div>

        <div class=""col-md-9 products-right"">
            <div class=""products-right-grid"">
                <div class=""row"">
                    <div class=""products-right-grids"">
                        <div class=""sort "">
                            <div class=""sort-heading"">
                                Sắp Xếp
                                <ul class=""sort-box__list"">
");
#nullable restore
#line 166 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                     if (ViewBag.type != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"search-box__item\"><a");
            BeginWriteAttribute("href", " href=\"", 6629, "\"", 6741, 1);
#nullable restore
#line 168 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 6636, Url.Action("ProductByType", "Category", new { data =1 ,minPrice = ViewBag.min, maxPrice = ViewBag.max }), 6636, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">giá tiền tăng</a></li>\r\n");
#nullable restore
#line 169 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"search-box__item\"><a");
            BeginWriteAttribute("href", " href=\"", 6958, "\"", 7062, 1);
#nullable restore
#line 172 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 6965, Url.Action("Index", "Category", new { data = 1 ,minPrice = ViewBag.min, maxPrice = ViewBag.max}), 6965, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">giá tiền tăng</a></li>\r\n");
#nullable restore
#line 173 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 175 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                     if (ViewBag.type != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"search-box__item\"><a");
            BeginWriteAttribute("href", " href=\"", 7303, "\"", 7415, 1);
#nullable restore
#line 177 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 7310, Url.Action("ProductByType", "Category", new { data = 2 ,minPrice = ViewBag.min, maxPrice = ViewBag.max}), 7310, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">giá tiền giảm</a></li>\r\n");
#nullable restore
#line 178 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"search-box__item\"><a");
            BeginWriteAttribute("href", " href=\"", 7632, "\"", 7736, 1);
#nullable restore
#line 181 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 7639, Url.Action("Index", "Category", new { data = 2 ,minPrice = ViewBag.min, maxPrice = ViewBag.max}), 7639, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">giá tiền giảm </a></li>\r\n");
#nullable restore
#line 182 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 184 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                     if (ViewBag.type != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"search-box__item\"><a");
            BeginWriteAttribute("href", " href=\"", 7978, "\"", 8090, 1);
#nullable restore
#line 186 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 7985, Url.Action("ProductByType", "Category", new { data = 3,minPrice = ViewBag.min, maxPrice = ViewBag.max }), 7985, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sản phẩm giảm giá</a></li>\r\n");
#nullable restore
#line 187 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"search-box__item\"><a");
            BeginWriteAttribute("href", " href=\"", 8311, "\"", 8415, 1);
#nullable restore
#line 190 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
WriteAttributeValue("", 8318, Url.Action("Index", "Category", new { data = 3 ,minPrice = ViewBag.min, maxPrice = ViewBag.max}), 8318, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sản phẩm giảm giá</a></li>\r\n");
#nullable restore
#line 191 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </ul>
                            </div>



                            <div class=""clearfix""></div>

                        </div>

                    </div>

                </div>

            </div>
            <div id=""myparital"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30750bf11a8d6b81a2a20924d7d2b70fa788b77e22747", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 208 "D:\LocTran\HocPhan\HP_CNWeb\Final-3AE\Final-3AE\WebMarket\WebMarket\WebMarket\Views\Category\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30750bf11a8d6b81a2a20924d7d2b70fa788b77e24524", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebMarket.Models.ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
