#pragma checksum "/home/ricksam/Projects/CCB/gem/Views/Presenca/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb09dc286f0e9aa3b4cad6009799cec2c276abfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_Edit), @"mvc.1.0.view", @"/Views/Presenca/Edit.cshtml")]
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
#line 2 "/home/ricksam/Projects/CCB/gem/Views/Presenca/Edit.cshtml"
using GEM.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ricksam/Projects/CCB/gem/Views/Presenca/Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb09dc286f0e9aa3b4cad6009799cec2c276abfb", @"/Views/Presenca/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ebefddbfc1ec11f6d16e946c3256bf3888b9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.Presenca>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "/home/ricksam/Projects/CCB/gem/Views/Presenca/Edit.cshtml"
  
    UserSession sessao = UserSession.Get(HttpContextAccessor.HttpContext);
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"alert alert-danger\" role=\"alert\">\n    This is a danger alert check it out!\n</div>\n\n<div class=\"row\">\n    <input type=\"hidden\" name=\"Cod_Presenca\"");
            BeginWriteAttribute("value", " value=\"", 389, "\"", 418, 1);
#nullable restore
#line 15 "/home/ricksam/Projects/CCB/gem/Views/Presenca/Edit.cshtml"
WriteAttributeValue("", 397, Model.Cod_Presenca, 397, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    \n    <div class=\"form-group col-sm-6\">\n        <label class=\"control-label\">Cod_Usuario</label>\n        ");
#nullable restore
#line 19 "/home/ricksam/Projects/CCB/gem/Views/Presenca/Edit.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_Combo.cshtml", new GEM.Models.Combo(){
            Class="form-control",
            Name="Cod_Usuario",
            Items=GEM.Repository.Usuario.ListByComum(sessao.Usuario.Cod_Comum).Select(e=>new ComboItem(){Text=e.Nome,Value=e.Cod_Usuario.ToString()}).ToList(),
            SelectedItem=Model.Cod_Usuario.ToString()            
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div> \n    <div class=\"form-group col-sm-6\">\n        <label class=\"control-label\">Data</label>\n        <input type=\"text\" class=\"form-control\" name=\"Data\"");
            BeginWriteAttribute("value", " value=\"", 1074, "\"", 1095, 1);
#nullable restore
#line 28 "/home/ricksam/Projects/CCB/gem/Views/Presenca/Edit.cshtml"
WriteAttributeValue("", 1082, Model.Data, 1082, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div> \n    <div class=\"form-group col-sm-6\">\n        <label class=\"control-label\">Instrutor</label>\n        ");
#nullable restore
#line 32 "/home/ricksam/Projects/CCB/gem/Views/Presenca/Edit.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_Combo.cshtml", new GEM.Models.Combo(){
            Class="form-control",
            Name="Instrutor",
            Items=GEM.Repository.Usuario.ListByComum(sessao.Usuario.Cod_Comum).Select(e=>new ComboItem(){Text=e.Nome,Value=e.Cod_Usuario.ToString()}).ToList(),
            SelectedItem=Model.Instrutor.ToString()            
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div> \n</div> \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.Presenca> Html { get; private set; }
    }
}
#pragma warning restore 1591
