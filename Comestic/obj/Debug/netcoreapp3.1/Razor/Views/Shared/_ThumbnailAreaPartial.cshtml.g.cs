#pragma checksum "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48cb1f3b49d4ca65b8cb2d66e93fa902a7092679"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbnailAreaPartial), @"mvc.1.0.view", @"/Views/Shared/_ThumbnailAreaPartial.cshtml")]
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
#line 1 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\_ViewImports.cshtml"
using Comestic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\_ViewImports.cshtml"
using Comestic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cb1f3b49d4ca65b8cb2d66e93fa902a7092679", @"/Views/Shared/_ThumbnailAreaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab919da19c83fe3c29b6d709ca28a7f900413e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbnailAreaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-addcart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 post@Model.FirstOrDefault().Category.Name.Replace(\" \",string.Empty) menu-restaurant\">\r\n        <div class=\"row\">\r\n            <h4 class=\"text-success title-category\"> ");
#nullable restore
#line 10 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                Write(Model.FirstOrDefault().Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n        </div>\r\n        <div class=\"row row-wrap\">\r\n");
#nullable restore
#line 13 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-2 col-md-3 col-sm-6 item-product\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 620, "\"", 627, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"favourite\" title=\"sản phẩm yêu thích\">\r\n                        <i class=\"far fa-heart heart--transparent\"></i>\r\n                    </a>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 799, "\"", 816, 1);
#nullable restore
#line 20 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
WriteAttributeValue("", 805, item.Image, 805, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"upload-image\" width=\"99%\" />\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 877, "\"", 884, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\" name-product\">");
#nullable restore
#line 21 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 22 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                     if (item.Tag == "0")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <p class=""vote"">Hight rated</p>
                        <span><i class=""fas fa-star vote-star""></i></span>
                        <span><i class=""fas fa-star vote-star""></i></span>
                        <span><i class=""fas fa-star vote-star""></i></span>
                        <span><i class=""fas fa-star vote-star""></i></span>
                        <span><i class=""fas fa-star vote-star""></i></span>
");
#nullable restore
#line 30 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                     if (item.Tag == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"vote\">New</p>\r\n                        <p></p>\r\n");
#nullable restore
#line 35 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                     if (item.Tag == "2")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"vote\">Best Seller</p>\r\n                        <p></p>\r\n");
#nullable restore
#line 40 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                     if (item.Tag == "3")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"vote\">New Edition</p>\r\n                        <p></p>\r\n");
#nullable restore
#line 45 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"price\">\r\n                        <h6 class=\"new-price\">");
#nullable restore
#line 47 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                         Write(item.NewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <sup>đ</sup> </h6>\r\n                        <h4 class=\"old-price\">");
#nullable restore
#line 48 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                         Write(item.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("<sup>đ</sup></h4>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48cb1f3b49d4ca65b8cb2d66e93fa902a70926799395", async() => {
                WriteLiteral(@"
                        <div class=""btn__cart--icon--cricle"">
                            <i class=""fas fa-cart-plus btn__cart--cart""></i>
                        </div>
                        <span class=""btn-cart-title"">Xem chi tiết</span>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n");
#nullable restore
#line 58 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 63 "C:\Users\miqng\Desktop\Comestic\Comestic\Views\Shared\_ThumbnailAreaPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
