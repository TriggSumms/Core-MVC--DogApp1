#pragma checksum "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5ee35c7b00ff816a6dbf0b1c735c34ad15dc311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owners_Index), @"mvc.1.0.view", @"/Views/Owners/Index.cshtml")]
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
#line 1 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\_ViewImports.cshtml"
using DogWalk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\_ViewImports.cshtml"
using DogWalk.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ee35c7b00ff816a6dbf0b1c735c34ad15dc311", @"/Views/Owners/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbff4a587dfd87fa6669ec4fd82d7215b06f3a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Owners_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DogWalk.Models.Owner>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Owners LIST!</h1>\r\n\r\n<p>\r\n");
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n\r\n                ");
#nullable restore
#line 55 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 56 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 57 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\stsum\workspace\DogsWalkMVC\Core-MVC--DogApp1\DogWalk-ASPNET-MVCExample\Views\Owners\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DogWalk.Models.Owner>> Html { get; private set; }
    }
}
#pragma warning restore 1591
