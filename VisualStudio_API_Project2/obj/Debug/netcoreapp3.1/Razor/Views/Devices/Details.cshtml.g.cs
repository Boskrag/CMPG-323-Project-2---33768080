#pragma checksum "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bcc808fe64e210a0b137f27d36fcd7708b4cdc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devices_Details), @"mvc.1.0.view", @"/Views/Devices/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bcc808fe64e210a0b137f27d36fcd7708b4cdc0", @"/Views/Devices/Details.cshtml")]
    #nullable restore
    public class Views_Devices_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VisualStudio_API_Project2.Models.Device>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Device</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeviceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeviceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ZoneId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayFor(model => model.ZoneId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActvie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActvie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1499, "\"", 1529, 1);
#nullable restore
#line 52 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Devices\Details.cshtml"
WriteAttributeValue("", 1514, Model.DeviceId, 1514, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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