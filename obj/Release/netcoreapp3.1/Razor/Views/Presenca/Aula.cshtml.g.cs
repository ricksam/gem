#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "834199bf55b17b769f849252562dba8cbf0ecf18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_Aula), @"mvc.1.0.view", @"/Views/Presenca/Aula.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834199bf55b17b769f849252562dba8cbf0ecf18", @"/Views/Presenca/Aula.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_Aula : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Estudo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"DadosAula\" class=\"row\">\r\n    <div class=\"alert alert-danger\" role=\"alert\">\r\n    </div>\r\n\r\n    <input type=\"hidden\" name=\"Cod_Presenca\"");
            BeginWriteAttribute("value", " value=\"", 206, "\"", 237, 1);
#nullable restore
#line 10 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 214, ViewBag.Cod_Presenca, 214, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"hidden\" name=\"Cod_Usuario\"");
            BeginWriteAttribute("value", " value=\"", 284, "\"", 314, 1);
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 292, ViewBag.Cod_Usuario, 292, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    <div class=\"form-group col-sm-6\">\r\n      <label>Nome</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 419, "\"", 443, 1);
#nullable restore
#line 15 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 427, ViewBag.Aluno, 427, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n    <div class=\"form-group col-sm-6\">\r\n      <label>Instrumento</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 574, "\"", 604, 1);
#nullable restore
#line 19 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 582, ViewBag.Instrumento, 582, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n\r\n    <div class=\"form-group col-sm-4\">\r\n        <label>Tipo</label>\r\n        ");
#nullable restore
#line 24 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_Combo.cshtml", new GEM.Models.Combo(){
                Class="form-control",
                Name="Cod_Tipo",
                OnChange="TipoChange(this)",
                Items=GEM.Repository.TipoEstudo.List().Select(e=>new ComboItem(){Text=e.Nome,Value=e.Cod_Tipo.ToString()}).ToList()
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""form-group col-sm-2"">
        <label id=""Controle"">Número</label>
        <input type=""number"" class=""form-control"" name=""Numero"">
    </div>
    <div class=""form-group col-sm-5"">
        <label>Observação</label>
        <input type=""text"" class=""form-control"" name=""Observacao"">
    </div>
    <div class=""form-group col-sm-1"">
        <label>&nbsp;</label>
        <button class=""btn btn-primary""");
            BeginWriteAttribute("onclick", " onclick=\"", 1494, "\"", 1565, 5);
            WriteAttributeValue("", 1504, "AdicionaAula(", 1504, 13, true);
#nullable restore
#line 41 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 1517, ViewBag.Cod_Presenca, 1517, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1540, ",", 1540, 1, true);
#nullable restore
#line 41 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue(" ", 1541, ViewBag.Cod_Usuario, 1542, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1564, ")", 1564, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-plus""></i></button>
    </div>
</div>

<div class=""table-responsive"">
  <table class=""table "">
    <thead>
      <tr>
        <th>Tipo</th>
        <th>Controle</th>
        <th>Observacao</th>
        <th>Instrutor</th>
        <th></th>
      </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 57 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 60 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
         Write(item.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 61 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
         Write(string.Format("{0} {1}", item.Controle, item.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 62 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
         Write(item.Observacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 63 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
         Write(item.Nome_Instrutor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          \r\n          <td>\r\n            <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2198, "\'", 2287, 7);
            WriteAttributeValue("", 2208, "RemoveAula(", 2208, 11, true);
#nullable restore
#line 66 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 2219, ViewBag.Cod_Presenca, 2219, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2242, ",", 2242, 1, true);
#nullable restore
#line 66 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue(" ", 2243, ViewBag.Cod_Usuario, 2244, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2266, ",", 2266, 1, true);
#nullable restore
#line 66 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue(" ", 2267, item.Cod_Estudo, 2268, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2286, ")", 2286, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 69 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div> \r\n\r\n<script>\r\n  function TipoChange(e){\r\n    rsp.post({ Cod_Tipo : $(e).val() }, \"/Presenca/Controle\", (res)=>{\r\n      $(\"#Controle\").html(res);\r\n    })\r\n  }\r\n</script>");
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
