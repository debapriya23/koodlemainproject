#pragma checksum "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea44246781bce610d83bee5c38e7523c425cc543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProfileCover_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProfileCover/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ProfileCover/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ProfileCover_Default))]
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
#line 1 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
using Core.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea44246781bce610d83bee5c38e7523c425cc543", @"/Views/Shared/Components/ProfileCover/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d0d685ff31f1eb6c0abbfb793838606aa9c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProfileCover_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewModels.Profile.ProfileCoverViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile__link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetUserPhotos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(143, 40, true);
            WriteLiteral("\r\n<div class=\"profile__cover\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 183, "\"", 215, 1);
#line 7 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
WriteAttributeValue("", 189, Model.ProfileCoverPicture, 189, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(216, 75, true);
            WriteLiteral(" class=\"profile__bg-img\"/>\r\n\r\n    <div class=\"profile__info\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 291, "\"", 318, 1);
#line 10 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
WriteAttributeValue("", 297, Model.ProfilePicture, 297, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(319, 84, true);
            WriteLiteral(" class=\"profile__photo\" alt=\"Profile-Picture\"/>\r\n        <h2 class=\"profile__title\">");
            EndContext();
            BeginContext(404, 14, false);
#line 11 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                              Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(418, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 12 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
         if (!string.IsNullOrEmpty(Model.Description))
        {

#line default
#line hidden
            BeginContext(492, 62, true);
            WriteLiteral("            <p class=\"profile__description\">\r\n                ");
            EndContext();
            BeginContext(555, 17, false);
#line 15 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(572, 20, true);
            WriteLiteral("\r\n            </p>\r\n");
            EndContext();
#line 17 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(603, 14, true);
            WriteLiteral("    </div>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
     if (!await UserService.IsProfilePageForCurrentUserAsync(CommonHelper.GetUserNameFromUrl()))
    {
        if (Model.IsFollowingUser)
        {

#line default
#line hidden
            BeginContext(769, 144, true);
            WriteLiteral("            <div class=\"profile__follow\">\r\n                <a class=\"profile__follow-btn profile__follow--is-following\" data-followee-username=\"");
            EndContext();
            BeginContext(914, 33, false);
#line 25 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                                                                                                Write(CommonHelper.GetUserNameFromUrl());

#line default
#line hidden
            EndContext();
            BeginContext(947, 92, true);
            WriteLiteral("\">\r\n                    <span>Following</span>\r\n\r\n                </a>\r\n            </div>\r\n");
            EndContext();
#line 30 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1075, 114, true);
            WriteLiteral("            <div class=\"profile__follow\">\r\n                <a class=\"profile__follow-btn\" data-followee-username=\"");
            EndContext();
            BeginContext(1190, 33, false);
#line 34 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                                                                  Write(CommonHelper.GetUserNameFromUrl());

#line default
#line hidden
            EndContext();
            BeginContext(1223, 145, true);
            WriteLiteral("\">\r\n                    <i class=\"fa fa-user-plus\"></i>\r\n                    <span>Follow me</span>\r\n\r\n                </a>\r\n            </div>\r\n");
            EndContext();
#line 40 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1386, 122, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"profile__stats\">\r\n    <ul class=\"profile__list\">\r\n        <li class=\"profile__item\">\r\n            ");
            EndContext();
            BeginContext(1508, 291, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8badad7579b04605884162b1d94b986c", async() => {
                BeginContext(1635, 160, true);
                WriteLiteral("\r\n\r\n                <span class=\"fa fa-globe profile__icon\"></span>\r\n             \r\n                <span class=\"profile__page-name\">Stream</span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                                                                                           WriteLiteral(CommonHelper.GetUserNameFromUrl());

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
            BeginContext(1799, 67, true);
            WriteLiteral("\r\n        </li>\r\n\r\n        <li class=\"profile__item\">\r\n            ");
            EndContext();
            BeginContext(1866, 339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fa76b59afa9498f85e9ff48e4d38a16", async() => {
                BeginContext(1999, 202, true);
                WriteLiteral("\r\n                <span class=\"fa fa-image profile__icon\"></span>\r\n                <span class=\"profile__page-name\">Photos</span>\r\n                <span class=\"profile__counter\">222</span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                                                                                                 WriteLiteral(CommonHelper.GetUserNameFromUrl());

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
            BeginContext(2205, 75, true);
            WriteLiteral("\r\n        </li>\r\n        \r\n        <li class=\"profile__item\">\r\n            ");
            EndContext();
            BeginContext(2280, 339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e65ba59fe2e243a494aa154d4d4175f5", async() => {
                BeginContext(2413, 202, true);
                WriteLiteral("\r\n                <span class=\"fa fa-users profile__icon\"></span>\r\n                <span class=\"profile__page-name\">Friends</span>\r\n                <span class=\"profile__counter\">10</span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                                                                                                 WriteLiteral(CommonHelper.GetUserNameFromUrl());

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
            BeginContext(2619, 34, true);
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService UserService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CommonHelper CommonHelper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewModels.Profile.ProfileCoverViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591