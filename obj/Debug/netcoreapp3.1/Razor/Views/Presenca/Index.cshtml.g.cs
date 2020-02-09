#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eabd9fa131a875baaa4d3ff3dafb4504b2b10db5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_Index), @"mvc.1.0.view", @"/Views/Presenca/Index.cshtml")]
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
#line 1 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eabd9fa131a875baaa4d3ff3dafb4504b2b10db5", @"/Views/Presenca/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
  
    ViewBag.Title = "Controle de presença";
    UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);
    int DefaultComum = sessao.UserLogged? sessao.Usuario.Cod_Comum : 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Controle de Presença</h2>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
     if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group col-sm-6\">\r\n            <label class=\"control-label\">Comum Congregação</label>\r\n            ");
#nullable restore
#line 15 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
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
            WriteLiteral("\r\n        </div>  \r\n");
#nullable restore
#line 24 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group col-sm-6\">\r\n        <label>Data</label>\r\n        <input id=\"Data\" type=\"date\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\'", 1153, "\'", 1226, 1);
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
WriteAttributeValue("", 1161, GEM.Helpers.Util.BrazilianDatetimeNow().ToString("yyyy-MM-dd"), 1161, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onchange=""SelecionaData(this)"">
    </div>
</div>

<div id=""ListaPresencas"">
    Selecione uma data para registrar as presenças
</div>

<div class=""modal fade"" id=""modalAula"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Aula</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""Aula"" class=""modal-body"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalHistorico"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""  data-backdrop=""stat");
            WriteLiteral(@"ic"">
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
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        let Cod_Comum = ");
#nullable restore
#line 74 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
                    Write(DefaultComum);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        let Data = \'");
#nullable restore
#line 75 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Presenca\Index.cshtml"
                Write(GEM.Helpers.Util.BrazilianDatetimeNow().ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        let Filtro_Presenca = """";
        let Filtro_Usuario = """";
        $(document).ready(() => {
            Lista();
        });

        function SelecionaComum(e){
            Cod_Comum = $(e).val();
            Lista();
        }

        function SelecionaData(e){
            Data = $(e).val();
            Lista();
        }

        function FiltroPresenca(tipo){
            Filtro_Presenca = tipo;
            //Lista();
            Filtro();
        }

        function FiltroUsuario(tipo){
            Filtro_Usuario = tipo;
            //Lista();
            Filtro();
        }

        function Filtro(){

            $("".btn-group .btn"").removeClass(""btn-dark"");
            $("".btn-group .btn"").addClass(""btn-secondary"");

            let sel_id_left = """";
            let sel_id_right = """";

            if(Filtro_Presenca.length==0||Filtro_Presenca==""Todos""){
                sel_id_left = ""#btn_todos"";
            }

            if(Filtro_Presenca == ""Pre");
                WriteLiteral(@"sente""){
                sel_id_left = ""#btn_presente"";
            }

            if(Filtro_Presenca == ""Ausente""){
                sel_id_left = ""#btn_ausente"";
            }

            if(Filtro_Usuario.length==0||Filtro_Usuario==""Todos""){
                sel_id_right = ""#btn_usuarios"";
            }

            if(Filtro_Usuario == ""Instrutores""){
                sel_id_right = ""#btn_instrutores"";
            }

            if(Filtro_Usuario == ""Alunos""){
                sel_id_right = ""#btn_alunos"";
            }

            $(sel_id_left).removeClass(""btn-secondary"");
            $(sel_id_left).addClass(""btn-dark"");

            $(sel_id_right).removeClass(""btn-secondary"");
            $(sel_id_right).addClass(""btn-dark"");

            if((Filtro_Presenca.length==0||Filtro_Presenca==""Todos"")&&(Filtro_Usuario.length==0||Filtro_Usuario==""Todos"")){
                $("".tr_usuario"").show();
            }else{
                $("".tr_usuario"").hide();
                $("".tr_us");
                WriteLiteral(@"uario"").each((index, element)=>{
                    if(Filtro_Presenca.length==0||Filtro_Presenca==""Todos""){
                        if((Filtro_Usuario==""Instrutores"" && $(element).hasClass(""tr_instrutor""))
                        ||(Filtro_Usuario==""Alunos"" && $(element).hasClass(""tr_aluno""))){
                            $(element).show();
                        }
                    }
                    else if(Filtro_Usuario.length==0||Filtro_Usuario==""Todos""){
                        if((Filtro_Presenca==""Presente"" && $(element).hasClass(""tr_presente""))
                        ||(Filtro_Presenca==""Ausente"" && $(element).hasClass(""tr_ausente""))){
                            $(element).show();
                        }
                    }
                    else{
                        if(
                            (Filtro_Usuario==""Instrutores"" && $(element).hasClass(""tr_instrutor"")&&Filtro_Presenca==""Presente"" && $(element).hasClass(""tr_presente""))
                            ||(");
                WriteLiteral(@"Filtro_Usuario==""Instrutores"" && $(element).hasClass(""tr_instrutor"")&&Filtro_Presenca==""Ausente"" && $(element).hasClass(""tr_ausente""))
                            ||(Filtro_Usuario==""Alunos"" && $(element).hasClass(""tr_aluno"")&&Filtro_Presenca==""Presente"" && $(element).hasClass(""tr_presente""))
                            ||(Filtro_Usuario==""Alunos"" && $(element).hasClass(""tr_aluno"")&&Filtro_Presenca==""Ausente"" && $(element).hasClass(""tr_ausente""))
                        )
                        {
                            $(element).show();
                        }
                    }

                })
            }
        }

        function Lista() {
            rsp.get(null, ""/Presenca/List?Cod_Comum=""+Cod_Comum+""&Data=""+Data, (res) => {

                let Comum_Nome = $(""#Comum option:selected"").text();
                if(Comum_Nome.length == 0){
                    Comum_Nome = $(""#Congregacao"").html();
                }
                
                $(""#ListaPresencas""");
                WriteLiteral(@").html(res);
                $(""#ListaPresencas .table"").DataTable({
                    dom: 'Bfrtip',
                    buttons: [
                        {
                            extend: 'print',
                            className: 'btn btn-secondary fa fa-print',
                            text: '',
                            messageTop: Comum_Nome + "" - "" + Data.split(""-"").reverse().join(""/""),
                            exportOptions: {
                                columns: [ 0, 1, 2 ]
                            } 
                        },
                        { 
                            extend: 'excel', 
                            className: 'btn btn-secondary fa fa-file-excel-o', 
                            text: '',
                            messageTop: Comum_Nome + "" - "" + Data.split(""-"").reverse().join(""/""),
                            exportOptions: {
                                columns: [ 0, 1, 2 ]
                            }
                ");
                WriteLiteral(@"        }
                    ],
                    ""pageLength"": 100,
                    ""bPaginate"": true,
                    ""bLengthChange"": false,
                    ""bFilter"": true,
                    ""bInfo"": false,
                    ""bAutoWidth"": false,
                    /*""pageLength"": 100,
                    ""bPaginate"": true,
                    ""bLengthChange"": false,
                    ""bFilter"": true,
                    ""bInfo"": false,
                    ""bAutoWidth"": false,
                    ""columns"": [
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
                setTimeout(()=");
                WriteLiteral(@">{
                    $(""#DataTables_Table_0_wrapper .col-sm-12"").css(""overflow"", ""auto"");
                },200);

                //Filtro();
            });
        }

        function RegistraPresenca(Cod_Usuario){
            rsp.post({Cod_Usuario, Data}, ""/Presenca/RegistraPresenca"", (res)=>{
                if(res==""ok""){
                    Lista();
                }else{
                    showAlert(res, ""alert-danger"");
                }
            })
        }

        function RegistraAusencia(Cod_Usuario){
            rsp.post({Cod_Usuario, Data}, ""/Presenca/RegistraAusencia"", (res)=>{
                if(res==""ok""){
                    Lista();
                }else{
                    showAlert(res, ""alert-danger"");
                }
            })
        }

        /**************************************************************/
        function Aula(Cod_Presenca, Aluno, Instrumento) {
            rsp.post({Cod_Presenca, Aluno, Instrumento}, ""/Presenca/Aula"", ");
                WriteLiteral(@"(res) => {
                $(""#Aula"").html(res);
                $(""#modalAula"").modal('show');
                $(""#modalAula .alert"").hide();
            });
        }

        function Historico(Cod_Usuario, Aluno, Instrumento){
            rsp.post({Cod_Usuario, Aluno, Instrumento}, ""/Presenca/Historico"", (res)=>{
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
                            messageTop: $(""#Congregacao"").html() + "" - "" + Aluno + "" - "" + Instrumento,
                        },
                        { 
                            extend: 'e");
                WriteLiteral(@"xcel', 
                            className: 'btn btn-secondary fa fa-file-excel-o',
                            text: '',
                            messageTop: $(""#Congregacao"").html() + "" - "" + Aluno + "" - "" + Instrumento,
                        }
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
                        null,
                        null
                    ],
                    ""language"": {
                        ""url"": ""//cdn.datatables.net/plug-ins/1.10.19/i18n/Portuguese-Brasil.json""
                    }
                });
            })
        }

          function AdicionaAula(Cod_Presenca){
            ");
                WriteLiteral(@"    rsp.post(""#DadosAula"", ""/Presenca/AdicionaAula"", (res)=>{
                if(res==""ok""){
                    $(""#modalAula .alert"").hide();
                    Aula(Cod_Presenca);
                }
                else{
                    $(""#modalAula .alert"").html(res);
                    $(""#modalAula .alert"").show();
                }
                })
            }

            function RemoveAula(Cod_Presenca, Cod_Estudo){
                rsp.post({Cod_Estudo}, ""/Presenca/RemoveAula"", (res)=>{
                if(res==""ok""){
                    $(""#modalAula .alert"").hide();
                    Aula(Cod_Presenca);
                }
                else{
                    $(""#modalAula .alert"").html(res);
                    $(""#modalAula .alert"").show();
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
