#pragma checksum "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa72f7b88781c3096bc83d083cfd6ef7d8cbef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zones_Details), @"mvc.1.0.view", @"/Views/Zones/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa72f7b88781c3096bc83d083cfd6ef7d8cbef7", @"/Views/Zones/Details.cshtml")]
    #nullable restore
    public class Views_Zones_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VisualStudio_API_Project2.Models.Zone>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Zone</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ZoneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml"
       Write(Html.DisplayFor(model => model.ZoneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ZoneDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml"
       Write(Html.DisplayFor(model => model.ZoneDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 876, "\"", 904, 1);
#nullable restore
#line 34 "C:\Users\Alouw\Desktop\CMPG-323-Project-2---33768080\VisualStudio_API_Project2\Views\Zones\Details.cshtml"
WriteAttributeValue("", 891, Model.ZoneId, 891, 13, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VisualStudio_API_Project2.Models.Zone> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
