#pragma checksum "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\Demo\SetPagingAndSorting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040f54b8a4d3af9edcc0bccc3f5698f596cd69a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_SetPagingAndSorting), @"mvc.1.0.view", @"/Views/Demo/SetPagingAndSorting.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040f54b8a4d3af9edcc0bccc3f5698f596cd69a9", @"/Views/Demo/SetPagingAndSorting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cbb9cc1eb4d0f8287d9825fa57879e6f8cc7a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_SetPagingAndSorting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HandsOnSyncfustion.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Pid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "120", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Pname", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "150", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Price", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Price", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "130", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Stock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Stock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "grid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.EJ2.Grids.Grid __Syncfusion_EJ2_Grids_Grid;
        private global::Syncfusion.EJ2.Grids.GridPageSettings __Syncfusion_EJ2_Grids_GridPageSettings;
        private global::Syncfusion.EJ2.Grids.GridColumns __Syncfusion_EJ2_Grids_GridColumns;
        private global::Syncfusion.EJ2.Grids.GridColumn __Syncfusion_EJ2_Grids_GridColumn;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\Demo\SetPagingAndSorting.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PagingAndStoring</h1>\r\n<div>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ejs-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040f54b8a4d3af9edcc0bccc3f5698f596cd69a97283", async() => {
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-pagesettings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040f54b8a4d3af9edcc0bccc3f5698f596cd69a97549", async() => {
                }
                );
                __Syncfusion_EJ2_Grids_GridPageSettings = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridPageSettings>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridPageSettings);
#nullable restore
#line 9 "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\Demo\SetPagingAndSorting.cshtml"
__Syncfusion_EJ2_Grids_GridPageSettings.PageSize = 5;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("pageSize", __Syncfusion_EJ2_Grids_GridPageSettings.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040f54b8a4d3af9edcc0bccc3f5698f596cd69a98954", async() => {
                    WriteLiteral("\r\n\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040f54b8a4d3af9edcc0bccc3f5698f596cd69a99238", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040f54b8a4d3af9edcc0bccc3f5698f596cd69a910810", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040f54b8a4d3af9edcc0bccc3f5698f596cd69a912383", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040f54b8a4d3af9edcc0bccc3f5698f596cd69a913956", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_10.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t");
                }
                );
                __Syncfusion_EJ2_Grids_GridColumns = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumns>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumns);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\r\n\t");
            }
            );
            __Syncfusion_EJ2_Grids_Grid = CreateTagHelper<global::Syncfusion.EJ2.Grids.Grid>();
            __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_Grid);
            __Syncfusion_EJ2_Grids_Grid.Id = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#nullable restore
#line 8 "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\Demo\SetPagingAndSorting.cshtml"
__Syncfusion_EJ2_Grids_Grid.DataSource = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("dataSource", __Syncfusion_EJ2_Grids_Grid.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\Demo\SetPagingAndSorting.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowPaging = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("allowPaging", __Syncfusion_EJ2_Grids_Grid.AllowPaging, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "D:\OnlineBatch\Dotnet-Batch-1\MVC\HandsOnSyncfustion\HandsOnSyncfustion\Views\Demo\SetPagingAndSorting.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowSorting = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("allowSorting", __Syncfusion_EJ2_Grids_Grid.AllowSorting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HandsOnSyncfustion.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
