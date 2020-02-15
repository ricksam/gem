#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30376a3b19da8a49cc70c7dee7a0cfdb471c1ba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escala_List), @"mvc.1.0.view", @"/Views/Escala/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30376a3b19da8a49cc70c7dee7a0cfdb471c1ba6", @"/Views/Escala/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Escala_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Escala>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""table-responsive"">
  <table class=""table "">
    <thead>
      <tr>
        <th>Título</th>
        <th>Inicio</th>
        <th>Fim</th>
        <th>Usuarios</th>
        <th>Em dupla</th>
        <th>Sequencial</th>
        <th>Instrutor</th>
        <th></th>
        <th></th>
        <th></th>
      </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 22 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <th>");
#nullable restore
#line 25 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n          <td>");
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Inicio.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 27 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Fim.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <th>");
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.GetUsuarios().Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>  \r\n          <td>");
#nullable restore
#line 29 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
          Write(item.Dupla ? "Sim" : "Não");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 30 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
          Write(item.DiaSequencial ? "Sim" : "Não");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 31 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Instrutor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td><a class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 860, "\"", 904, 2);
            WriteAttributeValue("", 867, "/Escala/Visualizar/", 867, 19, true);
#nullable restore
#line 32 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
WriteAttributeValue("", 886, item.Cod_Escala, 886, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-eye\"></i> Visualizar</a></td>\r\n          <td>\r\n            <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1022, "\'", 1074, 3);
            WriteAttributeValue("", 1032, "Edita(", 1032, 6, true);
#nullable restore
#line 34 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
WriteAttributeValue("", 1038, GEM.Helpers.JSON.Serialize(item), 1038, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1073, ")", 1073, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil\"></i> Editar</button>\r\n          </td>\r\n          <td>\r\n            <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1205, "\'", 1271, 6);
            WriteAttributeValue("", 1215, "DesejaRemover(", 1215, 14, true);
#nullable restore
#line 37 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
WriteAttributeValue("", 1229, item.Cod_Escala, 1229, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1247, ",", 1247, 1, true);
            WriteAttributeValue(" ", 1248, "\"", 1249, 2, true);
#nullable restore
#line 37 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
WriteAttributeValue("", 1250, item.Cod_Usuario, 1250, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1269, "\")", 1269, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 40 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.Escala>> Html { get; private set; }
    }
}
#pragma warning restore 1591
