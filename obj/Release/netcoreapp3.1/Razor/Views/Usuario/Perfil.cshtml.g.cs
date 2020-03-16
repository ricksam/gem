#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0fa2d1195dd401c375d7df5a4f671708fba458c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Perfil), @"mvc.1.0.view", @"/Views/Usuario/Perfil.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0fa2d1195dd401c375d7df5a4f671708fba458c", @"/Views/Usuario/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"EditaUsuario\">\r\n    ");
#nullable restore
#line 4 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Perfil.cshtml"
Write(await Html.PartialAsync("~/Views/Usuario/Edit.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 form-group\">\r\n        <button class=\"btn btn-primary\" onclick=\"Grava()\">Gravar</button>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 form-group\">\r\n");
#nullable restore
#line 16 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Perfil.cshtml"
         if(Model.Instrutor){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-info\" onclick=\"Historico(false)\">Histórico do Instrutor</button>\r\n");
#nullable restore
#line 18 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Perfil.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Perfil.cshtml"
         if(Model.Aluno){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-info\" onclick=\"Historico(true)\">Histórico do Aluno</button>\r\n");
#nullable restore
#line 22 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Perfil.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""modalHistorico"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Histórico</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""Historico"" class=""modal-body"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        let Cod_Comum=");
#nullable restore
#line 46 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Perfil.cshtml"
                  Write(Model.Cod_Comum);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        let Cod_Grupo=");
#nullable restore
#line 47 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Perfil.cshtml"
                  Write(Model.Cod_Grupo ?? 0);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        $(document).ready(()=>{
            $(""#EditaUsuario .alert"").hide();
            $("".phone"").mask(""(00)000000009"");
            ComboGrupo();
        });

        function ComboGrupo(){
            rsp.get({ Cod_Comum, Cod_Grupo }, ""/Usuario/ComboGrupo"",""#ComboGrupo"")
        }

        function Grava() 
        {
            rsp.post(""#EditaUsuario"", ""/Usuario/Save"", (res) => {
                if (res == ""ok"") {
                    $(""#modalEdit"").modal('hide');
                    showAlert(""Usuario gravado(a) com sucesso!"", ""alert-success"");
                } else {
                    showAlert(res, ""alert-danger"");
                }
            })
        }

        function Historico(Aluno){
            let Cod_Usuario = $(""#Cod_Usuario"").val();
            let Nome = $(""#Nome"").val();
            let Instrumento = $(""#Cod_Instrumento option:selected"").text();
            
            rsp.post({Cod_Usuario, Nome, Instrumento, Aluno }, ""/Presenca/Historico"", (res)");
                WriteLiteral(@"=>{
                $(""#Historico"").html(res);
                $(""#modalHistorico"").modal('show');
                $(""#modalHistorico .alert"").hide();

                $(""#Historico .table"").DataTable({
                    //""bSort"" : false,
                    dom: 'Bfrtip',
                    buttons: [
                        {
                            extend: 'print',
                            className: 'btn btn-secondary fa fa-print',
                            text: '',
                            messageTop: $(""#Congregacao"").html() + "" - "" + (Aluno ? ""Aluno"" : ""Instrutor"") + "" "" + Nome + "" - "" + Instrumento,
                        },
                        { 
                            extend: 'excel', 
                            className: 'btn btn-secondary fa fa-file-excel-o',
                            text: '',
                            messageTop: $(""#Congregacao"").html() + "" - "" + (Aluno ? ""Aluno"" : ""Instrutor"") + "" "" + Nome + "" - "" + Instrumento,
            ");
                WriteLiteral(@"            }
                    ],
                    ""pageLength"": 100,
                    ""bPaginate"": true,
                    ""bLengthChange"": false,
                    ""bFilter"": true,
                    ""bInfo"": false,
                    ""bAutoWidth"": false,
                    ""columns"": [
                        { ""sType"": ""date-pt"" },
                        null,
                        null,
                        null
                    ],
                    ""language"": {
                        ""url"": ""//cdn.datatables.net/plug-ins/1.10.19/i18n/Portuguese-Brasil.json""
                    }
                });
            })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
