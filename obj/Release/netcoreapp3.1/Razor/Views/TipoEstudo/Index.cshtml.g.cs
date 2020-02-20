#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\TipoEstudo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e609c2cce60d173576b3693e252f92ac5911aef3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoEstudo_Index), @"mvc.1.0.view", @"/Views/TipoEstudo/Index.cshtml")]
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
#nullable restore
#line 1 "D:\PROJECTS\RckSoftware\CCB\gem\Views\TipoEstudo\Index.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\TipoEstudo\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e609c2cce60d173576b3693e252f92ac5911aef3", @"/Views/TipoEstudo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoEstudo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\PROJECTS\RckSoftware\CCB\gem\Views\TipoEstudo\Index.cshtml"
  
    ViewBag.Title = "TipoEstudo";
    UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Tipo de Aula</h2>\r\n\r\n");
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\TipoEstudo\Index.cshtml"
 if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <button type=\"button\" class=\"btn btn-sm btn-secondary\" onclick=\"Edita({})\">\r\n        <i class=\"fas fa-plus\"></i> Novo\r\n    </button>\r\n</p>\r\n");
#nullable restore
#line 17 "D:\PROJECTS\RckSoftware\CCB\gem\Views\TipoEstudo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div id=\"ListaTipoEstudos\">\r\n    Carregando ...\r\n</div>\r\n\r\n");
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\CCB\gem\Views\TipoEstudo\Index.cshtml"
 if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cadastro TipoEstudo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""EditaTipoEstudo"" class=""modal-body"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""Grava()"">Gravar</button>
            </div>
        </div>
    </div>
</div>
");
            WriteLiteral(@"<div class=""modal fade"" id=""modalDelete"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Remover TipoEstudo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""RemoverTipoEstudoId"" />
                Tem certeza que deseja remover um registro da tabela TipoEstudo?<br />
                Nome: <span id=""RemoverTipoEstudo""></span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""> Fechar</button>
                <button type=""button"" class=""btn btn-danger"" onclick=""Remove()"">  Apagar</button>
   ");
            WriteLiteral("         </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 67 "D:\PROJECTS\RckSoftware\CCB\gem\Views\TipoEstudo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(() => {
            Lista();
        });

        function Lista() {
            rsp.get(null, ""/TipoEstudo/List/"", (res) => {
                $(""#ListaTipoEstudos"").html(res);
                $(""#ListaTipoEstudos .table"").DataTable({
                    ""pageLength"": 100,
                    ""bPaginate"": true,
                    ""bLengthChange"": false,
                    ""bFilter"": true,
                    ""bInfo"": false,
                    ""bAutoWidth"": false,
                    /*""columns"": [
                        null,
                        null,
                        null,
                        null,
                        null,
                        { ""sType"": ""date-pt"" },
                        null
                    ],*/
                    ""language"": {
                        ""url"": ""//cdn.datatables.net/plug-ins/1.10.19/i18n/Portuguese-Brasil.json""
                    }
                });");
                WriteLiteral(@"
                setTimeout(()=>{
                    $(""#DataTables_Table_0_wrapper .col-sm-12"").css(""overflow"", ""auto"");
                },200);
            });


        }

        function Edita(item) {
            rsp.get(item, ""/TipoEstudo/Edit/"", (res) => {
                $(""#EditaTipoEstudo"").html(res);
                $(""#modalEdit"").modal('show');
                $(""#modalEdit .alert"").hide();
                //$("".cep"").mask(""00000-000"");
                //$("".cnpj"").mask(""00.000.000/0000-00"");
                //$("".phone"").mask(""(00)000000009"");
            });
        }

        function Grava() {
            rsp.post(""#EditaTipoEstudo"", ""/TipoEstudo/Save"", (res) => {
                if (res == ""ok"") {
                    $(""#modalEdit"").modal('hide');
                    Lista();
                    showAlert(""TipoEstudo gravado(a) com sucesso!"", ""alert-success"");
                } else {
                    $(""#modalEdit .alert"").html(res);
                    $(""#mo");
                WriteLiteral(@"dalEdit .alert"").show();
                }
            })
        }

        function DesejaRemover(id, nome) {
            $(""#RemoverTipoEstudoId"").val(id);
            $(""#RemoverTipoEstudo"").html(nome);
            $(""#modalDelete"").modal('show');
        }

        function Remove() {
            rsp.post(null, ""/TipoEstudo/Delete/"" + $(""#RemoverTipoEstudoId"").val(), (res) => {
                if (res == ""ok"") {
                    $(""#modalDelete"").modal('hide');
                    showAlert(""TipoEstudo removido(a) com sucesso!"", ""alert-success"");
                    Lista();
                } else {
                    $(""#modalDelete"").modal('hide');
                    showAlert(res, ""alert-warning"");
                }
            })
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
