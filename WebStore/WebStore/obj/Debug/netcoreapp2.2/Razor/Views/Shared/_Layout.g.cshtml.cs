#pragma checksum "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dbacc47252ecc636f22e6f7ca579e7baba779a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dbacc47252ecc636f22e6f7ca579e7baba779a9", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Shared\_Layout.cshtml"
  
	Layout = "_LayoutBase";

#line default
#line hidden
            BeginContext(33, 28, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\t");
            EndContext();
            BeginContext(62, 12, false);
#line 6 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(74, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(102, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(106, 30, false);
#line 10 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Shared\_Layout.cshtml"
Write(RenderSection("Styles", false));

#line default
#line hidden
                EndContext();
                BeginContext(136, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(160, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(164, 31, false);
#line 14 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(195, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591