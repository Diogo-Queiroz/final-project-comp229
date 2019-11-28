#pragma checksum "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bbcbefc69d1f0b05953ebaf4af3f7880aab59f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_List), @"mvc.1.0.view", @"/Views/Recipe/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/List.cshtml", typeof(AspNetCore.Views_Recipe_List))]
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
#line 2 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
#line 3 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bbcbefc69d1f0b05953ebaf4af3f7880aab59f2", @"/Views/Recipe/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dcc75e1e9dff7c10c711390a49b95a8f56239ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipesListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 594, true);
            WriteLiteral(@"
<div class=""container"">

    <div class=""container"">
        <div class=""center-div"">
            <p>
                <h1>Recipes</h1>
            </p>
        </div>


        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Recipe Name:</th>
                    <th scope=""col"">Serves</th>
                    <th scope=""col"">Cooking Time</th>
                    <th scope=""col"">Details</th>


                </tr>
            </thead>
            <tbody>


");
            EndContext();
#line 28 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml"
                  
                    int i = 1;
                    foreach (var p in Model.Recipes)
                    {

#line default
#line hidden
            BeginContext(752, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(815, 1, false);
#line 33 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml"
                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(816, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(856, 6, false);
#line 34 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml"
                           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(862, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(902, 15, false);
#line 35 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml"
                           Write(p.ServingNumber);

#line default
#line hidden
            EndContext();
            BeginContext(917, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(957, 13, false);
#line 36 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml"
                           Write(p.CookingTime);

#line default
#line hidden
            EndContext();
            BeginContext(970, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1009, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a934f419a07c44e3b159928b4712db1d", async() => {
                BeginContext(1076, 7, true);
                WriteLiteral("Details");
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
#line 37 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml"
                                                                                 WriteLiteral(p.Id);

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
            BeginContext(1087, 40, true);
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 40 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml"
                        i++;
                    }
                

#line default
#line hidden
            BeginContext(1199, 58, true);
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n\r\n        <div");
            EndContext();
            BeginWriteAttribute("page-model", " page-model=\"", 1257, "\"", 1287, 1);
#line 48 "C:\repos\Centennial-Projects\COMP-229\Final-Project\Recipes\Views\Recipe\List.cshtml"
WriteAttributeValue("", 1270, Model.PagingInfo, 1270, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1288, 48, true);
            WriteLiteral(" page-action=\"List\"></div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591