#pragma checksum "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Shared\Components\User\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65102164dc548de6ceea861362ab17a87035ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_User_Default), @"mvc.1.0.view", @"/Views/Shared/Components/User/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/User/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_User_Default))]
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
#line 1 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using GeekStore;

#line default
#line hidden
#line 2 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using GeekStore.Models;

#line default
#line hidden
#line 3 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using GeekStore.Data.Tables;

#line default
#line hidden
#line 4 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using GeekStore.Data.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65102164dc548de6ceea861362ab17a87035ae2", @"/Views/Shared/Components/User/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e88e7114a52b1816d86d77c80d4c57a475ff67", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_User_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Shared\Components\User\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#line 5 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Shared\Components\User\Default.cshtml"
 if (Model.UserId=="")
{

}
else
{

#line default
#line hidden
            BeginContext(86, 14, true);
            WriteLiteral("    <p>1</p>\r\n");
            EndContext();
#line 12 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Shared\Components\User\Default.cshtml"
}

#line default
#line hidden
            BeginContext(103, 4, true);
            WriteLiteral("\r\n\r\n");
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
