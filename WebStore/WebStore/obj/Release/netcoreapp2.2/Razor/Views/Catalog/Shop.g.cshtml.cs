#pragma checksum "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Catalog\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3295e974454f7166beb43182ae305835d6a8a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Shop), @"mvc.1.0.view", @"/Views/Catalog/Shop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Shop.cshtml", typeof(AspNetCore.Views_Catalog_Shop))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb3295e974454f7166beb43182ae305835d6a8a1", @"/Views/Catalog/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.ViewModels.CatalogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shop/advertisement.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Catalog\Shop.cshtml"
  
	ViewData["Title"] = "ShopView";
	Layout = "_LayoutBase";

#line default
#line hidden
            BeginContext(112, 62, true);
            WriteLiteral("\r\n\r\n<section id=\"advertisement\">\r\n\t<div class=\"container\">\r\n\t\t");
            EndContext();
            BeginContext(174, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb3295e974454f7166beb43182ae305835d6a8a13963", async() => {
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
            EndContext();
            BeginContext(226, 110, true);
            WriteLiteral("\r\n\t</div>\r\n</section>\r\n\r\n<section>\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-sm-3\">\r\n");
            EndContext();
#line 18 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Catalog\Shop.cshtml"
                  await Html.RenderPartialAsync("Partial/_LeftSideBar"); 

#line default
#line hidden
            BeginContext(400, 54, true);
            WriteLiteral("\t\t\t</div>\r\n\r\n\t\t\t<div class=\"col-sm-9 padding-right\">\r\n");
            EndContext();
#line 22 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Catalog\Shop.cshtml"
                  await Html.RenderPartialAsync("Partial/_FeaturesItems", Model.Products); 

#line default
#line hidden
            BeginContext(536, 46, true);
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.ViewModels.CatalogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
