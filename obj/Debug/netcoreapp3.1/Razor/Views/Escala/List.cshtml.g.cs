#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4159e7bd887c677d40350aa198021f54c37a7c04"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4159e7bd887c677d40350aa198021f54c37a7c04", @"/Views/Escala/List.cshtml")]
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
        <th>#</th>
        <th>Cod_Usuario</th>
        <th>Usuarios</th>
        <th>Inicio</th>
        <th>Fim</th>
        <th>Dias</th>
        <th>Dupla</th>
        <th>DiaSequencial</th>
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
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 25 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Cod_Escala);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Cod_Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 27 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Usuarios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Inicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 29 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Fim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 30 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Dias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 31 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.Dupla);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 32 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
         Write(item.DiaSequencial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n            <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 832, "\'", 872, 3);
            WriteAttributeValue("", 842, "Edita(", 842, 6, true);
#nullable restore
#line 34 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
WriteAttributeValue("", 848, Json.Serialize(item), 848, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 871, ")", 871, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil\"></i> Editar</button>\r\n          </td>\r\n          <td>\r\n            <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1003, "\'", 1069, 6);
            WriteAttributeValue("", 1013, "DesejaRemover(", 1013, 14, true);
#nullable restore
#line 37 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
WriteAttributeValue("", 1027, item.Cod_Escala, 1027, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1045, ",", 1045, 1, true);
            WriteAttributeValue(" ", 1046, "\"", 1047, 2, true);
#nullable restore
#line 37 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\List.cshtml"
WriteAttributeValue("", 1048, item.Cod_Usuario, 1048, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1067, "\")", 1067, 2, true);
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
