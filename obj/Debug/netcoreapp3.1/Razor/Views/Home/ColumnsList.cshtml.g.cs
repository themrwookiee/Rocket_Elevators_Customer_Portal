#pragma checksum "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b9679045069c032966e411368e8653c9e0d8ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ColumnsList), @"mvc.1.0.view", @"/Views/Home/ColumnsList.cshtml")]
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
#line 1 "E:\Git\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Git\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b9679045069c032966e411368e8653c9e0d8ea", @"/Views/Home/ColumnsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43fdba9ec3567df5250e21f4feb7b14e91ed237", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ColumnsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
  
    ViewData["Title"] = "Columns";
    var l = ViewBag.columns;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-6"">
            <h2>Columns</h2>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-6"">
            <table id=""productTable"" class=""table table-bordered table-condensed table-striped"">
                <thead>
                    <tr>
                        <th>Column ID</th>
                        <th>Column Type</th>
                        <th>Column Status</th>
                        <th>Number of Floors Served</th>
                        <th>Information</th>
                        <th>Notes</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 28 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
                     foreach (var column in l )
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 31 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
                           Write(column.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
                           Write(column.ColumnType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
                           Write(column.ColumnStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
                           Write(column.NumberOfFloorsServed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
                           Write(column.Information);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
                           Write(column.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 38 "E:\Git\Rocket_Elevators_Customer_Portal\Views\Home\ColumnsList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591