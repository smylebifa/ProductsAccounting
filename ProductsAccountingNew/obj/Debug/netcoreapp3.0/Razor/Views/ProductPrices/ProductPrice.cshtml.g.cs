#pragma checksum "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\ProductPrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6da90af8d6e2d33b11b293bdbe110720513c3a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductPrices_ProductPrice), @"mvc.1.0.view", @"/Views/ProductPrices/ProductPrice.cshtml")]
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
#line 1 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\_ViewImports.cshtml"
using ProductsAccountingNew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\_ViewImports.cshtml"
using ProductsAccountingNew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da90af8d6e2d33b11b293bdbe110720513c3a8c", @"/Views/ProductPrices/ProductPrice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1ca3baf16085efc32ea419afbb292ca884d922", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductPrices_ProductPrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsAccountingNew.Models.ProductPrice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\ProductPrice.cshtml"
  
    ViewBag.Title = "Изменение цены";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\ProductPrice.cshtml"
 using (Html.BeginForm("Edit", "ProductPrices", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        ");
#nullable restore
#line 11 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\ProductPrice.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td>Название:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\ProductPrice.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Цена:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\ProductPrice.cshtml"
           Write(Html.TextBoxFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <input type=\"submit\" value=\"Добавить\" />\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 31 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\ProductPrice.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsAccountingNew.Models.ProductPrice> Html { get; private set; }
    }
}
#pragma warning restore 1591
