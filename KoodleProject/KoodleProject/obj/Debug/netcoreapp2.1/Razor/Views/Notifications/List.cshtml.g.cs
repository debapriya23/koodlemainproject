#pragma checksum "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Notifications\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "570c8894f4fc0dfa1dad1d85388d19e9a9c08d4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notifications_List), @"mvc.1.0.view", @"/Views/Notifications/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Notifications/List.cshtml", typeof(AspNetCore.Views_Notifications_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"570c8894f4fc0dfa1dad1d85388d19e9a9c08d4a", @"/Views/Notifications/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d0d685ff31f1eb6c0abbfb793838606aa9c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Notifications_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Notifications", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Notifications\List.cshtml"
  
    ViewBag.Title = "Notifications";
 

#line default
#line hidden
            BeginContext(129, 298, true);
            WriteLiteral(@"
<section class=""notification"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 offset-md-3"">
                
                <div class=""notification__title"">
                    <h2 class=""d-inline-block"">All notifications</h2>
                    ");
            EndContext();
            BeginContext(427, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aa02ef1af024ff1af0f3db795476cfd", async() => {
                BeginContext(517, 82, true);
                WriteLiteral("\r\n                        <i class=\"fa fa-cog\"></i> settings\r\n                    ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(603, 88, true);
            WriteLiteral("\r\n                </div>\r\n                <div id=\"mainNotificationContainer\"></div>\r\n\r\n");
            EndContext();
#line 22 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Notifications\List.cshtml"
                 if (Model)
                {

#line default
#line hidden
            BeginContext(739, 71, true);
            WriteLiteral("                    <span class=\"d-none\" id=\"mainNotificationLoadMore\">");
            EndContext();
            BeginContext(811, 5, false);
#line 24 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Notifications\List.cshtml"
                                                                  Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(816, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 25 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Notifications\List.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(885, 80, true);
            WriteLiteral("                    <span class=\"d-none\" id=\"mainNotificationLoadMore\"></span>\r\n");
            EndContext();
#line 29 "C:\Users\dsp\Desktop\final\KoodleProject\KoodleProject\Views\Notifications\List.cshtml"
                }

#line default
#line hidden
            BeginContext(984, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPostService PostService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService UserService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool> Html { get; private set; }
    }
}
#pragma warning restore 1591