#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "654d7e42779a96e1be2ba779a109b55e94db475b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escala_Edit), @"mvc.1.0.view", @"/Views/Escala/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654d7e42779a96e1be2ba779a109b55e94db475b", @"/Views/Escala/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Escala_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.Escala>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-danger\" role=\"alert\">\r\n    This is a danger alert—check it out!\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <input type=\"hidden\" name=\"Cod_Escala\"");
            BeginWriteAttribute("value", " value=\"", 219, "\"", 246, 1);
#nullable restore
#line 11 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 227, Model.Cod_Escala, 227, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Cod_Usuario\"");
            BeginWriteAttribute("value", " value=\"", 295, "\"", 323, 1);
#nullable restore
#line 12 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 303, Model.Cod_Usuario, 303, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <div class=""form-group col-sm-6"">
        <label class=""control-label"">Cod_Usuario</label>
        
    </div>
    <div class=""form-group col-sm-6"">
        <label class=""control-label"">Título</label>
        <input type=""text"" class=""form-control"" name=""Nome""");
            BeginWriteAttribute("value", " value=\"", 601, "\"", 622, 1);
#nullable restore
#line 20 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 609, Model.Nome, 609, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Usuarios</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Usuarios\"");
            BeginWriteAttribute("value", " value=\"", 798, "\"", 823, 1);
#nullable restore
#line 24 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 806, Model.Usuarios, 806, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Inicio</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Inicio\"");
            BeginWriteAttribute("value", " value=\"", 995, "\"", 1018, 1);
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 1003, Model.Inicio, 1003, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Fim</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Fim\"");
            BeginWriteAttribute("value", " value=\"", 1184, "\"", 1204, 1);
#nullable restore
#line 32 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 1192, Model.Fim, 1192, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Dias</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Dias\"");
            BeginWriteAttribute("value", " value=\"", 1372, "\"", 1393, 1);
#nullable restore
#line 36 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 1380, Model.Dias, 1380, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Dupla</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Dupla\"");
            BeginWriteAttribute("value", " value=\"", 1563, "\"", 1585, 1);
#nullable restore
#line 40 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 1571, Model.Dupla, 1571, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">DiaSequencial</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"DiaSequencial\"");
            BeginWriteAttribute("value", " value=\"", 1771, "\"", 1801, 1);
#nullable restore
#line 44 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 1779, Model.DiaSequencial, 1779, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n</div> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.Escala> Html { get; private set; }
    }
}
#pragma warning restore 1591