#pragma checksum "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ab2af4599ee288779e7aca286c59c962f0dd684"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
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
#line 1 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
using Online_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ab2af4599ee288779e7aca286c59c962f0dd684", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c341d60b42f081b259587877284be7fea141da", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
  
  ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"row\">\r\n  <div class=\"col-6\">\r\n    <h2 class=\"text-info\">Product List</h2>\r\n  </div>\r\n  <div class=\"col-6 text-right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab2af4599ee288779e7aca286c59c962f0dd6845178", async() => {
                WriteLiteral("<i class=\"fa fa-plus-square\" aria-hidden=\"true\"></i>&nbsp;Add New Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab2af4599ee288779e7aca286c59c962f0dd6846509", async() => {
                WriteLiteral(@"
  <div class=""row"">
    <div class=""col-3"">
      <input type=""number"" class=""form-control"" name=""lowAmount"" />
    </div>
    <div class=""col-3"">
      <input type=""number"" class=""form-control"" name=""largeAmount"" />
    </div>
    <div class=""col-3"">
      <input type=""submit"" value=""Search"" class=""btn btn-success"" />
    </div>
    <div class=""col-3""></div>
  </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<div>\r\n  <table class=\"table table-striped border\" id=\"myTable\">\r\n    <thead>\r\n      <tr class=\"table-info\">\r\n        <th>\r\n          ");
#nullable restore
#line 37 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
     Write(Html.DisplayNameFor(c => c.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n          ");
#nullable restore
#line 40 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
     Write(Html.DisplayNameFor(c => c.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n          ");
#nullable restore
#line 43 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
     Write(Html.DisplayNameFor(c => c.ProductColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n          ");
#nullable restore
#line 46 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
     Write(Html.DisplayNameFor(c => c.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n          ");
#nullable restore
#line 49 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
     Write(Html.DisplayNameFor(c => c.ProductTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n          ");
#nullable restore
#line 52 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
     Write(Html.DisplayNameFor(c => c.SpecialTagId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n        <th></th>\r\n      </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 60 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 63 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 64 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 65 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
         Write(item.ProductColor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 66 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
         Write(item.IsAvailable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 67 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
         Write(item.ProductTypes.ProductType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 68 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
         Write(item.SpecialTags.SpecialTag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ab2af4599ee288779e7aca286c59c962f0dd68412095", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 69 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 71 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"

      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
  <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js""></script>
  <script type=""text/javascript"">
    $(document).ready(function () {
      $('#myTable').DataTable({
        dom: 'Bfrtip',
        buttons: [
          'copy', 'csv', 'excel', 'pdf', 'print'
        ]
      });
    });

    $(function () {
      var save = '");
#nullable restore
#line 89 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
             Write(TempData["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n      if (save != null) {\r\n        alertify.success(save);\r\n      }\r\n      var update = \'");
#nullable restore
#line 93 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
               Write(TempData["update"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n      if (update != null) {\r\n        alertify.success(update);\r\n      }\r\n      var deletedata = \'");
#nullable restore
#line 97 "E:\Asp.net Core\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["deletedata"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n      if (deletedata != null) {\r\n        alertify.success(deletedata);\r\n      }\r\n    })\r\n\r\n  </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
