#pragma checksum "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0515edeb046295bc07f7b7accb0c177db2919613a44619e582f62ca5ce5f4211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TransactionContactUs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TransactionContactUs/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0515edeb046295bc07f7b7accb0c177db2919613a44619e582f62ca5ce5f4211", @"/Areas/Admin/Views/TransactionContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_TransactionContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Restaurant.ViewModels.TransactionContactUsViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"pagetitle\">\r\n    <nav>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0515edeb046295bc07f7b7accb0c177db2919613a44619e582f62ca5ce5f42114040", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            <li class=""breadcrumb-item"">News letter</li>
        </ol>
    </nav>
</div>
<section class=""section"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title d-flex justify-content-end"">
                    </h5>
                    <table class=""table datatable index-table text-break"">
                        <thead>
                            <tr class=""bg-dark text-white"">
                                <th>
                                    ");
#nullable restore
#line 26 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.TransactionContactUsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 29 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.TransactionContactUsFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 32 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.TransactionContactUsEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 35 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.TransactionContactUsSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"w-25\">\r\n                                    ");
#nullable restore
#line 38 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.TransactionContactUsMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody class=\"bg-dark-light\">\r\n");
#nullable restore
#line 43 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"align-middle\">\r\n                                        ");
#nullable restore
#line 47 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TransactionContactUsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"align-middle\">\r\n                                        ");
#nullable restore
#line 50 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TransactionContactUsFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"align-middle\">\r\n                                        ");
#nullable restore
#line 53 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TransactionContactUsEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"align-middle\">\r\n                                        ");
#nullable restore
#line 56 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TransactionContactUsSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"align-middle w-25\">\r\n                                        ");
#nullable restore
#line 59 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TransactionContactUsMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 62 "D:\D-2023\.NetCore\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Restaurant.ViewModels.TransactionContactUsViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
