#pragma checksum "C:\Users\CodeSmart\source\repos\TestingWebApp\TestingWebApp\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bc86e977c34b31f88e1424c1b8f18830c9d9a63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\CodeSmart\source\repos\TestingWebApp\TestingWebApp\Views\_ViewImports.cshtml"
using TestingWebApp;

#line default
#line hidden
#line 2 "C:\Users\CodeSmart\source\repos\TestingWebApp\TestingWebApp\Views\_ViewImports.cshtml"
using TestingWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bc86e977c34b31f88e1424c1b8f18830c9d9a63", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330dc17480b143b7ae5b7a0388a3be1e8c69980a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\CodeSmart\source\repos\TestingWebApp\TestingWebApp\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Hey there";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(50, 17, false);
#line 4 "C:\Users\CodeSmart\source\repos\TestingWebApp\TestingWebApp\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(67, 440, true);
            WriteLiteral(@"</h2>

<img /> 
<p>Hi, my name is Menzelle! I'm currently an intern at Code Smart. I created this app after my mentor (Chuck) encouraged me to expand on an existing Console application that 
    I designed to log my daily work activities. In the process of creating this application I learned a TON of new programming concepts. I became familiar with Entity Framework Core. 
    MVC and Razor Pages (like the page you're viewing)</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
