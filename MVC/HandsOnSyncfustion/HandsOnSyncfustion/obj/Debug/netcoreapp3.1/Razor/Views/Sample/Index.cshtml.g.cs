#pragma checksum "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\Sample\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61db572daba2b5c1e48f32c120732ae17a180bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sample_Index), @"mvc.1.0.view", @"/Views/Sample/Index.cshtml")]
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
#line 1 "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\_ViewImports.cshtml"
using HandsOnSyncfustion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\_ViewImports.cshtml"
using HandsOnSyncfustion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61db572daba2b5c1e48f32c120732ae17a180bae", @"/Views/Sample/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cbb9cc1eb4d0f8287d9825fa57879e6f8cc7a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Sample_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "datepicker", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "t1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.EJ2.Calendars.DatePicker __Syncfusion_EJ2_Calendars_DatePicker;
        private global::Syncfusion.EJ2.Inputs.TextBox __Syncfusion_EJ2_Inputs_TextBox;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\Sample\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<div class=\"container\" style=\"width:200px\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ejs-datepicker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61db572daba2b5c1e48f32c120732ae17a180bae4105", async() => {
            }
            );
            __Syncfusion_EJ2_Calendars_DatePicker = CreateTagHelper<global::Syncfusion.EJ2.Calendars.DatePicker>();
            __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Calendars_DatePicker);
            __Syncfusion_EJ2_Calendars_DatePicker.Id = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ejs-textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61db572daba2b5c1e48f32c120732ae17a180bae5160", async() => {
            }
            );
            __Syncfusion_EJ2_Inputs_TextBox = CreateTagHelper<global::Syncfusion.EJ2.Inputs.TextBox>();
            __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Inputs_TextBox);
            __Syncfusion_EJ2_Inputs_TextBox.Id = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
