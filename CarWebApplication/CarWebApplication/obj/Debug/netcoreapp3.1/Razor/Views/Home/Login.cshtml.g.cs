#pragma checksum "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c3beebfc298f065263ca7fef41c80a425c2054"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.razor-page", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c3beebfc298f065263ca7fef41c80a425c2054", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome Login Page</h1>\r\n\r\n        <h2>login</h2>\r\n");
#nullable restore
#line 8 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
         using (Html.BeginForm("Login", "Home", FormMethod.Post))
        {
            //this is for create form tag
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
                                     // this is for prevent CSRF attack
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
                                         
            if (@ViewBag.Message != null)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"border:1px solid red\">\r\n                    ");
#nullable restore
#line 17 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(a => a.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
                   Write(Html.TextBoxFor(a => a.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(a => a.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
                   Write(Html.PasswordFor(a => a.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type=""submit"" value=""Login"" />
                    </td>
                    <td></td>
                </tr>
            </table>
");
#nullable restore
#line 46 "C:\DATA\Study\LearnSOLID\study-solid\CarWebApplication\CarWebApplication\Views\Home\Login.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWebApplication.Models.LoginViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarWebApplication.Models.LoginViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarWebApplication.Models.LoginViewModel>)PageContext?.ViewData;
        public CarWebApplication.Models.LoginViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
