#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d22662fb1eb70e89367ca45d6ae78c6615e848b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Arquivo_Edit), @"mvc.1.0.view", @"/Views/Arquivo/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d22662fb1eb70e89367ca45d6ae78c6615e848b", @"/Views/Arquivo/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Arquivo_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.Arquivo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-danger\" role=\"alert\">\r\n    This is a danger alert—check it out!\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <input type=\"hidden\" name=\"Cod_Arquivo\"");
            BeginWriteAttribute("value", " value=\"", 221, "\"", 249, 1);
#nullable restore
#line 11 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 229, Model.Cod_Arquivo, 229, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Cod_Usuario\"");
            BeginWriteAttribute("value", " value=\"", 298, "\"", 326, 1);
#nullable restore
#line 12 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 306, Model.Cod_Usuario, 306, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <div class=\"form-group col-sm-12\">\r\n        <label class=\"control-label\">Nome</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Nome\"");
            BeginWriteAttribute("value", " value=\"", 484, "\"", 505, 1);
#nullable restore
#line 16 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 492, Model.Nome, 492, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n     \r\n    <div class=\"form-group col-sm-12\">\r\n        <label class=\"control-label\">Url</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Url\"");
            BeginWriteAttribute("value", " value=\"", 678, "\"", 698, 1);
#nullable restore
#line 21 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 686, Model.Url, 686, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    \r\n    <div class=\"form-group col-md-12\">\r\n        <label class=\"control-label\">Visibilidade (Quem pode acessar)</label><br />\r\n        <!--input type=\"hidden\" id=\"Instrutor\" name=\"Instrutor\" value=\"");
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
                                                                   Write(Model.Instrutor.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\"-->\r\n        <input type=\"hidden\" id=\"Oficializado\" name=\"Oficializado\"");
            BeginWriteAttribute("value", " value=\"", 1020, "\"", 1060, 1);
#nullable restore
#line 27 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 1028, Model.Oficializado.ToString(), 1028, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"RJM\" name=\"RJM\"");
            BeginWriteAttribute("value", " value=\"", 1112, "\"", 1143, 1);
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 1120, Model.RJM.ToString(), 1120, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"Aluno\" name=\"Aluno\"");
            BeginWriteAttribute("value", " value=\"", 1199, "\"", 1232, 1);
#nullable restore
#line 29 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 1207, Model.Aluno.ToString(), 1207, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"btn-group\" role=\"group\">\r\n            <!--button type=\"button\" class=\'btn ");
#nullable restore
#line 31 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
                                            Write(Model.Instrutor ? "btn-dark" : "btn-secondary");

#line default
#line hidden
#nullable disable
            WriteLiteral("\' onclick=\"ChangeValue(this, \'#Instrutor\')\"> <i class=\'fa ");
#nullable restore
#line 31 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
                                                                                                                                                       Write(Model.Instrutor ? "fa-check-square-o" : "fa-square-o");

#line default
#line hidden
#nullable disable
            WriteLiteral("\'></i> Instrutores</button-->\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1557, "\'", 1621, 2);
            WriteAttributeValue("", 1565, "btn", 1565, 3, true);
#nullable restore
#line 32 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1568, Model.Oficializado ? "btn-dark" : "btn-secondary", 1569, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Oficializado\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1671, "\'", 1741, 2);
            WriteAttributeValue("", 1679, "fa", 1679, 2, true);
#nullable restore
#line 32 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1681, Model.Oficializado ? "fa-check-square-o" : "fa-square-o", 1682, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> Oficializados</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1805, "\'", 1860, 2);
            WriteAttributeValue("", 1813, "btn", 1813, 3, true);
#nullable restore
#line 33 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1816, Model.RJM ? "btn-dark" : "btn-secondary", 1817, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#RJM\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1901, "\'", 1962, 2);
            WriteAttributeValue("", 1909, "fa", 1909, 2, true);
#nullable restore
#line 33 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1911, Model.RJM ? "fa-check-square-o" : "fa-square-o", 1912, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> RJM</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 2016, "\'", 2073, 2);
            WriteAttributeValue("", 2024, "btn", 2024, 3, true);
#nullable restore
#line 34 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 2027, Model.Aluno ? "btn-dark" : "btn-secondary", 2028, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Aluno\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 2116, "\'", 2179, 2);
            WriteAttributeValue("", 2124, "fa", 2124, 2, true);
#nullable restore
#line 34 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 2126, Model.Aluno ? "fa-check-square-o" : "fa-square-o", 2127, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></i> Alunos</button>
        </div>
    </div>
</div> 

<script>
    function ChangeValue(e, id){
        $(e).removeClass(""btn-dark"");
        $(e).removeClass(""btn-secondary"");

        $(e).find("".fa"").removeClass(""fa-square-o"");
        $(e).find("".fa"").removeClass(""fa-check-square-o"");

        if($(id).val()==""True""){
            $(id).val(""False"");
            $(e).addClass(""btn-secondary"");
            $(e).find("".fa"").addClass(""fa-square-o"");
        }else{
            $(id).val(""True"");
            $(e).addClass(""btn-dark"");
            $(e).find("".fa"").addClass(""fa-check-square-o"");
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.Arquivo> Html { get; private set; }
    }
}
#pragma warning restore 1591
