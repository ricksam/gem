#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0ca78d8bb96c500e911ffc332d36f26db6086b1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0ca78d8bb96c500e911ffc332d36f26db6086b1", @"/Views/Escala/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Escala_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.Escala>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Organistas_Oficializadas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Organistas_RJM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Instrutores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "False", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "True", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
  
    Layout = null;
    Semana DiasSemana = Model.GetDiasSemana();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-danger\" role=\"alert\">\r\n    This is a danger alert—check it out!\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <input type=\"hidden\" name=\"Cod_Escala\"");
            BeginWriteAttribute("value", " value=\"", 267, "\"", 294, 1);
#nullable restore
#line 12 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 275, Model.Cod_Escala, 275, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Cod_Usuario\"");
            BeginWriteAttribute("value", " value=\"", 343, "\"", 371, 1);
#nullable restore
#line 13 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 351, Model.Cod_Usuario, 351, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Cod_Comum\"");
            BeginWriteAttribute("value", " value=\"", 418, "\"", 444, 1);
#nullable restore
#line 14 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 426, Model.Cod_Comum, 426, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Dias\"");
            BeginWriteAttribute("value", " value=\"", 486, "\"", 507, 1);
#nullable restore
#line 15 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 494, Model.Dias, 494, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Usuarios\"");
            BeginWriteAttribute("value", " value=\"", 553, "\"", 578, 1);
#nullable restore
#line 16 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 561, Model.Usuarios, 561, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <div class=\"form-group col-sm-8\">\r\n        <label class=\"control-label\">Título</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Nome\"");
            BeginWriteAttribute("value", " value=\"", 737, "\"", 758, 1);
#nullable restore
#line 20 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 745, Model.Nome, 745, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n");
#nullable restore
#line 22 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
     if(Model.Cod_Escala==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group col-sm-4\">\r\n            <label class=\"control-label\">Tipo</label>\r\n            <select class=\"form-control\"");
            BeginWriteAttribute("onchange", " onchange=\"", 941, "\"", 991, 4);
            WriteAttributeValue("", 952, "SelecionaTipo(", 952, 14, true);
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 966, Model.Cod_Comum, 966, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 984, ",", 984, 1, true);
            WriteAttributeValue(" ", 985, "this)", 986, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca78d8bb96c500e911ffc332d36f26db6086b18260", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca78d8bb96c500e911ffc332d36f26db6086b19193", async() => {
                WriteLiteral("Organistas Oficializadas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca78d8bb96c500e911ffc332d36f26db6086b110386", async() => {
                WriteLiteral("Organistas RJM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca78d8bb96c500e911ffc332d36f26db6086b111570", async() => {
                WriteLiteral("Instrutores");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n");
#nullable restore
#line 32 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row\">\r\n     \r\n     \r\n    <div class=\"form-group col-sm-3\">\r\n        <label class=\"control-label\">Inicio</label>\r\n        <input type=\"date\" class=\"form-control\" name=\"Inicio\"");
            BeginWriteAttribute("value", " value=\'", 1502, "\'", 1548, 1);
#nullable restore
#line 40 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 1510, Model.Inicio.ToString("yyyy-MM-dd"), 1510, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    <div class=\"form-group col-sm-3\">\r\n        <label class=\"control-label\">Fim</label>\r\n        <input type=\"date\" class=\"form-control\" name=\"Fim\"");
            BeginWriteAttribute("value", " value=\'", 1714, "\'", 1757, 1);
#nullable restore
#line 44 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
WriteAttributeValue("", 1722, Model.Fim.ToString("yyyy-MM-dd"), 1722, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n    <div class=\"form-group col-sm-3\">\r\n        <label class=\"control-label\">Sequencial por data?</label>\r\n        <select class=\"form-control\" name=\"DiaSequencial\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca78d8bb96c500e911ffc332d36f26db6086b114302", async() => {
                WriteLiteral("Não");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
AddHtmlAttributeValue("", 1986, !Model.DiaSequencial, 1986, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca78d8bb96c500e911ffc332d36f26db6086b115921", async() => {
                WriteLiteral("Sim");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
AddHtmlAttributeValue("", 2068, Model.DiaSequencial, 2068, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </select>\r\n    </div> \r\n    <div class=\"form-group col-sm-3\">\r\n        <label class=\"control-label\">Toca-se 2 por culto?</label>\r\n        <select class=\"form-control\" name=\"Dupla\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca78d8bb96c500e911ffc332d36f26db6086b117747", async() => {
                WriteLiteral("Não");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 56 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
AddHtmlAttributeValue("", 2340, !Model.Dupla, 2340, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ca78d8bb96c500e911ffc332d36f26db6086b119358", async() => {
                WriteLiteral("Sim");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
AddHtmlAttributeValue("", 2414, Model.Dupla, 2414, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </select>\r\n    </div> \r\n    \r\n    \r\n    <div id=\"Dias\" class=\"form-group col-md-12\">\r\n        ");
#nullable restore
#line 63 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
   Write(await Html.PartialAsync("~/Views/Escala/Dias.cshtml", DiasSemana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 65 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
     if(Model.Cod_Escala==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"Usuarios\" class=\"form-group col-sm-12\">\r\n            ");
#nullable restore
#line 67 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
       Write(await Html.PartialAsync("~/Views/Escala/Usuarios.cshtml", new List<GEM.Repository.Usuario>()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 69 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"Usuarios\" class=\"form-group col-sm-12\">\r\n");
#nullable restore
#line 71 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
             foreach (var item in Model.GetUsuarios())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"form-group btn btn-sm btn-info\">");
#nullable restore
#line 73 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
                                                         Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 74 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 76 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     
</div> 

<script>
    function SelecionaTipo(Cod_Comum, e){
        rsp.post({ Cod_Comum, Tipo: $(e).val() },""/Escala/Dias"",""#Dias"");
        rsp.post({ Cod_Comum, Tipo: $(e).val() },""/Escala/Usuarios"",""#Usuarios"");
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.Escala> Html { get; private set; }
    }
}
#pragma warning restore 1591