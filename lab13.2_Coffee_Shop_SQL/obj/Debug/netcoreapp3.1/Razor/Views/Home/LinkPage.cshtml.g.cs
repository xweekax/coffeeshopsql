#pragma checksum "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\Home\LinkPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8538ee195b981af6c12bd822cb1f1f857c2587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LinkPage), @"mvc.1.0.view", @"/Views/Home/LinkPage.cshtml")]
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
#line 1 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\_ViewImports.cshtml"
using lab13._2_Coffee_Shop_SQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\_ViewImports.cshtml"
using lab13._2_Coffee_Shop_SQL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de8538ee195b981af6c12bd822cb1f1f857c2587", @"/Views/Home/LinkPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c52761768ea47315e1f195be296b67973ad7495", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LinkPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\Home\LinkPage.cshtml"
  
    ViewData["Title"] = "LinkPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .hide {\r\n        display: none;\r\n    }\r\n\r\n    .myDIV:hover + .hide {\r\n        display: block;\r\n        color: red;\r\n    }\r\n</style>\r\n\r\n<h1>LinkPage</h1>\r\n\r\n");
#nullable restore
#line 19 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\Home\LinkPage.cshtml"
 foreach (Product cat in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <td>\r\n            <div class=\"myDIV\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 357, "\"", 392, 2);
            WriteAttributeValue("", 364, "/Home/Category?catid=", 364, 21, true);
#nullable restore
#line 25 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\Home\LinkPage.cshtml"
WriteAttributeValue("", 385, cat.id, 385, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\Home\LinkPage.cshtml"
                                                  Write(cat.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n\r\n            <div class=\"hide\">");
#nullable restore
#line 28 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\Home\LinkPage.cshtml"
                         Write(cat.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(": $");
#nullable restore
#line 28 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\Home\LinkPage.cshtml"
                                            Write(cat.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </td>\r\n    </tr>\r\n</table>\r\n    <br />\r\n");
#nullable restore
#line 33 "C:\devbuild4\lab13.2_Coffee_Shop_SQL\lab13.2_Coffee_Shop_SQL\Views\Home\LinkPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
