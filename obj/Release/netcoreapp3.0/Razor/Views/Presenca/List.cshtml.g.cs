#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "881690e391add0660f3ca061b9221fc85b77456f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881690e391add0660f3ca061b9221fc85b77456f", @"/Views/Presenca/List.cshtml")]
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
            WriteLiteral(@"
<div class=""noprint row"">
    <div class=""form-group col-sm-6"">
        <div class=""btn-group"" role=""group"" aria-label=""Filtro controle de presença"">
            <button id=""btn_todos"" type=""button"" class='btn btn-dark' onclick=""FiltroPresenca('Todos')"">Todos</button>
            <button id=""btn_presente"" type=""button"" class='btn btn-secondary' onclick=""FiltroPresenca('Presente')"">Presente</button>
            <button id=""btn_ausente"" type=""button"" class='btn btn-secondary' onclick=""FiltroPresenca('Ausente')"">Ausente</button>
        </div>
    </div>
    <div class=""form-group col-sm-6"">
        <div class=""btn-group float-right"" role=""group"" aria-label=""Filtro usuários"">
            <button id=""btn_usuarios"" type=""button"" class='btn btn-dark' onclick=""FiltroUsuario('Todos')"">Todos</button>
            <button id=""btn_instrutores"" type=""button"" class='btn btn-secondary' onclick=""FiltroUsuario('Instrutores')"">Instrutores</button>
            <button id=""btn_alunos"" type=""button"" class='btn btn-s");
            WriteLiteral(@"econdary' onclick=""FiltroUsuario('Alunos')"">Alunos</button>
        </div>
    </div>
</div>

<div class=""table-responsive"">
  <table class=""table "">
    <thead>
      <tr>
        <th>Nome</th>
        <th>Grupo</th>
        <th>Instrumento</th>
        <th>Situação</th>
        <th>Histórico</th>
      </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 35 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=\'", 1508, "\'", 1675, 7);
            WriteAttributeValue("", 1516, "tr_usuario", 1516, 10, true);
            WriteAttributeValue(" ", 1526, "tr_usuario_", 1527, 12, true);
#nullable restore
#line 37 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 1538, item.Cod_Usuario, 1538, 19, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 1557, item.Cod_Presenca == 0?"tr_ausente":"tr_presente", 1558, 52, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 1610, item.Instrutor?"tr_instrutor":"", 1611, 35, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 1646, item.Aluno?"tr_aluno":"", 1647, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1674, "", 1675, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n          <td>");
#nullable restore
#line 38 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 39 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
         Write(item.Grupos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 40 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
         Write(item.Instrumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n            <div class=\"btn-group\"");
            BeginWriteAttribute("id", " id=\"", 1831, "\"", 1864, 2);
            WriteAttributeValue("", 1836, "Situacao_", 1836, 9, true);
#nullable restore
#line 42 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 1845, item.Cod_Usuario, 1845, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              ");
#nullable restore
#line 43 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
         Write(await Html.PartialAsync("~/Views/Presenca/Situacao.cshtml", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n          </td>\r\n          <td>\r\n              <button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2052, "\'", 2161, 11);
            WriteAttributeValue("", 2062, "Historico(", 2062, 10, true);
#nullable restore
#line 47 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2072, item.Cod_Usuario, 2072, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2091, ",", 2091, 1, true);
            WriteAttributeValue(" ", 2092, "\"", 2093, 2, true);
#nullable restore
#line 47 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2094, item.Nome, 2094, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2106, "\",", 2106, 2, true);
            WriteAttributeValue(" ", 2108, "\"", 2109, 2, true);
#nullable restore
#line 47 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2110, item.Instrumento, 2110, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2129, "\",", 2129, 2, true);
#nullable restore
#line 47 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 2131, item.Aluno?"true":"false", 2132, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2160, ")", 2160, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-history\"></i></button>\r\n          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 50 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
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
