#pragma checksum "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8092723b8933d52b7ee5c028f638b0ea952827eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicamento_Index), @"mvc.1.0.view", @"/Views/Medicamento/Index.cshtml")]
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
#line 1 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\_ViewImports.cshtml"
using MiPrimeraAplicacionEnNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\_ViewImports.cshtml"
using MiPrimeraAplicacionEnNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
using MiPrimeraAplicacionEnNetCore.Clases;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8092723b8933d52b7ee5c028f638b0ea952827eb", @"/Views/Medicamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edff50b2c3a22e5b2a4a00e06e66c209ab133f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Medicamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MedicamentoCLS>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: grid; grid-template-columns: 1fr 2fr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formMedicamento"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"

    ViewData["Title"] = "Index";
    List<SelectListItem> listaFormas = ViewBag.listaFormasFarmaceuticas;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Medicamento</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8092723b8933d52b7ee5c028f638b0ea952827eb5135", async() => {
                WriteLiteral("\r\n    <label>Ingresa la forma</label>\r\n    ");
#nullable restore
#line 14 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
Write(Html.DropDownList("idFormaFarmaceutica", listaFormas, new { @class="form form-control"} ));

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>");
#nullable restore
#line 20 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.idMedicamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 21 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 22 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.formaFarmaceutica));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
         foreach (MedicamentoCLS oMedicamento in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => oMedicamento.idMedicamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => oMedicamento.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => oMedicamento.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => oMedicamento.stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => oMedicamento.formaFarmaceutica));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\userone\Downloads\Proyectos\MiPrimeraAplicacionEnNetCore\MiPrimeraAplicacionEnNetCore\Views\Medicamento\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
    </tbody>
</table>

<script>
    var idFormaFarmaceutica = document.getElementById(""idFormaFarmaceutica"");
    idFormaFarmaceutica.onchange = function () {
        document.getElementById(""formMedicamento"").submit();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MedicamentoCLS>> Html { get; private set; }
    }
}
#pragma warning restore 1591
