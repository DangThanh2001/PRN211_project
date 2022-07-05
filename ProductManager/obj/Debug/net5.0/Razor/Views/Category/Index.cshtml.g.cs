#pragma checksum "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e8aaa5dc051ecb5b91122f2205c506b58c04a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
using ProductManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e8aaa5dc051ecb5b91122f2205c506b58c04a3", @"/Views/Category/Index.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
Write(await Html.PartialAsync("Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e8aaa5dc051ecb5b91122f2205c506b58c04a32969", async() => {
                WriteLiteral("\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row header\">\r\n\t\t\t<div class=\"text-center col-sm-12\">\r\n\t\t\t\t<h1>\r\n\t\t\t\t\tSunflower\r\n\t\t\t\t</h1>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t");
#nullable restore
#line 20 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
   Write(await Html.PartialAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"		<div class=""row"">
			<div class=""col-sm-1""></div>
			<div class=""col-sm-10 row"">
				<div class=""col-sm-10""></div>
				<div class=""col-sm-2"">
					<br>
					<a class=""btn btn-outline-primary my-2 my-sm-0 float-right"" href=""/category/add"">Add more category</a>
				</div>
			</div>
			<div class=""col-sm-1""></div>
		</div>

		<div class=""row content"">
			<div class=""col-sm-1""></div>
			<div class=""col-sm-10"">
				<div class=""alert alert-warning"" role=""alert"">
					");
#nullable restore
#line 38 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
               Write(ViewBag.mess);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
				</div>
				<div>
					<table class=""table table-striped "">
						<thead>
							<tr>
								<th scope=""col"">Category Name</th>
								<th scope=""col"">Category Description</th>
								<th scope=""col"">Action</th>
							</tr>
						</thead>
						<tbody>
");
#nullable restore
#line 50 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
                             if (Model.Count == 0)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td colspan=\"7\" class=\"text-center\">\r\n\t\t\t\t\t\t\t\t\t\t<i>No records found...</i>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 57 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
							}
							else
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
                                 foreach (Category o in Model)
								{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td scope=\"row\">");
#nullable restore
#line 63 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
                                                   Write(o.CatName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td scope=\"row\">");
#nullable restore
#line 64 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
                                                   Write(o.CatNote);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<a class=\"text-info\"");
                BeginWriteAttribute("href", " href=\"", 1620, "\"", 1652, 2);
                WriteAttributeValue("", 1627, "/category/update/", 1627, 17, true);
#nullable restore
#line 67 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
WriteAttributeValue("", 1644, o.CatId, 1644, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update</a>\r\n\t\t\t\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t\t\t\t<a class=\"text-info\" data-toggle=\"modal\" data-target=\"#Cat");
#nullable restore
#line 69 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
                                                                                                  Write(o.CatId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" href=\"#\">Delete</a>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 72 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
								}

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
                                 
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-1\"></div>\r\n\t\t</div>\r\n\r\n");
#nullable restore
#line 83 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
         foreach (Category o in Model)
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 2007, "\"", 2025, 2);
                WriteAttributeValue("", 2012, "Cat", 2012, 3, true);
#nullable restore
#line 85 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
WriteAttributeValue("", 2015, o.CatId, 2015, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
				<div class=""modal-dialog"" role=""document"">
					<div class=""modal-content"">
						<div class=""modal-header"">
							<h5 class=""modal-title text-danger"" id=""exampleModalLabel"">Warning!!!</h5>
							<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
								<span aria-hidden=""true"">&times;</span>
							</button>
						</div>
						<div class=""modal-body"">
							");
#nullable restore
#line 95 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
                       Write(ViewBag.mess);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"modal-footer\">\r\n\t\t\t\t\t\t\t<a type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</a>\r\n\t\t\t\t\t\t\t<a type=\"button\" class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 2708, "\"", 2740, 2);
                WriteAttributeValue("", 2715, "/category/delete/", 2715, 17, true);
#nullable restore
#line 99 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
WriteAttributeValue("", 2732, o.CatId, 2732, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Save changes</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 104 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<!-- Modal -->\r\n");
                WriteLiteral("\t</div>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
