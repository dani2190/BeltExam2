#pragma checksum "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac386b42d76916bc6ccd48c9932cb7107279d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 1 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/_ViewImports.cshtml"
using BeltExam2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/_ViewImports.cshtml"
using BeltExam2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac386b42d76916bc6ccd48c9932cb7107279d61", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ebe52704f92416eecb1ad36f04801210d7a366", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DojoActivity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"jumbotron\">\n    <h1>Dojo Activity Center</h1>\n    \n    <h3>Hello! Welcome back, ");
#nullable restore
#line 5 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                        Write(ViewBag.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    <a href=""/Logout"" role=""button"" class=""btn btn-danger"">Logout</a>
</div>
<table class=""table table-dark"">
    <thead>
        <tr>
            <th>Activity</th>
            <th>Date and Time</th>
            <th>Duration</th>
            <th>Event Coordinator</th>
            <th>No. of Participants</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
         foreach( var a in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 608, "\"", 640, 2);
            WriteAttributeValue("", 615, "/single/", 615, 8, true);
#nullable restore
#line 23 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
WriteAttributeValue("", 623, a.DojoActivityId, 623, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                                                   Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                <td>");
#nullable restore
#line 24 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
               Write(a.ActivityDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
               Write(a.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                       Write(a.StringTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
               Write(a.Creator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
               Write(a.ActivityList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n");
#nullable restore
#line 29 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                     if( a.Creator.UserId == ViewBag.User.UserId)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 976, "\"", 1008, 2);
            WriteAttributeValue("", 983, "/cancel/", 983, 8, true);
#nullable restore
#line 31 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
WriteAttributeValue("", 991, a.DojoActivityId, 991, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-danger\">Delete</a>\n");
#nullable restore
#line 32 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                         if(a.ActivityList.All(t => t.UserId != ViewBag.User.UserId))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1269, "\"", 1320, 4);
            WriteAttributeValue("", 1276, "/join/", 1276, 6, true);
#nullable restore
#line 37 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
WriteAttributeValue("", 1282, a.DojoActivityId, 1282, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1299, "/", 1299, 1, true);
#nullable restore
#line 37 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
WriteAttributeValue("", 1300, ViewBag.User.UserId, 1300, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-success\">Join</a>\n");
#nullable restore
#line 38 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                         if (a.ActivityList.Any(t=> t.UserId == ViewBag.User.UserId))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1537, "\"", 1589, 4);
            WriteAttributeValue("", 1544, "/leave/", 1544, 7, true);
#nullable restore
#line 41 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
WriteAttributeValue("", 1551, a.DojoActivityId, 1551, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1568, "/", 1568, 1, true);
#nullable restore
#line 41 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
WriteAttributeValue("", 1569, ViewBag.User.UserId, 1569, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-warning\">Leave</a>\n");
#nullable restore
#line 42 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 46 "/Users/danielgatabazi/Desktop/CSharp3/BeltExam2/BeltExam2/Views/Home/Home.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n    </tbody>\n</table>\n<a href=\"/NewActivity\" class=\"btn btn-primary\">Add Activity</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DojoActivity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
