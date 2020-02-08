#pragma checksum "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c28fefbb23d3a7aaa12cbcfab66ad8533cab61"
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
#line 1 "/home/ricksam/Projects/CCB/gem/Views/_ViewImports.cshtml"
using GEM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ricksam/Projects/CCB/gem/Views/_ViewImports.cshtml"
using GEM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c28fefbb23d3a7aaa12cbcfab66ad8533cab61", @"/Views/Presenca/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ebefddbfc1ec11f6d16e946c3256bf3888b9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.UsuarioPresenca>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"form-group col-sm-12\">\n        <div class=\"btn-group\" role=\"group\" aria-label=\"Filtro controle de presença\">\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 243, "\'", 348, 2);
            WriteAttributeValue("", 251, "btn", 251, 3, true);
#nullable restore
#line 9 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue(" ", 254, ViewBag.FiltroPresenca==null || ViewBag.FiltroPresenca=="Todos"?"btn-dark":"btn-secondary", 255, 93, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"FiltroPresenca(\'Todos\')\">Todos</button>\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 432, "\'", 508, 2);
            WriteAttributeValue("", 440, "btn", 440, 3, true);
#nullable restore
#line 10 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue(" ", 443, ViewBag.FiltroPresenca=="Presente"?"btn-dark":"btn-secondary", 444, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"FiltroPresenca(\'Presente\')\">Presente</button>\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 598, "\'", 673, 2);
            WriteAttributeValue("", 606, "btn", 606, 3, true);
#nullable restore
#line 11 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue(" ", 609, ViewBag.FiltroPresenca=="Ausente"?"btn-dark":"btn-secondary", 610, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""FiltroPresenca('Ausente')"">Ausente</button>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""form-group col-sm-12"">
        <div class=""btn-group float-right"" role=""group"" aria-label=""Filtro usuários"">
            <button type=""button""");
            BeginWriteAttribute("class", " class=\'", 937, "\'", 1040, 2);
            WriteAttributeValue("", 945, "btn", 945, 3, true);
#nullable restore
#line 18 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue(" ", 948, ViewBag.FiltroUsuario==null || ViewBag.FiltroUsuario=="Todos"?"btn-dark":"btn-secondary", 949, 91, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"FiltroUsuario(\'Todos\')\">Todos</button>\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1123, "\'", 1201, 2);
            WriteAttributeValue("", 1131, "btn", 1131, 3, true);
#nullable restore
#line 19 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue(" ", 1134, ViewBag.FiltroUsuario=="Instrutores"?"btn-dark":"btn-secondary", 1135, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"FiltroUsuario(\'Instrutores\')\">Instrutores</button>\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1296, "\'", 1369, 2);
            WriteAttributeValue("", 1304, "btn", 1304, 3, true);
#nullable restore
#line 20 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue(" ", 1307, ViewBag.FiltroUsuario=="Alunos"?"btn-dark":"btn-secondary", 1308, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""FiltroUsuario('Alunos')"">Alunos</button>
        </div>
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
      </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 40 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n          <td>");
#nullable restore
#line 43 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 44 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
         Write(item.Instrumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>\n");
#nullable restore
#line 46 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
             if(item.Cod_Presenca == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1931, "\'", 1978, 3);
            WriteAttributeValue("", 1941, "RegistraPresenca(", 1941, 17, true);
#nullable restore
#line 47 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue("", 1958, item.Cod_Usuario, 1958, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1977, ")", 1977, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-exclamation\"></i> Falta</button>\n");
#nullable restore
#line 48 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-success btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2116, "\'", 2163, 3);
            WriteAttributeValue("", 2126, "RegistraAusencia(", 2126, 17, true);
#nullable restore
#line 50 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue("", 2143, item.Cod_Usuario, 2143, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2162, ")", 2162, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-flag\"></i> Presente</button>\n");
#nullable restore
#line 51 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\n          <td>\n");
#nullable restore
#line 54 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
             if(item.Cod_Presenca != 0 && item.Aluno){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2360, "\'", 2396, 3);
            WriteAttributeValue("", 2370, "Aula(", 2370, 5, true);
#nullable restore
#line 55 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
WriteAttributeValue("", 2375, item.Cod_Presenca, 2375, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2395, ")", 2395, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-book\"></i> Aula</button>\n");
#nullable restore
#line 56 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\n        </tr>    \n");
#nullable restore
#line 59 "/home/ricksam/Projects/CCB/gem/Views/Presenca/List.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n  </table>\n</div>");
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
