#pragma checksum "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59cc6cb9200c909938f4c7f22d2068a2773a0aa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devices_Delete), @"mvc.1.0.view", @"/Views/Devices/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59cc6cb9200c909938f4c7f22d2068a2773a0aa9", @"/Views/Devices/Delete.cshtml")]
    #nullable restore
    public class Views_Devices_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VisualStudio_API_Project2.Models.Device>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Device</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeviceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeviceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ZoneId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ZoneId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActvie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsActvie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""DeviceId"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VisualStudio_API_Project2.Models.Device> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591