#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "711592f5b74069707aab05b3af1eee197117e1ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_Historico), @"mvc.1.0.view", @"/Views/Presenca/Historico.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711592f5b74069707aab05b3af1eee197117e1ec", @"/Views/Presenca/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Estudo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n  <div class=\"alert alert-danger\" role=\"alert\">\r\n    </div>\r\n\r\n    <div class=\"form-group col-sm-5\">\r\n      <label>");
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
         Write(ViewBag.Aluno?"Aluno":"Instrutor");

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 276, "\"", 299, 1);
#nullable restore
#line 12 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
WriteAttributeValue("", 284, ViewBag.Nome, 284, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n    <div class=\"form-group col-sm-4\">\r\n      <label>Instrumento</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 430, "\"", 460, 1);
#nullable restore
#line 16 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
WriteAttributeValue("", 438, ViewBag.Instrumento, 438, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n    <div class=\"form-group col-sm-3\">\r\n      <label>Filtrar</label>\r\n      ");
#nullable restore
#line 20 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
 Write(await Html.PartialAsync("~/Views/Shared/_Combo.cshtml", new GEM.Models.Combo(){
                Class="form-control",
                Name="Cod_Tipo",
                OnChange="FiltraTipo(this)",
                DefaultText = "Todos",
                Items=GEM.Repository.TipoEstudo.List().Select(e=>new ComboItem(){Text=e.Nome,Value=e.Cod_Tipo.ToString()}).ToList()
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"table-responsive\">\r\n  <table class=\"table \">\r\n    <thead>\r\n      <tr>\r\n        <th>Data</th>\r\n        <th>Tipo</th>\r\n        <th>Controle</th>\r\n        <th>Observação</th>\r\n        <th>");
#nullable restore
#line 39 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
        Write(ViewBag.Aluno?"Instrutor":"Aluno");

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      </tr>\r\n      </thead>\r\n      <tbody>\r\n");
#nullable restore
#line 43 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=\"", 1314, "\"", 1352, 3);
            WriteAttributeValue("", 1322, "tr_tipo", 1322, 7, true);
            WriteAttributeValue(" ", 1329, "tr_tp_", 1330, 7, true);
#nullable restore
#line 45 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
WriteAttributeValue("", 1336, item.Cod_Tipo, 1336, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n          <td>");
#nullable restore
#line 46 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
         Write(item.Data.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 47 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
          Write(item.Cod_Justificativa != 0? "Falta" : item.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 48 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
          Write(item.Cod_Justificativa != 0? "Justificada" : string.Format("{0} {1}", item.Controle, item.Numero == 0 ? "" : item.Numero.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 49 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
         Write(item.Observacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 50 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
          Write(string.Format("{0}{1}", GEM.Helpers.Util.ShortName(item.Nome_Instrutor), item.Nome_Aluno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>    \r\n");
#nullable restore
#line 52 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Historico.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div> \r\n\r\n<script>\r\n  function FiltraTipo(e){\r\n    $(\".tr_tipo\").hide();\r\n\r\n    if($(e).val().length==0){\r\n      $(\".tr_tipo\").show();\r\n    }else{\r\n      $(\".tr_tp_\"+$(e).val()).show();\r\n    }\r\n  } \r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.Estudo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
