#pragma checksum "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "045c29d02e7085aab80fac6347232a50df13951b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Customers.Pages_Customers_Details), @"mvc.1.0.razor-page", @"/Pages/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Customers/Details.cshtml", typeof(RazorPagesMovie.Pages.Customers.Pages_Customers_Details), @"{id:int}")]
namespace RazorPagesMovie.Pages.Customers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045c29d02e7085aab80fac6347232a50df13951b", @"/Pages/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bffd98f02597e6a09295a2131188dc64093be78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Customers_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(116, 28, true);
            WriteLiteral("\r\n<h2>Details for Customer: ");
            EndContext();
            BeginContext(145, 52, false);
#line 8 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
                     Write(Html.DisplayFor(model=> model.Customer.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(197, 109, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(307, 57, false);
#line 15 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(364, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(408, 53, false);
#line 18 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(461, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(505, 55, false);
#line 21 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Salutation));

#line default
#line hidden
            EndContext();
            BeginContext(560, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(604, 51, false);
#line 24 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Salutation));

#line default
#line hidden
            EndContext();
            BeginContext(655, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(699, 53, false);
#line 27 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(752, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(796, 49, false);
#line 30 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(845, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(889, 54, false);
#line 33 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(943, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(987, 50, false);
#line 36 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1081, 51, false);
#line 39 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1176, 47, false);
#line 42 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1267, 52, false);
#line 45 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1363, 48, false);
#line 48 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1455, 50, false);
#line 51 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1549, 46, false);
#line 54 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1642, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeed42421a7348a19e0cc9be4cf5f0b3", async() => {
                BeginContext(1697, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\arnol\source\RazorPagesMovie\RazorPagesMovie\Pages\Customers\Details.cshtml"
                           WriteLiteral(Model.Customer.ID);

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
            BeginContext(1705, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1713, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a174f16a4a0f4ffe8f9de05a2755bbfc", async() => {
                BeginContext(1735, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1751, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.Customers.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.Customers.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.Customers.DetailsModel>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.Customers.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
