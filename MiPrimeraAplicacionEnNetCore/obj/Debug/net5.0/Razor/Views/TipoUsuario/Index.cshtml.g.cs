#pragma checksum "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0ca8360acd5097e097ec5dfa17b2b999cac2f42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoUsuario_Index), @"mvc.1.0.view", @"/Views/TipoUsuario/Index.cshtml")]
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
#line 1 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\_ViewImports.cshtml"
using MiPrimeraAplicacionEnNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\_ViewImports.cshtml"
using MiPrimeraAplicacionEnNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0ca8360acd5097e097ec5dfa17b2b999cac2f42", @"/Views/TipoUsuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edff50b2c3a22e5b2a4a00e06e66c209ab133f6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TipoUsuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MiPrimeraAplicacionEnNetCore.Clases.TipoUsuarioCLS>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TipoUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmEliminarTipoUsuario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/generic.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tipo Usuarios</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca8360acd5097e097ec5dfa17b2b999cac2f427099", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" class=\"btn btn-primary btn-sm\" value=\"Enviar\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca8360acd5097e097ec5dfa17b2b999cac2f427444", async() => {
                    WriteLiteral(" <i class=\"fas fa-plus\"></i> Agregar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.idTipoUsuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>Operaciones</th>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n");
#nullable restore
#line 28 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
                     if (ViewBag.Id == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"number\" name=\"idTipoUsuario\" class=\"form form-control\" />\r\n");
#nullable restore
#line 31 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 1173, "\"", 1192, 1);
#nullable restore
#line 34 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
WriteAttributeValue("", 1181, ViewBag.Id, 1181, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"idTipoUsuario\" class=\"form form-control\" />\r\n");
#nullable restore
#line 35 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1353, "\"", 1376, 1);
#nullable restore
#line 39 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
WriteAttributeValue("", 1361, ViewBag.Nombre, 1361, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"nombre\" class=\"form form-control\" />\r\n                </th>\r\n                <th>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1505, "\"", 1533, 1);
#nullable restore
#line 42 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
WriteAttributeValue("", 1513, ViewBag.Descripcion, 1513, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"descripcion\" class=\"form form-control\" />\r\n                </th>\r\n                <th>\r\n\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.idTipoUsuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <i class=\"fa fa-trash btn btn-danger\" aria-hidden=\"true\"");
                BeginWriteAttribute("onclick", " \r\n                           onclick=\"", 2268, "\"", 2347, 3);
                WriteAttributeValue("", 2307, "eliminarTipoUsuario(", 2307, 20, true);
#nullable restore
#line 64 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
WriteAttributeValue("", 2327, item.idTipoUsuario, 2327, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2346, ")", 2346, 1, true);
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\TipoUsuario\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca8360acd5097e097ec5dfa17b2b999cac2f4217132", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"idTipoUsuario\" id=\"txtTipoUsuario\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca8360acd5097e097ec5dfa17b2b999cac2f4219133", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca8360acd5097e097ec5dfa17b2b999cac2f4220173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>
    function eliminarTipoUsuario(idTipoUsuario) {
        document.getElementById(""txtTipoUsuario"").value = idTipoUsuario;

        mostrarModal().then(res => {
            if (res.value) {
                var frmEliminarTipoUsuario = document.getElementById(""frmEliminarTipoUsuario"");
                frmEliminarTipoUsuario.submit();
            }
        })

    }

</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MiPrimeraAplicacionEnNetCore.Clases.TipoUsuarioCLS>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
