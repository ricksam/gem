#pragma checksum "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1dbda415f013d3a117276607d41adb300b57ff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Edit), @"mvc.1.0.view", @"/Views/Categoria/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1dbda415f013d3a117276607d41adb300b57ff6", @"/Views/Categoria/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897aa4d6df6414ee158a0704d46d7dbd531adc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEM.Repository.Categoria>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-danger\" role=\"alert\">\r\n    This is a danger alert�check it out!\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <input type=\"hidden\" name=\"Cod_Categoria\"");
            BeginWriteAttribute("value", " value=\"", 225, "\"", 255, 1);
#nullable restore
#line 11 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\Edit.cshtml"
WriteAttributeValue("", 233, Model.Cod_Categoria, 233, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    \r\n    <div class=\"form-group col-sm-6\">\r\n        <label class=\"control-label\">Nome</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Nome\"");
            BeginWriteAttribute("value", " value=\"", 416, "\"", 437, 1);
#nullable restore
#line 15 "D:\PROJECTS\RckSoftware\CCB\gem\Views\Categoria\Edit.cshtml"
WriteAttributeValue("", 424, Model.Nome, 424, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div> \r\n</div> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEM.Repository.Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591
