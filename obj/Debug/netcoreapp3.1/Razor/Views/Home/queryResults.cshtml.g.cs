#pragma checksum "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b1b44bb490292f553255ce4d2670e45a257da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_queryResults), @"mvc.1.0.view", @"/Views/Home/queryResults.cshtml")]
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
#line 1 "/home/slick/Documents/nbaMVC/Views/_ViewImports.cshtml"
using nbaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
using nbaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b1b44bb490292f553255ce4d2670e45a257da3", @"/Views/Home/queryResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35801dd8bcc46dd0e1843d9054b2153681356408", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_queryResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<queryDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
  
    ViewData["Title"] = "query results";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"text-center\">\n    <table>\n        <tr>\n            <th>Date</th>\n");
#nullable restore
#line 12 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
             foreach(var cat in Model.catValues){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>");
#nullable restore
#line 13 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
               Write(cat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 14 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n");
#nullable restore
#line 16 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
             foreach(var dict in Model.results){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n");
#nullable restore
#line 18 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
                 foreach(var value in dict){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 19 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
               Write(value.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 20 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n");
#nullable restore
#line 22 "/home/slick/Documents/nbaMVC/Views/Home/queryResults.cshtml"
            }   

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>    \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<queryDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
