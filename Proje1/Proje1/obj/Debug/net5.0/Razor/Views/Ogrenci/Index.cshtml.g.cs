#pragma checksum "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea3d90a8f17c89e6190e61b539195d5752738da9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_Index), @"mvc.1.0.view", @"/Views/Ogrenci/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\_ViewImports.cshtml"
using Proje1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\_ViewImports.cshtml"
using Proje1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea3d90a8f17c89e6190e61b539195d5752738da9", @"/Views/Ogrenci/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592e581bfde78d21941bd0f5ec4ca1a2400740f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ogrenci_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proje1.Models.Ogrenci>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Öğrenciler</h2>\r\n<a href=\"/Ogrenci/Create\" class=\"btn btn-primary mb-3 \" title=\"Yeni Kayıt\">\r\n   Yeni Kayıt\r\n</a>\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.TCKimlikNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Adres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.AldigiEgitim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.BasariDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TCKimlikNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Adres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AldigiEgitim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BasariDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1678, "\"", 1707, 2);
            WriteAttributeValue("", 1685, "/Ogrenci/Edit/", 1685, 14, true);
#nullable restore
#line 63 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
WriteAttributeValue("", 1699, item.Id, 1699, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-xs\" title=\"Düzenle\">\r\n                    <i class=\"bi bi-pencil-fill\"></i> Düzenle\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1893, 2);
            WriteAttributeValue("", 1868, "/Ogrenci/Details/", 1868, 17, true);
#nullable restore
#line 66 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
WriteAttributeValue("", 1885, item.Id, 1885, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-xs\" title=\"Detay\">\r\n                    <i class=\"bi bi-search\"></i> Detay\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2035, "\"", 2066, 2);
            WriteAttributeValue("", 2042, "/Ogrenci/Delete/", 2042, 16, true);
#nullable restore
#line 69 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
WriteAttributeValue("", 2058, item.Id, 2058, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-xs\" title=\"Sil\">\r\n                    <i class=\"bi bi-trash-fill\"></i> Sil\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proje1.Models.Ogrenci>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
