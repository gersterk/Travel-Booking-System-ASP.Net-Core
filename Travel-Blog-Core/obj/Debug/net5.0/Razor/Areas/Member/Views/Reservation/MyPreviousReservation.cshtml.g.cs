#pragma checksum "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beca475721e6316b151a72b15f1694340ad9fc4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyPreviousReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyPreviousReservation.cshtml")]
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
#line 1 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\_ViewImports.cshtml"
using Travel_Blog_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\_ViewImports.cshtml"
using Travel_Blog_Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beca475721e6316b151a72b15f1694340ad9fc4e", @"/Areas/Member/Views/Reservation/MyPreviousReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095a4c245f3b6871b137e76482bfa214d07060d4", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyPreviousReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
  
    ViewData["Title"] = "MyPreviousReservation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MyPreviousReservation</h1>\r\n\r\n\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Location</th>\r\n        <th>Number of Person</th>\r\n        <th>Reservation Date</th>\r\n        <th>Statu</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
           Write(item.ReservationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
           Write(item.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Areas\Member\Views\Reservation\MyPreviousReservation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591