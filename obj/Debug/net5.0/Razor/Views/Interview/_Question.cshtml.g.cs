#pragma checksum "/home/andrew/Documents/chms/chms/Views/Interview/_Question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28be87fc019408bd67b86d49745422276efb9784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Interview__Question), @"mvc.1.0.view", @"/Views/Interview/_Question.cshtml")]
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
#line 1 "/home/andrew/Documents/chms/chms/Views/_ViewImports.cshtml"
using mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/andrew/Documents/chms/chms/Views/_ViewImports.cshtml"
using mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28be87fc019408bd67b86d49745422276efb9784", @"/Views/Interview/_Question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a06753573638890b0ff2d42042a0bcf031bf36", @"/Views/_ViewImports.cshtml")]
    public class Views_Interview__Question : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/andrew/Documents/chms/chms/Views/Interview/_Question.cshtml"
 if(Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"question\">\n        <p><b>");
#nullable restore
#line 6 "/home/andrew/Documents/chms/chms/Views/Interview/_Question.cshtml"
         Write(Model.Medication.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n        <p>");
#nullable restore
#line 7 "/home/andrew/Documents/chms/chms/Views/Interview/_Question.cshtml"
      Write(Model.Question.Information.QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        ");
#nullable restore
#line 8 "/home/andrew/Documents/chms/chms/Views/Interview/_Question.cshtml"
   Write(Html.Hidden("mId", Model.Medication.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 9 "/home/andrew/Documents/chms/chms/Views/Interview/_Question.cshtml"
   Write(Html.Hidden("qId", Model.Question.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <a id=\"next\" href=\"#\">Next</a>\n    </div>\n");
#nullable restore
#line 12 "/home/andrew/Documents/chms/chms/Views/Interview/_Question.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    document.addEventListener(""DOMContentLoaded"", function bind() {
        $('#next').on('click', function(e){
            e.preventDefault();
            $.ajax({
                url: '/Interview/NextQuestion',
                cache: 'false',
                method: 'POST',
                data: {
                    mId: $('#mId').val(),
                    qId: $('#qId').val()
                },
                success: function(data)
                {
                    $('#question').html(data);
                    bind();
                }

            });
        })
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591