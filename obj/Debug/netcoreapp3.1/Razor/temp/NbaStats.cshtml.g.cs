#pragma checksum "/home/slick/Documents/nbaMVC/temp/NbaStats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "554b4916ff57915ffe0778adb9082d7c03694306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.temp_NbaStats), @"mvc.1.0.view", @"/temp/NbaStats.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554b4916ff57915ffe0778adb9082d7c03694306", @"/temp/NbaStats.cshtml")]
    public class temp_NbaStats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/slick/Documents/nbaMVC/temp/NbaStats.cshtml"
  
    ViewData["Title"] = "Nba Stats Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">This is the Nba stats page where we\'ll put html forms to create queries to the nba db</h1>\n</div>\n");
#nullable restore
#line 8 "/home/slick/Documents/nbaMVC/temp/NbaStats.cshtml"
 using (Html.BeginForm("createQuery")){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<form>
    Player First Name <input type=""text"" id=""name1"">
    Player Last Name <input type=""text"" id=""name2"">
    Season <select id=""season"" name=""season"">
            <option value='all'>All</option>
            <option value='1980-1981'>1981-1982</option>
            <option value='1981-1982'>1982-1983</option>
            <option value='1982-1983'>1983-1984</option>
            <option value='1984-1985'>1984-1985</option>
            <option value='1985-1986'>1985-1986</option>
            <option value='1986-1987'>1986-1987</option>
            <option value='1987-1988'>1987-1988</option>
            <option value='1988-1989'>1988-1989</option>
            <option value='1989-1990'>1989-1990</option>
            <option value='1990-1991'>1990-1991</option>
            <option value='1991-1992'>1991-1992</option>
            <option value='1992-1993'>1992-1993</option>
            <option value='1993-1994'>1993-1994</option>
            <option value='1994-1995'>1994-1995</option>
            <option val");
            WriteLiteral(@"ue='1995-1996'>1995-1996</option>
            <option value='1996-1997'>1996-1997</option>
            <option value='1997-1998'>1997-1998</option>
            <option value='1998-1999'>1998-1999</option>
            <option value='1999-2000'>1999-2000</option>
            <option value='2000-2001'>2000-2001</option>
            <option value='2001-2002'>2001-2002</option>
            <option value='2002-2003'>2002-2003</option>
            <option value='2003-2004'>2003-2004</option>
            <option value='2004-2005'>2004-2005</option>
            <option value='2005-2006'>2005-2006</option>
            <option value='2006-2007'>2006-2007</option>
            <option value='2008-2009'>2008-2009</option>
            <option value='2008-2009'>2008-2009</option>
            <option value='2009-2010'>2009-2010</option>
            <option value='2010-2011'>2010-2011</option>
            <option value='2011-2012'>2011-2012</option>
            <option value='2012-2013'>2012-2013</option>
            <option v");
            WriteLiteral(@"alue='2013-2014'>2013-2014</option>
            <option value='2014-2015'>2014-2015</option>
            <option value='2015-2016'>2015-2016</option>
            <option value='2016-2017'>2016-2017</option>
            <option value='2017-2018'>2017-2018</option>
            <option value='2018-2019'>2018-2019</option>
            <option value='2019-2020'>2019-2020</option>            
            </select>
            <br><br>
            Statistical Categories
            <br><br>
            <input type=""checkbox"" id='pts'> PTS <br>
            <input type=""checkbox"" id='reb'> REB <br>
            <input type=""checkbox"" id='3fgm'> 3FGM <br>
            <input type=""checkbox"" id='ast'> AST <br>
            <input type=""checkbox"" id='stl'> STL <br>
            <input type=""checkbox"" id='blk'> BLK <br>
            <input type=""checkbox"" id='tov'> TOV <br>
            <input type=""checkbox"" id='mins'> MINS <br>
            <br><br>
            <input type='submit' value='run'>
</form>
");
#nullable restore
#line 68 "/home/slick/Documents/nbaMVC/temp/NbaStats.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591