#pragma checksum "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87dc72c0d5c00ededdd00052fdbeec158230c8b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/admin/Desktop/wos/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Desktop/wos/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87dc72c0d5c00ededdd00052fdbeec158230c8b8", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\n    <span><a href=\"/\">Logout</a></s></span> ");
            WriteLiteral(@"
    <title>Dashboard</title>
    <h1>Welcome to the Wedding Planner</h1>
    <div>
         <ul>
                <table>
                    <thead>
                        <th>Wedding</th>
                        <th>Date</th>
                        <th>Guest</th>
                        <th>Action</th>
                    </thead>
                    <tbody>
");
#nullable restore
#line 15 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                     if (ViewBag.AllWeddings != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                         foreach (var boda in ViewBag.AllWeddings)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td> <a");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 701, 2);
            WriteAttributeValue("", 672, "SingleWedding/", 672, 14, true);
#nullable restore
#line 20 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 686, boda.WeddingId, 686, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                                Write(boda.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 20 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                                                  Write(boda.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </td> ");
            WriteLiteral("\n                                <td>");
#nullable restore
#line 21 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                               Write(boda.date.ToString("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  ");
            WriteLiteral("\n                                <td>");
#nullable restore
#line 22 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                               Write(boda.UsersWhoRSVP.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> ");
            WriteLiteral("\n");
#nullable restore
#line 23 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                 if (boda.UserId == ViewBag.UserId)

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                                                                 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1101, "\"", 1131, 2);
            WriteAttributeValue("", 1108, "/delete/", 1108, 8, true);
#nullable restore
#line 25 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1116, boda.WeddingId, 1116, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\n");
#nullable restore
#line 26 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                }
                                else
                                {
                                    int temp = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                     foreach (var a in boda.UsersWhoRSVP)
                                    {
                                        if (a.User.UserId == ViewBag.UserId)
                                        {
                                            temp = a.AssociationId;
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                     if (temp == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1819, "\"", 1847, 2);
            WriteAttributeValue("", 1826, "/rsvp/", 1826, 6, true);
#nullable restore
#line 39 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1832, boda.WeddingId, 1832, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">RSVP</a></td>\n");
#nullable restore
#line 40 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2026, "\"", 2046, 2);
            WriteAttributeValue("", 2033, "/unrsvp/", 2033, 8, true);
#nullable restore
#line 43 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2041, temp, 2041, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Un-RSVP</a></td>\n");
#nullable restore
#line 44 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\n");
#nullable restore
#line 47 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/admin/Desktop/wos/WeddingPlanner/Views/Home/Dashboard.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n                   \n                \n            \n        </ul>\n\n    </div>\n  \n    <span><a href=\"/AddWedding\">New Wedding</a></s></span> \n</div>");
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
