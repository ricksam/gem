#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1079f58e978fefde554ce0510630e62d1a2d9394"
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
#line 1 "d:\PROJECTS\RckSoftware\CCB\gem\Views\_ViewImports.cshtml"
using GEM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\_ViewImports.cshtml"
using GEM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1079f58e978fefde554ce0510630e62d1a2d9394", @"/Views/Presenca/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.UsuarioPresenca>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""form-group col-sm-6"">
        <div class=""btn-group"" role=""group"" aria-label=""Filtro controle de presença"">
            <button id=""btn_todos"" type=""button"" class='btn ' onclick=""FiltroPresenca('Todos')"">Todos</button>
            <button id=""btn_presente"" type=""button"" class='btn ' onclick=""FiltroPresenca('Presente')"">Presente</button>
            <button id=""btn_ausente"" type=""button"" class='btn ' onclick=""FiltroPresenca('Ausente')"">Ausente</button>
        </div>
    </div>
    <div class=""form-group col-sm-6"">
        <div class=""btn-group float-right"" role=""group"" aria-label=""Filtro usuários"">
            <button id=""btn_usuarios"" type=""button"" class='btn ' onclick=""FiltroUsuario('Todos')"">Todos</button>
            <button id=""btn_instrutores"" type=""button"" class='btn ' onclick=""FiltroUsuario('Instrutores')"">Instrutores</button>
            <button id=""btn_alunos"" type=""button"" class='btn ' onclick=""FiltroUsuario('Alunos')"">Alunos</button>
        </div>");
            WriteLiteral(@"
    </div>
</div>
    
    
  
    

    <div class=""table-responsive"">
  <table class=""table "">
    <thead>
      <tr>
        <th>Nome</th>
        <th>Instrumento</th>
        <th>Situação</th>
        <th>Aula</th>
        <th>Histórico</th>
      </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 39 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=\'", 1457, "\'", 1592, 4);
            WriteAttributeValue("", 1465, "tr_usuario", 1465, 10, true);
#nullable restore
#line 41 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 1475, item.Cod_Presenca == 0?"tr_ausente":"tr_presente", 1476, 52, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 1528, item.Instrutor?"tr_instrutor":"", 1529, 35, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue(" ", 1564, item.Aluno?"tr_aluno":"", 1565, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n          <td>");
#nullable restore
#line 42 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 43 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
         Write(item.Instrumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n");
#nullable restore
#line 45 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
             if(item.Cod_Presenca == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1779, "\'", 1826, 3);
            WriteAttributeValue("", 1789, "RegistraPresenca(", 1789, 17, true);
#nullable restore
#line 46 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 1806, item.Cod_Usuario, 1806, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1825, ")", 1825, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-exclamation\"></i> Falta</button>\r\n");
#nullable restore
#line 47 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-success btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1967, "\'", 2014, 3);
            WriteAttributeValue("", 1977, "RegistraAusencia(", 1977, 17, true);
#nullable restore
#line 49 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 1994, item.Cod_Usuario, 1994, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2013, ")", 2013, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-flag\"></i> Presente</button>\r\n");
#nullable restore
#line 50 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\r\n          <td>\r\n");
#nullable restore
#line 53 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
             if(item.Cod_Presenca != 0 && item.Aluno){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2216, "\"", 2291, 9);
            WriteAttributeValue("", 2226, "Aula(", 2226, 5, true);
#nullable restore
#line 54 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2231, item.Cod_Presenca, 2231, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2251, ",", 2251, 1, true);
            WriteAttributeValue(" ", 2252, "\'", 2253, 2, true);
#nullable restore
#line 54 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2254, item.Nome, 2254, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2266, "\',", 2266, 2, true);
            WriteAttributeValue(" ", 2268, "\'", 2269, 2, true);
#nullable restore
#line 54 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2270, item.Instrumento, 2270, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2289, "\')", 2289, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-book\"></i> Conteúdo</button>\r\n");
#nullable restore
#line 55 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\r\n          <td>\r\n");
#nullable restore
#line 58 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
             if(item.Cod_Presenca != 0 && item.Aluno){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2493, "\"", 2572, 9);
            WriteAttributeValue("", 2503, "Historico(", 2503, 10, true);
#nullable restore
#line 59 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2513, item.Cod_Usuario, 2513, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2532, ",", 2532, 1, true);
            WriteAttributeValue(" ", 2533, "\'", 2534, 2, true);
#nullable restore
#line 59 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2535, item.Nome, 2535, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2547, "\',", 2547, 2, true);
            WriteAttributeValue(" ", 2549, "\'", 2550, 2, true);
#nullable restore
#line 59 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
WriteAttributeValue("", 2551, item.Instrumento, 2551, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2570, "\')", 2570, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-history\"></i></button>\r\n");
#nullable restore
#line 60 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("              \r\n          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 64 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\List.cshtml"
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
