#pragma checksum "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\Shared\Components\_Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497a27cb4a61cc2330f22d452056b702f9021826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
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
#line 1 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\_ViewImports.cshtml"
using Travel_Blog_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\_ViewImports.cshtml"
using Travel_Blog_Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\Shared\Components\_Testimonial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497a27cb4a61cc2330f22d452056b702f9021826", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095a4c245f3b6871b137e76482bfa214d07060d4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"

 <!-- testimonials -->
 
  <section class=""w3l-clients"" id=""clients"">
    <!-- /grids -->
    <div class=""cusrtomer-layout py-5"">
      <div class=""container py-lg-4 py-md-3 pb-lg-0"">
        <div class=""heading text-center mx-auto"">
          <h6 class=""sub-title text-center"">Here’s what they have to say</h6>
          <h3 class=""hny-title mb-md-5 mb-4"">our clients do the talking</h3>
        </div>
        <!-- /grids -->


        <div class=""testimonial-width"">
          <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
            <div class=""item"">
");
#nullable restore
#line 26 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\Shared\Components\_Testimonial\Default.cshtml"
               foreach(var item in Model)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"testimonial-content\">\r\n                <div class=\"testimonial\">\r\n                  <blockquote>\r\n                    <span class=\"fa fa-quote-left\" aria-hidden=\"true\"></span>\r\n                    \r\n                    ");
#nullable restore
#line 33 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\Shared\Components\_Testimonial\Default.cshtml"
               Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                  </blockquote>\r\n                  <div class=\"testi-des\">\r\n                    <div class=\"test-img\"><img");
            BeginWriteAttribute("src", " src=\"", 1129, "\"", 1152, 1);
#nullable restore
#line 38 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\Shared\Components\_Testimonial\Default.cshtml"
WriteAttributeValue("", 1135, item.ClientImage, 1135, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"client-img\">\r\n                    </div>\r\n                    <div class=\"peopl align-self\">\r\n                      <h3>");
#nullable restore
#line 41 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\Shared\Components\_Testimonial\Default.cshtml"
                     Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                      <p class=\"indentity\">Example City</p>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n");
#nullable restore
#line 47 "C:\Users\Şoreş\source\repos\Travel-Blog-Core\Travel-Blog-Core\Views\Shared\Components\_Testimonial\Default.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <!-- /grids -->\r\n    </div>\r\n    <!-- //grids -->\r\n  </section>\r\n\r\n\r\n\r\n\r\n           ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
