#pragma checksum "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/dojo_survey_validations/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5155a75961a3a74abb613eb5123bb358f62e94e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/dojo_survey_validations/Views/_ViewImports.cshtml"
using dojo_survey_validations;

#line default
#line hidden
#line 2 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/dojo_survey_validations/Views/_ViewImports.cshtml"
using dojo_survey_validations.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5155a75961a3a74abb613eb5123bb358f62e94e", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87c4045cc16377176e57310bb9906cbe013e2f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 33, true);
            WriteLiteral("\n<h1>Sumitted Info</h1>\n<p>Name: ");
            EndContext();
            BeginContext(48, 10, false);
#line 4 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/dojo_survey_validations/Views/Home/Result.cshtml"
    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(58, 23, true);
            WriteLiteral("</p>\n<p>Dojo Location: ");
            EndContext();
            BeginContext(82, 16, false);
#line 5 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/dojo_survey_validations/Views/Home/Result.cshtml"
             Write(ViewBag.Location);

#line default
#line hidden
            EndContext();
            BeginContext(98, 27, true);
            WriteLiteral("</p>\n<p>Favorite Language: ");
            EndContext();
            BeginContext(126, 14, false);
#line 6 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/dojo_survey_validations/Views/Home/Result.cshtml"
                 Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(140, 17, true);
            WriteLiteral("</p>\n<p>Comment: ");
            EndContext();
            BeginContext(158, 13, false);
#line 7 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/dojo_survey_validations/Views/Home/Result.cshtml"
       Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(171, 81, true);
            WriteLiteral("</p>\n<br>\n<a class=\"btn btn-primary\" href=\"/\"><button>Retake Survey</button></a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591