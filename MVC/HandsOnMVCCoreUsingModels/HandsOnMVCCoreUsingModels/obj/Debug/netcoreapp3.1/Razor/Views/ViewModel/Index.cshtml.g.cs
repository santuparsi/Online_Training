#pragma checksum "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\ViewModel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaff1db255d4bda931a10568c1708962b2560e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewModel_Index), @"mvc.1.0.view", @"/Views/ViewModel/Index.cshtml")]
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
#line 1 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\_ViewImports.cshtml"
using HandsOnMVCCoreUsingModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\_ViewImports.cshtml"
using HandsOnMVCCoreUsingModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaff1db255d4bda931a10568c1708962b2560e26", @"/Views/ViewModel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb88db6a31c8539a674a4481cba51f9dabe079c", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewModel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnMVCCoreUsingModels.ViewModels.OrderItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\ViewModel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<div class=\"container\">\r\n    <pre>\r\n    OrderId:");
#nullable restore
#line 10 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\ViewModel\Index.cshtml"
       Write(Model.Order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ItemName:");
#nullable restore
#line 11 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\ViewModel\Index.cshtml"
        Write(Model.Item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    Price:");
#nullable restore
#line 12 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\ViewModel\Index.cshtml"
     Write(Model.Item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    OrderDate:");
#nullable restore
#line 13 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\ViewModel\Index.cshtml"
         Write(Model.Order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</pre>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnMVCCoreUsingModels.ViewModels.OrderItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
