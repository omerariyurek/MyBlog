#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ca401665eb8c59ec5d944a08845511328cce96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Post_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Post/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ca401665eb8c59ec5d944a08845511328cce96", @"/Areas/Administrator/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d4d6404a600e7932f1d62349b2eca37f84ae5", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Areas.Administrator.Models.ViewModels.PostIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MyBlog.WebUI.Areas.Administrator.TagHelpers.PostPagingTagHelper __MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Posts Page";

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"admin-object-table col-md-12\">\r\n    <div class=\"search-object-base\">\r\n        <div class=\"search-object\" style=\"float: left;\">\r\n            <div class=\"search-object\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 325, "\"", 357, 1);
#line 10 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
WriteAttributeValue("", 332, Url.Action("Add","Post"), 332, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Post Add</a>\r\n            </div>\r\n        </div>\r\n        <div class=\"search-object\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ca401665eb8c59ec5d944a08845511328cce964954", async() => {
                WriteLiteral("\r\n                <input class=\"form-control form-fix\" name=\"search\" placeholder=\"Search Post\">\r\n                <button type=\"submit\" class=\"btn btn-info\">Search</button>\r\n            ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#line 20 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
     if (TempData["searchPost"] != null)
    {

#line default
#line hidden
            WriteLiteral("        <div class=\"alert alert-primary\" style=\"margin-top: 50px\" role=\"alert\">\r\n            Searched Post : ");
#line 23 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                       Write(TempData["searchPost"]);

#line default
#line hidden
            WriteLiteral("\r\n        </div>\r\n");
#line 25 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
    }
    else if (TempData["Error"] != null)
    {

#line default
#line hidden
            WriteLiteral("        <div class=\"alert alert-danger\" style=\"margin-top: 50px\" role=\"alert\">\r\n            ");
#line 29 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
       Write(TempData["Error"]);

#line default
#line hidden
            WriteLiteral("\r\n        </div>\r\n");
#line 31 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
    }
    else if (TempData["Success"] != null)
    {

#line default
#line hidden
            WriteLiteral("        <div class=\"alert alert-success\" style=\"margin-top: 50px\" role=\"alert\">\r\n            ");
#line 35 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
       Write(TempData["Success"]);

#line default
#line hidden
            WriteLiteral("\r\n        </div>\r\n");
#line 37 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
    }

#line default
#line hidden
            WriteLiteral(@"    <div class=""admin-object-table-info"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Post Title</th>
                    <th scope=""col"">Status</th>
                    <th scope=""col"">Is Home</th>
                    <th scope=""col"">Comment Status</th>
                    <th scope=""col"">Operations</th>
                </tr>
            </thead>
            <tbody>
");
#line 50 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                 if (Model.Posts.Count == 0)
                {

#line default
#line hidden
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" style=\"text-align: center\">No Post</td>\r\n                    </tr>\r\n");
#line 55 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                }
                else
                {
                    foreach (var post in Model.Posts)
                    {

#line default
#line hidden
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 2161, "\"", 2187, 2);
            WriteAttributeValue("", 2166, "row_post_", 2166, 9, true);
#line 60 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
WriteAttributeValue("", 2175, post.PostId, 2175, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#line 61 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                           Write(post.Title);

#line default
#line hidden
            WriteLiteral("</td>\r\n                            <td>");
#line 62 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                           Write(post.Status);

#line default
#line hidden
            WriteLiteral("</td>\r\n                            <td>");
#line 63 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                           Write(post.IsHome);

#line default
#line hidden
            WriteLiteral("</td>\r\n                            <td>");
#line 64 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                           Write(post.CommentStatus);

#line default
#line hidden
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2469, "\"", 2525, 1);
#line 66 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
WriteAttributeValue("", 2476, Url.Action("Update","Post",new{@id=post.PostId}), 2476, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"table-button-object\">Update</a> |\r\n                                <a class=\"table-button-object\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2640, "\"", 2674, 3);
            WriteAttributeValue("", 2650, "deletePost(", 2650, 11, true);
#line 67 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
WriteAttributeValue("", 2661, post.PostId, 2661, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2673, ")", 2673, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#line 70 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                    }
                }

#line default
#line hidden
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"paging-admin\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("post-paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ca401665eb8c59ec5d944a08845511328cce9612952", async() => {
                WriteLiteral("\r\n    ");
            }
            );
            __MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper = CreateTagHelper<global::MyBlog.WebUI.Areas.Administrator.TagHelpers.PostPagingTagHelper>();
            __tagHelperExecutionContext.Add(__MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper);
#line 77 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
__MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 77 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
__MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 77 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
__MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Areas\Administrator\Views\Post\Index.cshtml"
                                                                                                              WriteLiteral(Model.SearchPost);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper.SearchPost = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("search-post", __MyBlog_WebUI_Areas_Administrator_TagHelpers_PostPagingTagHelper.SearchPost, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.WebUI.Areas.Administrator.Models.ViewModels.PostIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
