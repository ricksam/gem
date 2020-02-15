#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13efdb1bb96d7b5b37148a0fbc8250e87abf97d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escala_Index), @"mvc.1.0.view", @"/Views/Escala/Index.cshtml")]
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
#nullable restore
#line 1 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13efdb1bb96d7b5b37148a0fbc8250e87abf97d", @"/Views/Escala/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Escala_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
  
    ViewBag.Title = "Escala";
    UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);
    var DefaultComum = sessao.Usuario.Cod_Comum;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Escalas</h2>\r\n\r\n");
#nullable restore
#line 12 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
 if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Comum Congregação</label>\r\n        ");
#nullable restore
#line 15 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_Combo.cshtml", new GEM.Models.Combo(){
            Class="form-control",
            Id="Comum",
            Name="Cod_Comum",
            OnChange="SelecionaComum(this)",
            Items=GEM.Repository.Comum.List().Select(e=>new ComboItem(){Text=e.Nome,Value=e.Cod_Comum.ToString()}).ToList(),
            SelectedItem=(ViewBag.Cod_Comum != null ? ViewBag.Cod_Comum.ToString() : DefaultComum.ToString())
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>  \r\n");
#nullable restore
#line 24 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
 if(sessao.Instrutor){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <button type=\"button\" class=\"btn btn-sm btn-secondary\" onclick=\"Edita({})\">\r\n            <i class=\"fas fa-plus\"></i> Novo\r\n        </button>\r\n    </p>\r\n");
#nullable restore
#line 32 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div id=\"ListaEscalas\">\r\n    Carregando ...\r\n</div>\r\n\r\n");
#nullable restore
#line 40 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
 if(sessao.Instrutor){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Modal -->
    <div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Cadastro Escala</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div id=""EditaEscala"" class=""modal-body"">
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                    <button type=""button"" class=""btn btn-primary"" onclick=""Grava()"">Gravar</button>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral(@"    <div class=""modal fade"" id=""modalDelete"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Remover Escala</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <input type=""hidden"" id=""RemoverEscalaId"" />
                    Tem certeza que deseja remover um registro da tabela Escala?<br />
                    Nome: <span id=""RemoverEscala""></span>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""> Fechar</button>
                    <button type=""button"" class=""btn b");
            WriteLiteral("tn-danger\" onclick=\"Remove()\">  Apagar</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 82 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        let Cod_Comum = ");
#nullable restore
#line 87 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Escala\Index.cshtml"
                    Write(DefaultComum);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        $(document).ready(() => {
            Lista();
        });

        function SelecionaComum(e){
            Cod_Comum = $(e).val();
            Lista();
        }

        function Lista() {
            rsp.get({ Cod_Comum }, ""/Escala/List/"", (res) => {
                $(""#ListaEscalas"").html(res);
                $(""#ListaEscalas .table"").DataTable({
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
                        ""url"": ""//cdn.datatables.net/plug-ins/1.10.19/i18");
                WriteLiteral(@"n/Portuguese-Brasil.json""
                    }
                });
                setTimeout(()=>{
                    $(""#DataTables_Table_0_wrapper .col-sm-12"").css(""overflow"", ""auto"");
                },200);
            });
        }

        function Edita(item) {
            item.Cod_Comum = Cod_Comum;
            rsp.get(item, ""/Escala/Edit/"", (res) => {
                $(""#EditaEscala"").html(res);
                $(""#modalEdit"").modal('show');
                $(""#modalEdit .alert"").hide();

                /*$(document).ready(function() {
                    $('.js-example-basic-multiple').select2({ theme: ""bootstrap"" });
                });*/
                //$("".cep"").mask(""00000-000"");
                //$("".cnpj"").mask(""00.000.000/0000-00"");
                //$("".phone"").mask(""(00)000000009"");
            });
        }

        function Grava() {
            rsp.post(""#EditaEscala"", ""/Escala/Save"", (res) => {
                if (res == ""ok"") {
                    $(""#");
                WriteLiteral(@"modalEdit"").modal('hide');
                    Lista();
                    showAlert(""Escala gravado(a) com sucesso!"", ""alert-success"");
                } else {
                    $(""#modalEdit .alert"").html(res);
                    $(""#modalEdit .alert"").show();
                }
            })
        }

        function DesejaRemover(id, nome) {
            $(""#RemoverEscalaId"").val(id);
            $(""#RemoverEscala"").html(nome);
            $(""#modalDelete"").modal('show');
        }

        function Remove() {
            rsp.post({ Cod_Comum }, ""/Escala/Delete/"" + $(""#RemoverEscalaId"").val(), (res) => {
                if (res == ""ok"") {
                    $(""#modalDelete"").modal('hide');
                    showAlert(""Escala removido(a) com sucesso!"", ""alert-success"");
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
