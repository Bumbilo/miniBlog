#pragma checksum "/Users/dima/Projects/MiniBlog/MiniBlog/Views/Home/Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "827b70c48f7e59664bc0ed6fbd6ba0c3ceaf9b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thanks), @"mvc.1.0.view", @"/Views/Home/Thanks.cshtml")]
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
#line 1 "/Users/dima/Projects/MiniBlog/MiniBlog/Views/_ViewImports.cshtml"
using MiniBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dima/Projects/MiniBlog/MiniBlog/Views/_ViewImports.cshtml"
using MiniBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"827b70c48f7e59664bc0ed6fbd6ba0c3ceaf9b3b", @"/Views/Home/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d70508130ac4b53391f712141162a3eb25d969b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/dima/Projects/MiniBlog/MiniBlog/Views/Home/Thanks.cshtml"
  
    ViewData["Title"] = "Success Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"thankYou\">\r\n    <h1>Ваш запит обробляеться, наші спеціалісти зв\'яжуться за вам !</h1>\r\n    <div class=\"button__wrapper\">\r\n        <a sp-action=\"Index\" class=\"main-section__button\">Повернутись на головну</a>\r\n    </div>\r\n\r\n</div>");
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
