#pragma checksum "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae22e47fedb5a7e16d46aa8679ec6874816dfb36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Templates__Post), @"mvc.1.0.view", @"/Views/Shared/Templates/_Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Templates/_Post.cshtml", typeof(AspNetCore.Views_Shared_Templates__Post))]
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
#line 1 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Posts;

#line default
#line hidden
#line 2 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Notifications;

#line default
#line hidden
#line 3 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Users;

#line default
#line hidden
#line 4 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Follows;

#line default
#line hidden
#line 5 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Posts;

#line default
#line hidden
#line 6 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Follows;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae22e47fedb5a7e16d46aa8679ec6874816dfb36", @"/Views/Shared/Templates/_Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d0d685ff31f1eb6c0abbfb793838606aa9c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Templates__Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewModels.Templates.PostTemplateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-1 w-100 d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
 if (Model.Posts.Any())
{
    foreach (var post in Model.Posts)
    {

#line default
#line hidden
            BeginContext(161, 136, true);
            WriteLiteral("        <div class=\"post\">\r\n            <div class=\"post__content\">\r\n                <div class=\"post__photo-box\">\r\n                    ");
            EndContext();
            BeginContext(297, 238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "148f628bb35d46c1bd1ac652bf6f4959", async() => {
                BeginContext(392, 52, true);
                WriteLiteral("\r\n\r\n                        <img class=\"post__photo\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 444, "\"", 464, 2);
#line 13 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
WriteAttributeValue("", 450, post.Id, 450, 8, false);

#line default
#line hidden
                WriteAttributeValue(" ", 458, "image", 459, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("src", " src=\"", 465, "\"", 506, 1);
#line 13 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
WriteAttributeValue("", 471, post.CreatedBy.GetProfilePicture(), 471, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(507, 24, true);
                WriteLiteral("/>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                                             WriteLiteral(post.CreatedBy.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(535, 166, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"post__text-container\">\r\n                    <h2 class=\"post__author d-inline-block\">\r\n                        ");
            EndContext();
            BeginContext(701, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6bb688c388400a8383969d95fdce64", async() => {
                BeginContext(796, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(827, 23, false);
#line 20 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                       Write(post.CreatedBy.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(850, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                                                 WriteLiteral(post.CreatedBy.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(880, 107, true);
            WriteLiteral("\r\n                    </h2>\r\n                    <time class=\"d-inline-block pull-right post__time timeago\"");
            EndContext();
            BeginWriteAttribute("datetime", " datetime=\"", 987, "\"", 1013, 1);
#line 23 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
WriteAttributeValue("", 998, post.CreatedOn, 998, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1014, 53, true);
            WriteLiteral("></time>\r\n                    <p class=\"post__text\"> ");
            EndContext();
            BeginContext(1068, 12, false);
#line 24 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                      Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 26 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                 foreach (var photo in post.Photos)
                {

#line default
#line hidden
            BeginContext(1182, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1202, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f766a66f6684154a15da78fb73524ae", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1212, "~/uploads/posts/", 1212, 16, true);
#line 28 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
AddHtmlAttributeValue("", 1228, photo.FileName, 1228, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-overlay", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1285, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                }

#line default
#line hidden
            BeginContext(1306, 170, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"d-flex justify-content-between post__icons\">\r\n                <div>\r\n                    <i class=\"fa fa-thumbs-o-up\"></i>\r\n");
            EndContext();
#line 35 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                     if (!await PostService.HasUserLikePostAsync(post.Id))
                    {

#line default
#line hidden
            BeginContext(1575, 74, true);
            WriteLiteral("                        <a href=\"#\" class=\"post__like-icon\" data-post-id=\"");
            EndContext();
            BeginContext(1651, 7, false);
#line 37 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                                      Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1659, 68, true);
            WriteLiteral("\">\r\n                            Like\r\n                        </a>\r\n");
            EndContext();
            BeginContext(1729, 29, true);
            WriteLiteral("                        <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1758, "\"", 1787, 2);
            WriteAttributeValue("", 1766, "like-count-", 1766, 11, true);
#line 41 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
WriteAttributeValue("", 1777, post.Id, 1777, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1788, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(1791, 18, false);
#line 41 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                        Write(post.Likes.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1809, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 42 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1891, 100, true);
            WriteLiteral("                        <a href=\"#\" class=\"post__like-icon post__like-icon--is-liked\" data-post-id=\"");
            EndContext();
            BeginContext(1993, 7, false);
#line 45 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                                                                Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2001, 69, true);
            WriteLiteral("\">\r\n                            Liked\r\n                        </a>\r\n");
            EndContext();
#line 48 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"

                        /*When the user and many peole have liked the post*/
                        if (post.Likes.Count() > 2)
                        {

#line default
#line hidden
            BeginContext(2230, 33, true);
            WriteLiteral("                            <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2263, "\"", 2292, 2);
            WriteAttributeValue("", 2271, "like-count-", 2271, 11, true);
#line 52 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
WriteAttributeValue("", 2282, post.Id, 2282, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2293, 10, true);
            WriteLiteral(">(you and ");
            EndContext();
            BeginContext(2305, 22, false);
#line 52 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                                     Write(post.Likes.Count() - 1);

#line default
#line hidden
            EndContext();
            BeginContext(2328, 17, true);
            WriteLiteral(" people)</span>\r\n");
            EndContext();
#line 53 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                        }
                    
                        /*when the user and only one person has liked the post*/
                        else if (post.Likes.Count() - 1 == 1)
                        {

#line default
#line hidden
            BeginContext(2566, 33, true);
            WriteLiteral("                            <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2599, "\"", 2628, 2);
            WriteAttributeValue("", 2607, "like-count-", 2607, 11, true);
#line 58 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
WriteAttributeValue("", 2618, post.Id, 2618, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2629, 10, true);
            WriteLiteral(">(you and ");
            EndContext();
            BeginContext(2641, 22, false);
#line 58 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                                     Write(post.Likes.Count() - 1);

#line default
#line hidden
            EndContext();
            BeginContext(2664, 17, true);
            WriteLiteral(" person)</span>\r\n");
            EndContext();
#line 59 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                        }
                        //Only the user has liked the post
                        else
                        {

#line default
#line hidden
            BeginContext(2825, 33, true);
            WriteLiteral("                            <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2858, "\"", 2887, 2);
            WriteAttributeValue("", 2866, "like-count-", 2866, 11, true);
#line 63 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
WriteAttributeValue("", 2877, post.Id, 2877, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2888, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(2892, 18, false);
#line 63 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                             Write(post.Likes.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2911, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 64 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2971, 146, true);
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <a href=\"#\" class=\"post__comment-icon\" data-comments-target=\"#post__comments-");
            EndContext();
            BeginContext(3119, 7, false);
#line 69 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                                                             Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3127, 145, true);
            WriteLiteral("\">\r\n                        <i class=\"fa fa-comment-o\"></i> Comments\r\n\r\n                    </a>\r\n                    \r\n                    <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3272, "\"", 3304, 2);
            WriteAttributeValue("", 3280, "comment-count-", 3280, 14, true);
#line 74 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
WriteAttributeValue("", 3294, post.Id, 3294, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3305, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(3308, 19, false);
#line 74 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
                                                       Write(post.Comments.Count);

#line default
#line hidden
            EndContext();
            BeginContext(3327, 66, true);
            WriteLiteral(")</span>\r\n                </div>\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(3394, 63, false);
#line 77 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
       Write(await Component.InvokeAsync("Comments", new {postId = post.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(3457, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 79 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
    }
}

else
{

#line default
#line hidden
            BeginContext(3496, 131, true);
            WriteLiteral("    <div class=\"post\"><div class=\"post__content text-center\"><h4 style=\"font-size: 1.6rem\">No post is available.</h4></div></div>\r\n");
            EndContext();
#line 85 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Templates\_Post.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPostService PostService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewModels.Templates.PostTemplateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
