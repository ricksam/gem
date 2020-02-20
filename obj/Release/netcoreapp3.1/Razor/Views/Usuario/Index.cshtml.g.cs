#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "576abe7b3463890ecc347042239b7effca488d1a"
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
#line 1 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576abe7b3463890ecc347042239b7effca488d1a", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
  
    ViewBag.Title = "Usuario";
    UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);
    int DefaultComum = sessao.UserLogged? sessao.Usuario.Cod_Comum : 0;
    if(ViewBag.Cod_Comum == null){
        ViewBag.Cod_Comum = DefaultComum;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Usuarios</h2>\r\n\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 17 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
 if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Comum Congregação</label>\r\n        ");
#nullable restore
#line 20 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_Combo.cshtml", new GEM.Models.Combo(){
                Class="form-control",
                Name="Cod_Comum",
                OnChange="SelecionaComum(this)",
                Items=GEM.Repository.Comum.List().Select(e=>new ComboItem(){Text=e.Nome,Value=e.Cod_Comum.ToString()}).ToList(),
                SelectedItem=ViewBag.Cod_Comum.ToString()
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 28 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
    
}   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Grupo de Estudo</label>\r\n        <div id=\"FiltroGrupo\"></div>\r\n    </div>       \r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 38 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
 if(sessao.Instrutor){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <button type=\"button\" class=\"btn btn-sm btn-secondary\" onclick=\"Edita({})\">\r\n            <i class=\"fas fa-plus\"></i> Novo\r\n        </button>\r\n    </p>\r\n");
#nullable restore
#line 44 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
                <button type=""button"" class=""btn btn-primary"" onclick=""Grava()"">Gravar</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalDelete"" tabindex=""-1"" role=""dial");
            WriteLiteral(@"og"" aria-hidden=""true""  data-backdrop=""static"">
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
                <button type=""button"" class=""btn btn-danger"" onclick=""Remove()"">  Apagar</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        let Cod_Comum = ");
#nullable restore
#line 94 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
                    Write(ViewBag.Cod_Comum != null ? ViewBag.Cod_Comum : 0);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        let Cod_Grupo = ");
#nullable restore
#line 95 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
                    Write(ViewBag.Cod_Grupo != null ? ViewBag.Cod_Grupo : 0);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        let Tipo = \"");
#nullable restore
#line 96 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
                Write(ViewBag.q);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        let Status = \"");
#nullable restore
#line 97 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Usuario\Index.cshtml"
                  Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
        $(document).ready(() => {
            Lista(Status);
        });

        function SelecionaComum(e){
            Cod_Comum = $(e).val();
            Lista(Status);
        }

        function SelecionaGrupo(e){
            Cod_Grupo = $(e).val();
            Lista(Status);
        }

        function Lista(Status) {
            rsp.get({ Cod_Comum, Cod_Grupo, q : Tipo, Status }, ""/Usuario/List"", (res) => {
                $(""#ListaUsuarios"").html(res);
                $(""#ListaUsuarios .table"").DataTable({
                    dom: 'Bfrtip',
                    buttons: [
                        {
                            extend: 'print',
                            className: 'btn btn-secondary fa fa-print',
                            text: '',
                            messageTop: $(""#Congregacao"").html(),
                            exportOptions: {
                                columns: [ 0, 1, 2, 3, 4 ]
                            } 
                       ");
                WriteLiteral(@" },
                        { 
                            extend: 'excel', 
                            className: 'btn btn-secondary fa fa-file-excel-o',
                            text: '',
                            messageTop: $(""#Congregacao"").html(),
                            exportOptions: {
                                columns: [ 0, 1, 2, 3, 4 ]
                            } 
                        }
                    ],
                    ""pageLength"": 1000,
                    ""bPaginate"": true,
                    ""bLengthChange"": false,
                    ""bFilter"": true,
                    ""bInfo"": false,
                    ""bAutoWidth"": false,
                    //""columns"": [
                    //  null,
                    //  null,
                    //  null,
                    //  null,
                    //  null,
                    //  { ""sType"": ""date-pt"" },
                    //  null
                    //],
                    ""language""");
                WriteLiteral(@": {
                        ""url"": ""//cdn.datatables.net/plug-ins/1.10.19/i18n/Portuguese-Brasil.json""
                    }
                });
                setTimeout(()=>{
                    $(""#DataTables_Table_0_wrapper .col-sm-12"").css(""overflow"", ""auto"");
                },200);

                Filtro(Tipo);
                rsp.get({ Cod_Comum, Cod_Grupo, DefaultText:""Todos"", OnChange : ""SelecionaGrupo(this)"" }, ""/Usuario/ComboGrupo"",""#FiltroGrupo"");
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
                ComboGrupo(Co");
                WriteLiteral(@"d_Comum, item.Cod_Grupo);
            });
        }

        function EditComumChange(e){
            ComboGrupo(Cod_Comum, """");
        }

        function ComboGrupo(codComum, codGrupo){
            rsp.get({ Cod_Comum : codComum, Cod_Grupo : codGrupo }, ""/Usuario/ComboGrupo"",""#ComboGrupo"")
        }

        function Grava() {
            rsp.post(""#EditaUsuario"", ""/Usuario/Save"", (res) => {
                if (res == ""ok"") {
                    $(""#modalEdit"").modal('hide');
                    Lista(Status);
                    showAlert(""Usuario gravado(a) com sucesso!"", ""alert-success"");
                } else {
                    $(""#modalEdit .alert"").html(res);
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
");
                WriteLiteral(@"            rsp.post({ Cod_Comum }, ""/Usuario/Delete/"" + $(""#RemoverUsuarioId"").val(), (res) => {
                if (res == ""ok"") {
                    $(""#modalDelete"").modal('hide');
                    showAlert(""Usuario removido(a) com sucesso!"", ""alert-success"");
                    Lista(Status);
                } else {
                    $(""#modalDelete"").modal('hide');
                    showAlert(res, ""alert-warning"");
                }
            })
        }

        function EnviarConvite(Email) {
            rsp.post({ Email }, ""/Home/EnviarConvite"", (res) => {
                if (res == ""ok"") {
                    $(""#modalEdit .alert"").removeClass(""alert-danger"");
                    $(""#modalEdit .alert"").addClass(""alert-success"");
                    $(""#modalEdit .alert"").html(""Email enviado com sucesso!"");
                    $(""#modalEdit .alert"").show();
                    $(""#btn_convite"").hide();
                } else {
                    $(""#modalEdit .aler");
                WriteLiteral(@"t"").removeClass(""alert-success"");
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
