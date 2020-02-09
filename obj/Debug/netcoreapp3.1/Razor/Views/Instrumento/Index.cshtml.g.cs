#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a91d089d9cc3f9819902f04219dd8365d3c41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instrumento_Index), @"mvc.1.0.view", @"/Views/Instrumento/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a91d089d9cc3f9819902f04219dd8365d3c41e", @"/Views/Instrumento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Instrumento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\Index.cshtml"
  
    ViewBag.Title = "Instrumento";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Instrumentos</h2>

<p>
    <button type=""button"" class=""btn btn-sm btn-secondary"" onclick=""Edita({})"">
        <i class=""fas fa-plus""></i> Novo
    </button>
</p>


<div id=""ListaInstrumentos"">
    Carregando ...
</div>

<!-- Modal -->
<div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cadastro Instrumento</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""EditaInstrumento"" class=""modal-body"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                <button type=""");
            WriteLiteral(@"button"" class=""btn btn-primary"" onclick=""Grava()"">Gravar</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalDelete"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Remover Instrumento</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""RemoverInstrumentoId"" />
                Tem certeza que deseja remover um registro da tabela Instrumento?<br />
                Nome: <span id=""RemoverInstrumento""></span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss");
            WriteLiteral("=\"modal\"> Fechar</button>\r\n                <button type=\"button\" class=\"btn btn-danger\" onclick=\"Remove()\">  Apagar</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(() => {
            Lista();
        });

        function Lista() {
            rsp.get(null, ""/Instrumento/List/"", (res) => {
                $(""#ListaInstrumentos"").html(res);
                $(""#ListaInstrumentos .table"").DataTable({
                    ""bSort"" : false,
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
  ");
                WriteLiteral(@"                  }
                });
                setTimeout(()=>{
                    $(""#DataTables_Table_0_wrapper .col-sm-12"").css(""overflow"", ""auto"");
                },200);
            });


        }

        function Edita(item) {
            rsp.get(item, ""/Instrumento/Edit/"", (res) => {
                $(""#EditaInstrumento"").html(res);
                $(""#modalEdit"").modal('show');
                $(""#modalEdit .alert"").hide();
                //$("".cep"").mask(""00000-000"");
                //$("".cnpj"").mask(""00.000.000/0000-00"");
                //$("".phone"").mask(""(00)000000009"");
            });
        }

        function Grava() {
            rsp.post(""#EditaInstrumento"", ""/Instrumento/Save"", (res) => {
                if (res == ""ok"") {
                    $(""#modalEdit"").modal('hide');
                    Lista();
                    showAlert(""Instrumento gravado(a) com sucesso!"", ""alert-success"");
                } else {
                    $(""#modalEdit .");
                WriteLiteral(@"alert"").html(res);
                    $(""#modalEdit .alert"").show();
                }
            })
        }

        function DesejaRemover(id, nome) {
            $(""#RemoverInstrumentoId"").val(id);
            $(""#RemoverInstrumento"").html(nome);
            $(""#modalDelete"").modal('show');
        }

        function Remove() {
            rsp.post(null, ""/Instrumento/Delete/"" + $(""#RemoverInstrumentoId"").val(), (res) => {
                if (res == ""ok"") {
                    $(""#modalDelete"").modal('hide');
                    showAlert(""Instrumento removido(a) com sucesso!"", ""alert-success"");
                    Lista();
                } else {
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
