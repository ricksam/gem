#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb8d1899d02453f5eee4d0717a1c7b1238f634ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instrumento_List), @"mvc.1.0.view", @"/Views/Instrumento/List.cshtml")]
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
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8d1899d02453f5eee4d0717a1c7b1238f634ff", @"/Views/Instrumento/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Instrumento_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Instrumento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
  
  Layout = null;
  UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-responsive\">\r\n  <table class=\"table \">\r\n    <thead>\r\n      <tr>\r\n        <th>Nome</th>\r\n        <th>Afinacao</th>\r\n        <th>Principal</th>\r\n        <th>Alternativa</th>\r\n        <th>Cod_Categoria</th>\r\n");
#nullable restore
#line 18 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
         if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <th></th>\r\n          <th></th>\r\n");
#nullable restore
#line 21 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n      </tr>\r\n      </thead>\r\n      <tbody>\r\n");
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 29 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 30 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
         Write(item.Afinacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
         Write(item.Principal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 32 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
         Write(item.Alternativa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 33 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
         Write(item.Cod_Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
           if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n              <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 944, "\'", 984, 3);
            WriteAttributeValue("", 954, "Edita(", 954, 6, true);
#nullable restore
#line 36 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
WriteAttributeValue("", 960, Json.Serialize(item), 960, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 983, ")", 983, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil\"></i> Editar</button>\r\n            </td>\r\n            <td>\r\n              <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1121, "\'", 1185, 6);
            WriteAttributeValue("", 1131, "DesejaRemover(", 1131, 14, true);
#nullable restore
#line 39 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
WriteAttributeValue("", 1145, item.Cod_Instrumento, 1145, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1168, ",", 1168, 1, true);
            WriteAttributeValue(" ", 1169, "\"", 1170, 2, true);
#nullable restore
#line 39 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
WriteAttributeValue("", 1171, item.Nome, 1171, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1183, "\")", 1183, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n            </td>\r\n");
#nullable restore
#line 41 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n        </tr>    \r\n");
#nullable restore
#line 44 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Instrumento\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.Instrumento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
