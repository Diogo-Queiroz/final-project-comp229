#pragma checksum "C:\repos\Final-Project-Comp229\Recipes\Views\Review\ViewReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffee9b7b8d13dcbde7082993cb4c1644a5952a43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review_ViewReview), @"mvc.1.0.view", @"/Views/Review/ViewReview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Review/ViewReview.cshtml", typeof(AspNetCore.Views_Review_ViewReview))]
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
#line 2 "C:\repos\Final-Project-Comp229\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
#line 3 "C:\repos\Final-Project-Comp229\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffee9b7b8d13dcbde7082993cb4c1644a5952a43", @"/Views/Review/ViewReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dcc75e1e9dff7c10c711390a49b95a8f56239ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Review_ViewReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Recipes.Models.Review>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\repos\Final-Project-Comp229\Recipes\Views\Review\ViewReview.cshtml"
  
    ViewData["Title"] = "ViewReview";

#line default
#line hidden
            BeginContext(88, 87, true);
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n\r\n\r\n        <h1 class=\"center-div\">Reviews:</h1>\r\n\r\n\r\n");
            EndContext();
#line 13 "C:\repos\Final-Project-Comp229\Recipes\Views\Review\ViewReview.cshtml"
          
        int i = 1;
        foreach (Review p in Model)
        {

#line default
#line hidden
            BeginContext(255, 16, true);
            WriteLiteral("            <h3>");
            EndContext();
            BeginContext(272, 1, false);
#line 17 "C:\repos\Final-Project-Comp229\Recipes\Views\Review\ViewReview.cshtml"
           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(273, 44, true);
            WriteLiteral(" - <span style=\"text-decoration: underline\">");
            EndContext();
            BeginContext(318, 13, false);
#line 17 "C:\repos\Final-Project-Comp229\Recipes\Views\Review\ViewReview.cshtml"
                                                         Write(p.ReviewTitle);

#line default
#line hidden
            EndContext();
            BeginContext(331, 31, true);
            WriteLiteral(" </span> </h3>\r\n            <p>");
            EndContext();
            BeginContext(363, 12, false);
#line 18 "C:\repos\Final-Project-Comp229\Recipes\Views\Review\ViewReview.cshtml"
          Write(p.ReviewText);

#line default
#line hidden
            EndContext();
            BeginContext(375, 26, true);
            WriteLiteral("</p>\r\n            <hr />\r\n");
            EndContext();
#line 20 "C:\repos\Final-Project-Comp229\Recipes\Views\Review\ViewReview.cshtml"
            i++;
        }
        

#line default
#line hidden
            BeginContext(441, 16, true);
            WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Recipes.Models.Review>> Html { get; private set; }
    }
}
#pragma warning restore 1591
