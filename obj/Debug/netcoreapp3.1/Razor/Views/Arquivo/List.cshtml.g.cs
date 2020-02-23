#pragma checksum "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b7b794c266f4139b29c66a74281d09f45f646fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Arquivo_List), @"mvc.1.0.view", @"/Views/Arquivo/List.cshtml")]
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
#line 1 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b7b794c266f4139b29c66a74281d09f45f646fc", @"/Views/Arquivo/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Arquivo_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Arquivo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
  
  Layout = null;
  UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-responsive\">\r\n  <table class=\"table \">\r\n    <thead>\r\n      <tr>\r\n        <th>Arquivo</th>\r\n        <th>Instrutor</th>\r\n");
#nullable restore
#line 15 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
         if(sessao.Instrutor()){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <th>Visibilidade</th>\r\n          <th></th>\r\n          <th></th>\r\n");
#nullable restore
#line 19 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tr>\r\n      </thead>\r\n      <tbody>\r\n");
#nullable restore
#line 23 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 633, "\"", 651, 1);
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
WriteAttributeValue("", 640, item.Url, 640, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-download\"></i> ");
#nullable restore
#line 26 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
                                                                                Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n          <td>");
#nullable restore
#line 27 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
         Write(item.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
           if(sessao.Instrutor()){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 29 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
            Write(item.Instrutor?"Instrutores":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
                                               Write(item.Oficializado?"Oficializados":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
                                                                                       Write(item.RJM?"RJM":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
                                                                                                            Write(item.Aluno?"Alunos":"");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n              <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 994, "\'", 1046, 3);
            WriteAttributeValue("", 1004, "Edita(", 1004, 6, true);
#nullable restore
#line 31 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
WriteAttributeValue("", 1010, GEM.Helpers.JSON.Serialize(item), 1010, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1045, ")", 1045, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil\"></i> Editar</button>\r\n            </td>\r\n            <td>\r\n              <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1183, "\'", 1250, 6);
            WriteAttributeValue("", 1193, "DesejaRemover(", 1193, 14, true);
#nullable restore
#line 34 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
WriteAttributeValue("", 1207, item.Cod_Arquivo, 1207, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1226, ",", 1226, 1, true);
            WriteAttributeValue(" ", 1227, "\"", 1228, 2, true);
#nullable restore
#line 34 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
WriteAttributeValue("", 1229, item.Cod_Usuario, 1229, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1248, "\")", 1248, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n            </td>\r\n");
#nullable restore
#line 36 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>    \r\n");
#nullable restore
#line 38 "d:\PROJECTS\RckSoftware\CCB\gem\Views\Arquivo\List.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.Arquivo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
