#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd42bdd092e2fc8e3920295644d43c0f9ff8439e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_AulaGrupo), @"mvc.1.0.view", @"/Views/Presenca/AulaGrupo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd42bdd092e2fc8e3920295644d43c0f9ff8439e", @"/Views/Presenca/AulaGrupo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_AulaGrupo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"DadosAulaGrupo\" >\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <div class=\"alert alert-danger\" role=\"alert\">\r\n            </div>\r\n        </div>\r\n        \r\n        <input type=\"hidden\" name=\"Cod_Comum\"");
            BeginWriteAttribute("value", " value=\"", 261, "\"", 289, 1);
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
WriteAttributeValue("", 269, ViewBag.Cod_Comum, 269, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" name=\"Cod_Grupo\"");
            BeginWriteAttribute("value", " value=\"", 338, "\"", 366, 1);
#nullable restore
#line 12 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
WriteAttributeValue("", 346, ViewBag.Cod_Grupo, 346, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <div class=\"form-group col-sm-4\">\r\n        <label>Grupo</label>\r\n        <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 480, "\"", 504, 1);
#nullable restore
#line 16 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
WriteAttributeValue("", 488, ViewBag.Grupo, 488, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n        </div>\r\n        <div class=\"form-group col-sm-4\">\r\n        <label>Alunos</label>\r\n        <input type=\"hidden\" id=\"AlunosCount\" name=\"AlunosCount\"");
            BeginWriteAttribute("value", " value=\"", 671, "\"", 701, 1);
#nullable restore
#line 20 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
WriteAttributeValue("", 679, ViewBag.AlunosCount, 679, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 752, "\"", 782, 1);
#nullable restore
#line 21 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
WriteAttributeValue("", 760, ViewBag.AlunosCount, 760, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n        </div>\r\n        <div class=\"form-group col-sm-4\">\r\n        <label>Data</label>\r\n        <input type=\"hidden\" name=\"Data\"");
            BeginWriteAttribute("value", " value=\'", 923, "\'", 969, 1);
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
WriteAttributeValue("", 931, ViewBag.Data.ToString("yyyy-MM-dd"), 931, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\'", 1020, "\'", 1066, 1);
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
WriteAttributeValue("", 1028, ViewBag.Data.ToString("dd/MM/yyyy"), 1028, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n        </div>  \r\n    </div>\r\n\r\n    <div id=\"ListaAulaGrupo\">\r\n        ");
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\AulaGrupo.cshtml"
   Write(await Html.PartialAsync("~/Views/Presenca/ListaAulaGrupo.cshtml", new List<GEM.Repository.Estudo>()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
