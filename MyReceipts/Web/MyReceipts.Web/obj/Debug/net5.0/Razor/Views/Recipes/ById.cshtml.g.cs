#pragma checksum "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8577437f006ec9016a3f6b78aea873f3d74d270b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_ById), @"mvc.1.0.view", @"/Views/Recipes/ById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8577437f006ec9016a3f6b78aea873f3d74d270b", @"/Views/Recipes/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f759f4a7d59e0768b13507a430ff2c094f5f3d86", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyReceipts.Web.ViewModels.Recipes.SingleRecipeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("antiForgetyForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
  
    this.ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"single-recipe-layout1\">\r\n    <div class=\"ctg-name\">");
#nullable restore
#line 8 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                     Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <h2 class=\"item-title\">");
#nullable restore
#line 9 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                      Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"row mb-4\">\r\n        <div class=\"col-xl-9 col-12\">\r\n            <ul class=\"entry-meta\">\r\n                <li class=\"single-meta\">\r\n                    <i class=\"far fa-calendar-alt\"></i>\r\n                    ");
#nullable restore
#line 15 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
               Write(Model.CreatedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"single-meta\">\r\n\r\n                    <i class=\"fas fa-user\"></i>by\r\n");
#nullable restore
#line 20 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                     if (string.IsNullOrWhiteSpace(Model.AddedbyUserEmail))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 769, "\"", 794, 1);
#nullable restore
#line 22 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 776, Model.OriginalUrl, 776, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">by recepti.gotvach.bg</a>\r\n");
#nullable restore
#line 23 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 26 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                         Write(Model.AddedbyUserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 27 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </li>
                <li class=""single-meta"">
                    <ul class=""item-rating"">
                        <li class=""star-fill"" data-vote=""1""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill"" data-vote=""2""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill"" data-vote=""3""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill"" data-vote=""4""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill"" data-vote=""5""><i class=""fas fa-star""></i></li>
                        <li><span id=""averageVoteValue"">");
#nullable restore
#line 36 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                                   Write(Model.AverageVote.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span> / 5</span></li>\r\n                    </ul>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"item-figure\">\r\n            <img class=\"img-fluid w-100\"");
            BeginWriteAttribute("src", " src=\"", 1861, "\"", 1882, 1);
#nullable restore
#line 43 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 1867, Model.ImageUrl, 1867, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1883, "\"", 1900, 1);
#nullable restore
#line 43 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 1889, Model.Name, 1889, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
        <div class=""item-feature"">
            <ul>
                <li>
                    <div class=""feature-wrap"">
                        <div class=""media"">
                            <div class=""feature-icon"">
                                <i class=""far fa-clock""></i>
                            </div>
                            <div class=""media-body space-sm"">
                                <div class=""feature-title"">PREP TIME</div>
                                <div class=""feature-sub-title"">");
#nullable restore
#line 55 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                                          Write(Model.PeparationTime.TotalMinutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Mins</div>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class=""feature-wrap"">
                        <div class=""media"">
                            <div class=""feature-icon"">
                                <i class=""fas fa-utensils""></i>
                            </div>
                            <div class=""media-body space-sm"">
                                <div class=""feature-title"">COOK TIME</div>
                                <div class=""feature-sub-title"">");
#nullable restore
#line 68 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                                          Write(Model.CookingTime.TotalMinutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Mins</div>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class=""feature-wrap"">
                        <div class=""media"">
                            <div class=""feature-icon"">
                                <i class=""fas fa-users""></i>
                            </div>
                            <div class=""media-body space-sm"">
                                <div class=""feature-title"">SERVING</div>
                                <div class=""feature-sub-title"">
                                    ");
#nullable restore
#line 82 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                               Write(Model.PortionCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                     if (Model.PortionCount == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Person</span>\r\n");
#nullable restore
#line 86 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>People</span>\r\n");
#nullable restore
#line 90 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class=""feature-wrap"">
                        <div class=""media"">
                            <div class=""feature-icon"">
                                <i class=""fa fa-list-ol""></i>
                            </div>
                            <div class=""media-body space-sm"">
                                <div class=""feature-title"">CATEGORY RECIEPES</div>
                                <div class=""feature-sub-title"">");
#nullable restore
#line 104 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                                          Write(Model.CategoryRecipesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
        <div class=""making-elements-wrap"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <p class=""item-description"">
                        ");
#nullable restore
#line 115 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                   Write(Model.Instructions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"ingridients-wrap\">\r\n                        <h3 class=\"item-title\"><i class=\"fas fa-list-ul\"></i>Ingridients</h3>\r\n");
#nullable restore
#line 122 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                         foreach (var ingredient in Model.Ingredients)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"checkbox checkbox-primary\">\r\n                                <label for=\"checkbox1\">");
#nullable restore
#line 125 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                                  Write(ingredient.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 125 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                                                                       Write(ingredient.IngredientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 127 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8577437f006ec9016a3f6b78aea873f3d74d270b17031", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\"li[data-vote]\").each(function (el) {\r\n            $(this).click(function () {\r\n                var vote = $(this).attr(\"data-vote\");\r\n                var recipeId =");
#nullable restore
#line 141 "C:\Users\mojit\OneDrive\Работен плот\.NET\ASP.NET Core\Solutions\My-Receipts\MyReceipts\Web\MyReceipts.Web\Views\Recipes\ById.cshtml"
                         Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                var antiForgeryToken = $('#antiForgetyForm input[name=_RequestVerificationToken]').val;
                var data = { recipeId: recipeId, value: value };
                $.ajax({
                    type: ""POST"",
                    url: ""/api/Votes"",
                    data: JSON.stringify(data),
                    headers: {
                        ""X-CSRF-TOKEN"": antiForgeryToken
                    },
                    success: function (data)
                    {
                        $(""#averageVoteValue"").html(data.averageVote.toFixed(1));
                    },
                    contentType:'applicatiom/json',

                });

            });
        });
    </script>


");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyReceipts.Web.ViewModels.Recipes.SingleRecipeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
