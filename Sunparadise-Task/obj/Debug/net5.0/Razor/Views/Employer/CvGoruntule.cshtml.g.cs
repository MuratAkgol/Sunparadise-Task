#pragma checksum "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fb1beae5384254ff9b2a581074779110aeb6ac3"
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
#line 1 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\_ViewImports.cshtml"
using Sunparadise_Task;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\_ViewImports.cshtml"
using Sunparadise_Task.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fb1beae5384254ff9b2a581074779110aeb6ac3", @"/Views/Employer/CvGoruntule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e0a5f791371bc03df56e0043476461f1c7eeb3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employer_CvGoruntule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CvTable>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
  
    Layout = "~/Views/Shared/AfterLoginEmployer.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
 foreach(var item in Model){
   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-3 mt-2\">\r\n            <div class=\"card mt-2\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                                      Write(item.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
            WriteLiteral("                    <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                                    Write(item.Deneyim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                                    Write(item.Eğitim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
                                    Write(item.Sertifikalar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\huawei\Desktop\Sunparadise-Task\Sunparadise-Task\Views\Employer\CvGoruntule.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CvTable>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
