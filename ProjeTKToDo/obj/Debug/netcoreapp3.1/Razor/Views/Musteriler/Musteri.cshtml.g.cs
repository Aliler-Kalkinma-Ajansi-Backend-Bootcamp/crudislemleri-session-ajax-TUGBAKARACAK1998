#pragma checksum "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b442f668a63afe4412e8c54c91d1751037b5d4f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musteriler_Musteri), @"mvc.1.0.view", @"/Views/Musteriler/Musteri.cshtml")]
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
#line 1 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\_ViewImports.cshtml"
using ProjeTKToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\_ViewImports.cshtml"
using ProjeTKToDo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b442f668a63afe4412e8c54c91d1751037b5d4f9", @"/Views/Musteriler/Musteri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a755dbb199018ef6cb734e5c39e81f8c91a5f882", @"/Views/_ViewImports.cshtml")]
    public class Views_Musteriler_Musteri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Musteriler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--");
#nullable restore
#line 3 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
  
    ViewData["Title"] = "Musteri";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<!--<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>List</title>\r\n</head>\r\n<body>\r\n    <p>\r\n        ");
#nullable restore
#line 42 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
   Write(Html.ActionLink("Create New", "Insert"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <table>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Ad</th>\r\n            <th>Soyad</th>\r\n            <th>Email</th>\r\n            <th>Sil</th>\r\n            <th>Guncelle</th>\r\n\r\n        </tr>\r\n\r\n");
#nullable restore
#line 55 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
               Write(Html.DisplayFor(modelItem => item.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n              \r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                 \r\n                    ");
#nullable restore
#line 74 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new {  id=item.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 77 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Musteriler\Musteri.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</body>\r\n</html>-->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Musteriler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
