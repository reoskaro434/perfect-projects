#pragma checksum "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76d63fb94b2e8b09f273085208edf30e09121bfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_UserProfile_Index), @"mvc.1.0.view", @"/Areas/User/Views/UserProfile/Index.cshtml")]
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
#line 1 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\_ViewImports.cshtml"
using PerfectProjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\_ViewImports.cshtml"
using PerfectProjects.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
using PerfectProjects.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d63fb94b2e8b09f273085208edf30e09121bfb", @"/Areas/User/Views/UserProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6502ecc9469ed554089be8a6fff946f352f68a3d", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_UserProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PerfectProjects.Model.ViewModel.UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/UserProfile.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76d63fb94b2e8b09f273085208edf30e09121bfb4795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"XD\"></div>\r\n    <div class=\"col-md-8 offset-md-2 text-center\">\r\n        <h1>This is ");
#nullable restore
#line 15 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
               Write(Model.Nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'s profile!</h1>
        <br />

        <br />
    </div>
    <div class=""row"">
        <div class=""col-md-2 text-center"">
            <nav id=""sidebar"">
                <ul class=""list-unstyled components"">
                    <li id=""my-projects-li"" class=""h3"" style=""cursor:default"">My Projects</li>
                    <br />
                    <li id=""about-me-li"" class=""h3"" style=""cursor:default"">About Me</li>
                </ul>
            </nav>
        </div>
        <div class=""col-md-6 offset-1 text-center"" id=""profileContent"">
            <div id=""project-list"">
");
#nullable restore
#line 32 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
                 foreach (var i in Model.ShortDescriptions)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"cursor: default; \" class=\"text-center\"><a class=\"lighting-text\">");
#nullable restore
#line 34 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
                                                                                           Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 35 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div hidden id=\"about-me\">\r\n                <p>");
#nullable restore
#line 38 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
              Write(Model.AboutMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 42 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <h1>Login or create account to show this page. </h1>\r\n");
#nullable restore
#line 48 "C:\Users\reosk\Documents\GitHub\PerfectProjects\PerfectProjects\PerfectProjects\Areas\User\Views\UserProfile\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(""#my-projects-li"").click(function () {
        $(""#project-list"").show();
        $(""#about-me"").attr(""hidden"", ""true"");
    });
    $(""#about-me-li"").click(function () {
        $(""#project-list"").hide();
        $(""#about-me"").removeAttr(""hidden"");
    });
</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76d63fb94b2e8b09f273085208edf30e09121bfb9450", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PerfectProjects.Model.ViewModel.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
