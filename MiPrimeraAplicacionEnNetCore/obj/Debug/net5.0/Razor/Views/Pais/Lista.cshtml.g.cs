#pragma checksum "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\Pais\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a992c71383f146dd403adf4d2cd97dd2d08ab47b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pais_Lista), @"mvc.1.0.view", @"/Views/Pais/Lista.cshtml")]
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
#nullable restore
#line 4 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\Pais\Lista.cshtml"
using MiPrimeraAplicacionEnNetCore.Clases;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a992c71383f146dd403adf4d2cd97dd2d08ab47b", @"/Views/Pais/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edff50b2c3a22e5b2a4a00e06e66c209ab133f6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pais_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\Pais\Lista.cshtml"
                                               

    ViewData["Title"] = "Lista";

    List<InstructorCLS> listaInstructor = new List<InstructorCLS>();

    InstructorCLS oInstructorCLS = new InstructorCLS();
    oInstructorCLS.nombre = "Ali";
    oInstructorCLS.paterno = "Cruz";
    oInstructorCLS.materno = "Monter";
    listaInstructor.Add(oInstructorCLS);

    oInstructorCLS = new InstructorCLS();
    oInstructorCLS.nombre = "Sara";
    oInstructorCLS.paterno = "Cruz";
    oInstructorCLS.materno = "D";
    listaInstructor.Add(oInstructorCLS);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pagina por defecto</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nombre</th>\r\n            <th>Paterno</th>\r\n            <th>Materno</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\Pais\Lista.cshtml"
         foreach (InstructorCLS oInstructor in listaInstructor)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\Pais\Lista.cshtml"
           Write(oInstructor.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\Pais\Lista.cshtml"
           Write(oInstructor.paterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\Pais\Lista.cshtml"
           Write(oInstructor.materno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\userone\Desktop\Proyectos-ali.cruz\NetCore-MiPrimeraAplicacion-Licito\MiPrimeraAplicacionEnNetCore\Views\Pais\Lista.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
