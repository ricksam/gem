#pragma checksum "/home/ricksam/Projects/CCB/gem/Views/TipoEstudo/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "965114c93556dcabcc13ea5f236f0a281e3dd045"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoEstudo_Edit), @"mvc.1.0.view", @"/Views/TipoEstudo/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965114c93556dcabcc13ea5f236f0a281e3dd045", @"/Views/TipoEstudo/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ebefddbfc1ec11f6d16e946c3256bf3888b9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoEstudo_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.TipoEstudo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ricksam/Projects/CCB/gem/Views/TipoEstudo/Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"alert alert-danger\" role=\"alert\">\n    This is a danger alert�check it out!\n</div>\n\n<div class=\"row\">\n    <input type=\"hidden\" name=\"Cod_Tipo\"");
            BeginWriteAttribute("value", " value=\"", 211, "\"", 236, 1);
#nullable restore
#line 11 "/home/ricksam/Projects/CCB/gem/Views/TipoEstudo/Edit.cshtml"
WriteAttributeValue("", 219, Model.Cod_Tipo, 219, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    \n    <div class=\"form-group col-sm-6\">\n        <label class=\"control-label\">Nome</label>\n        <input type=\"text\" class=\"form-control\" name=\"Nome\"");
            BeginWriteAttribute("value", " value=\"", 393, "\"", 414, 1);
#nullable restore
#line 15 "/home/ricksam/Projects/CCB/gem/Views/TipoEstudo/Edit.cshtml"
WriteAttributeValue("", 401, Model.Nome, 401, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div> \n    <div class=\"form-group col-sm-6\">\n        <label class=\"control-label\">Controle</label>\n        <input type=\"text\" class=\"form-control\" name=\"Controle\"");
            BeginWriteAttribute("value", " value=\"", 586, "\"", 611, 1);
#nullable restore
#line 19 "/home/ricksam/Projects/CCB/gem/Views/TipoEstudo/Edit.cshtml"
WriteAttributeValue("", 594, Model.Controle, 594, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div> \n</div> \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.TipoEstudo> Html { get; private set; }
    }
}
#pragma warning restore 1591
