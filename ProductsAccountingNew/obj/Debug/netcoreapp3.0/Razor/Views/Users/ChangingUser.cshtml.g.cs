#pragma checksum "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c6635297a7cec0a5f141d962a9b6c9caa78317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ChangingUser), @"mvc.1.0.view", @"/Views/Users/ChangingUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c6635297a7cec0a5f141d962a9b6c9caa78317", @"/Views/Users/ChangingUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1ca3baf16085efc32ea419afbb292ca884d922", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_ChangingUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsAccountingNew.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("editUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-color: #343a40;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml"
  
    ViewBag.Title = "Редактирование пользователя";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"modDialog\" class=\"modal fade\">\r\n    <div id=\"dialogContent\" class=\"modal-dialog\"></div>\r\n</div>\r\n\r\n<h3>Редактирование пользователя</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22c6635297a7cec0a5f141d962a9b6c9caa783175064", async() => {
                WriteLiteral("\r\n    <table>\r\n\r\n        ");
#nullable restore
#line 17 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Логин:</td>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"text\" name=\"login\"");
                BeginWriteAttribute("value", " value=\"", 575, "\"", 597, 1);
#nullable restore
#line 22 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml"
WriteAttributeValue("", 583, ViewBag.Login, 583, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"padding: 4px;\">ФИО:</td>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 774, "\"", 799, 1);
#nullable restore
#line 28 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml"
WriteAttributeValue("", 782, ViewBag.FullName, 782, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"fullName\" />\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Email:</td>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"email\"");
                BeginWriteAttribute("value", " value=\"", 997, "\"", 1019, 1);
#nullable restore
#line 35 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml"
WriteAttributeValue("", 1005, ViewBag.Email, 1005, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"email\" />\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Cash:</td>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 1214, "\"", 1235, 1);
#nullable restore
#line 42 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml"
WriteAttributeValue("", 1222, ViewBag.Cash, 1222, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""cash"" />
            </td>
        </tr>

        <br>


        <tr>
            <td style=""padding: 4px;"">
            </td>

            <td style=""padding: 4px;"">
                <a class=""btn btn-outline-dark"" href=""/Users"" style=""text-align:center"">Отмена</a>
                <input type=""submit"" class=""btn btn-outline-warning submitBtn"" value=""Изменить"" />
            </td>

            <td style=""padding: 4px;"">
            </td>
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 66 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml"
  
    if (@ViewBag.Status == "errorWithLogin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"">
            $.get(this.href, function (data) {
                $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Пользователь с таким логином уже существует</dd> </dl> </div> </div>');
                $('#modDialog').modal('show');
            });
        </script>
");
#nullable restore
#line 75 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Users\ChangingUser.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $.ajaxSetup({ cache: false });
            $("".submitBtn"").click(function (e) {
                let editUserForm = document.forms.editUserForm;
                let login = editUserForm.elements.Login.value;
                if (login == """") {
                    e.preventDefault();
                    $.get(this.href, function (data) {
                        $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Нужно задать логин</dd> </dl> </div> </div>');
                        $('#modDialog').modal('show');
                    });
                }
            });
        })
    </script>

");
            }
            );
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
