#pragma checksum "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0258521a1363185416dfb805417bc19da0c9a3e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoEstudo_List), @"mvc.1.0.view", @"/Views/TipoEstudo/List.cshtml")]
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
#line 1 "d:\PROJECTS\RckSoftware\GEM\Views\_ViewImports.cshtml"
using GEM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\GEM\Views\_ViewImports.cshtml"
using GEM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0258521a1363185416dfb805417bc19da0c9a3e9", @"/Views/TipoEstudo/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoEstudo_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.TipoEstudo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-responsive\">\r\n  <table class=\"table \">\r\n    <thead>\r\n      <tr>\r\n        <th>#</th>\r\n        <th>Nome</th>\r\n        <th></th>\r\n        <th></th>\r\n      </tr>\r\n      </thead>\r\n      <tbody>\r\n");
#nullable restore
#line 16 "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 19 "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml"
         Write(item.Cod_Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 20 "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n            <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 466, "\'", 506, 3);
            WriteAttributeValue("", 476, "Edita(", 476, 6, true);
#nullable restore
#line 22 "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml"
WriteAttributeValue("", 482, Json.Serialize(item), 482, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 505, ")", 505, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil\"></i> Editar</button>\r\n          </td>\r\n          <td>\r\n            <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 637, "\'", 694, 6);
            WriteAttributeValue("", 647, "DesejaRemover(", 647, 14, true);
#nullable restore
#line 25 "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml"
WriteAttributeValue("", 661, item.Cod_Tipo, 661, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 677, ",", 677, 1, true);
            WriteAttributeValue(" ", 678, "\"", 679, 2, true);
#nullable restore
#line 25 "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml"
WriteAttributeValue("", 680, item.Nome, 680, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 692, "\")", 692, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\GEM\Views\TipoEstudo\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.TipoEstudo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
