#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f84a59f8ab5d034100fcd3f6fa91a01c6a6785c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f84a59f8ab5d034100fcd3f6fa91a01c6a6785c", @"/Views/Aviso/Edit.cshtml")]
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
            WriteLiteral(" />\r\n\r\n    <div class=\"form-group col-sm-12\">\r\n        <label class=\"control-label\">Mensagem</label>\r\n        <textarea class=\"form-control\" name=\"Mensagem\">");
#nullable restore
#line 16 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
                                                   Write(Model.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n    </div> \r\n\r\n    <div class=\"form-group col-md-12\">\r\n        <input type=\"hidden\" id=\"Instrutor\" name=\"Instrutor\"");
            BeginWriteAttribute("value", " value=\"", 623, "\"", 660, 1);
#nullable restore
#line 20 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 631, Model.Instrutor.ToString(), 631, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"Oficializado\" name=\"Oficializado\"");
            BeginWriteAttribute("value", " value=\"", 730, "\"", 770, 1);
#nullable restore
#line 21 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 738, Model.Oficializado.ToString(), 738, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"RJM\" name=\"RJM\"");
            BeginWriteAttribute("value", " value=\"", 822, "\"", 853, 1);
#nullable restore
#line 22 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 830, Model.RJM.ToString(), 830, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"Aluno\" name=\"Aluno\"");
            BeginWriteAttribute("value", " value=\"", 909, "\"", 942, 1);
#nullable restore
#line 23 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue("", 917, Model.Aluno.ToString(), 917, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"btn-group\" role=\"group\">\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1025, "\'", 1086, 2);
            WriteAttributeValue("", 1033, "btn", 1033, 3, true);
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1036, Model.Instrutor ? "btn-dark" : "btn-secondary", 1037, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Instrutor\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1133, "\'", 1200, 2);
            WriteAttributeValue("", 1141, "fa", 1141, 2, true);
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1143, Model.Instrutor ? "fa-check-square-o" : "fa-square-o", 1144, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> Instrutores</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1262, "\'", 1326, 2);
            WriteAttributeValue("", 1270, "btn", 1270, 3, true);
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1273, Model.Oficializado ? "btn-dark" : "btn-secondary", 1274, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Oficializado\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1376, "\'", 1446, 2);
            WriteAttributeValue("", 1384, "fa", 1384, 2, true);
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1386, Model.Oficializado ? "fa-check-square-o" : "fa-square-o", 1387, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> Oficializados</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1510, "\'", 1565, 2);
            WriteAttributeValue("", 1518, "btn", 1518, 3, true);
#nullable restore
#line 27 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1521, Model.RJM ? "btn-dark" : "btn-secondary", 1522, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#RJM\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1606, "\'", 1667, 2);
            WriteAttributeValue("", 1614, "fa", 1614, 2, true);
#nullable restore
#line 27 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1616, Model.RJM ? "fa-check-square-o" : "fa-square-o", 1617, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> RJM</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1721, "\'", 1778, 2);
            WriteAttributeValue("", 1729, "btn", 1729, 3, true);
#nullable restore
#line 28 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1732, Model.Aluno ? "btn-dark" : "btn-secondary", 1733, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Aluno\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1821, "\'", 1884, 2);
            WriteAttributeValue("", 1829, "fa", 1829, 2, true);
#nullable restore
#line 28 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Aviso\Edit.cshtml"
WriteAttributeValue(" ", 1831, Model.Aluno ? "fa-check-square-o" : "fa-square-o", 1832, 52, false);

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
