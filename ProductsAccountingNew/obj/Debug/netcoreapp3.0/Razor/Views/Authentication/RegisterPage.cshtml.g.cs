#pragma checksum "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b2d137746b522c892794f53e9338ddc93ba87b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentication_RegisterPage), @"mvc.1.0.view", @"/Views/Authentication/RegisterPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2d137746b522c892794f53e9338ddc93ba87b2", @"/Views/Authentication/RegisterPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1ca3baf16085efc32ea419afbb292ca884d922", @"/Views/_ViewImports.cshtml")]
    public class Views_Authentication_RegisterPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("registerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"
  
    ViewData["Title"] = "Регистрация";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"modDialog\" class=\"modal fade\">\r\n    <div id=\"dialogContent\" class=\"modal-dialog\"></div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b2d137746b522c892794f53e9338ddc93ba87b24618", async() => {
                WriteLiteral(@"

    <div class=""mb-3 row"">
        <div class=""col-sm-4 col-form-label""></div>

        <div class=""col-sm-3"">
            <label class=""form-label h3"">Регистрация</label>
        </div>

        <div class=""col-sm-5 col-form-label""></div>
    </div>

");
#nullable restore
#line 21 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"
      
        if (@ViewBag.Status == "success")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"mb-3 row\">\r\n                <div class=\"col-sm-4 col-form-label\"></div>\r\n\r\n                <div class=\"col-sm-3\">\r\n                    <label class=\"form-label\">Логин</label>\r\n                    <input type=\"text\" name=\"login\"");
                BeginWriteAttribute("value", " value=\"", 798, "\"", 820, 1);
#nullable restore
#line 29 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"
WriteAttributeValue("", 806, ViewBag.Login, 806, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n                </div>\r\n\r\n                <div class=\"col-sm-5 col-form-label\"></div>\r\n            </div>\r\n");
                WriteLiteral(@"            <div class=""mb-3 row"">
                <div class=""col-sm-4 col-form-label""></div>

                <div class=""col-sm-3"">
                    <label class=""form-label"">Пароль</label>
                    <input type=""password"" name=""password""");
                BeginWriteAttribute("value", " value=\"", 1215, "\"", 1240, 1);
#nullable restore
#line 41 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"
WriteAttributeValue("", 1223, ViewBag.Password, 1223, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n                </div>\r\n\r\n                <div class=\"col-sm-5 col-form-label\"></div>\r\n            </div>\r\n");
                WriteLiteral(@"            <div class=""mb-3 row"">
                <div class=""col-sm-4 col-form-label""></div>

                <div class=""col-sm-3"">
                    <label class=""form-label"">Подвтерждение пароля</label>
                    <input type=""password"" name=""password2"" class=""form-control"">
                </div>

                <div class=""col-sm-5 col-form-label""></div>
            </div>
");
                WriteLiteral(@"            <div class=""mb-3 row"">
                <div class=""col-sm-4 col-form-label""></div>

                <div class=""col-sm-3"">
                    <button type=""submit"" class=""submitBtn btn btn-warning"">Зарегистрироваться</button>
                </div>

                <div class=""col-sm-5 col-form-label""></div>
            </div>
");
#nullable restore
#line 67 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"

        }

        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"mb-3 row\">\r\n                <div class=\"col-sm-4 col-form-label\"></div>\r\n\r\n                <div class=\"col-sm-3\">\r\n                    <label class=\"form-label\">Логин</label>\r\n                    <input type=\"text\" name=\"login\"");
                BeginWriteAttribute("value", " value=\"", 2423, "\"", 2445, 1);
#nullable restore
#line 77 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"
WriteAttributeValue("", 2431, ViewBag.Login, 2431, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n                </div>\r\n\r\n                <div class=\"col-sm-5 col-form-label\"></div>\r\n            </div>\r\n");
                WriteLiteral(@"            <div class=""mb-3 row"">
                <div class=""col-sm-4 col-form-label""></div>

                <div class=""col-sm-3"">
                    <button type=""submit"" class=""submitBtn btn btn-outline-warning"">Далее</button>
                </div>

                <div class=""col-sm-5 col-form-label""></div>
            </div>
");
#nullable restore
#line 92 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"

        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 100 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"
  
    if (@ViewBag.Status == "errorWithLogin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"">
            $.get(this.href, function (data) {
                $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Пользователь с таким именем уже существует или введен неверно</dd> </dl> </div> </div>');
                $('#modDialog').modal('show');
            });
        </script>
");
#nullable restore
#line 109 "E:\ilia\Web\ProductsAccountingNew\ProductsAccountingNew\Views\Authentication\RegisterPage.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $.ajaxSetup({ cache: false });
            $("".submitBtn"").click(function (e) {
                let registerForm = document.forms.registerForm;

                let login = registerForm.elements.login.value;
                let password1 = registerForm.elements.password.value;
                let password2 = registerForm.elements.password2.value;

                if (password1 != password2) {
                    e.preventDefault();
                    $.get(this.href, function (data) {
                        $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Пароли не совпадают</dd> </dl> </div> </div>');
                        $('#modDialog').modal('show');
                    });
                }

                if (login");
                WriteLiteral(@" == """") {
                    e.preventDefault();
                    $.get(this.href, function (data) {
                        $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Для регистрации нужно ввести логин</dd> </dl> </div> </div>');
                        $('#modDialog').modal('show');
                    });
                }

                if (password1 == """") {
                    e.preventDefault();
                    $.get(this.href, function (data) {
                        $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Для регистрации нужно ввести пароль</dd> </dl> </div> </div>');
        ");
                WriteLiteral("                $(\'#modDialog\').modal(\'show\');\r\n                    });\r\n                }\r\n\r\n            });\r\n        })\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
