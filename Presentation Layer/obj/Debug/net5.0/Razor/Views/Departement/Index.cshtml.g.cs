#pragma checksum "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f6b45127e414c2c5abb0473b79b5531c13c17ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departement_Index), @"mvc.1.0.view", @"/Views/Departement/Index.cshtml")]
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
#line 1 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\_ViewImports.cshtml"
using Presentation_Layer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\_ViewImports.cshtml"
using Presentation_Layer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\_ViewImports.cshtml"
using DataAccessLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\_ViewImports.cshtml"
using Presentation_Layer.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f6b45127e414c2c5abb0473b79b5531c13c17ce", @"/Views/Departement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22133508a07b4aceb4d6055e357b959515f926e3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Departement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DepartmentViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Departement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var Message = ViewBag.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
 if (Message is not null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" id=\"messageDiv\">\r\n        ");
#nullable restore
#line 9 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
   Write(Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 11 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    setTimeout(function () {
        var messageDiv = document.getElementById('messageDiv');
        if (messageDiv) {
            messageDiv.style.display = 'none';
        }
    }, 5000);
</script>
<h1>All Departments</h1>
<br/>
<br/>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6b45127e414c2c5abb0473b79b5531c13c17ce6377", async() => {
                WriteLiteral("Create New Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 25 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <table class=\"table table-striped table-hover mt-3\">\r\n     <thead>\r\n         <tr>\r\n             <th>");
#nullable restore
#line 30 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
            Write(Html.DisplayNameFor(D=>D.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n             <th>");
#nullable restore
#line 31 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
            Write(Html.DisplayNameFor(D=>D.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n             <th>");
#nullable restore
#line 32 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
            Write(Html.DisplayNameFor(D=>D.DateOfCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n             <th>Details</th>\r\n             <th>Update</th>\r\n             <th>Delete</th>\r\n         </tr>\r\n     </thead>\r\n     <tbody>\r\n");
#nullable restore
#line 39 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
          foreach(var item in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr>\r\n                 <td>");
#nullable restore
#line 42 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
                Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 43 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 44 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
                Write(item.DateOfCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f6b45127e414c2c5abb0473b79b5531c13c17ce10410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 45 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id.ToString();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n             </tr>\r\n");
#nullable restore
#line 47 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </tbody>\r\n    </table>\r\n");
#nullable restore
#line 50 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-4 alert alert-warning \">\r\n          <h3>There Is No Departments</h3>\r\n    </div>\r\n");
#nullable restore
#line 56 "D:\ROUTE\Sessions\ASP.NET MVC\MVC Project\Web Appliaction\Presentation Layer\Views\Departement\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DepartmentViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
