#pragma checksum "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e11856063ea8160ae773dc15b82a3f3a354c6cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_Delete), @"mvc.1.0.view", @"/Views/Ogrenci/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11856063ea8160ae773dc15b82a3f3a354c6cb6", @"/Views/Ogrenci/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592e581bfde78d21941bd0f5ec4ca1a2400740f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ogrenci_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proje1.Models.Ogrenci>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"baslik\">Kayıt Sil</h2>\r\n\r\n<h3>Silmek istediğinize emin misiniz?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TCKimlikNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TCKimlikNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Adres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Adres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 50 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 55 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-actions no-color"">
            <input type=""submit"" value=""Delete"" class=""btn btn-danger"" />
            <a href=""/Ogrenci/Index"" class=""btn btn-primary"">
                <i class=""bi bi-backspace-fill""></i> Listeye Dön
            </a>
        </div>
");
#nullable restore
#line 65 "C:\Users\Admin\Desktop\OBS\Proje1\Proje1\Views\Ogrenci\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proje1.Models.Ogrenci> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591