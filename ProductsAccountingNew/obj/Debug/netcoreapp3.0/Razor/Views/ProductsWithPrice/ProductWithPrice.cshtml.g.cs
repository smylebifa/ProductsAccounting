#pragma checksum "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductsWithPrice\ProductWithPrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75b29552a18e8cbb2900d472a874c2e2e0d462e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductsWithPrice_ProductWithPrice), @"mvc.1.0.view", @"/Views/ProductsWithPrice/ProductWithPrice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b29552a18e8cbb2900d472a874c2e2e0d462e0", @"/Views/ProductsWithPrice/ProductWithPrice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1ca3baf16085efc32ea419afbb292ca884d922", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductsWithPrice_ProductWithPrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsAccountingNew.Models.ProductWithPrice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductsWithPrice\ProductWithPrice.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductsWithPrice\ProductWithPrice.cshtml"
 using (Html.BeginForm("Edit", "ProductsWithPrice", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        ");
#nullable restore
#line 11 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductsWithPrice\ProductWithPrice.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td>Название:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductsWithPrice\ProductWithPrice.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Цена:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductsWithPrice\ProductWithPrice.cshtml"
           Write(Html.TextBoxFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <input type=\"submit\" value=\"Send\" />\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n\r\n    </table>\r\n");
#nullable restore
#line 32 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductsWithPrice\ProductWithPrice.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsAccountingNew.Models.ProductWithPrice> Html { get; private set; }
    }
}
#pragma warning restore 1591