#pragma checksum "D:\DOCUMENT\NET\WebERP\WebERP\Views\Shared\_ModalFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72ef86ac1f7d861de22db3bd603f177a0fc6e76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalFooter), @"mvc.1.0.view", @"/Views/Shared/_ModalFooter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ModalFooter.cshtml", typeof(AspNetCore.Views_Shared__ModalFooter))]
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
#line 1 "D:\DOCUMENT\NET\WebERP\WebERP\Views\_ViewImports.cshtml"
using WebERP;

#line default
#line hidden
#line 2 "D:\DOCUMENT\NET\WebERP\WebERP\Views\_ViewImports.cshtml"
using WebERP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ef86ac1f7d861de22db3bd603f177a0fc6e76", @"/Views/Shared/_ModalFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e63f44424d3be86819b308dbfb8a2bb79e4a0b35", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ModalFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebERP.Models.ModalFooter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 62, true);
            WriteLiteral("\r\n<div class=\"modal-footer\">\r\n    <button data-dismiss=\"modal\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 96, "\"", 122, 1);
#line 4 "D:\DOCUMENT\NET\WebERP\WebERP\Views\Shared\_ModalFooter.cshtml"
WriteAttributeValue("", 101, Model.CancelButtonID, 101, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(123, 39, true);
            WriteLiteral(" class=\"btn btn-default\" type=\"button\">");
            EndContext();
            BeginContext(163, 22, false);
#line 4 "D:\DOCUMENT\NET\WebERP\WebERP\Views\Shared\_ModalFooter.cshtml"
                                                                                             Write(Model.CancelButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(185, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 5 "D:\DOCUMENT\NET\WebERP\WebERP\Views\Shared\_ModalFooter.cshtml"
     if (!Model.OnlyCancelButton)
    {

#line default
#line hidden
            BeginContext(238, 39, true);
            WriteLiteral("        <button class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 277, "\"", 303, 1);
#line 7 "D:\DOCUMENT\NET\WebERP\WebERP\Views\Shared\_ModalFooter.cshtml"
WriteAttributeValue("", 282, Model.SubmitButtonID, 282, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(304, 44, true);
            WriteLiteral(" type=\"submit\">            \r\n               ");
            EndContext();
            BeginContext(349, 22, false);
#line 8 "D:\DOCUMENT\NET\WebERP\WebERP\Views\Shared\_ModalFooter.cshtml"
          Write(Model.SubmitButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(371, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 9 "D:\DOCUMENT\NET\WebERP\WebERP\Views\Shared\_ModalFooter.cshtml"
    }

#line default
#line hidden
            BeginContext(389, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebERP.Models.ModalFooter> Html { get; private set; }
    }
}
#pragma warning restore 1591
