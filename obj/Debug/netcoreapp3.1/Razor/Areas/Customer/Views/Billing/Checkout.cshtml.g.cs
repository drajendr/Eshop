#pragma checksum "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "933d5a03dfd1d4ded86887a6b514eca326675984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Billing_Checkout), @"mvc.1.0.view", @"/Areas/Customer/Views/Billing/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"933d5a03dfd1d4ded86887a6b514eca326675984", @"/Areas/Customer/Views/Billing/Checkout.cshtml")]
    public class Areas_Customer_Views_Billing_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/form-validation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
      }

/*      .media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }*/
    </style>
    <div class = ""container"">
<div class=""row"">
    <div class=""col-md-4 order-md-2 mb-4"">
     
");
#nullable restore
#line 28 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
       if (ViewBag.cart != null && ViewBag.cart.Count != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <h4 class=\"d-flex justify-content-between align-items-center mb-3\">\r\n                <span class=\"text-muted\">Your cart</span>\r\n                <span class=\"badge badge-secondary badge-pill\">");
#nullable restore
#line 32 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
                                                          Write(ViewBag.cart.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </h4>\r\n              <ul class=\"list-group mb-3\">\r\n");
#nullable restore
#line 35 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
                     foreach (var item in ViewBag.cart)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                            <div>\r\n                                <h6 class=\"my-0\">");
#nullable restore
#line 39 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
                                            Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <small class=\"text-muted\">Quantity : ");
#nullable restore
#line 40 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
                                                                Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                            <span class=\"text-muted\">$");
#nullable restore
#line 42 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
                                                  Write(item.Product.Price * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n");
#nullable restore
#line 44 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 <li class=\"list-group-item d-flex justify-content-between\">\r\n                  <span>Total (USD)</span>\r\n                  <strong>$");
#nullable restore
#line 48 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
                      Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </li>\r\n             </ul>\r\n");
#nullable restore
#line 51 "C:\My Workspace\HTC\Training\EShop\Areas\Customer\Views\Billing\Checkout.cshtml"
           }
        


#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-8 order-md-1\">\r\n      <h4 class=\"mb-3\">Billing address</h4>\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933d5a03dfd1d4ded86887a6b514eca3266759848202", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n          <div class=\"col-md-6 mb-3\">\r\n            <label for=\"firstName\">First name</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"firstName\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2471, "\"", 2485, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2486, "\"", 2494, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            <div class=""invalid-feedback"">
              Valid first name is required.
            </div>
          </div>
          <div class=""col-md-6 mb-3"">
            <label for=""lastName"">Last name</label>
            <input type=""text"" class=""form-control"" id=""lastName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2791, "\"", 2805, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2806, "\"", 2814, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            <div class=""invalid-feedback"">
              Valid last name is required.
            </div>
          </div>
        </div>
        <div class=""mb-3"">
          <label for=""email"">Email</label>
          <input type=""email"" class=""form-control"" id=""email"" placeholder=""you@example.com"" required>
          <div class=""invalid-feedback"">
            Please enter a valid email address for shipping updates.
          </div>
        </div>

        <div class=""mb-3"">
          <label for=""address"">Address</label>
          <input type=""text"" class=""form-control"" id=""address"" placeholder=""1234 Main St"" required>
          <div class=""invalid-feedback"">
            Please enter your shipping address.
          </div>
        </div>

        <div class=""mb-3"">
          <label for=""address2"">Address 2 <span class=""text-muted"">(Optional)</span></label>
          <input type=""text"" class=""form-control"" id=""address2"" placeholder=""Apartment or suite"">
        </div>

    ");
                WriteLiteral("    <div class=\"row\">\r\n          <div class=\"col-md-5 mb-3\">\r\n            <label for=\"country\">Country</label>\r\n            <select class=\"custom-select d-block w-100\" id=\"country\" required>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933d5a03dfd1d4ded86887a6b514eca32667598410872", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933d5a03dfd1d4ded86887a6b514eca32667598412113", async() => {
                    WriteLiteral("United States");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
            <div class=""invalid-feedback"">
              Please select a valid country.
            </div>
          </div>
          <div class=""col-md-4 mb-3"">
            <label for=""state"">State</label>
            <select class=""custom-select d-block w-100"" id=""state"" required>
              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933d5a03dfd1d4ded86887a6b514eca32667598413472", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933d5a03dfd1d4ded86887a6b514eca32667598414713", async() => {
                    WriteLiteral("California");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
            <div class=""invalid-feedback"">
              Please provide a valid state.
            </div>
          </div>
          <div class=""col-md-3 mb-3"">
            <label for=""zip"">Zip</label>
            <input type=""text"" class=""form-control"" id=""zip""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4827, "\"", 4841, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            <div class=""invalid-feedback"">
              Zip code required.
            </div>
          </div>
        </div>
        <hr class=""mb-4"">        

        <h4 class=""mb-3"">Payment</h4>

        <div class=""d-block my-3"">
          <div class=""custom-control custom-radio"">
            <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" checked required>
            <label class=""custom-control-label"" for=""credit"">Credit card</label>
          </div>
          <div class=""custom-control custom-radio"">
            <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required>
            <label class=""custom-control-label"" for=""debit"">Debit card</label>
          </div>
          <div class=""custom-control custom-radio"">
            <input id=""paypal"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required>
            <label class=""custom-control-label"" for=""paypal"">PayPal</label>
          ");
                WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n          <div class=\"col-md-6 mb-3\">\r\n            <label for=\"cc-name\">Name on card</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"cc-name\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6075, "\"", 6089, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            <small class=""text-muted"">Full name as displayed on card</small>
            <div class=""invalid-feedback"">
              Name on card is required
            </div>
          </div>
          <div class=""col-md-6 mb-3"">
            <label for=""cc-number"">Credit card number</label>
            <input type=""text"" class=""form-control"" id=""cc-number""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6470, "\"", 6484, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            <div class=""invalid-feedback"">
              Credit card number is required
            </div>
          </div>
        </div>
        <div class=""row"">
          <div class=""col-md-3 mb-3"">
            <label for=""cc-expiration"">Expiration</label>
            <input type=""text"" class=""form-control"" id=""cc-expiration""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6836, "\"", 6850, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            <div class=""invalid-feedback"">
              Expiration date required
            </div>
          </div>
          <div class=""col-md-3 mb-3"">
            <label for=""cc-cvv"">CVV</label>
            <input type=""text"" class=""form-control"" id=""cc-cvv""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 7132, "\"", 7146, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            <div class=""invalid-feedback"">
              Security code required
            </div>
          </div>
        </div>
        <hr class=""mb-4"">
        <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Continue to checkout</button>
      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n  </div>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933d5a03dfd1d4ded86887a6b514eca32667598420961", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
