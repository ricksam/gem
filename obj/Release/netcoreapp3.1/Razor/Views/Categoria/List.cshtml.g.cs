#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ffbb843ad64e272ab8788b1ad78465c30a2189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_List), @"mvc.1.0.view", @"/Views/Categoria/List.cshtml")]
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
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ffbb843ad64e272ab8788b1ad78465c30a2189", @"/Views/Categoria/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GEM.Repository.Categoria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
  
  Layout = null;
  UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-responsive\">\r\n  <table class=\"table \">\r\n    <thead>\r\n      <tr>\r\n        <th>Nome</th>\r\n");
#nullable restore
#line 14 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
         if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <th></th>\r\n          <th></th>\r\n");
#nullable restore
#line 17 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n      </tr>\r\n      </thead>\r\n      <tbody>\r\n");
#nullable restore
#line 22 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 25 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
         Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 26 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
           if(sessao.Admin){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n              <button class=\"btn btn-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 676, "\'", 716, 3);
            WriteAttributeValue("", 686, "Edita(", 686, 6, true);
#nullable restore
#line 28 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
WriteAttributeValue("", 692, Json.Serialize(item), 692, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 715, ")", 715, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil\"></i> Editar</button>\r\n            </td>\r\n            <td>\r\n              <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\'", 853, "\'", 915, 6);
            WriteAttributeValue("", 863, "DesejaRemover(", 863, 14, true);
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
WriteAttributeValue("", 877, item.Cod_Categoria, 877, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 898, ",", 898, 1, true);
            WriteAttributeValue(" ", 899, "\"", 900, 2, true);
#nullable restore
#line 31 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
WriteAttributeValue("", 901, item.Nome, 901, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 913, "\")", 913, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Apagar</button>\r\n            </td>\r\n");
#nullable restore
#line 33 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>    \r\n");
#nullable restore
#line 35 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GEM.Repository.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
