#pragma checksum "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76c903709138661730dc46b706a996496010dd1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employes_EmployeeView), @"mvc.1.0.view", @"/Views/Employes/EmployeeView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employes/EmployeeView.cshtml", typeof(AspNetCore.Views_Employes_EmployeeView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76c903709138661730dc46b706a996496010dd1d", @"/Views/Employes/EmployeeView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employes_EmployeeView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
  
    ViewData["Title"] = "EmployeeView";

#line default
#line hidden
            BeginContext(83, 127, true);
            WriteLiteral("\r\n<h2>EmployeeView</h2>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(211, 38, false);
#line 14 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(293, 34, false);
#line 17 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(327, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(371, 43, false);
#line 20 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayNameFor(model => model.SurName));

#line default
#line hidden
            EndContext();
            BeginContext(414, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(458, 39, false);
#line 23 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayFor(model => model.SurName));

#line default
#line hidden
            EndContext();
            BeginContext(497, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(541, 45, false);
#line 26 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(586, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(630, 41, false);
#line 29 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(671, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(715, 46, false);
#line 32 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayNameFor(model => model.Patronymic));

#line default
#line hidden
            EndContext();
            BeginContext(761, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(805, 42, false);
#line 35 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayFor(model => model.Patronymic));

#line default
#line hidden
            EndContext();
            BeginContext(847, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(891, 39, false);
#line 38 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(930, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(974, 35, false);
#line 41 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1057, 48, false);
#line 46 "E:\Курс JS Задания\xx C# ASP.NET MVC 6. Уровень 1\Lesson 04\WebStore\WebStore\Views\Employes\EmployeeView.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1113, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76c903709138661730dc46b706a996496010dd1d8468", async() => {
                BeginContext(1135, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1151, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591