#pragma checksum "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a14eac0e2bb6714eb2af94b2a7b890b9955a74c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employer_CvGoruntule), @"mvc.1.0.view", @"/Views/Employer/CvGoruntule.cshtml")]
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
#line 1 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\_ViewImports.cshtml"
using Sunparadise_Task;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\_ViewImports.cshtml"
using Sunparadise_Task.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a14eac0e2bb6714eb2af94b2a7b890b9955a74c0", @"/Views/Employer/CvGoruntule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e0a5f791371bc03df56e0043476461f1c7eeb3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employer_CvGoruntule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CvTablosu>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
  
    Layout = "~/Views/Shared/AfterLoginEmployer.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<p>
    <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
        Filtrele
    </button>
</p>
<div class=""collapse"" id=""collapseExample"">
    <div class=""card card-body"">
        <div class=""row"">
            <div class=""col""><p>Filtrelenecek Sözcüğü giriniz: &nbsp; <input type=""text"" id=""AdSoyad"" /></p></div>
");
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row\" id=\"card\">\r\n");
#nullable restore
#line 29 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-3 mt-2\">\r\n            <div class=\"card mt-2\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 34 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                                      Write(item.IsimSoyisim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 35 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                     foreach (var deneyim in item.Deneyimler)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><b>Çalıştığı Şirket</b> <br/> ");
#nullable restore
#line 37 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                                                    Write(deneyim.FirmaAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Pozisyonu</b><br />");
#nullable restore
#line 38 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                                            Write(deneyim.Pozisyon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <hr />\r\n");
#nullable restore
#line 40 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<script>
    $(document).ready(function () {
        $(""#AdSoyad"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#card div"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            })
        })
    })
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CvTablosu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
