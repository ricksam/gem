#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57ff1576c81f0d89c0436ecf29a760420974a91"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57ff1576c81f0d89c0436ecf29a760420974a91", @"/Views/Arquivo/Edit.cshtml")]
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
            WriteLiteral(" />\r\n     \r\n    <div class=\"form-group col-sm-12\">\r\n        <label class=\"control-label\">Url</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Url\"");
            BeginWriteAttribute("value", " value=\"", 487, "\"", 507, 1);
#nullable restore
#line 16 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 495, Model.Url, 495, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    \r\n    <div class=\"form-group col-md-12\">\r\n        <input type=\"hidden\" id=\"Instrutor\" name=\"Instrutor\"");
            BeginWriteAttribute("value", " value=\"", 632, "\"", 658, 1);
#nullable restore
#line 20 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 640, Model.Instrutor, 640, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"Oficializado\" name=\"Oficializado\"");
            BeginWriteAttribute("value", " value=\"", 728, "\"", 757, 1);
#nullable restore
#line 21 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 736, Model.Oficializado, 736, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"RJM\" name=\"RJM\"");
            BeginWriteAttribute("value", " value=\"", 809, "\"", 829, 1);
#nullable restore
#line 22 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 817, Model.RJM, 817, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"hidden\" id=\"Aluno\" name=\"Aluno\"");
            BeginWriteAttribute("value", " value=\"", 885, "\"", 907, 1);
#nullable restore
#line 23 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue("", 893, Model.Aluno, 893, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"btn-group\" role=\"group\">\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 990, "\'", 1051, 2);
            WriteAttributeValue("", 998, "btn", 998, 3, true);
#nullable restore
#line 25 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1001, Model.Instrutor ? "btn-dark" : "btn-secondary", 1002, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Instrutor\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1098, "\'", 1165, 2);
            WriteAttributeValue("", 1106, "fa", 1106, 2, true);
#nullable restore
#line 25 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1108, Model.Instrutor ? "fa-check-square-o" : "fa-square-o", 1109, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> Instrutores</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1227, "\'", 1291, 2);
            WriteAttributeValue("", 1235, "btn", 1235, 3, true);
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1238, Model.Oficializado ? "btn-dark" : "btn-secondary", 1239, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Oficializado\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1341, "\'", 1411, 2);
            WriteAttributeValue("", 1349, "fa", 1349, 2, true);
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1351, Model.Oficializado ? "fa-check-square-o" : "fa-square-o", 1352, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> Oficializados</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1475, "\'", 1530, 2);
            WriteAttributeValue("", 1483, "btn", 1483, 3, true);
#nullable restore
#line 27 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1486, Model.RJM ? "btn-dark" : "btn-secondary", 1487, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#RJM\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1571, "\'", 1632, 2);
            WriteAttributeValue("", 1579, "fa", 1579, 2, true);
#nullable restore
#line 27 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1581, Model.RJM ? "fa-check-square-o" : "fa-square-o", 1582, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> RJM</button>\r\n            <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 1686, "\'", 1743, 2);
            WriteAttributeValue("", 1694, "btn", 1694, 3, true);
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1697, Model.Aluno ? "btn-dark" : "btn-secondary", 1698, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChangeValue(this, \'#Aluno\')\"> <i");
            BeginWriteAttribute("class", " class=\'", 1786, "\'", 1849, 2);
            WriteAttributeValue("", 1794, "fa", 1794, 2, true);
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\Edit.cshtml"
WriteAttributeValue(" ", 1796, Model.Aluno ? "fa-check-square-o" : "fa-square-o", 1797, 52, false);

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