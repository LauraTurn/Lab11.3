#pragma checksum "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ecbb2aa777e22397901536461a83f4f2286a681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\_ViewImports.cshtml"
using CoffeeHouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\_ViewImports.cshtml"
using CoffeeHouse.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ecbb2aa777e22397901536461a83f4f2286a681", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0294fe7d5e9d617deee3c63d87515446de498248", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<String>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Products Index</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Index.cshtml"
 foreach (String categ in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 140, "\"", 169, 2);
            WriteAttributeValue("", 147, "/product/detail/", 147, 16, true);
#nullable restore
#line 13 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Index.cshtml"
WriteAttributeValue("", 163, categ, 163, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Index.cshtml"
                                Write(categ);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> ");
#nullable restore
#line 13 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Index.cshtml"
                                                //

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Index.cshtml"
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<String>> Html { get; private set; }
    }
}
#pragma warning restore 1591