#pragma checksum "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f1a95c0c263ff644ead9b90989fb331fd521770cd82f027dc4e7287e45598e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmployeesCRUD.Pages.Employees.Pages_Employees_Delete), @"mvc.1.0.razor-page", @"/Pages/Employees/Delete.cshtml")]
namespace EmployeesCRUD.Pages.Employees
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\_ViewImports.cshtml"
using EmployeesCRUD

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f1a95c0c263ff644ead9b90989fb331fd521770cd82f027dc4e7287e45598e04", @"/Pages/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"557ae3dc0e84f8bf2780295dc29589db3fadd314078086794339b97a133fa60d", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Pages_Employees_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
  
    ViewData["Title"] = "Eliminar Empleado";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h2>¿Está seguro de eliminar este empleado?</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">");
            Write(
#nullable restore
#line 12 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                              Html.DisplayNameFor(model => model.Employee.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
            Write(
#nullable restore
#line 13 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                               Html.DisplayFor(model => model.Employee.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-2\">");
            Write(
#nullable restore
#line 15 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                              Html.DisplayNameFor(model => model.Employee.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
            Write(
#nullable restore
#line 16 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                               Html.DisplayFor(model => model.Employee.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-2\">");
            Write(
#nullable restore
#line 18 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                              Html.DisplayNameFor(model => model.Employee.Department)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
            Write(
#nullable restore
#line 19 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                               Html.DisplayFor(model => model.Employee.Department)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-2\">");
            Write(
#nullable restore
#line 21 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                              Html.DisplayNameFor(model => model.Employee.EntryDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
            Write(
#nullable restore
#line 22 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                               Html.DisplayFor(model => model.Employee.EntryDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-2\">");
            Write(
#nullable restore
#line 24 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                              Html.DisplayNameFor(model => model.Employee.IsActive)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
            Write(
#nullable restore
#line 25 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                               Html.DisplayFor(model => model.Employee.IsActive)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1a95c0c263ff644ead9b90989fb331fd521770cd82f027dc4e7287e45598e048621", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f1a95c0c263ff644ead9b90989fb331fd521770cd82f027dc4e7287e45598e048911", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 29 "D:\!!!Work\TestApp\EmployeesCRUD\EmployeesCRUD\Pages\Employees\Delete.cshtml"
                                      Employee.Id

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1a95c0c263ff644ead9b90989fb331fd521770cd82f027dc4e7287e45598e0410801", async() => {
                    WriteLiteral("Cancelar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeesCRUD.Pages.Employees.DeleteModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeesCRUD.Pages.Employees.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeesCRUD.Pages.Employees.DeleteModel>)PageContext?.ViewData;
        public EmployeesCRUD.Pages.Employees.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
