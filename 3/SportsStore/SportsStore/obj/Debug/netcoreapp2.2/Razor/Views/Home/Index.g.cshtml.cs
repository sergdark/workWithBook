#pragma checksum "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc627510f460cf6e8058b359250570c8cb5f785"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc627510f460cf6e8058b359250570c8cb5f785", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77560e7e41fa351060b684219371159d4cfde8e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 433, true);
            WriteLiteral(@"<h3 class=""p-2 bg-primary text-white text-center"">Products</h3>
<div class=""container-fluid mt-3"">
    <div class=""row"">
        <div class=""col font-weight-bold"">Name</div>
        <div class=""col font-weight-bold"">Category</div>
        <div class=""col font-weight-bold text-right"">Purchase Price</div>
        <div class=""col font-weight-bold text-right"">Retail Price</div>
        <div class=""col""></div>
    </div>
    ");
            EndContext();
            BeginContext(462, 627, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfc627510f460cf6e8058b359250570c8cb5f7854261", async() => {
                BeginContext(506, 576, true);
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col""><input name=""Name"" class=""form-control"" /></div>
            <div class=""col""><input name=""Category"" class=""form-control"" /></div>
            <div class=""col"">
                <input name=""PurchasePrice"" class=""form-control"" />
            </div>
            <div class=""col"">
                <input name=""RetailPrice"" class=""form-control"" />
            </div>
            <div class=""col"">
                <button type=""submit"" class=""btn btn-primary"">Add</button>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1089, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(1128, 103, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col text-center p-2\">No Data</div>\r\n        </div>\r\n");
            EndContext();
#line 31 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#line 34 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
         foreach (Product p in Model)
        {

#line default
#line hidden
            BeginContext(1305, 68, true);
            WriteLiteral("            <div class=\"row p-2\">\r\n                <div class=\"col\">");
            EndContext();
            BeginContext(1374, 6, false);
#line 37 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
                            Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1380, 41, true);
            WriteLiteral("</div>\r\n                <div class=\"col\">");
            EndContext();
            BeginContext(1422, 10, false);
#line 38 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
                            Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(1432, 52, true);
            WriteLiteral("</div>\r\n                <div class=\"col text-right\">");
            EndContext();
            BeginContext(1485, 15, false);
#line 39 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
                                       Write(p.PurchasePrice);

#line default
#line hidden
            EndContext();
            BeginContext(1500, 52, true);
            WriteLiteral("</div>\r\n                <div class=\"col text-right\">");
            EndContext();
            BeginContext(1553, 13, false);
#line 40 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
                                       Write(p.RetailPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1566, 69, true);
            WriteLiteral("</div>\r\n                <div class=\"col\"></div>\r\n            </div>\r\n");
            EndContext();
#line 43 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#line 43 "d:\project\c#\WorkWithBook\EFrCoreMvc2\3\SportsStore\SportsStore\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1653, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591