#pragma checksum "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfc8fe8228392fd0d65f64405f168725c444d933"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
#line 1 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\_ViewImports.cshtml"
using FinalFinal_mvc;

#line default
#line hidden
#line 2 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\_ViewImports.cshtml"
using FinalFinal_mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfc8fe8228392fd0d65f64405f168725c444d933", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2095926ca2c1e502fdb4eb79f9d33158a40d45b", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 302, true);
            WriteLiteral(@"
<h2>Enrolled Customer</h2>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>No</th>
            <th>Name</th>
            <th>Gender</th>
            <th>Email</th>
            <th>Date</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
            BeginContext(394, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(433, 7, false);
#line 22 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
               Write(user.id);

#line default
#line hidden
            EndContext();
            BeginContext(440, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(468, 13, false);
#line 23 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
               Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(481, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(509, 11, false);
#line 24 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
               Write(user.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(520, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(548, 10, false);
#line 25 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
               Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(558, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(586, 9, false);
#line 26 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
               Write(user.Date);

#line default
#line hidden
            EndContext();
            BeginContext(595, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(1097, 58, true);
            WriteLiteral("                    <button class=\"btn btn-primary btn-sm\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1155, "\"", 1224, 2);
#line 34 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
WriteAttributeValue("", 1165, Url.Action("Update", "Customer", new { @id = @user.id }), 1165, 57, false);

#line default
#line hidden
            WriteAttributeValue("", 1222, "\')", 1222, 2, true);
            EndWriteAttribute();
            BeginContext(1225, 70, true);
            WriteLiteral(">Update</button>\r\n                    <a class=\"btn btn-danger btn-sm\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1295, "\"", 1372, 3);
            WriteAttributeValue("", 1305, "Delete(\'", 1305, 8, true);
#line 35 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
WriteAttributeValue("", 1313, Url.Action("Delete", "Customer", new { @id = @user.id }), 1313, 57, false);

#line default
#line hidden
            WriteAttributeValue("", 1370, "\')", 1370, 2, true);
            EndWriteAttribute();
            BeginContext(1373, 88, true);
            WriteLiteral(">Delete</a><i class=\"fa fa-trash fa-lg\"></i>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\mvc_example_Dapper\FinalFinal_mvc\Views\Customer\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1472, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591