#pragma checksum "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0646826fead17f9ceeab1766fb75e17eb2ab4b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_State_Details), @"mvc.1.0.view", @"/Views/State/Details.cshtml")]
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
#line 1 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\_ViewImports.cshtml"
using CompanyName.AppName.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\_ViewImports.cshtml"
using CompanyName.AppName.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0646826fead17f9ceeab1766fb75e17eb2ab4b9", @"/Views/State/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2501974874ef3c2bcba0e23d9c770e790f0e9fcc", @"/Views/_ViewImports.cshtml")]
    public class Views_State_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyName.AppName.Domain.Entities.State>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
  
    ViewData["Title"] = labelLocalizer["Details"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
Write(labelLocalizer["Details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>");
#nullable restore
#line 10 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
   Write(labelLocalizer["State"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
       Write(labelLocalizer[Html.DisplayNameFor(model => model.Code)]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
       Write(labelLocalizer[Html.DisplayNameFor(model => model.Description)]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0646826fead17f9ceeab1766fb75e17eb2ab4b97270", async() => {
#nullable restore
#line 28 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
                                             Write(labelLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0646826fead17f9ceeab1766fb75e17eb2ab4b99777", async() => {
#nullable restore
#line 29 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\State\Details.cshtml"
                     Write(labelLocalizer["Back to List"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<Menu> menuLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<Messages> messageLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<Labels> labelLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyName.AppName.Domain.Entities.State> Html { get; private set; }
    }
}
#pragma warning restore 1591
