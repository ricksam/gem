#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76583fc8d54650762d0c64497af223a72ff3de6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76583fc8d54650762d0c64497af223a72ff3de6", @"/Views/Presenca/Aula.cshtml")]
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
            WriteLiteral("\r\n<div id=\"DadosAula\" class=\"row\">\r\n    <div class=\"col-md-12\">\r\n      <div class=\"alert alert-danger\" role=\"alert\">\r\n      </div>\r\n    </div>\r\n    \r\n\r\n    <input type=\"hidden\" name=\"Cod_Presenca\"");
            BeginWriteAttribute("value", " value=\"", 257, "\"", 288, 1);
#nullable restore
#line 13 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 265, ViewBag.Cod_Presenca, 265, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"hidden\" name=\"Cod_Usuario\"");
            BeginWriteAttribute("value", " value=\"", 335, "\"", 365, 1);
#nullable restore
#line 14 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 343, ViewBag.Cod_Usuario, 343, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    <div class=\"form-group col-sm-4\">\r\n      <label>Nome</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 470, "\"", 494, 1);
#nullable restore
#line 18 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 478, ViewBag.Aluno, 478, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n    <div class=\"form-group col-sm-4\">\r\n      <label>Instrumento</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 625, "\"", 655, 1);
#nullable restore
#line 22 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 633, ViewBag.Instrumento, 633, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n    <div class=\"form-group col-sm-4\">\r\n      <label>Data</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\'", 779, "\'", 825, 1);
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 787, ViewBag.Data.ToString("dd/MM/yyyy"), 787, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n\r\n    <div class=\"form-group col-sm-4\">\r\n        <label>Tipo</label>\r\n        ");
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
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
            BeginWriteAttribute("onclick", " onclick=\"", 1715, "\"", 1786, 5);
            WriteAttributeValue("", 1725, "AdicionaAula(", 1725, 13, true);
#nullable restore
#line 48 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 1738, ViewBag.Cod_Presenca, 1738, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1761, ",", 1761, 1, true);
#nullable restore
#line 48 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue(" ", 1762, ViewBag.Cod_Usuario, 1763, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1785, ")", 1785, 1, true);
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
        <th>Observação</th>
        <th>Instrutor</th>
        <th></th>
      </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 64 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 67 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
         Write(item.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 68 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
         Write(string.Format("{0} {1}", item.Controle, item.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 69 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
         Write(item.Observacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 70 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
         Write(GEM.Helpers.Util.ShortName(item.Nome_Instrutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          \r\n          <td>\r\n            <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2447, "\'", 2536, 7);
            WriteAttributeValue("", 2457, "RemoveAula(", 2457, 11, true);
#nullable restore
#line 73 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 2468, ViewBag.Cod_Presenca, 2468, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2491, ",", 2491, 1, true);
#nullable restore
#line 73 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue(" ", 2492, ViewBag.Cod_Usuario, 2493, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2515, ",", 2515, 1, true);
#nullable restore
#line 73 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue(" ", 2516, item.Cod_Estudo, 2517, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2535, ")", 2535, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n          </td>\r\n        </tr>    \r\n");
#nullable restore
#line 76 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
  </table>
</div> 

<script>
  function TipoChange(e){
    rsp.post({ Cod_Tipo : $(e).val() }, ""/Presenca/Controle"", (res)=>{
      $(""#Controle"").html(res);
    })
  }

  function AdicionaAula(Cod_Presenca, Cod_Usuario){
      rsp.post(""#DadosAula"", ""/Presenca/AdicionaAula"", (res)=>{
        if(res==""ok""){
            $(""#DadosAula .alert"").hide();
            Aula(Cod_Presenca, Cod_Usuario);
        }
        else{
            $(""#DadosAula .alert"").html(res);
            $(""#DadosAula .alert"").show();
        }
      })
  }
 
  function RemoveAula(Cod_Presenca, Cod_Usuario, Cod_Estudo){
      rsp.post({Cod_Presenca, Cod_Usuario, Cod_Estudo}, ""/Presenca/RemoveAula"", (res)=>{
      if(res==""ok""){
          $(""#DadosAula .alert"").hide();
          Aula(Cod_Presenca, Cod_Usuario);
      }
      else{
          $(""#DadosAula .alert"").html(res);
          $(""#DadosAula .alert"").show();
      }
      })
  }
</script>");
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
