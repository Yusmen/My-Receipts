#pragma checksum "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a630039aa8f3428a11a1cb881f230e20ec6da74b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_All), @"mvc.1.0.view", @"/Views/Recipes/All.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a630039aa8f3428a11a1cb881f230e20ec6da74b", @"/Views/Recipes/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f759f4a7d59e0768b13507a430ff2c094f5f3d86", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyReceipts.Web.ViewModels.Recipes.RecipesListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
  
    this.ViewData["Title"] = "All Recipes Page...";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
     foreach (var recipe in this.Model.Recipes)
    {
        if (recipe != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex  row-cols-md-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 345, "\"", 367, 1);
#nullable restore
#line 14 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
WriteAttributeValue("", 351, recipe.ImageUrl, 351, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" width=\"100\" class=\"mr-3 img-responsive\">\r\n                <div class=\"media=body\">\r\n                    <h5 class=\"mt-0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a630039aa8f3428a11a1cb881f230e20ec6da74b5785", async() => {
#nullable restore
#line 16 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                                               Write(recipe.Name);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 16 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                            WriteLiteral(recipe.Id);

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
            WriteLiteral("</h5>\r\n                    ");
#nullable restore
#line 17 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
               Write(recipe.CategotyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<nav class=\"mx-auto\" aria-label=\"...\">\r\n    <ul class=\"pagination justify-content-center\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 791, "\"", 863, 3);
            WriteAttributeValue("", 799, "page-item", 799, 9, true);
            WriteAttributeValue(" ", 808, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 28 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                              if (!Model.HasPreviousPage) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 28 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                                                 }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 809, 53, false);
            WriteAttributeValue(" ", 862, "", 863, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a630039aa8f3428a11a1cb881f230e20ec6da74b10218", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                    WriteLiteral(Model.PreviousPageNumber);

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
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 31 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
         for (int i = Model.PageNumber - 3; i < Model.PageNumber; i++)
        {
            if (i > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a630039aa8f3428a11a1cb881f230e20ec6da74b12958", async() => {
#nullable restore
#line 35 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                                              WriteLiteral(i);

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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 36 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <li class=\"page-item active\" aria-current=\"page\">\r\n            ");
#nullable restore
#line 40 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
       Write(Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"page-link\">2</span>\r\n        </li>\r\n");
#nullable restore
#line 43 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
         for (int i = Model.PageNumber + 1; i <= Model.PageNumber + 3; i++)
        {
            if (i <= Model.PagesCount)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a630039aa8f3428a11a1cb881f230e20ec6da74b16679", async() => {
#nullable restore
#line 47 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                                              WriteLiteral(i);

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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 48 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 1684, "\"", 1752, 2);
            WriteAttributeValue("", 1692, "page-item", 1692, 9, true);
            WriteAttributeValue("  ", 1701, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 51 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                               if (!Model.HasNextPage) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 51 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                                              }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1703, 49, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a630039aa8f3428a11a1cb881f230e20ec6da74b20675", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\All.cshtml"
                                                    WriteLiteral(Model.NextPageNumber);

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
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyReceipts.Web.ViewModels.Recipes.RecipesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
