#pragma checksum "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Reset.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc697a6c58ae0b56e85901389945719402791ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Reset), @"mvc.1.0.view", @"/Views/Home/Reset.cshtml")]
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
#line 1 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\_ViewImports.cshtml"
using Dojoachi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\_ViewImports.cshtml"
using Dojoachi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc697a6c58ae0b56e85901389945719402791ac", @"/Views/Home/Reset.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99084fe81e2d303c11e61c95ec1b40a0e0eeb938", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Reset : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Reset.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-3\">Welcome To Mario World!!</h1>\r\n<br>\r\n<br>\r\n\r\n<br>\r\n<h3>");
#nullable restore
#line 11 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Reset.cshtml"
Write(ViewBag.Reaction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br>\r\n    <i class=\"nes-mario\"></i>\r\n<br>\r\n<br>\r\n    <div>\r\n        <a href=\"/\" class=\"nes-btn is-default\">Reset</a>\r\n    </div>\r\n</div>\r\n");
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
