#pragma checksum "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8fa2a1c8e19df7e7c7c2ec152d3448b47b62e7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchRecipes_Index), @"mvc.1.0.view", @"/Views/SearchRecipes/Index.cshtml")]
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
#line 1 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\_ViewImports.cshtml"
using MyReceipts.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\_ViewImports.cshtml"
using MyReceipts.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fa2a1c8e19df7e7c7c2ec152d3448b47b62e7f", @"/Views/SearchRecipes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f759f4a7d59e0768b13507a430ff2c094f5f3d86", @"/Views/_ViewImports.cshtml")]
    public class Views_SearchRecipes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyReceipts.Web.ViewModels.SearchRecipes.SearchIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml"
  
    ViewData["Title"] = "Search recipes by ingredient";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8fa2a1c8e19df7e7c7c2ec152d3448b47b62e7f4680", async() => {
                WriteLiteral("\r\n    <div class=\"row\"> \r\n");
#nullable restore
#line 10 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml"
         foreach (var ingredient in this.Model.Ingredients)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-1\">\r\n                <input");
                BeginWriteAttribute("id", " id=\"", 356, "\"", 386, 2);
                WriteAttributeValue("", 361, "ingredient_", 361, 11, true);
#nullable restore
#line 13 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml"
WriteAttributeValue("", 372, ingredient.Id, 372, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" name=\"Ingredients\"");
                BeginWriteAttribute("value", " value=\"", 422, "\"", 444, 1);
#nullable restore
#line 13 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml"
WriteAttributeValue("", 430, ingredient.Id, 430, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" \r\n                       class=\"form-control\" />\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 518, "\"", 549, 2);
                WriteAttributeValue("", 524, "ingredient_", 524, 11, true);
#nullable restore
#line 15 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml"
WriteAttributeValue("", 535, ingredient.Id, 535, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml"
                                                  Write(ingredient.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n");
#nullable restore
#line 17 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\SearchRecipes\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n\r\n    <button class=\"btn btn-primary\">Search</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyReceipts.Web.ViewModels.SearchRecipes.SearchIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591