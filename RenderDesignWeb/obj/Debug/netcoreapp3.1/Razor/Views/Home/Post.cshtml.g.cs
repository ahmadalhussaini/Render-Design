#pragma checksum "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66cbb884eaff55210491e2eb6aeb3b3bb16df4ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 1 "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\_ViewImports.cshtml"
using RenderDesignWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\_ViewImports.cshtml"
using RenderDesignWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cbb884eaff55210491e2eb6aeb3b3bb16df4ac", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ecc5db40f755e460d233d63af876728ae7bb40", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RenderDesignWeb.ViweModel.Post.PostListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Addpost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\Home\Post.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66cbb884eaff55210491e2eb6aeb3b3bb16df4ac4531", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link href=""https://fonts.googleapis.com/css?family=Ropa+Sans"" rel=""stylesheet"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css"" integrity=""sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb"" crossorigin=""anonymous"">

    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">

    <title>page3</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scal");
                WriteLiteral(@"e=1"">
    <title>Activate Bootstrap Modals via Data Attributes</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""></script>
    <style>

        body {
            background-color: #F2EEED;
        }

        h1 {
            margin-top: 1% !important;
            margin-left: 0% !important;
            color: #3B1B55;
            font-style: normal;
            font-weight: 600;
            font-family: 'Anek Tamil', sans-serif;
            font-family: 'PT Sans', sans-serif;
            font-family: 'Ubuntu', sans-serif;
            font-weight: bold;
            padding-top: 5vw;
            font-size: 3vw;
        }

        .m-4 {
            margin-top: 8%;
            margin-left: 30%;
            margin-top: 0vw !important;
            margin-left: !important;
            margin-bottom: 1vw !important;
        }
");
                WriteLiteral(@"
        .main-section {
            padding: 0.9765VW;
            background-color: #fff;
            width: 90%;
        }

        .list-inline-item {
            border-right: 0.065VW solid black;
            padding-right: 0.39VW;
            line-height: 0.4em;
        }

            .list-inline-item:last-child {
                border: none;
            }

        .post-detail ul {
            margin-top: 0.9765VW;
        }
    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66cbb884eaff55210491e2eb6aeb3b3bb16df4ac8143", async() => {
                WriteLiteral(@"
    <h1 class=""text-center"">POST </h1>

    <div class=""m-4"">
        <!-- Button HTML (to Trigger Modal) -->
        <a href=""#myModal"" role=""button"" class=""btn btn-lg btn-primary"" data-bs-toggle=""modal"">Add Post</a>

        <!-- Modal HTML -->
        <div id=""myModal"" class=""modal fade"" tabindex=""-1"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66cbb884eaff55210491e2eb6aeb3b3bb16df4ac8842", async() => {
                    WriteLiteral(@"
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">Add Post </h5>
                            <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""></button>
                        </div>
                        <div class=""modal-body"">
                            <label for=""message-text"" class=""col-form-label"">Name:</label>
                            <input class=""form-control"" name=""Name""  id=""message-text"">
                        </div>
                        <div class=""modal-body"">
                            <label for=""message-text"" class=""col-form-label"">Descripion:</label>
                            <textarea class=""form-control"" name=""Subject""  id=""message-text""></textarea>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Cancel</button>
                            <button type=""button""");
                    WriteLiteral(" class=\"btn btn-primary\">Add Post </button>\r\n                            <button type=\"submit\" class=\"btn btn-primary\">\r\n                                send\r\n                            </button>\r\n                        </div>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n               \r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"container main-section border\"");
                BeginWriteAttribute("style", " style=\"", 4638, "\"", 4646, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 117 "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\Home\Post.cshtml"
         foreach (var elem in Model.PostViewModel)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""row"">
                <div class=""col-lg-12 col-sm-12 col-12"">
                    <div class=""row"" style="" margin-top: 3vw; margin-left: 3vw;  "">

                        <div class=""col-lg-10 col-sm-10 col-7"">
                            <h4 class=""text-primary"">");
#nullable restore
#line 124 "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\Home\Post.cshtml"
                                                Write(elem.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h4>\r\n                            <p>\r\n                                ");
#nullable restore
#line 126 "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\Home\Post.cshtml"
                           Write(elem.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                    <div class=""row post-detail"" style="" margin-top: 3vw; margin-left: 3vw;"">
                        <div class=""col-lg-12 col-sm-12 col-12"">
                            <ul class=""list-inline"">
                                <li class=""list-inline-item"">
                                    <span class=""text-info"">");
#nullable restore
#line 134 "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\Home\Post.cshtml"
                                                       Write(elem.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span>
                                </li>
                                <li class=""list-inline-item"">
                                    <i class=""fa fa-calendar"" aria-hidden=""true""></i> <span>22/4/2022</span>
                                </li>
                                <li class=""list-inline-item"">
                                    <i class=""fa fa-comment"" aria-hidden=""true""></i> <span class=""text-info"">0 Comments</span>
                                </li>
                                <li class=""list-inline-item"">
                                    <i class=""fa fa-share-square-o"" aria-hidden=""true""></i> <span class=""text-info"">0 Shares</span>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 150 "C:\Users\H4C\Desktop\render-design\Render-Design\RenderDesignWeb\Views\Home\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <hr>\r\n\r\n        </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RenderDesignWeb.ViweModel.Post.PostListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
