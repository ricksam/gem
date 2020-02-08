#pragma checksum "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c3d5e82de883de6e0014c7ed187681f1326fd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "/home/ricksam/Projects/CCB/gem/Views/_ViewImports.cshtml"
using GEM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ricksam/Projects/CCB/gem/Views/_ViewImports.cshtml"
using GEM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c3d5e82de883de6e0014c7ed187681f1326fd6", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ebefddbfc1ec11f6d16e946c3256bf3888b9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml"
  
    ViewBag.Title = "Usuario";
    UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);
    int DefaultComum = sessao.UserLogged? sessao.Usuario.Cod_Comum : 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Usuarios</h2>\n\n<div class=\"row\">\n");
#nullable restore
#line 13 "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml"
     if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group col-sm-6\">\n            <label class=\"control-label\">Comum Congregação</label>\n            ");
#nullable restore
#line 16 "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml"
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
            WriteLiteral("\n        </div>  \n");
#nullable restore
#line 24 "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<p>
    <button type=""button"" class=""btn btn-sm btn-default"" onclick=""Edita({})"">
        <i class=""fas fa-plus""></i> Novo
    </button>
</p>


<div id=""ListaUsuarios"">
    Carregando ...
</div>

<!-- Modal -->
<div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cadastro Usuario</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""EditaUsuario"" class=""modal-body"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""Grava()"">Gravar<");
            WriteLiteral(@"/button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalDelete"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Remover Usuario</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""RemoverUsuarioId"" />
                Tem certeza que deseja remover um registro da tabela Usuario?<br />
                Nome: <span id=""RemoverUsuario""></span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""> Fechar</button>
                <button type=""button"" class=""btn btn-danger"" onclick");
            WriteLiteral("=\"Remove()\">  Apagar</button>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script type=\"text/javascript\">\n        let Cod_Comum = ");
#nullable restore
#line 83 "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml"
                    Write(DefaultComum);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n        let Tipo = \"");
#nullable restore
#line 84 "/home/ricksam/Projects/CCB/gem/Views/Usuario/Index.cshtml"
                Write(ViewBag.q);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
        $(document).ready(() => {
            Lista();
        });

        function ComumChange(e){
            Cod_Comum = $(e).val();
            Lista();
        }

        function Filtro(tipo){
            $("".btn-group .btn"").removeClass(""btn-dark"");
            $("".btn-group .btn"").addClass(""btn-secondary"");
            
            let sel_id = """"
            if(tipo.length == 0 || tipo == ""Todos""){
                $("".tr_usuarios"").show();
                sel_id = ""#btn_todos"";
            }else{
                $("".tr_usuarios"").hide();
                if(tipo==""Oficializados""){
                    $("".tr_oficializado"").show();
                    sel_id = ""#btn_oficializados"";
                }
                if(tipo==""Instrutores""){
                    $("".tr_instrutor"").show();
                    sel_id = ""#btn_instrutores"";
                }
                if(tipo==""Alunos""){
                    $("".tr_aluno"").show();
                    sel_id = ""#btn_alunos"";
                }
         ");
                WriteLiteral(@"   }
            $(sel_id).removeClass(""btn-secondary"");
            $(sel_id).addClass(""btn-dark"");
        }

        function Lista() {
            rsp.get(null, ""/Usuario/List?Cod_Comum="" + Cod_Comum, (res) => {
                $(""#ListaUsuarios"").html(res);
                $(""#ListaUsuarios .table"").DataTable({
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
                });
        ");
                WriteLiteral(@"        setTimeout(()=>{
                    $(""#DataTables_Table_0_wrapper .col-sm-12"").css(""overflow"", ""auto"");
                },200);

                Filtro(Tipo);
            });


        }

        function Edita(item) {
            if(!item.Cod_Comum){
                item.Cod_Comum = Cod_Comum; 
            }
            rsp.get(item, ""/Usuario/Edit/"", (res) => {
                $(""#EditaUsuario"").html(res);
                $(""#modalEdit"").modal('show');
                $(""#modalEdit .alert"").hide();
                //$("".cep"").mask(""00000-000"");
                //$("".cnpj"").mask(""00.000.000/0000-00"");
                $("".phone"").mask(""(00)000000009"");
            });
        }

        function Grava() {
            rsp.post(""#EditaUsuario"", ""/Usuario/Save"", (res) => {
                if (res == ""ok"") {
                    $(""#modalEdit"").modal('hide');
                    Lista();
                    showAlert(""Usuario gravado(a) com sucesso!"", ""alert-success"");
                } else {
          ");
                WriteLiteral(@"          $(""#modalEdit .alert"").html(res);
                    $(""#modalEdit .alert"").show();
                }
            })
        }

        function DesejaRemover(id, nome) {
            $(""#RemoverUsuarioId"").val(id);
            $(""#RemoverUsuario"").html(nome);
            $(""#modalDelete"").modal('show');
        }

        function Remove() {
            rsp.post(null, ""/Usuario/Delete/"" + $(""#RemoverUsuarioId"").val(), (res) => {
                if (res == ""ok"") {
                    $(""#modalDelete"").modal('hide');
                    showAlert(""Usuario removido(a) com sucesso!"", ""alert-success"");
                    Lista();
                } else {
                    showAlert(res, ""alert-warning"");
                }
            })
        }

        function EnviarConvite(Email) {
            rsp.post({ Email }, ""/Home/EnviarConvite"", (res) => {
                if (res == ""ok"") {
                    $(""#modalEdit .alert"").removeClass(""alert-danger"");
                    $(""#modalEdit .alert"").a");
                WriteLiteral(@"ddClass(""alert-success"");
                    $(""#modalEdit .alert"").html(""Email enviado com sucesso!"");
                    $(""#modalEdit .alert"").show();
                    $(""#btn_convite"").hide();
                } else {
                    $(""#modalEdit .alert"").removeClass(""alert-success"");
                    $(""#modalEdit .alert"").addClass(""alert-danger"");
                    $(""#modalEdit .alert"").html(res);
                    $(""#modalEdit .alert"").show();
                }
            });
        }
    </script>
");
            }
            );
            WriteLiteral("\n\n");
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
