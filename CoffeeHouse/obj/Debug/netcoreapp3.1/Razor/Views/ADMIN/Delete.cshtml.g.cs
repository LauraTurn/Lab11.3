#pragma checksum "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\ADMIN\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccbb4ba9443e6363763dc2dbcf394d314c1a2970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ADMIN_Delete), @"mvc.1.0.view", @"/Views/ADMIN/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccbb4ba9443e6363763dc2dbcf394d314c1a2970", @"/Views/ADMIN/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0294fe7d5e9d617deee3c63d87515446de498248", @"/Views/_ViewImports.cshtml")]
    public class Views_ADMIN_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\ADMIN\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>PLEASE CONFIRM DELETION</h1>
<br />

<img src=""/Images/nottheway.jpg""
     width=""600""
     height=""400"" />

<br />
<br />
<br />

<h3>Please consider editing an existing product.</h3>

<p>
    <strong></strong>
    There is no way to retrieve data once it has been deleted. <br />
    Product will need to be added manually after deletion. <br />
    </strong>
</p>
<br />
<br />

<p>
    <h4></h4>Are you sure you want to permanently delete this product? <br />
    <strong>
        ");
#nullable restore
#line 31 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\ADMIN\Delete.cshtml"
   Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n        ");
#nullable restore
#line 32 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\ADMIN\Delete.cshtml"
   Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 34 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\ADMIN\Delete.cshtml"
   Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 36 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\ADMIN\Delete.cshtml"
   Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n    </strong>\r\n\r\n</p>\r\n<br />\r\n\r\n\r\n<!--Neato!  Makes the delete button an html link that asks for confirmation!-->\r\n<p style=\"font-weight:bold; font-size: 30px\">Click here to ");
#nullable restore
#line 45 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\ADMIN\Delete.cshtml"
                                                      Write(Html.ActionLink("DELETE", "DeleteConfirm", new { id = Model.id },

     new { onclick = "return confirm('Are you ABSOLUTELY sure?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591