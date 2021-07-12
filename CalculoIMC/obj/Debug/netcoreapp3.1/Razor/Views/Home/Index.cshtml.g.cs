#pragma checksum "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6107a328e2373946d7e726b47a2818d7936680c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\_ViewImports.cshtml"
using CalculoIMC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\_ViewImports.cshtml"
using CalculoIMC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
using IMC.Dominio.Entidades;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6107a328e2373946d7e726b47a2818d7936680c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1f38677ca7c3c972aa0bead75b0c3153a67dd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Histórico";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""m-5"">
    <div class=""col-md-12"">
        <h2>Histórico dos Cálculos</h2>
        <table class=""table table-bordered table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Nome</th>
                    <th scope=""col"">Peso</th>
                    <th scope=""col"">Altura</th>
                    <th scope=""col"">IMC</th>
                    <th scope=""col"" style=""width: 10%;"">Ações</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                 foreach (var usuario in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                                   Write(usuario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                       Write(usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                       Write(usuario.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                       Write(usuario.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                       Write(usuario.Imc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <button class=\"btn btn-danger btn-sm\" data-id=\"");
#nullable restore
#line 32 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                                                                      Write(usuario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"btn-excluir\"><i class=\"fa fa-trash-o\"></i></button>\r\n                            <button class=\"btn btn-warning btn-sm\" data-id=\"");
#nullable restore
#line 33 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                                                                       Write(usuario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"btn-editar\"><i class=\"fa fa-pencil-square-o\"></i></button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Ismael\source\repos\CalculoIMC\CalculoIMC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
