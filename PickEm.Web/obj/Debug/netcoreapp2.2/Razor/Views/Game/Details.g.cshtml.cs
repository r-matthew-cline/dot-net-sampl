#pragma checksum "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31786214a66e88294014ecbc1f15b26e64969878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Details), @"mvc.1.0.view", @"/Views/Game/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/Details.cshtml", typeof(AspNetCore.Views_Game_Details))]
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
#line 1 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/_ViewImports.cshtml"
using PickEm.Web;

#line default
#line hidden
#line 2 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/_ViewImports.cshtml"
using PickEm.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31786214a66e88294014ecbc1f15b26e64969878", @"/Views/Game/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78160ceae16cede55e026c4e3809192e7c8a31ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PickEm.Models.GameModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>GameModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(208, 44, false);
#line 14 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomeTeam));

#line default
#line hidden
            EndContext();
            BeginContext(252, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(316, 45, false);
#line 17 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayFor(model => model.HomeTeam.Name));

#line default
#line hidden
            EndContext();
            BeginContext(361, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(421, 44, false);
#line 20 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AwayTeam));

#line default
#line hidden
            EndContext();
            BeginContext(465, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(529, 45, false);
#line 23 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayFor(model => model.AwayTeam.Name));

#line default
#line hidden
            EndContext();
            BeginContext(574, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(637, 45, false);
#line 26 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomeScore));

#line default
#line hidden
            EndContext();
            BeginContext(682, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(746, 41, false);
#line 29 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayFor(model => model.HomeScore));

#line default
#line hidden
            EndContext();
            BeginContext(787, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(850, 45, false);
#line 32 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AwayScore));

#line default
#line hidden
            EndContext();
            BeginContext(895, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(959, 41, false);
#line 35 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayFor(model => model.AwayScore));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1063, 46, false);
#line 38 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prediction));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1173, 42, false);
#line 41 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
       Write(Html.DisplayFor(model => model.Prediction));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1262, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31786214a66e88294014ecbc1f15b26e649698788249", async() => {
                BeginContext(1308, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 46 "/home/matthew_cline/repos/dot-net-sample/PickEm.Web/Views/Game/Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1316, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1324, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31786214a66e88294014ecbc1f15b26e6496987810533", async() => {
                BeginContext(1346, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1362, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PickEm.Models.GameModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
