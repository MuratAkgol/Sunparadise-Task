#pragma checksum "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6e4968b711923148d85c759116bd99d002ef867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 7 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e4968b711923148d85c759116bd99d002ef867", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e0a5f791371bc03df56e0043476461f1c7eeb3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IsIlanı>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
  
    Layout = "~/Views/Shared/AfterLoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <script>\r\n        \r\n    \r\n        var alertMessage = \'");
#nullable restore
#line 14 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
                       Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        if (alertMessage) {\r\n            alert(alertMessage);\r\n        \r\n    }\r\n    </script>\r\n\r\n\r\n\r\n    <h3>En son yayınlanan ilanlar</h3>\r\n    <hr />\r\n<div class=\"row\" id=\"card\">\r\n");
#nullable restore
#line 26 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 col-sm-6 mt-2\">\r\n            <div class=\"card mt-2\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 34 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
                                      Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <hr>\r\n");
            WriteLiteral("                    <p class=\"card-text\"><h6>İş hakkında:</h6> ");
#nullable restore
#line 37 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
                                                          Write(item.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\"><h6>Çalışma Türü:</h6> ");
#nullable restore
#line 38 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
                                                           Write(item.CalismaTuru);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h6 class=\"card-text\">");
#nullable restore
#line 39 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
                                     Write(item.IsVerenAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <a class=\"btn btn-success\" name=\"IsId\"");
            BeginWriteAttribute("href", " href=\"", 1205, "\"", 1233, 2);
            WriteAttributeValue("", 1212, "/User/Basvur/", 1212, 13, true);
#nullable restore
#line 40 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
WriteAttributeValue("", 1225, item.ID, 1225, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Başvur</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\murat\Desktop\Sunparadise\Sunparadise-Task\Sunparadise-Task\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IsIlanı>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
