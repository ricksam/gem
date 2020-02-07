#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2d21ae366bcbbb0c89c1613475eb4dfaef65313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_List), @"mvc.1.0.view", @"/Views/Presenca/List.cshtml")]
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
#line 1 "D:\PROJECTS\RckSoftware\CCB\gem\Views\_ViewImports.cshtml"
using GEM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\_ViewImports.cshtml"
using GEM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2d21ae366bcbbb0c89c1613475eb4dfaef65313", @"/Views/Presenca/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.UsuarioPresenca>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"btn-group\" role=\"group\" aria-label=\"Filtro\">\r\n        <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 157, "\'", 236, 2);
            WriteAttributeValue("", 165, "btn", 165, 3, true);
#nullable restore
#line 6 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 168, ViewBag.q==null || ViewBag.q=="Todos"?"btn-dark":"btn-secondary", 169, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"Filtro(\'Todos\')\">Todos</button>\r\n        <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 309, "\'", 372, 2);
            WriteAttributeValue("", 317, "btn", 317, 3, true);
#nullable restore
#line 7 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 320, ViewBag.q=="Presente"?"btn-dark":"btn-secondary", 321, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"Filtro(\'Presente\')\">Presente</button>\r\n        <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 451, "\'", 513, 2);
            WriteAttributeValue("", 459, "btn", 459, 3, true);
#nullable restore
#line 8 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 462, ViewBag.q=="Ausente"?"btn-dark":"btn-secondary", 463, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""Filtro('Ausente')"">Ausente</button>
    </div>

    <div class=""table-responsive"">
  <table class=""table "">
    <thead>
      <tr>
        <th>Nome</th>
        <th>Instrumento</th>
        <th>Situação</th>
        <th>Aula</th>
      </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 22 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
         Write(item.Instrumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n");
#nullable restore
#line 28 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
             if(item.Cod_Presenca == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1051, "\'", 1098, 3);
            WriteAttributeValue("", 1061, "RegistraPresenca(", 1061, 17, true);
#nullable restore
#line 29 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 1078, item.Cod_Usuario, 1078, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1097, ")", 1097, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-exclamation\"></i> Falta</button>\r\n");
#nullable restore
#line 30 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-success btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1239, "\'", 1286, 3);
            WriteAttributeValue("", 1249, "RegistraAusencia(", 1249, 17, true);
#nullable restore
#line 32 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 1266, item.Cod_Usuario, 1266, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1285, ")", 1285, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-flag\"></i> Presente</button>\r\n");
#nullable restore
#line 33 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\r\n          <td>\r\n");
#nullable restore
#line 36 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
             if(item.Cod_Presenca != 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1474, "\'", 1510, 3);
            WriteAttributeValue("", 1484, "Aula(", 1484, 5, true);
#nullable restore
#line 37 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 1489, item.Cod_Presenca, 1489, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1509, ")", 1509, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-book\"></i> Aula</button>\r\n");
#nullable restore
#line 38 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 41 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.UsuarioPresenca>> Html { get; private set; }
    }
}
#pragma warning restore 1591
