#pragma checksum "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d6ea542a8c2b1553350862332d3a9046115a040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comum_List), @"mvc.1.0.view", @"/Views/Comum/List.cshtml")]
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
#line 1 "D:\PROJECTS\RckSoftware\GEM\Views\_ViewImports.cshtml"
using GEM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\GEM\Views\_ViewImports.cshtml"
using GEM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d6ea542a8c2b1553350862332d3a9046115a040", @"/Views/Comum/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Comum_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Comum>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""table-responsive"">
  <table class=""table "">
    <thead>
      <tr>
        <th>#</th>
        <th>Nome</th>
        <th>Cidade</th>
        <th>Estado</th>
        <th>Endereco</th>
        <th></th>
        <th></th>
      </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 19 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 22 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
         Write(item.Cod_Comum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 23 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 24 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
         Write(item.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
         Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
         Write(item.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n            <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 640, "\'", 680, 3);
            WriteAttributeValue("", 650, "Edita(", 650, 6, true);
#nullable restore
#line 28 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
WriteAttributeValue("", 656, Json.Serialize(item), 656, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 679, ")", 679, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil\"></i> Editar</button>\r\n          </td>\r\n          <td>\r\n            <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 811, "\'", 869, 6);
            WriteAttributeValue("", 821, "DesejaRemover(", 821, 14, true);
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
WriteAttributeValue("", 835, item.Cod_Comum, 835, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 852, ",", 852, 1, true);
            WriteAttributeValue(" ", 853, "\"", 854, 2, true);
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
WriteAttributeValue("", 855, item.Nome, 855, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 867, "\")", 867, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 34 "D:\PROJECTS\RckSoftware\GEM\Views\Comum\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.Comum>> Html { get; private set; }
    }
}
#pragma warning restore 1591
