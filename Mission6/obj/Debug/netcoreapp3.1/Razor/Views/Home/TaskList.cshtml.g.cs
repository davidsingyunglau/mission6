#pragma checksum "C:\Users\matth\source\repos\mission6\Mission6\Views\Home\TaskList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da91986a20ed20d8798fed04129fd2b4ee82ed53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TaskList), @"mvc.1.0.view", @"/Views/Home/TaskList.cshtml")]
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
#line 1 "C:\Users\matth\source\repos\mission6\Mission6\Views\_ViewImports.cshtml"
using Mission6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matth\source\repos\mission6\Mission6\Views\_ViewImports.cshtml"
using Mission6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da91986a20ed20d8798fed04129fd2b4ee82ed53", @"/Views/Home/TaskList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34aeb8077033f1de2c5787128cdbf382e389409c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TaskList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 style=""text-align: center"">Task List</h1>

<div class=""container border border-dark"">
    <div class=""row border-bottom border-dark"">
        <div class=""col-12 text-center"">
            <h1>Stephen Covey's Time Management Matrix</h1>
        </div>
    </div>

    <div class=""row border-bottom border-dark"">
        <div class=""col-2"">
        </div>
        <div class=""col-5 border-left border-dark"">
            <h3>Urgent</h3>
        </div>
        <div class=""col-5 border-left border-dark"">
            <h3>Not Urgent</h3>
        </div>
    </div>

    <div class=""row border-bottom border-dark"">
        <div class=""col-2"">
            <h3>Important</h3>
        </div>
        <div class=""col-5 border-left border-dark"">
            <h4>Quadrant 1</h4>
        </div>
        <div class=""col-5 border-left border-dark"">
            <h4>Quadrant 2</h4>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-2"">
            <h3>Not Important</h3>
       ");
            WriteLiteral(" </div>\r\n        <div class=\"col-5 border-left border-dark\">\r\n            <h4>Quadrant 3</h4>\r\n        </div>\r\n        <div class=\"col-5 border-left border-dark\">\r\n            <h4>Quadrant 4</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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