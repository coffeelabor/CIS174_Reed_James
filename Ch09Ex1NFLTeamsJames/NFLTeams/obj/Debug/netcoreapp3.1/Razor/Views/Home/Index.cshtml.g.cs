#pragma checksum "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e3b05aa39b8935b7f432b2d7de9b2340d0f8cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\_ViewImports.cshtml"
using NFLTeams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\_ViewImports.cshtml"
using NFLTeams.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e3b05aa39b8935b7f432b2d7de9b2340d0f8cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"575b46a07ba0d9c3e631ae1b72311e496429adad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "NFL Teams";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        <h3 class=\"mt-3\">Conference</h3>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 10 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
             foreach (Conference conf in Model.Conferences)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69e3b05aa39b8935b7f432b2d7de9b2340d0f8cb4713", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
               Write(conf.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeConf", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
                             WriteLiteral(conf.ConferenceID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeConf"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeConf", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeConf"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
                            WriteLiteral(Model.ActiveDiv);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeDiv"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeDiv", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeDiv"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 458, "list-group-item", 458, 15, true);
#nullable restore
#line 15 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 473, Model.CheckActiveConf(conf.ConferenceID), 474, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <h3 class=\"mt-3\">Division</h3>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 22 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
             foreach (Division div in Model.Divisions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69e3b05aa39b8935b7f432b2d7de9b2340d0f8cb9337", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
               Write(div.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeConf", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
                             WriteLiteral(Model.ActiveConf);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeConf"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeConf", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeConf"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
                            WriteLiteral(div.DivisionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeDiv"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeDiv", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeDiv"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 933, "list-group-item", 933, 15, true);
#nullable restore
#line 27 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 948, Model.CheckActiveDiv(div.DivisionID), 949, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-sm-9\">\r\n        <ul class=\"list-inline\">\r\n");
#nullable restore
#line 35 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
             foreach (Team team in Model.Teams)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-inline-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69e3b05aa39b8935b7f432b2d7de9b2340d0f8cb14004", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69e3b05aa39b8935b7f432b2d7de9b2340d0f8cb14284", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1367, "~/images/", 1367, 9, true);
#nullable restore
#line 39 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1376, team.LogoImage, 1376, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1398, team.Name, 1398, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1450, team.Name, 1450, 10, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue(" ", 1460, "|", 1461, 2, true);
#nullable restore
#line 40 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 1462, team.Conference.Name, 1463, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 1484, team.Division.Name, 1485, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
                                              WriteLiteral(team.TeamID);

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
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 43 "C:\Users\Reed\Documents\6_DMACC\2021_Fall\Advanced_C_Sharp\CIS174_Reed_James\Ch09Ex1NFLTeamsJames\NFLTeams\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
