#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb35cc4af85300ece2f17616ab579ddea80129a0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb35cc4af85300ece2f17616ab579ddea80129a0", @"/Views/Presenca/Aula.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_Aula : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Estudo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n  <div class=\"col-md-12\">\r\n      <div class=\"alert alert-danger\" role=\"alert\">\r\n      </div>\r\n    </div>\r\n\r\n    <div class=\"form-group col-sm-4\">\r\n      <label>Nome</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 289, "\"", 313, 1);
#nullable restore
#line 14 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 297, ViewBag.Aluno, 297, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n    <div class=\"form-group col-sm-4\">\r\n      <label>Instrumento</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 444, "\"", 474, 1);
#nullable restore
#line 18 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 452, ViewBag.Instrumento, 452, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n    <div class=\"form-group col-sm-4\">\r\n      <label>Data</label>\r\n      <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\'", 598, "\'", 644, 1);
#nullable restore
#line 22 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
WriteAttributeValue("", 606, ViewBag.Data.ToString("dd/MM/yyyy"), 606, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"ListaAula\">\r\n  ");
#nullable restore
#line 27 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
Write(await Html.PartialAsync("~/Views/Presenca/ListaAula.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>
  function AulaTipoChange(e){
    rsp.post({ Cod_Tipo : $(e).val(), input_name: ""estudo.Numero"" }, ""/Presenca/Controle"", (res)=>{
      $(""#AulaControle"").html(res);
    })
  }

  function ListaAula(Cod_Presenca){
    rsp.post({ Cod_Presenca }, ""/Presenca/ListaAula"", ""#ListaAula"");
  }

  function AdicionaAula(Cod_Presenca){
      rsp.post(""#DadosAula"", ""/Presenca/AdicionaAula"", ""#ListaAula"")
  }
 
  function RemoveAula(Cod_Presenca, Cod_Estudo, Descricao){
      rsp.post({Cod_Presenca, Cod_Estudo, Descricao:'");
#nullable restore
#line 46 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
                                                 Write(GEM.Helpers.Util.ShortName(ViewBag.Aluno));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Aula.cshtml"
                                                                                              Write(ViewBag.Data.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \' + Descricao }, \"/Presenca/RemoveAula\", \"#ListaAula\")\r\n  }\r\n</script>");
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
