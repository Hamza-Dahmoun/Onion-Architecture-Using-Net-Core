#pragma checksum "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d78ae92fd05e38cb241977ad10b4431511ebd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activity_Index), @"mvc.1.0.view", @"/Views/Activity/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d78ae92fd05e38cb241977ad10b4431511ebd2", @"/Views/Activity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811a409c753354ee101afb05a0ff0cac36eb5285", @"/Views/_ViewImports.cshtml")]
    public class Views_Activity_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CompanyName.AppName.Domain.Entities.Activity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_datatablesStyle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_datatablesScript", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
  
    ViewData["Title"] = "List of Activities";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09d78ae92fd05e38cb241977ad10b4431511ebd25936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09d78ae92fd05e38cb241977ad10b4431511ebd27052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09d78ae92fd05e38cb241977ad10b4431511ebd28498", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Code\r\n            </th>\r\n            <th>\r\n                Description\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09d78ae92fd05e38cb241977ad10b4431511ebd211155", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
                                           WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09d78ae92fd05e38cb241977ad10b4431511ebd213413", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
                                              WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09d78ae92fd05e38cb241977ad10b4431511ebd215677", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
                                             WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09d78ae92fd05e38cb241977ad10b4431511ebd218278", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n        $(function () {\r\n            initDataTable(\"table\",\"");
#nullable restore
#line 49 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
                               Write(ApiServicesUrls.GetDatabableUrl<CompanyName.AppName.Domain.Entities.Activity>());

#line default
#line hidden
#nullable disable
            WriteLiteral("\")\r\n        });\r\n\r\n        function initDataTable(selector, url) {\r\n\r\n");
            WriteLiteral(@"
            


            $(selector).DataTable(
                {
                    ""processing"": true,//whether to show 'processing' indicator when waiting for a processing result or not
                    ""serverSide"": true,//for server side processing
                    ""filter"": true,//this is for disable filter (search box)
                    ""lengthMenu"": [[10, 25, 50, 100], [10, 25, 50, 100]],
                    ""ajax"": {
                        ""url"": url,
                        ""type"": 'POST',
                        dataType: ""json"",
                        ""data"": function (d) {
                            return JSON.stringify(d);
                        },
                        /*
                         WHEN I USED THE BELOW TO SEND ELECTIONID TO THE SERVER, I GOT EVERY LETTER AND NUMBER OF THE GUID SENT AS A SEPARATE PARAMETER!
                         THE ABOVE WAY IS THE ONE MENTIONED IN THE DOCUMENTATION
                         ""data"": JSON.stringify({electi");
            WriteLiteral(@"onId: electionId}),
                         or
                         ""data"": electionId,
                         */

                        //""error"": function (reason) {
                        //    //to know why I used 'response.responseJSON.message' to get the error text just log the response object and check its properties

                        //    //so there is a server error, lets display the error msg
                        //    let errorParag = document.createElement(""p"");
                        //    let responseMsg = document.createElement(""div"");
                        //    responseMsg.className = ""alert alert-danger"";
                        //    errorParag.innerHTML = ""<strong>"" + resources[currentUserLanguage][""Error when retrieving Candidates!""] + ""</strong> "" + reason.responseJSON.message;
                        //    responseMsg.appendChild(errorParag);
                        //    document.getElementById(""step-two"").appendChild(responseMsg);
               ");
            WriteLiteral(@"         //    //now lets hide the datatable wrapper (a div created by jquery which surrounds the table)
                        //    document.getElementById(""step-two"").querySelector("".dataTables_wrapper"").style.display = ""none"";
                        //}
                    },
                    ""columnDefs"": [
                        { ""type"": ""numeric-comma"", targets: ""_all"" }
                    ],
                    ""columns"":
                        [//These are the columns to be displayed, and they are the fields of the voters objects brought from the server
                            //{ ""data"": ""Id"", ""visible"": false, ""searchable"": false },
                            //{ ""data"": ""FirstName"", ""title"": resources[currentUserLanguage][""FirstName""], ""name"": ""FirstName"", ""visible"": true, ""searchable"": true, ""sortable"": false },
                            //{ ""data"": ""LastName"", ""title"": resources[currentUserLanguage][""LastName""], ""name"": ""LastName"", ""visible"": true, ""searchable"": true, ");
            WriteLiteral(@"""sortable"": false },
                            //{ ""data"": ""StateName"", ""title"": resources[currentUserLanguage][""State""], ""visible"": true, ""searchable"": true, ""sortable"": false },
                            //{
                            //    ""data"": null, ""searchable"": false, ""sortable"": false,
                            //    ""render"": function (data, type, row, meta) {
                            //        var button =
                            //            ""<a class='select-candidate-btn' title='Select this Voter as a Candidate' voterid="" +
                            //            row.Id + "" voterfullname='"" + row.FirstName + "" "" + row.LastName
                            //            + ""' onclick='selectNewCandidate()'>Select as Candidate</a>""
                            //            + ""<div class='spinner-border text-success hidden-spinner'></div>""
                            //            ;


                            //        return button;
                            //  ");
            WriteLiteral(@"  }
                            //}

                            //{ ""data"": ""id"", ""visible"": false, ""searchable"": false },
                { ""data"": ""code"", ""visible"": true, ""searchable"": false },
                { ""data"": ""designation"", ""visible"": true, ""searchable"": false },
                //{ ""data"": ""secteurActivite.designation"", ""visible"": true, ""searchable"": false },
                { ""data"": null, ""searchable"": false, ""sortable"": false,
                  ""render"": function (data, type, row, meta){
                      var markup =
                        ""<a class='btn btn-secondary btn-sm' href="" + '");
#nullable restore
#line 153 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
                                                                  Write(Url.Action("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\' + row.id + \"><i class=\'fa fa-pencil-alt\'></i></a>\" + \" \" +\r\n                        \"<a class=\'btn btn-danger btn-sm\' href=\" + \'");
#nullable restore
#line 154 "D:\to new laptop\fcc and others\Onion Architecture Using Net Core\Onion-Architecture-Using-Net-Core\CompanyName\CompanyName.AppName.Web\Views\Activity\Index.cshtml"
                                                               Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\' + row.id +\"><i class=\'fa fa-trash\'></i></a>\";\r\n                          return markup;\r\n                        }\r\n                    }\r\n                        ]\r\n                }\r\n            );\r\n\r\n    }\r\n\r\n\r\n\r\n</script>\r\n}");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CompanyName.AppName.Web.Infrastructure.ApiServicesUrls ApiServicesUrls { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CompanyName.AppName.Domain.Entities.Activity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
