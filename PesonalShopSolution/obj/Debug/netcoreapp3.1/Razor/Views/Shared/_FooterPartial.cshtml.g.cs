#pragma checksum "D:\HK202\Project 202\Computer science\C#\WatchShop_Team4\PesonalShopSolution\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0e48ea69a5d4ba8602d150a01625a36f23cba33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterPartial.cshtml")]
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
#line 1 "D:\HK202\Project 202\Computer science\C#\WatchShop_Team4\PesonalShopSolution\Views\_ViewImports.cshtml"
using PesonalShopSolution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HK202\Project 202\Computer science\C#\WatchShop_Team4\PesonalShopSolution\Views\_ViewImports.cshtml"
using PesonalShopSolution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0e48ea69a5d4ba8602d150a01625a36f23cba33", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f1dc9a630f10dd00debe86ffdbf868986da9a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""footer"">
    <div class=""container"">
        <div class=""newsletter"">
            <h3>Newsletter</h3>
            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0e48ea69a5d4ba8602d150a01625a36f23cba333621", async() => {
                WriteLiteral("\n                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 431, "\"", 439, 0);
                EndWriteAttribute();
                WriteLiteral(" onfocus=\"this.value=\'\';\" onblur=\"if (this.value == \'\') {this.value =\'\';}\">\n                <input type=\"submit\" value=\"SUBSCRIBE\">\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""cssmenu"">
            <ul>
                <li class=""active""><a href=""#"">Privacy</a></li>
                <li><a href=""#"">Terms</a></li>
                <li><a href=""#"">Shop</a></li>
                <li><a href=""#"">About</a></li>
                <li><a href=""contact.html"">Contact</a></li>
            </ul>
        </div>
        <ul class=""social"">
            <li><a");
            BeginWriteAttribute("href", " href=\"", 997, "\"", 1004, 0);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"instagram\"> </i> </a></li>\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1062, "\"", 1069, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fb\"> </i> </a></li>\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1119, "\"", 1126, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""tw""> </i> </a></li>
        </ul>
        <div class=""clearfix""></div>
        <div class=""copy"">
            <p> &copy; 2015 Watches. All Rights Reserved | Design by <a href=""http://w3layouts.com/"" target=""_blank"">W3layouts</a></p>
        </div>
    </div>
</div>");
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
