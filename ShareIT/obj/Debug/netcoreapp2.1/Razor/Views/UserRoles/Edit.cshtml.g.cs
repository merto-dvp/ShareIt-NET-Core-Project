#pragma checksum "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "827a0cc14f2f52c7694a3b239ca8621ee44bb187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRoles_Edit), @"mvc.1.0.view", @"/Views/UserRoles/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRoles/Edit.cshtml", typeof(AspNetCore.Views_UserRoles_Edit))]
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
#line 1 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\_ViewImports.cshtml"
using ShareIT;

#line default
#line hidden
#line 2 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\_ViewImports.cshtml"
using ShareIT.Models;

#line default
#line hidden
#line 3 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"827a0cc14f2f52c7694a3b239ca8621ee44bb187", @"/Views/UserRoles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d4753c867f7d3987f71d9b3294f530093af52ae", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRoles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(60, 641, true);
            WriteLiteral(@"<section class=""banner-area relative about-banner"" id=""home"" style=""height:300px"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"" style=""height:100px"">
            <div class=""about-content col-lg-8"">
                <h1 class=""text-white"">
                    Kullanıcı Yetki Yönetimi

                </h1>
            </div>
        </div>
    </div>
</section>


<div class=""whole-wrap"">
    <div class=""container"">
        <div class=""container"" style=""padding:5%;text-align:center"">

            <br />

            ");
            EndContext();
            BeginContext(701, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66b526206079494cb35259bf6246a591", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 26 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(767, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(783, 2167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa10447056544470accdacc82b516ca0", async() => {
                BeginContext(821, 54, true);
                WriteLiteral("\r\n\r\n                <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 875, "\"", 897, 1);
#line 30 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
WriteAttributeValue("", 883, Model.Role.Id, 883, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(898, 57, true);
                WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 955, "\"", 979, 1);
#line 31 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
WriteAttributeValue("", 963, Model.Role.Name, 963, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(980, 85, true);
                WriteLiteral(" />\r\n\r\n                <h6 class=\"bg-info p-1 text-white\">\r\n                    Rol( ");
                EndContext();
                BeginContext(1066, 15, false);
#line 34 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                    Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1081, 97, true);
                WriteLiteral(" )\'e ekle\r\n                </h6>\r\n                <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 37 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                     if (Model.NotMembers.Count() == 0)
                    {

#line default
#line hidden
                BeginContext(1258, 90, true);
                WriteLiteral("                        <tr><td colspan=\"2\">Tüm kullanıcılar bu yetkiye sahip.</td></tr>\r\n");
                EndContext();
#line 40 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 43 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                         foreach (var user in Model.NotMembers)
                        {

#line default
#line hidden
                BeginContext(1512, 70, true);
                WriteLiteral("                            <tr>\r\n                                <td>");
                EndContext();
                BeginContext(1583, 13, false);
#line 46 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                               Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1596, 121, true);
                WriteLiteral("</td>\r\n                                <td>\r\n                                    <input type=\"checkbox\" name=\"UsersToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1717, "\"", 1733, 1);
#line 48 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
WriteAttributeValue("", 1725, user.Id, 1725, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1734, 79, true);
                WriteLiteral(" />\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 51 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                        }

#line default
#line hidden
#line 51 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(1863, 108, true);
                WriteLiteral("                </table>\r\n\r\n\r\n                <h6 class=\"bg-info p-1 text-white\">\r\n                    Rol( ");
                EndContext();
                BeginContext(1972, 15, false);
#line 57 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                    Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1987, 99, true);
                WriteLiteral(" )\'den sil.\r\n                </h6>\r\n                <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 60 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                     if (Model.Members.Count() == 0)
                    {

#line default
#line hidden
                BeginContext(2163, 69, true);
                WriteLiteral("                        <tr><td colspan=\"2\">Kullanıcı Yok</td></tr>\r\n");
                EndContext();
#line 63 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 66 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                         foreach (var user in Model.Members)
                        {

#line default
#line hidden
                BeginContext(2393, 70, true);
                WriteLiteral("                            <tr>\r\n                                <td>");
                EndContext();
                BeginContext(2464, 13, false);
#line 69 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                               Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(2477, 124, true);
                WriteLiteral("</td>\r\n                                <td>\r\n                                    <input type=\"checkbox\" name=\"UsersToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2601, "\"", 2617, 1);
#line 71 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
WriteAttributeValue("", 2609, user.Id, 2609, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2618, 79, true);
                WriteLiteral(" />\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 74 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                        }

#line default
#line hidden
#line 74 "C:\Users\merto\Desktop\ShareIT\ShareIT\Views\UserRoles\Edit.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(2747, 125, true);
                WriteLiteral("\r\n                </table>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Güncelle</button>\r\n                ");
                EndContext();
                BeginContext(2872, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a8727a662434ea2a349906b058366a8", async() => {
                    BeginContext(2920, 5, true);
                    WriteLiteral("İptal");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                EndContext();
                BeginContext(2929, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2950, 66, true);
            WriteLiteral("\r\n\r\n\r\n            <br /><br />\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
