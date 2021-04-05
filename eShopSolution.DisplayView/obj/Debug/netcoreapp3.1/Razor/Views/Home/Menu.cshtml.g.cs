#pragma checksum "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15b2f537e23e8a70cd6d6ec2022c3388c3cb0498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15b2f537e23e8a70cd6d6ec2022c3388c3cb0498", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df52d89f6cb381bcd27c3338882541b0bd98f93c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("appointment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
  
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
                    <h1 class=""mb-3 mt-5 bread"">Our Menu</h1>
                    <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Menu</span></p>
                </div>

            </div>
        </div>
    </div>
</section>

<section class=""ftco-intro"">
    <div class=""container-wrap"">
        <div class=""wrap d-md-flex align-items-xl-end"">
            <div class=""info"">
                <div class=""row no-gutters"">
                    <div class=""col-md-4 d-flex ftco-animate"">
                        <div class=""icon""><span class=""icon-phone""></span></div>
     ");
            WriteLiteral(@"                   <div class=""text"">
                            <h3>000 (123) 456 7890</h3>
                            <p>A small river named Duden flows by their place and supplies.</p>
                        </div>
                    </div>
                    <div class=""col-md-4 d-flex ftco-animate"">
                        <div class=""icon""><span class=""icon-my_location""></span></div>
                        <div class=""text"">
                            <h3>198 West 21th Street</h3>
                            <p>	203 Fake St. Mountain View, San Francisco, California, USA</p>
                        </div>
                    </div>
                    <div class=""col-md-4 d-flex ftco-animate"">
                        <div class=""icon""><span class=""icon-clock-o""></span></div>
                        <div class=""text"">
                            <h3>Open Monday-Friday</h3>
                            <p>8:00am - 9:00pm</p>
                        </div>
                    </div>");
            WriteLiteral("\n                </div>\r\n            </div>\r\n            <div class=\"book p-4\">\r\n                <h3>Book a Table</h3>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15b2f537e23e8a70cd6d6ec2022c3388c3cb04987272", async() => {
                WriteLiteral(@"
                    <div class=""d-md-flex"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""First Name"">
                        </div>
                        <div class=""form-group ml-md-4"">
                            <input type=""text"" class=""form-control"" placeholder=""Last Name"">
                        </div>
                    </div>
                    <div class=""d-md-flex"">
                        <div class=""form-group"">
                            <div class=""input-wrap"">
                                <div class=""icon""><span class=""ion-md-calendar""></span></div>
                                <input type=""text"" class=""form-control appointment_date"" placeholder=""Date"">
                            </div>
                        </div>
                        <div class=""form-group ml-md-4"">
                            <div class=""input-wrap"">
                                <div class=""icon""><spa");
                WriteLiteral(@"n class=""ion-ios-clock""></span></div>
                                <input type=""text"" class=""form-control appointment_time"" placeholder=""Time"">
                            </div>
                        </div>
                        <div class=""form-group ml-md-4"">
                            <input type=""text"" class=""form-control"" placeholder=""Phone"">
                        </div>
                    </div>
                    <div class=""d-md-flex"">
                        <div class=""form-group"">
                            <textarea");
                BeginWriteAttribute("name", " name=\"", 4018, "\"", 4025, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 4026, "\"", 4031, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""2"" class=""form-control"" placeholder=""Message""></textarea>
                        </div>
                        <div class=""form-group ml-md-4"">
                            <input type=""submit"" value=""Appointment"" class=""btn btn-white py-3 px-4"">
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 mb-5 pb-3"">
                <h3 class=""mb-5 heading-pricing ftco-animate"">CAFE VIỆT</h3>
");
#nullable restore
#line 100 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                 foreach (var item in ViewBag.list1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"pricing-entry d-flex ftco-animate\">\r\n                        <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 4842, "\"", 4922, 4);
            WriteAttributeValue("", 4850, "background-image:", 4850, 17, true);
            WriteAttributeValue(" ", 4867, "url(../Admin/images/Product/", 4868, 29, true);
#nullable restore
#line 103 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
WriteAttributeValue("", 4896, Url.Content(item.Image), 4896, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4920, ");", 4920, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"desc pl-3\">\r\n                            <div class=\"d-flex text align-items-center\">\r\n                                <h3><span>");
#nullable restore
#line 106 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                     Write(item.NameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                <span class=\"price\">");
#nullable restore
#line 107 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                               Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Đ</span>
                            </div>
                            <div class=""d-block"">
                                <p>A small river named Duden flows by their place and supplies</p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 114 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                    
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                \r\n               \r\n\r\n            <div class=\"col-md-6 mb-5 pb-3\">\r\n                <h3 class=\"mb-5 heading-pricing ftco-animate\">CAFE MÁY</h3>\r\n");
#nullable restore
#line 122 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                 foreach (var item in ViewBag.list2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"pricing-entry d-flex ftco-animate\">\r\n                        <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 5895, "\"", 5983, 4);
            WriteAttributeValue("        ", 5903, "background-image:", 5911, 25, true);
            WriteAttributeValue(" ", 5928, "url(../Admin/images/Product/", 5929, 29, true);
#nullable restore
#line 125 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
WriteAttributeValue("", 5957, Url.Content(item.Image), 5957, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5981, ");", 5981, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"desc pl-3\">\r\n                            <div class=\"d-flex text align-items-center\">\r\n                                <h3><span>");
#nullable restore
#line 128 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                     Write(item.NameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                <span class=\"price\">");
#nullable restore
#line 129 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                               Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Đ</span>
                            </div>
                            <div class=""d-block"">
                                <p>A small river named Duden flows by their place and supplies</p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 136 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-6\">\r\n                <h3 class=\"mb-5 heading-pricing ftco-animate\">COLD BREW</h3>\r\n");
#nullable restore
#line 141 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                 foreach (var item in ViewBag.list3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"pricing-entry d-flex ftco-animate\">\r\n                        <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 6882, "\"", 6970, 4);
            WriteAttributeValue("        ", 6890, "background-image:", 6898, 25, true);
            WriteAttributeValue(" ", 6915, "url(../Admin/images/Product/", 6916, 29, true);
#nullable restore
#line 144 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
WriteAttributeValue("", 6944, Url.Content(item.Image), 6944, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6968, ");", 6968, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"desc pl-3\">\r\n                            <div class=\"d-flex text align-items-center\">\r\n                                <h3><span>");
#nullable restore
#line 147 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                     Write(item.NameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                <span class=\"price\">");
#nullable restore
#line 148 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                               Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Đ</span>
                            </div>
                            <div class=""d-block"">
                                <p>A small river named Duden flows by their place and supplies</p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 155 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            <div class=\"col-md-6\">\r\n                <h3 class=\"mb-5 heading-pricing ftco-animate\">TRÀ TRÁI CÂY</h3>\r\n");
#nullable restore
#line 160 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                 foreach (var item in ViewBag.list4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pricing-entry d-flex ftco-animate\">\r\n                <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 7860, "\"", 7948, 4);
            WriteAttributeValue("        ", 7868, "background-image:", 7876, 25, true);
            WriteAttributeValue(" ", 7893, "url(../Admin/images/Product/", 7894, 29, true);
#nullable restore
#line 163 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
WriteAttributeValue("", 7922, Url.Content(item.Image), 7922, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7946, ");", 7946, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div class=\"desc pl-3\">\r\n                    <div class=\"d-flex text align-items-center\">\r\n                        <h3><span>");
#nullable restore
#line 166 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                             Write(item.NameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                        <span class=\"price\">");
#nullable restore
#line 167 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                       Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Đ</span>\r\n                    </div>\r\n                    <div class=\"d-block\">\r\n                        <p>A small river named Duden flows by their place and supplies</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 174 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>

<section class=""ftco-menu mb-5 pb-5"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <span class=""subheading"">Discover</span>
                <h2 class=""mb-4"">Our Products</h2>
                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
            </div>
        </div>
        <div class=""row d-md-flex"">
            <div class=""col-lg-12 ftco-animate p-md-5"">
                <div class=""row"">
                    <div class=""col-md-12 nav-link-wrap mb-5"">
                        <div class=""nav ftco-animate nav-pills justify-content-center"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
                            <a class=""nav-link active"" id=""v-pills-1-tab"" data-toggle=""pill"" href=""#v-pills-1"" role=""tab"" aria-contro");
            WriteLiteral(@"ls=""v-pills-1"" aria-selected=""true"">CAFE VIỆT</a>

                            <a class=""nav-link"" id=""v-pills-2-tab"" data-toggle=""pill"" href=""#v-pills-2"" role=""tab"" aria-controls=""v-pills-2"" aria-selected=""false"">CAFE MÁY</a>

                            <a class=""nav-link"" id=""v-pills-3-tab"" data-toggle=""pill"" href=""#v-pills-3"" role=""tab"" aria-controls=""v-pills-3"" aria-selected=""false"">TRÀ TRÁI CÂY</a>

                        </div>
                    </div>
                    <div class=""col-md-12 d-flex align-items-center"">

                        <div class=""tab-content ftco-animate"" id=""v-pills-tabContent"">

                            <div class=""tab-pane fade show active"" id=""v-pills-1"" role=""tabpanel"" aria-labelledby=""v-pills-1-tab"">
                                <div class=""row"">
");
#nullable restore
#line 208 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                     foreach (var item in ViewBag.listAll1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-4 text-center\">\r\n                                            <div class=\"menu-wrap\">\r\n                                                <a href=\"#\" class=\"menu-img img mb-4\"");
            BeginWriteAttribute("style", " style=\"", 10640, "\"", 10728, 4);
            WriteAttributeValue("        ", 10648, "background-image:", 10656, 25, true);
            WriteAttributeValue(" ", 10673, "url(../Admin/images/Product/", 10674, 29, true);
#nullable restore
#line 212 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
WriteAttributeValue("", 10702, Url.Content(item.Image), 10702, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10726, ");", 10726, 2, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                                <div class=\"text\">\r\n                                                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15b2f537e23e8a70cd6d6ec2022c3388c3cb049824252", async() => {
#nullable restore
#line 214 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                                                                                                               Write(item.NameProduct);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 214 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
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
            WriteLiteral("</h3>\r\n                                                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia.</p>\r\n                                                    <p class=\"price\"><span>");
#nullable restore
#line 216 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                                                      Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Đ</span></p>
                                                    <p><a href=""#"" class=""btn btn-primary btn-outline-primary"">Add to cart</a></p>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 221 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                            </div>\r\n\r\n                            <div class=\"tab-pane fade\" id=\"v-pills-2\" role=\"tabpanel\" aria-labelledby=\"v-pills-2-tab\">\r\n                                <div class=\"row\">\r\n");
#nullable restore
#line 227 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                     foreach (var item in ViewBag.listAll2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-4 text-center\">\r\n                                            <div class=\"menu-wrap\">\r\n                                                <a href=\"#\" class=\"menu-img img mb-4\"");
            BeginWriteAttribute("style", " style=\"", 12139, "\"", 12227, 4);
            WriteAttributeValue("        ", 12147, "background-image:", 12155, 25, true);
            WriteAttributeValue(" ", 12172, "url(../Admin/images/Product/", 12173, 29, true);
#nullable restore
#line 231 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
WriteAttributeValue("", 12201, Url.Content(item.Image), 12201, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12225, ");", 12225, 2, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                                <div class=\"text\">\r\n                                                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15b2f537e23e8a70cd6d6ec2022c3388c3cb049829647", async() => {
#nullable restore
#line 233 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                                                                                                               Write(item.NameProduct);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 233 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
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
            WriteLiteral("</h3>\r\n                                                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia.</p>\r\n                                                    <p class=\"price\"><span>");
#nullable restore
#line 235 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                                                      Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Đ</span></p>
                                                    <p><a href=""#"" class=""btn btn-primary btn-outline-primary"">Add to cart</a></p>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 240 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                            </div>\r\n\r\n                            <div class=\"tab-pane fade\" id=\"v-pills-3\" role=\"tabpanel\" aria-labelledby=\"v-pills-3-tab\">\r\n                                <div class=\"row\">\r\n");
#nullable restore
#line 246 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                     foreach (var item in ViewBag.listAll4)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-4 text-center\">\r\n                                            <div class=\"menu-wrap\">\r\n                                                <a href=\"#\" class=\"menu-img img mb-4\"");
            BeginWriteAttribute("style", " style=\"", 13638, "\"", 13726, 4);
            WriteAttributeValue("        ", 13646, "background-image:", 13654, 25, true);
            WriteAttributeValue(" ", 13671, "url(../Admin/images/Product/", 13672, 29, true);
#nullable restore
#line 250 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
WriteAttributeValue("", 13700, Url.Content(item.Image), 13700, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13724, ");", 13724, 2, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                                <div class=\"text\">\r\n                                                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15b2f537e23e8a70cd6d6ec2022c3388c3cb049835042", async() => {
#nullable restore
#line 252 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                                                                                                               Write(item.NameProduct);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 252 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
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
            WriteLiteral("</h3>\r\n                                                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia.</p>\r\n                                                    <p class=\"price\"><span>");
#nullable restore
#line 254 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                                                      Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                                    <p><a href=""#"" class=""btn btn-primary btn-outline-primary"">Add to cart</a></p>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 259 "B:\Intent_asp_net\eShopSolutionCoffee\eShopSolution.DisplayView\Views\Home\Menu.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
