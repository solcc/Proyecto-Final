#pragma checksum "E:\USIL\CICLO IV\PROGRAMACIÓN MULTIPLATAFORMA\Proyecto final\Proyecto-Final\Views\Cuenta\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98cca646f6f4f9f9deb2307b2f879c40dd4589a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuenta_Login), @"mvc.1.0.view", @"/Views/Cuenta/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuenta/Login.cshtml", typeof(AspNetCore.Views_Cuenta_Login))]
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
#line 1 "E:\USIL\CICLO IV\PROGRAMACIÓN MULTIPLATAFORMA\Proyecto final\Proyecto-Final\Views\_ViewImports.cshtml"
using Proyecto_Final;

#line default
#line hidden
#line 2 "E:\USIL\CICLO IV\PROGRAMACIÓN MULTIPLATAFORMA\Proyecto final\Proyecto-Final\Views\_ViewImports.cshtml"
using Proyecto_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98cca646f6f4f9f9deb2307b2f879c40dd4589a2", @"/Views/Cuenta/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db32e4c60afea8645d8f000c0ecb7d5f01c2ab1", @"/Views/_ViewImports.cshtml")]
    public class Views_Cuenta_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proyecto_Final.Models.ViewModels.Sesion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Cuenta/validacion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario-ingreso ml-auto mr-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\USIL\CICLO IV\PROGRAMACIÓN MULTIPLATAFORMA\Proyecto final\Proyecto-Final\Views\Cuenta\Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 24, false);
#line 6 "E:\USIL\CICLO IV\PROGRAMACIÓN MULTIPLATAFORMA\Proyecto final\Proyecto-Final\Views\Cuenta\Login.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(112, 77, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n<div class=\"col-md-3\">\r\n</div>\r\n<div class=\"col-md-6\">\r\n");
            EndContext();
            BeginContext(189, 1441, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "164f476cecc643eb9f6a6caa4a6df21e", async() => {
                BeginContext(281, 324, true);
                WriteLiteral(@"
          <div class=""form-group"">
            <div class=""row div-h3"">
              <div class=""col-12"">
                <h3>Ingreso</h3>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-12"">
                <label >Correo electrónico </label>
                ");
                EndContext();
                BeginContext(606, 77, false);
#line 21 "E:\USIL\CICLO IV\PROGRAMACIÓN MULTIPLATAFORMA\Proyecto final\Proyecto-Final\Views\Cuenta\Login.cshtml"
           Write(Html.TextBoxFor(m=>m.Correo, new { @class = "form-control", type = "email" }));

#line default
#line hidden
                EndContext();
                BeginContext(683, 178, true);
                WriteLiteral("\r\n              </div>\r\n            </div>\r\n            <div class=\"row\">\r\n              <div class=\"col-12\">\r\n                <label for=\"\">Contraseña </label>\r\n                ");
                EndContext();
                BeginContext(862, 66, false);
#line 27 "E:\USIL\CICLO IV\PROGRAMACIÓN MULTIPLATAFORMA\Proyecto final\Proyecto-Final\Views\Cuenta\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(928, 695, true);
                WriteLiteral(@"
                
              </div>
            </div>
            <div class=""row"">
              <div class=""col-12"">
                <input type=""checkbox"" onclick=""mostrarPass()"" class=""""> Mostrar contraseña.
              </div>
            </div>
            <div class=""row"">
              <div class=""col-12"">
                <input type=""checkbox"" class=""""> Recordar contraseña.
              </div>
            </div>
            <div class=""row div-btn-registrar"">
              <div class=""col-12 form-group"">
                <button type=""submit"" class=""btn btn-registrar"">Iniciar</button>
              </div>
            </div>
          </div>    
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1630, 457, true);
            WriteLiteral(@"
</div>
<div class=""col-md-3"">

</div>
</div>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script>
            function mostrarPass() {
                var x = document.getElementById(""pass"");
                if (x.type === ""password"") {
                    x.type = ""text"";
                } else {
                    x.type = ""password"";
                }
            }
    </script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto_Final.Models.ViewModels.Sesion> Html { get; private set; }
    }
}
#pragma warning restore 1591
