#pragma checksum "/home/ricksam/Projects/CCB/gem/Views/Comum/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce091bfa2a4ddd1819aa8234d68d8b624b4eea74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comum_Edit), @"mvc.1.0.view", @"/Views/Comum/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce091bfa2a4ddd1819aa8234d68d8b624b4eea74", @"/Views/Comum/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ebefddbfc1ec11f6d16e946c3256bf3888b9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comum_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.Comum>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ricksam/Projects/CCB/gem/Views/Comum/Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"alert alert-danger\" role=\"alert\">\n    This is a danger alert�check it out!\n</div>\n\n<div class=\"row\">\n    <input type=\"hidden\" name=\"Cod_Comum\"");
            BeginWriteAttribute("value", " value=\"", 207, "\"", 233, 1);
#nullable restore
#line 11 "/home/ricksam/Projects/CCB/gem/Views/Comum/Edit.cshtml"
WriteAttributeValue("", 215, Model.Cod_Comum, 215, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    \n    <div class=\"form-group col-sm-12\">\n        <label class=\"control-label\">Nome</label>\n        <input type=\"text\" class=\"form-control\" name=\"Nome\"");
            BeginWriteAttribute("value", " value=\"", 391, "\"", 412, 1);
#nullable restore
#line 15 "/home/ricksam/Projects/CCB/gem/Views/Comum/Edit.cshtml"
WriteAttributeValue("", 399, Model.Nome, 399, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div> \n    <div class=\"form-group col-sm-8\">\n        <label class=\"control-label\">Cidade</label>\n        <input type=\"text\" class=\"form-control\" name=\"Cidade\"");
            BeginWriteAttribute("value", " value=\"", 580, "\"", 603, 1);
#nullable restore
#line 19 "/home/ricksam/Projects/CCB/gem/Views/Comum/Edit.cshtml"
WriteAttributeValue("", 588, Model.Cidade, 588, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div> \n    <div class=\"form-group col-sm-4\">\n        <label class=\"control-label\">Estado</label>\n        <input type=\"text\" class=\"form-control\" name=\"Estado\"");
            BeginWriteAttribute("value", " value=\"", 771, "\"", 794, 1);
#nullable restore
#line 23 "/home/ricksam/Projects/CCB/gem/Views/Comum/Edit.cshtml"
WriteAttributeValue("", 779, Model.Estado, 779, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div> \n    <div class=\"form-group col-sm-12\">\n        <label class=\"control-label\">Endereco</label>\n        <input type=\"text\" class=\"form-control\" name=\"Endereco\"");
            BeginWriteAttribute("value", " value=\"", 967, "\"", 992, 1);
#nullable restore
#line 27 "/home/ricksam/Projects/CCB/gem/Views/Comum/Edit.cshtml"
WriteAttributeValue("", 975, Model.Endereco, 975, 17, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.Comum> Html { get; private set; }
    }
}
#pragma warning restore 1591
