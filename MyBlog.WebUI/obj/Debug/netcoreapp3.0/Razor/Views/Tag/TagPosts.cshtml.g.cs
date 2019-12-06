#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a10e2e2a51cb3f9c244d62634282a5a8ac00f6ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_TagPosts), @"mvc.1.0.view", @"/Views/Tag/TagPosts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a10e2e2a51cb3f9c244d62634282a5a8ac00f6ac", @"/Views/Tag/TagPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d4d6404a600e7932f1d62349b2eca37f84ae5", @"/Views/_ViewImports.cshtml")]
    public class Views_Tag_TagPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Models.ViewModels.TagPostsViewModel>
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
        private global::MyBlog.WebUI.TagHelpers.TagPostsPagingHelper __MyBlog_WebUI_TagHelpers_TagPostsPagingHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
  
    ViewData["Title"] = $"{Model.Tag.TagName} Etiketi - Ömer ARIYÜREK";

#line default
#line hidden
#nullable disable
            DefineSection("metaTags", async() => {
                WriteLiteral("\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 187, "\"", 223, 1);
#nullable restore
#line 7 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
WriteAttributeValue("", 197, Model.Tag.MetaDescription, 197, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 287, 1);
#nullable restore
#line 8 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
WriteAttributeValue("", 264, Model.Tag.MetaKeywords, 264, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral("<section class=\"load-more\">\r\n    <h2 class=\"load-more--main-title\">");
#nullable restore
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
                                 Write(Model.Tag.TagName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" etiketine ait yazılar</h2>\r\n");
#nullable restore
#line 12 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
     foreach (var post in Model.PostDetails)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"load-more__other-post\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 522, "\"", 580, 1);
#nullable restore
#line 15 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
WriteAttributeValue("", 529, Url.Action("Get","Post",new{@seoUrl=@post.SeoUrl}), 529, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 604, "\"", 626, 1);
#nullable restore
#line 16 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
WriteAttributeValue("", 610, post.FirstImage, 610, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 627, "\"", 651, 1);
#nullable restore
#line 16 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
WriteAttributeValue("", 633, post.MetaKeywords, 633, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 652, "\"", 671, 1);
#nullable restore
#line 16 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
WriteAttributeValue("", 660, post.Title, 660, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 class=\"load-more__other-post--title\">");
#nullable restore
#line 17 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
                                                    Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </a>\r\n            <ul class=\"load-more__other-post--date-category\">\r\n                <li class=\"date\">");
#nullable restore
#line 20 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
                            Write(post.CreatedDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"hyphen\">-</li>\r\n                <li class=\"category\">\r\n");
#nullable restore
#line 23 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
                     foreach (var category in post.PostCategories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1186, 1);
#nullable restore
#line 25 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
WriteAttributeValue("", 1117, Url.Action("CategoryPosts","Category",new{@seoUrl=@category.SeoUrl}), 1117, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"title\">");
#nullable restore
#line 25 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
                                                                                                                 Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 26 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n            </ul>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tag-posts-paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a10e2e2a51cb3f9c244d62634282a5a8ac00f6ac8376", async() => {
            }
            );
            __MyBlog_WebUI_TagHelpers_TagPostsPagingHelper = CreateTagHelper<global::MyBlog.WebUI.TagHelpers.TagPostsPagingHelper>();
            __tagHelperExecutionContext.Add(__MyBlog_WebUI_TagHelpers_TagPostsPagingHelper);
#nullable restore
#line 31 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
__MyBlog_WebUI_TagHelpers_TagPostsPagingHelper.PageSize = Model.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __MyBlog_WebUI_TagHelpers_TagPostsPagingHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
__MyBlog_WebUI_TagHelpers_TagPostsPagingHelper.PageCount = Model.PageCount;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __MyBlog_WebUI_TagHelpers_TagPostsPagingHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
__MyBlog_WebUI_TagHelpers_TagPostsPagingHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __MyBlog_WebUI_TagHelpers_TagPostsPagingHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Tag\TagPosts.cshtml"
                                                                                                                   WriteLiteral(Model.CurrentTag);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __MyBlog_WebUI_TagHelpers_TagPostsPagingHelper.CurrentTag = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("current-tag", __MyBlog_WebUI_TagHelpers_TagPostsPagingHelper.CurrentTag, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.WebUI.Models.ViewModels.TagPostsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
