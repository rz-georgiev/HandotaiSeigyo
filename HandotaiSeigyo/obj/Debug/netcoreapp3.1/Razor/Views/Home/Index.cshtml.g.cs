#pragma checksum "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f57a7464ccd19c72f3c60cc164bd55eb3b42e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\_ViewImports.cshtml"
using HandotaiSeigyo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\_ViewImports.cshtml"
using HandotaiSeigyo.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f57a7464ccd19c72f3c60cc164bd55eb3b42e1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92ae62d5c8f1e793fca2419b2af122af55ec1d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandotaiSeigyo.ViewModels.Home.PostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 9 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
 for (var index = 0; index < Model.PostLists.Count; index++)
{
    var list = Model.PostLists.ElementAtOrDefault(index);
    if (list == null || list.Count < 1)
        continue;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 306, "\"", 343, 2);
            WriteAttributeValue("", 311, "carouselExampleIndicators_", 311, 26, true);
#nullable restore
#line 15 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
WriteAttributeValue("", 337, index, 337, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"4000\">\r\n        <ol class=\"carousel-indicators\">\r\n            <li data-target=\"#carouselExampleIndicators_");
#nullable restore
#line 17 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"0\" class=\"active\"></li>\r\n\r\n");
#nullable restore
#line 19 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
             for (var innerIndex = 1; innerIndex < list.Count(); innerIndex++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators_");
#nullable restore
#line 21 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                       Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 21 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                                              Write(innerIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 22 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 25 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
               var defaultItem = list.FirstOrDefault(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"carousel-item active\">\r\n                <div class=\"card mb-3\">\r\n                    <div class=\"row no-gutters\">\r\n                        <div class=\"col-md-4\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1104, "\"", 1132, 1);
#nullable restore
#line 30 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1110, defaultItem.ImagePath, 1110, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\"");
            BeginWriteAttribute("alt", " alt=\"", 1150, "\"", 1173, 1);
#nullable restore
#line 30 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1156, defaultItem.Name, 1156, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\">\r\n                        </div>\r\n                        <div class=\"col-md-8\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 34 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                  Write(defaultItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 35 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                Write(defaultItem.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 36 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                                          Write(defaultItem.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
             for (var innerIndex = 1; innerIndex < list.Count(); innerIndex++)
            {
                var item = list.ElementAtOrDefault(innerIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    <div class=\"card mb-3\">\r\n                        <div class=\"row no-gutters\">\r\n                            <div class=\"col-md-4\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2131, "\"", 2152, 1);
#nullable restore
#line 49 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
WriteAttributeValue("", 2137, item.ImagePath, 2137, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\"");
            BeginWriteAttribute("alt", " alt=\"", 2170, "\"", 2186, 1);
#nullable restore
#line 49 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
WriteAttributeValue("", 2176, item.Name, 2176, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\">\r\n                            </div>\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 53 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 54 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 55 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
                                                                              Write(item.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 61 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <a class=\"carousel-control-prev\"");
            BeginWriteAttribute("href", " href=\"", 2846, "\"", 2886, 2);
            WriteAttributeValue("", 2853, "#carouselExampleIndicators_", 2853, 27, true);
#nullable restore
#line 63 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
WriteAttributeValue("", 2880, index, 2880, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\r\n            <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"sr-only\">Previous</span>\r\n        </a>\r\n        <a class=\"carousel-control-next\"");
            BeginWriteAttribute("href", " href=\"", 3108, "\"", 3148, 2);
            WriteAttributeValue("", 3115, "#carouselExampleIndicators_", 3115, 27, true);
#nullable restore
#line 67 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
WriteAttributeValue("", 3142, index, 3142, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"next\">\r\n            <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"sr-only\">Next</span>\r\n        </a>\r\n    </div>\r\n");
#nullable restore
#line 72 "E:\Development\HandotaiSeigyo\HandotaiSeigyo\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandotaiSeigyo.ViewModels.Home.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
