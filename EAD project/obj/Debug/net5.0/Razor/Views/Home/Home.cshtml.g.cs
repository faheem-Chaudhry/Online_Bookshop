#pragma checksum "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e52b311222d2f2a447e4fcee4095ccd6b396d1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 1 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\_ViewImports.cshtml"
using EAD_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\_ViewImports.cshtml"
using EAD_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e52b311222d2f2a447e4fcee4095ccd6b396d1d", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b68cbf680ee3f564413a647624457c33e1cd51", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
  
    Layout = "~/Views/Shared/headerLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("render", async() => {
                WriteLiteral("\r\n\t<h3>Online Bookshop</h3>\r\n");
            }
            );
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e52b311222d2f2a447e4fcee4095ccd6b396d1d4932", async() => {
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e52b311222d2f2a447e4fcee4095ccd6b396d1d5194", async() => {
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
                WriteLiteral("\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e52b311222d2f2a447e4fcee4095ccd6b396d1d7083", async() => {
                WriteLiteral(@"
        <section class=""section-products"">
		<div class=""container"">
				<div class=""row justify-content-center text-center"">
						<div class=""col-md-8 col-lg-6"">
								<div class=""header"">
										<h2>Popular Products</h2>
								</div>
						</div>
				</div>
				<div class=""row"">
						<!-- Single Product -->
");
                WriteLiteral("\t\t\t\t\t\t<!-- Single Product -->\r\n");
#nullable restore
#line 59 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
                         foreach (var data in Model)
						   {

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<div class=\"col-md-6 col-lg-4 col-xl-3\">\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t   \r\n\t\t\t\t\t\t   \r\n\t\t\t\t\t\t\t\t<div id=\"product-2\"");
                BeginWriteAttribute("style", " style=\"", 2254, "\"", 2335, 6);
                WriteAttributeValue("", 2262, "background:", 2262, 11, true);
                WriteAttributeValue(" ", 2273, "url(\'../", 2274, 9, true);
#nullable restore
#line 65 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
WriteAttributeValue("", 2282, data.Image, 2282, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2293, "\')", 2293, 2, true);
                WriteAttributeValue(" ", 2295, "no-repeat", 2296, 10, true);
                WriteAttributeValue(" ", 2305, "center;background-size:cover;", 2306, 30, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"single-product\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"part-1\" >\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e52b311222d2f2a447e4fcee4095ccd6b396d1d9122", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
                                                                                       WriteLiteral(data.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"part-2\" style=\"background-color:white\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h3 class=\"product-title\">");
#nullable restore
#line 77 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
                                                                     Write(data.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4 class=\"product-old-price\">Rs ");
#nullable restore
#line 78 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
                                                                            Write(data.OldPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4 class=\"product-price\">Rs ");
#nullable restore
#line 79 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
                                                                        Write(data.NewPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 84 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<!-- Single Product -->\r\n");
                WriteLiteral("</section>\r\n<div>\r\n");
#nullable restore
#line 197 "C:\Users\Ch Faheem\source\repos\EAD project\EAD project\Views\Home\Home.cshtml"
Write(await Component.InvokeAsync("Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n</div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
