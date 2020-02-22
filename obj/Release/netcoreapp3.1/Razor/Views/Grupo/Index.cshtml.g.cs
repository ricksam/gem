#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f728da7f7877f45435a415197056fadef4c18b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grupo_Index), @"mvc.1.0.view", @"/Views/Grupo/Index.cshtml")]
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
#line 1 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f728da7f7877f45435a415197056fadef4c18b4", @"/Views/Grupo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Grupo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
  
    ViewBag.Title = "Grupo";
    UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);
    int DefaultComum = sessao.UserLogged? sessao.Usuario.Cod_Comum : 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Grupos</h2>\r\n\r\n");
#nullable restore
#line 12 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
 if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"form-group col-sm-6\">\r\n            <label class=\"control-label\">Comum Congregação</label>\r\n            ");
#nullable restore
#line 16 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
       Write(await Html.PartialAsync("~/Views/Shared/_Combo.cshtml", new GEM.Models.Combo(){
                Class="form-control",
                Name="Cod_Comum",
                OnChange="ComumChange(this)",
                Items=GEM.Repository.Comum.List().Select(e=>new ComboItem(){Text=e.Nome,Value=e.Cod_Comum.ToString()}).ToList(),
                SelectedItem=(ViewBag.Cod_Comum != null ? ViewBag.Cod_Comum.ToString() : DefaultComum.ToString())
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>  \r\n    </div>\r\n");
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
 if(sessao.Instrutor){

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <button type=\"button\" class=\"btn btn-sm btn-secondary\" onclick=\"Edita({})\">\r\n        <i class=\"fas fa-plus\"></i> Novo\r\n    </button>\r\n</p>\r\n");
#nullable restore
#line 33 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"ListaGrupos\">\r\n    Carregando ...\r\n</div>\r\n\r\n");
#nullable restore
#line 39 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
 if(sessao.Instrutor){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cadastro Grupo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""EditaGrupo"" class=""modal-body"">
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
                <h5 class=""modal-title"">Remover Grupo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""RemoverGrupoId"" />
                Tem certeza que deseja remover um registro da tabela Grupo?<br />
                Nome: <span id=""RemoverGrupo""></span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""> Fechar</button>
                <button type=""button"" class=""btn btn-danger"" onclick=""Remove()"">  Apagar</button>
            </div>
   ");
            WriteLiteral("     </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 81 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        let Cod_Comum = ");
#nullable restore
#line 85 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Grupo\Index.cshtml"
                    Write(DefaultComum);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        $(document).ready(() => {
            Lista();
        });

        function ComumChange(e){
            Cod_Comum = $(e).val();
            Lista();
        }

        function Lista() {
            rsp.get({ Cod_Comum }, ""/Grupo/List/"", (res) => {
                $(""#ListaGrupos"").html(res);
                $(""#ListaGrupos .table"").DataTable({
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
                        ""url"": ""//cdn.datatables.net/plug-ins/1.10.19/i18n/Port");
                WriteLiteral(@"uguese-Brasil.json""
                    }
                });
                setTimeout(()=>{
                    $(""#DataTables_Table_0_wrapper .col-sm-12"").css(""overflow"", ""auto"");
                },200);
            });


        }

        function Edita(item) {
            rsp.get(item, ""/Grupo/Edit/"", (res) => {
                $(""#EditaGrupo"").html(res);
                $(""#modalEdit"").modal('show');
                $(""#modalEdit .alert"").hide();
                //$("".cep"").mask(""00000-000"");
                //$("".cnpj"").mask(""00.000.000/0000-00"");
                //$("".phone"").mask(""(00)000000009"");
            });
        }

        function Grava() {
            rsp.post(""#EditaGrupo"", ""/Grupo/Save"", (res) => {
                if (res == ""ok"") {
                    $(""#modalEdit"").modal('hide');
                    Lista();
                    showAlert(""Grupo gravado(a) com sucesso!"", ""alert-success"");
                } else {
                    $(""#modalEdit .alert"")");
                WriteLiteral(@".html(res);
                    $(""#modalEdit .alert"").show();
                }
            })
        }

        function DesejaRemover(id, nome) {
            $(""#RemoverGrupoId"").val(id);
            $(""#RemoverGrupo"").html(nome);
            $(""#modalDelete"").modal('show');
        }

        function Remove() {
            rsp.post({ Cod_Comum }, ""/Grupo/Delete/"" + $(""#RemoverGrupoId"").val(), (res) => {
                if (res == ""ok"") {
                    $(""#modalDelete"").modal('hide');
                    showAlert(""Grupo removido(a) com sucesso!"", ""alert-success"");
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
