#pragma checksum "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "491318748886e6af41f149dfd8a4c322278e61fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urunler_Index), @"mvc.1.0.view", @"/Views/Urunler/Index.cshtml")]
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
#line 1 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"491318748886e6af41f149dfd8a4c322278e61fd", @"/Views/Urunler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a755dbb199018ef6cb734e5c39e81f8c91a5f882", @"/Views/_ViewImports.cshtml")]
    public class Views_Urunler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Urunler>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
  
    ViewData["Title"] = "Urunler";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "491318748886e6af41f149dfd8a4c322278e61fd3693", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>List</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "491318748886e6af41f149dfd8a4c322278e61fd4751", async() => {
                WriteLiteral(@"

    <table class=""table table-bordered"">
        <tr>
            <th>Id</th>
            <th>Ürün Adı</th>
            <th>Ürün Kategorisi</th>
            <th>Ürün Fiyatı</th>
            <th>Ürün Stok Sayısı</th>
            <th>Güncelle</th>
            <th>Sil</th>


        </tr>

");
#nullable restore
#line 32 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UrunId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Urunad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UrunKategori));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UrunFiyat));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UrunStokSayisi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
               Write(Html.ActionLink("Güncelle", "Guncelle", new { id =item.UrunId }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
               Write(Html.ActionLink("Sil", "Sil", new { id = item.UrunId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\tubak\source\repos\Proje\ProjeTKToDo\Views\Urunler\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <p>\r\n     \r\n        <a href=\"/Urunler/UrunEkle\" class=\"btn btn-primary\">Ürün Ekle</a>\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Urunler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
