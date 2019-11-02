#pragma checksum "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02c8a3adbcf24914279f6fb2692d4d9b30ebcf2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ServicePage), @"mvc.1.0.view", @"/Views/Home/ServicePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ServicePage.cshtml", typeof(AspNetCore.Views_Home_ServicePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c8a3adbcf24914279f6fb2692d4d9b30ebcf2a", @"/Views/Home/ServicePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57cd24f8278aa43a88ac0a088daf74f4b29c08a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ServicePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary py-3 px-5 text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ServiceBookingPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
  

    Layout = "_Layout";
    ViewBag.Image = "url('/images/bg_1.jpg')";
    ViewBag.Title = @Model.ServiceName;
    ViewBag.PageName = @Model.ServiceName;

    double averageRating = 0;

#line default
#line hidden
            BeginContext(206, 757, true);
            WriteLiteral(@"
<div class=""row d-flex"">
    <div class=""col-md-12 dish-menu"">
        <div class=""tab-pane fade show active"" id=""v-pills-home"" role=""tabpanel"" aria-labelledby=""v-pills-home-tab"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""d-flex ftco-animate fadeInUp ftco-animated"">
                        <div class=""col-12 text-center"">
                            <hr />
                            <h2>Service Description</h2>
                            <hr />
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <h4>Service: </h4>
                </div>
                <div class=""col-lg-6"">
                    <h4>");
            EndContext();
            BeginContext(964, 17, false);
#line 29 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                   Write(Model.ServiceName);

#line default
#line hidden
            EndContext();
            BeginContext(981, 200, true);
            WriteLiteral("</h4>\n                </div>\n                <div class=\"col-lg-4\">\n                    <h4>Price Per Hour:</h4>\n                </div>\n                <div class=\"col-lg-6\">\n                    <h4>$");
            EndContext();
            BeginContext(1182, 18, false);
#line 35 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                    Write(Model.PricePerHour);

#line default
#line hidden
            EndContext();
            BeginContext(1200, 196, true);
            WriteLiteral("</h4>\n                </div>\n                <div class=\"col-lg-4\">\n                    <h4>Description:</h4>\n                </div>\n                <div class=\"col-lg-6\">\n                    <h4>");
            EndContext();
            BeginContext(1397, 17, false);
#line 41 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 155, true);
            WriteLiteral("</h4>\n                </div>\n                <div class=\"col-md-12 mt-3 text-center\">\n                    <div class=\"form-group\">\n                        ");
            EndContext();
            BeginContext(1569, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b498e5da78f4199b073303b12bbff34", async() => {
                BeginContext(1682, 22, true);
                WriteLiteral("Register for a service");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                                                                                                           WriteLiteral(Model.ServiceId);

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
            BeginContext(1708, 124, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n    <div class=\"col-md-12\">\n");
            EndContext();
#line 53 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(1905, 223, true);
            WriteLiteral("                <div class=\"col-md-12 text-center heading-section ftco-animate fadeInUp ftco-animated\">\n                    <hr />\n                    <h2>Add a Review</h2>\n                    <hr />\n                </div>\n");
            EndContext();
            BeginContext(2145, 69, false);
#line 60 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
           Write(Html.Partial("AddReview", new Review { ServiceId = Model.ServiceId }));

#line default
#line hidden
            EndContext();
#line 60 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                                                                                      ;
            }

#line default
#line hidden
            BeginContext(2240, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 64 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
         if (Model.Reviews != null && Model.Reviews.Count != 0)
        {

#line default
#line hidden
            BeginContext(2315, 198, true);
            WriteLiteral("            <div class=\"col-md-12 text-center heading-section ftco-animate fadeInUp ftco-animated\">\n                <hr />\n                <h2>Reviews</h2>\n                <hr />\n            </div>\n");
            EndContext();
#line 71 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
             foreach (var item in Model.Reviews)
            {
                averageRating += item.Rating;
            }

#line default
#line hidden
#line 74 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
             
            if (averageRating != 0)
            {
                averageRating /= Model.Reviews.Count();

#line default
#line hidden
            BeginContext(2742, 103, true);
            WriteLiteral("                <h5 class=\"font-weight-bold\" style=\"color:orange\">\n                    AVERAGE RATING: ");
            EndContext();
#line 79 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                                     for (int i = 0; i < Math.Round(averageRating); i++)
                    { Write("⭐ "); }

#line default
#line hidden
            BeginContext(2935, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 81 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                       Write(Math.Round(averageRating, 2));

#line default
#line hidden
            BeginContext(2996, 22, true);
            WriteLiteral("                </h5>\n");
            EndContext();
#line 83 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
            }

            

#line default
#line hidden
#line 85 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
             foreach (var item in Model.Reviews)
            {

#line default
#line hidden
            BeginContext(3096, 221, true);
            WriteLiteral("                <div class=\"row border\">\n                    <div class=\"col-md-4\">\n                        <div class=\"form-group\">\n                            <h5 class=\"font-weight-bold\" style=\"color:orange\">REVIEWER: ");
            EndContext();
            BeginContext(3318, 13, false);
#line 90 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                                                                                   Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3331, 275, true);
            WriteLiteral(@"</h5>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""form-group"">
                            <h5 class=""font-weight-bold"" style=""color:orange"">
                                RATING: ");
            EndContext();
#line 96 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                                         for (int i = 0; i < item.Rating; i++)
                                { Write("⭐ "); }

#line default
#line hidden
            BeginContext(3694, 301, true);
            WriteLiteral(@"                            </h5>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""form-group"">
                            <h5 class=""font-weight-bold"" style=""color:orange"">
                                Date: ");
            EndContext();
            BeginContext(3996, 9, false);
#line 104 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                                 Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4005, 241, true);
            WriteLiteral("\n                            </h5>\n                        </div>\n                    </div>\n                    <div class=\"col-md-8\">\n                        <div class=\"form-group\">\n                            <p class=\"font-weight-bold\">");
            EndContext();
            BeginContext(4247, 15, false);
#line 110 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
                                                   Write(item.ReviewText);

#line default
#line hidden
            EndContext();
            BeginContext(4262, 113, true);
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                    <hr />\n                </div>\n");
            EndContext();
#line 115 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
            }

#line default
#line hidden
#line 115 "\\Mac\Home\Desktop\COMP231-master\Project\Views\Home\ServicePage.cshtml"
             
        }

#line default
#line hidden
            BeginContext(4399, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; }
    }
}
#pragma warning restore 1591