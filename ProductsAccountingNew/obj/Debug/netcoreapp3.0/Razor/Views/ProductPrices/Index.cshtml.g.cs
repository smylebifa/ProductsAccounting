#pragma checksum "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8e0250346e1cf1af673e69e34036c22697a7811"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductPrices_Index), @"mvc.1.0.view", @"/Views/ProductPrices/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8e0250346e1cf1af673e69e34036c22697a7811", @"/Views/ProductPrices/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1ca3baf16085efc32ea419afbb292ca884d922", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductPrices_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsAccountingNew.Models.ProductPrice>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductPrices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-5 col-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-style: dashed; border-width:thin; border-color: #343a40; padding: 8px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\Index.cshtml"
  
    ViewBag.Title = "Цены на продукты";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    a.nav-link.prices {
        color: #ffc107;
    }
</style>



<table class=""table table-hover"" style=""text-align: center;"">

    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Название продукта</th>
            <th scope=""col"">Цена</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 28 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\Index.cshtml"
         foreach (var price in @ViewBag.ProductPrices)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\Index.cshtml"
               Write(price.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\Index.cshtml"
               Write(price.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\Index.cshtml"
               Write(Html.ActionLink("изменить", "ProductPrice", new { id = price.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 804, "\"", 838, 3);
            WriteAttributeValue("", 814, "deletePrice(\'", 814, 13, true);
#nullable restore
#line 34 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\Index.cshtml"
WriteAttributeValue("", 827, price.Id, 827, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 836, "\')", 836, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"> удалить </a></td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\ProductPrices\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8e0250346e1cf1af673e69e34036c22697a78117345", async() => {
                WriteLiteral(@"
    <table>
        <h4>Добавление цен</h4>
        <tr>
            <td style=""padding: 4px;"">Название:</td>
            <td style=""padding: 4px;"">
                <input type=""text"" name=""Name"" />
            </td>
        </tr>
        <tr>
            <td style=""padding: 4px;"">Цена:</td>
            <td style=""padding: 4px;"">
                <input type=""text"" name=""Price"" />
            </td>
        </tr>
        <tr>
            <td style=""padding: 2px;"">
                <input type=""submit"" value=""Добавить"" />
            </td>
            <td></td>
        </tr>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    function deletePrice(userId) {
        $.ajax({
            url: '/delete_price/' + userId,
            type: 'DELETE',
            contentType: ""application/json; charset=utf-8"",
            success: function () {
                location.reload()
            },
            error: function () {
                alert(""Всё сломалось!!!"")
            }
        })
    }
</script>");
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
