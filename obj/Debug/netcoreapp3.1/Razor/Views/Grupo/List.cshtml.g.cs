#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1246585477277277733c5faf905242cc75cbad0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grupo_List), @"mvc.1.0.view", @"/Views/Grupo/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1246585477277277733c5faf905242cc75cbad0", @"/Views/Grupo/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Grupo_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Grupo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\List.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-responsive\">\r\n  <table class=\"table \">\r\n    <thead>\r\n      <tr>\r\n        <th>Nome</th>\r\n        <th></th>\r\n        <th></th>\r\n      </tr>\r\n      </thead>\r\n      <tbody>\r\n");
#nullable restore
#line 15 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 18 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n            <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 406, "\'", 458, 3);
            WriteAttributeValue("", 416, "Edita(", 416, 6, true);
#nullable restore
#line 20 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\List.cshtml"
WriteAttributeValue("", 422, GEM.Helpers.JSON.Serialize(item), 422, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 457, ")", 457, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil\"></i> Editar</button>\r\n          </td>\r\n          <td>\r\n            <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 589, "\'", 647, 6);
            WriteAttributeValue("", 599, "DesejaRemover(", 599, 14, true);
#nullable restore
#line 23 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\List.cshtml"
WriteAttributeValue("", 613, item.Cod_Grupo, 613, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 630, ",", 630, 1, true);
            WriteAttributeValue(" ", 631, "\"", 632, 2, true);
#nullable restore
#line 23 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\List.cshtml"
WriteAttributeValue("", 633, item.Nome, 633, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 645, "\")", 645, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.Grupo>> Html { get; private set; }
    }
}
#pragma warning restore 1591