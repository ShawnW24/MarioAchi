#pragma checksum "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f50faaba878b3682c29348a0ced48bd313c1ff1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f50faaba878b3682c29348a0ced48bd313c1ff1b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99084fe81e2d303c11e61c95ec1b40a0e0eeb938", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-3\">Welcome To Mario World!!</h1>\r\n<br>\r\n<br>\r\n    <h4>\r\n        Fullness: ");
#nullable restore
#line 10 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Index.cshtml"
             Write(ViewBag.Fullness);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        Happiness: ");
#nullable restore
#line 11 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Index.cshtml"
              Write(ViewBag.Happiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        Meals: ");
#nullable restore
#line 12 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Index.cshtml"
          Write(ViewBag.Meals);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        Energy: ");
#nullable restore
#line 13 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Index.cshtml"
           Write(ViewBag.Energy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n<br>\r\n<h3>");
#nullable restore
#line 16 "C:\Users\djsha\OneDrive\Desktop\CodingDojo\C#_Stack\ASP.NET_CORE\Dojoachi\Views\Home\Index.cshtml"
Write(ViewBag.Reaction);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<br>
    <i class=""nes-mario""></i>
<br>
<br>
<br>
    <a href=""/feed""class=""nes-btn is-primary"">Feed</a>
    <a href=""/play""class=""nes-btn is-error"">Play</a>
    <a href=""/work""class=""nes-btn is-success"">Work</a>
    <a href=""/sleep""class=""nes-btn is-warning"">Sleep</a>
<br>
<br>

    <div>
        <a href=""/"" class=""nes-btn is-default"">Reset</a>
    </div>
</div>
");
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
