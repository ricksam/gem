#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ba0e7a3f3dcc8146a8dd00c5a7b02c18c0d1d6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aviso_Edit), @"mvc.1.0.view", @"/Views/Aviso/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ba0e7a3f3dcc8146a8dd00c5a7b02c18c0d1d6c", @"/Views/Aviso/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Aviso_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.Aviso>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-danger\" role=\"alert\">\r\n    This is a danger alert—check it out!\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <input type=\"hidden\" name=\"Cod_Aviso\"");
            BeginWriteAttribute("value", " value=\"", 217, "\"", 243, 1);
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 225, Model.Cod_Aviso, 225, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Cod_Usuario\"");
            BeginWriteAttribute("value", " value=\"", 292, "\"", 320, 1);
#nullable restore
#line 12 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 300, Model.Cod_Usuario, 300, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <div class=\"form-group col-sm-12\">\r\n        <label class=\"control-label\">Título</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Nome\"");
            BeginWriteAttribute("value", " value=\"", 480, "\"", 501, 1);
#nullable restore
#line 16 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 488, Model.Nome, 488, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n\r\n    <div class=\"form-group col-sm-12\">\r\n        <label class=\"control-label\">Mensagem</label>\r\n        <textarea class=\"form-control\" name=\"Mensagem\">");
#nullable restore
#line 21 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
                                                   Write(Model.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n    </div> \r\n\r\n    <div class=\"form-group col-md-12\">\r\n        <label class=\"control-label\">Visibilidade (Quem pode visualizar)</label><br />\r\n        <!--input type=\"hidden\" id=\"Instrutor\" name=\"Instrutor\" value=\"");
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
                                                                   Write(Model.Instrutor.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\"-->\r\n        <input type=\"hidden\" id=\"Oficializado\" name=\"Oficializado\"");
            BeginWriteAttribute("value", " value=\"", 1016, "\"", 1056, 1);
#nullable restore
#line 27 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 1024, Model.Oficializado.ToString(), 1024, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"RJM\" name=\"RJM\"");
            BeginWriteAttribute("value", " value=\"", 1108, "\"", 1139, 1);
#nullable restore
#line 28 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 1116, Model.RJM.ToString(), 1116, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"Aluno\" name=\"Aluno\"");
            BeginWriteAttribute("value", " value=\"", 1195, "\"", 1228, 1);
#nullable restore
#line 29 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 1203, Model.Aluno.ToString(), 1203, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"btn-group\" role=\"group\">\r\n            <!--button type=\"button\" class=\'btn ");
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
                                            Write(Model.Instrutor ? "btn-dark" : "btn-secondary");

#line default
#line hidden
#nullable disable
            WriteLiteral("\' onclick=\"ChangeValue(this, \'#Instrutor\')\"> <i class=\'fa ");
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
                                                                                                                                                       Write(Model.Instrutor ? "fa-check-square-o" : "fa-square-o");

#line default
#line hidden
#nullable disable
            WriteLiteral("\'></i> Instrutores</button-->\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1553, "\'", 1617, 2);
            WriteAttributeValue("", 1561, "btn", 1561, 3, true);
#nullable restore
#line 32 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1564, Model.Oficializado ? "btn-dark" : "btn-secondary", 1565, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Oficializado\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1667, "\'", 1737, 2);
            WriteAttributeValue("", 1675, "fa", 1675, 2, true);
#nullable restore
#line 32 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1677, Model.Oficializado ? "fa-check-square-o" : "fa-square-o", 1678, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> Oficializados</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1801, "\'", 1856, 2);
            WriteAttributeValue("", 1809, "btn", 1809, 3, true);
#nullable restore
#line 33 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1812, Model.RJM ? "btn-dark" : "btn-secondary", 1813, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#RJM\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1897, "\'", 1958, 2);
            WriteAttributeValue("", 1905, "fa", 1905, 2, true);
#nullable restore
#line 33 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1907, Model.RJM ? "fa-check-square-o" : "fa-square-o", 1908, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> RJM</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 2012, "\'", 2069, 2);
            WriteAttributeValue("", 2020, "btn", 2020, 3, true);
#nullable restore
#line 34 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 2023, Model.Aluno ? "btn-dark" : "btn-secondary", 2024, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Aluno\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 2112, "\'", 2175, 2);
            WriteAttributeValue("", 2120, "fa", 2120, 2, true);
#nullable restore
#line 34 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 2122, Model.Aluno ? "fa-check-square-o" : "fa-square-o", 2123, 52, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.Aviso> Html { get; private set; }
    }
}
#pragma warning restore 1591
