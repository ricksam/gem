#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05372dd90febf9e5e14bde0ffd50f34e3434d401"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_Situacao), @"mvc.1.0.view", @"/Views/Presenca/Situacao.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05372dd90febf9e5e14bde0ffd50f34e3434d401", @"/Views/Presenca/Situacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_Situacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.UsuarioPresenca>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
  
    Layout=null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
 if(Model.Cod_Presenca == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 141, "\'", 205, 3);
            WriteAttributeValue("", 151, "RegistraPresenca(", 151, 17, true);
#nullable restore
#line 7 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 168, GEM.Helpers.JSON.Serialize(Model), 168, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 204, ")", 204, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-exclamation\"></i> Falta</button>\r\n");
#nullable restore
#line 8 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
     if(Model.Cod_Justificativa==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-warning text-white btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 349, "\"", 435, 9);
            WriteAttributeValue("", 359, "Justificativa(", 359, 14, true);
#nullable restore
#line 9 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 373, Model.Cod_Usuario, 373, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 393, ",", 393, 1, true);
            WriteAttributeValue(" ", 394, "\'", 395, 2, true);
#nullable restore
#line 9 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 396, Model.Nome, 396, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 409, "\',", 409, 2, true);
            WriteAttributeValue(" ", 411, "\'", 412, 2, true);
#nullable restore
#line 9 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 413, Model.Instrumento, 413, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 433, "\')", 433, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-exclamation-triangle\"></i> Justificar </button>\r\n");
#nullable restore
#line 10 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 559, "\"", 645, 9);
            WriteAttributeValue("", 569, "Justificativa(", 569, 14, true);
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 583, Model.Cod_Usuario, 583, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 603, ",", 603, 1, true);
            WriteAttributeValue(" ", 604, "\'", 605, 2, true);
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 606, Model.Nome, 606, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 619, "\',", 619, 2, true);
            WriteAttributeValue(" ", 621, "\'", 622, 2, true);
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 623, Model.Instrumento, 623, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 643, "\')", 643, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-exclamation-triangle\"></i> Justificada </button>\r\n");
#nullable restore
#line 12 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
     
    
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-success btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 779, "\'", 843, 3);
            WriteAttributeValue("", 789, "RegistraAusencia(", 789, 17, true);
#nullable restore
#line 16 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 806, GEM.Helpers.JSON.Serialize(Model), 806, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 842, ")", 842, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-flag\"></i> Presente</button>\r\n");
#nullable restore
#line 17 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
 if(Model.Cod_Presenca != 0 && Model.Aluno){

#line default
#line hidden
#nullable disable
            WriteLiteral("<button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 978, "\"", 1037, 5);
            WriteAttributeValue("", 988, "Aula(", 988, 5, true);
#nullable restore
#line 20 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue("", 993, Model.Cod_Presenca, 993, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1014, ",", 1014, 1, true);
#nullable restore
#line 20 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
WriteAttributeValue(" ", 1015, Model.Cod_Usuario, 1016, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1036, ")", 1036, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-book\"></i> Conteúdo</button>\r\n");
#nullable restore
#line 21 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Situacao.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.UsuarioPresenca> Html { get; private set; }
    }
}
#pragma warning restore 1591