#pragma checksum "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5350cdd35e0da4ded75f28d6fc2b85d29a90bf77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
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
#line 1 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\_ViewImports.cshtml"
using eShopSolution.DisplayView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\_ViewImports.cshtml"
using eShopSolution.DisplayView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5350cdd35e0da4ded75f28d6fc2b85d29a90bf77", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df52d89f6cb381bcd27c3338882541b0bd98f93c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("billing-form ftco-bg-dark p-3 p-md-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Checkout.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""home-slider owl-carousel"">

    <div class=""slider-item"" style=""background-image: url(../User/images/bg_3.jpg);"" data-stellar-background-ratio=""0.5"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row slider-text justify-content-center align-items-center"">

                <div class=""col-md-7 col-sm-12 text-center ftco-animate"">
                    <h1 class=""mb-3 mt-5 bread"">Checkout</h1>
                    <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Checout</span></p>
                </div>

            </div>
        </div>
    </div>
</section>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-8 ftco-animate"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5350cdd35e0da4ded75f28d6fc2b85d29a90bf775892", async() => {
                WriteLiteral(@"
                    <h3 class=""mb-4 billing-heading"">Billing Details</h3>
                    <div class=""row align-items-end"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""firstname"">Firt Name</label>
                                <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1482, "\"", 1496, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""lastname"">Last Name</label>
                                <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1814, "\"", 1828, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""w-100""></div>
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label for=""country"">State / Country</label>
                                <div class=""select-wrap"">
                                    <div class=""icon""><span class=""ion-ios-arrow-down""></span></div>
                                    <select");
                BeginWriteAttribute("name", " name=\"", 2336, "\"", 2343, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2344, "\"", 2349, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5350cdd35e0da4ded75f28d6fc2b85d29a90bf778055", async() => {
                    WriteLiteral("France");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5350cdd35e0da4ded75f28d6fc2b85d29a90bf779318", async() => {
                    WriteLiteral("Italy");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5350cdd35e0da4ded75f28d6fc2b85d29a90bf7710580", async() => {
                    WriteLiteral("Philippines");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5350cdd35e0da4ded75f28d6fc2b85d29a90bf7711849", async() => {
                    WriteLiteral("South Korea");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5350cdd35e0da4ded75f28d6fc2b85d29a90bf7713118", async() => {
                    WriteLiteral("Hongkong");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5350cdd35e0da4ded75f28d6fc2b85d29a90bf7714384", async() => {
                    WriteLiteral("Japan");
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
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class=""w-100""></div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""streetaddress"">Street Address</label>
                                <input type=""text"" class=""form-control"" placeholder=""House number and street name"">
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Appartment, suite, unit etc: (optional)"">
                            </div>
                        </div>
                        <div class=""w-100""></div>
                        <div class=""col-md-6"">
                            <div class=""form-grou");
                WriteLiteral("p\">\r\n                                <label for=\"towncity\">Town / City</label>\r\n                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4001, "\"", 4015, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""postcodezip"">Postcode / ZIP *</label>
                                <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4343, "\"", 4357, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""w-100""></div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""phone"">Phone</label>
                                <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4719, "\"", 4733, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""emailaddress"">Email Address</label>
                                <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5059, "\"", 5073, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""w-100""></div>
                        <div class=""col-md-12"">
                            <div class=""form-group mt-4"">
                                <div class=""radio"">
                                    <label class=""mr-3""><input type=""radio"" name=""optradio""> Create an Account? </label>
                                    <label><input type=""radio"" name=""optradio""> Ship to different address</label>
                                </div>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<!-- END -->



                <div class=""row mt-5 pt-3 d-flex"">
                    <div class=""col-md-6 d-flex"">
                        <div class=""cart-detail cart-total ftco-bg-dark p-3 p-md-4"">
                            <h3 class=""billing-heading mb-4"">Cart Total</h3>
                            <p class=""d-flex"">
                                <span>Subtotal</span>
                                <span>$20.60</span>
                            </p>
                            <p class=""d-flex"">
                                <span>Delivery</span>
                                <span>$0.00</span>
                            </p>
                            <p class=""d-flex"">
                                <span>Discount</span>
                                <span>$3.00</span>
                            </p>
                            <hr>
                            <p class=""d-flex total-price"">
                                <span>Total</span>
                       ");
            WriteLiteral(@"         <span>$17.60</span>
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""cart-detail ftco-bg-dark p-3 p-md-4"">
                            <h3 class=""billing-heading mb-4"">Payment Method</h3>
                            <div class=""form-group"">
                                <div class=""col-md-12"">
                                    <div class=""radio"">
                                        <label><input type=""radio"" name=""optradio"" class=""mr-2""> Direct Bank Tranfer</label>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""col-md-12"">
                                    <div class=""radio"">
                                        <label><input type=""radio"" name=""optradio"" class=""mr-2""> Check Payment</label");
            WriteLiteral(@">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""col-md-12"">
                                    <div class=""radio"">
                                        <label><input type=""radio"" name=""optradio"" class=""mr-2""> Paypal</label>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""col-md-12"">
                                    <div class=""checkbox"">
                                        <label><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 8565, "\"", 8573, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2""> I have read and accept the terms and conditions</label>
                                    </div>
                                </div>
                            </div>
                            <p><a href=""#"" class=""btn btn-primary py-3 px-4"">Place an order</a></p>
                        </div>
                    </div>
                </div>
            </div> <!-- .col-md-8 -->




            <div class=""col-xl-4 sidebar ftco-animate"">
                <div class=""sidebar-box"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5350cdd35e0da4ded75f28d6fc2b85d29a90bf7724032", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <div class=""icon"">
                                <span class=""icon-search""></span>
                            </div>
                            <input type=""text"" class=""form-control"" placeholder=""Search..."">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""sidebar-box ftco-animate"">
                    <div class=""categories"">
                        <h3>Categories</h3>
                        <li><a href=""#"">Tour <span>(12)</span></a></li>
                        <li><a href=""#"">Hotel <span>(22)</span></a></li>
                        <li><a href=""#"">Coffee <span>(37)</span></a></li>
                        <li><a href=""#"">Drinks <span>(42)</span></a></li>
                        <li><a href=""#"">Foods <span>(14)</span></a></li>
                        <li><a href=""#"">Travel <span>(140)</span></a></li>
                    </div>
                </div>

                <div class=""sidebar-box ftco-animate"">
                    <h3>Recent Blog</h3>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""        background-image: url(../User/images/image_1.jpg);""></a>
                        <div class=""text"">
                            <h");
            WriteLiteral(@"3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> July 12, 2018</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""        background-image: url(../User/images/image_2.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span clas");
            WriteLiteral(@"s=""icon-calendar""></span> July 12, 2018</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""        background-image: url(../User/images/image_3.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> July 12, 2018</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""ic");
            WriteLiteral(@"on-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""sidebar-box ftco-animate"">
                    <h3>Tag Cloud</h3>
                    <div class=""tagcloud"">
                        <a href=""#"" class=""tag-cloud-link"">dish</a>
                        <a href=""#"" class=""tag-cloud-link"">menu</a>
                        <a href=""#"" class=""tag-cloud-link"">food</a>
                        <a href=""#"" class=""tag-cloud-link"">sweet</a>
                        <a href=""#"" class=""tag-cloud-link"">tasty</a>
                        <a href=""#"" class=""tag-cloud-link"">delicious</a>
                        <a href=""#"" class=""tag-cloud-link"">desserts</a>
                        <a href=""#"" class=""tag-cloud-link"">drinks</a>
                    </div>
                </div>

                <div class=""sidebar-box ftco-animate"">
                    <h3>Paragraph</h3>
                ");
            WriteLiteral(@"    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                </div>
            </div>

        </div>
    </div>
</section> <!-- .section -->");
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