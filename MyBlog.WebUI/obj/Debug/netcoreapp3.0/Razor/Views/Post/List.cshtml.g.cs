#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23f73f43df805bbe2d93c9aeea5f45941e4363f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_List), @"mvc.1.0.view", @"/Views/Post/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f73f43df805bbe2d93c9aeea5f45941e4363f1", @"/Views/Post/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d4d6404a600e7932f1d62349b2eca37f84ae5", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Models.ViewModels.PostListViewModel>
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
        private global::MyBlog.WebUI.TagHelpers.PostAllPagingHelper __MyBlog_WebUI_TagHelpers_PostAllPagingHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
  
    ViewData["Title"] = $"{@TempData["searchPost"]} - Ömer ARIYÜREK";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"load-more\">\r\n    <h2 class=\"load-more--main-title\">");
#nullable restore
#line 6 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                 Write(TempData["searchPost"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" için arama sonuçları</h2>\r\n");
#nullable restore
#line 7 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
     foreach (var post in Model.PostDetails)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"load-more__other-post\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 365, "\"", 423, 1);
#nullable restore
#line 10 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 372, Url.Action("Get","Post",new{@seoUrl=@post.SeoUrl}), 372, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 424, "\"", 443, 1);
#nullable restore
#line 10 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 432, post.Title, 432, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 467, "\"", 489, 1);
#nullable restore
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 473, post.FirstImage, 473, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 490, "\"", 507, 1);
#nullable restore
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 496, post.Title, 496, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 508, "\"", 537, 1);
#nullable restore
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 516, post.MetaDescription, 516, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 class=\"load-more__other-post--title\">");
#nullable restore
#line 12 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                                    Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </a>\r\n            <ul class=\"load-more__other-post--date-category\">\r\n                <li class=\"date\">");
#nullable restore
#line 15 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                            Write(post.CreatedDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"hyphen\">-</li>\r\n                <li class=\"category\">\r\n");
#nullable restore
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                     foreach (var category in post.PostCategories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 976, "\"", 1056, 1);
#nullable restore
#line 20 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 983, Url.Action("CategoryPosts", "Category", new {@seoUrl = category.SeoUrl}), 983, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1057, "\"", 1087, 1);
#nullable restore
#line 20 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 1065, category.CategoryName, 1065, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                                                                                                                      Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 21 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n            </ul>\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("post-all-paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f73f43df805bbe2d93c9aeea5f45941e4363f18023", async() => {
            }
            );
            __MyBlog_WebUI_TagHelpers_PostAllPagingHelper = CreateTagHelper<global::MyBlog.WebUI.TagHelpers.PostAllPagingHelper>();
            __tagHelperExecutionContext.Add(__MyBlog_WebUI_TagHelpers_PostAllPagingHelper);
#nullable restore
#line 26 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
__MyBlog_WebUI_TagHelpers_PostAllPagingHelper.PageSize = Model.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
__MyBlog_WebUI_TagHelpers_PostAllPagingHelper.PageCount = Model.PageCount;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
__MyBlog_WebUI_TagHelpers_PostAllPagingHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                                                                                                  WriteLiteral(Model.SearchKey);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.SearchPost = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("search-post", __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.SearchPost, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.WebUI.Models.ViewModels.PostListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
