#pragma checksum "C:\D Drive\Pankaj\Learning\Jun-20\Angular\EssentialAngular\essentialangular\ServerApp\Views\Home\Blazor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a99fd62bd2c3303cc9b8580e8e113543f481aa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blazor), @"mvc.1.0.view", @"/Views/Home/Blazor.cshtml")]
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
#line 1 "C:\D Drive\Pankaj\Learning\Jun-20\Angular\EssentialAngular\essentialangular\ServerApp\Views\_ViewImports.cshtml"
using ServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\D Drive\Pankaj\Learning\Jun-20\Angular\EssentialAngular\essentialangular\ServerApp\Views\_ViewImports.cshtml"
using ServerApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a99fd62bd2c3303cc9b8580e8e113543f481aa0", @"/Views/Home/Blazor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96711a00a324d5aa3ac613ff6e711257340ab38f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blazor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\D Drive\Pankaj\Learning\Jun-20\Angular\EssentialAngular\essentialangular\ServerApp\Views\Home\Blazor.cshtml"
  
    ViewData["RootUrl"] = "/blazor/";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"_framework/blazor.webassembly.js\"></script>\r\n");
            }
            );
            DefineSection("extraCSS", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div class=\"bg-dark text-white p-2\">\r\n    <div class=\"navbar-brand\">SPORTS STORE</div>\r\n</div>\r\n<app>Loading...</app>");
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
