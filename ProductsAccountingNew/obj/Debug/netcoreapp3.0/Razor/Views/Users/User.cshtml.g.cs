#pragma checksum "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "800902a687a12ac2a492bfe9335a35748a696d91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_User), @"mvc.1.0.view", @"/Views/Users/User.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800902a687a12ac2a492bfe9335a35748a696d91", @"/Views/Users/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1ca3baf16085efc32ea419afbb292ca884d922", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsAccountingNew.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\User.cshtml"
  
    ViewBag.Title = "Редактирование пользователя";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\User.cshtml"
 using (Html.BeginForm("Edit", "Users", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        ");
#nullable restore
#line 11 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\User.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td>Имя:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\User.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Email:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\User.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Адрес:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\User.cshtml"
           Write(Html.TextBoxFor(m => m.Cash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <input type=\"submit\" value=\"Send\" />\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n\r\n    </table>\r\n");
#nullable restore
#line 38 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\User.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsAccountingNew.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
