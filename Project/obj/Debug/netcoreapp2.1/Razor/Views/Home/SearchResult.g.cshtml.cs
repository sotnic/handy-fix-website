#pragma checksum "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47315f86a9a44e1965b498dd745f5a30c110a5a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchResult), @"mvc.1.0.view", @"/Views/Home/SearchResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SearchResult.cshtml", typeof(AspNetCore.Views_Home_SearchResult))]
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
#line 1 "\\Mac\Home\Desktop\COMP231-master\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#line 2 "\\Mac\Home\Desktop\COMP231-master\Project\Views\_ViewImports.cshtml"
using Project.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47315f86a9a44e1965b498dd745f5a30c110a5a6", @"/Views/Home/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57cd24f8278aa43a88ac0a088daf74f4b29c08a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ServicePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
  
    Layout = "_layout";
    ViewBag.Image = "url('/images/registration.jpg')";
    ViewBag.Title = "Search Results";
    ViewBag.PageName = "Search Results";

#line default
#line hidden
            BeginContext(183, 261, true);
            WriteLiteral(@"
<section class=""ftco-section bg-light"">
    <div class=""container text-center"">
        <div class=""row justify-content-center mb-5"">
            <div class=""col-md-10 text-center heading-section  ftco-animate"">
                <h3>Search</h3>
                ");
            EndContext();
            BeginContext(444, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e327c4e247b046a9969ff1a2d6c7e3f8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(470, 202, true);
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row justify-content-center mb-5\">\n            <div class=\"col-md-12 text-center heading-section  ftco-animate\">\n\n            </div>\n        </div>\n");
            EndContext();
#line 23 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
         if (Model.Services.Count > 0)
        {

#line default
#line hidden
            BeginContext(721, 144, true);
            WriteLiteral("            <div class=\"row d-flex no-gutters\">\n                <div class=\"col-md-6 text-center\">\n                    <ul class=\"list-group\">\n\n");
            EndContext();
#line 29 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
                         for (int i = 0; i < Model.Services.Count(); i += 2)
                        {

#line default
#line hidden
            BeginContext(968, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(996, 303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b1868d151114fefa31ef263b13bb93c", async() => {
                BeginContext(1078, 36, true);
                WriteLiteral("\n                                <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1114, "\"", 1218, 5);
                WriteAttributeValue("", 1122, "list-group-item", 1122, 15, true);
                WriteAttributeValue(" ", 1137, "list-group-item-action", 1138, 23, true);
                WriteAttributeValue(" ", 1160, "filterDiv", 1161, 10, true);
                WriteAttributeValue(" ", 1170, "type#", 1171, 6, true);
#line 32 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 1176, Model.Services.ElementAt(i).ServiceTypeId, 1176, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1219, 2, true);
                WriteLiteral(">\t");
                EndContext();
                BeginContext(1222, 39, false);
#line 32 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
                                                                                                                                            Write(Model.Services.ElementAt(i).ServiceName);

#line default
#line hidden
                EndContext();
                BeginContext(1261, 34, true);
                WriteLiteral("</li>\n                            ");
                EndContext();
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
#line 31 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
                                                          WriteLiteral(Model.Services.ElementAt(i).ServiceId);

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
            BeginContext(1299, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 34 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
                        }

#line default
#line hidden
            BeginContext(1326, 145, true);
            WriteLiteral("\n                    </ul>\n                </div>\n                <div class=\"col-md-6 text-center\">\n                    <ul class=\"list-group\">\n");
            EndContext();
#line 40 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
                         for (int i = 1; i < Model.Services.Count(); i += 2)
                        {

#line default
#line hidden
            BeginContext(1574, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1602, 303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a90409597042dfbae923b94776e180", async() => {
                BeginContext(1684, 36, true);
                WriteLiteral("\n                                <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1720, "\"", 1824, 5);
                WriteAttributeValue("", 1728, "list-group-item", 1728, 15, true);
                WriteAttributeValue(" ", 1743, "list-group-item-action", 1744, 23, true);
                WriteAttributeValue(" ", 1766, "filterDiv", 1767, 10, true);
                WriteAttributeValue(" ", 1776, "type#", 1777, 6, true);
#line 43 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 1782, Model.Services.ElementAt(i).ServiceTypeId, 1782, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1825, 2, true);
                WriteLiteral(">\t");
                EndContext();
                BeginContext(1828, 39, false);
#line 43 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
                                                                                                                                            Write(Model.Services.ElementAt(i).ServiceName);

#line default
#line hidden
                EndContext();
                BeginContext(1867, 34, true);
                WriteLiteral("</li>\n                            ");
                EndContext();
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
#line 42 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
                                                          WriteLiteral(Model.Services.ElementAt(i).ServiceId);

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
            BeginContext(1905, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 45 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
                        }

#line default
#line hidden
            BeginContext(1932, 68, true);
            WriteLiteral("                    </ul>\n                </div>\n            </div>\n");
            EndContext();
#line 49 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2033, 67, true);
            WriteLiteral("            <h2>Oooops. We didn\'t find anything. Try again :)</h2>\n");
            EndContext();
#line 53 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\SearchResult.cshtml"
        }

#line default
#line hidden
            BeginContext(2110, 156, true);
            WriteLiteral("    </div>\n</section>\n\n<script>\n    function filter() {\n        var button = document.getElementById(\"applyFilter\");\n        button.click();\n    }\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
