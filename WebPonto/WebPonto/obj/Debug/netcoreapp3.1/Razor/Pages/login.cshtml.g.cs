#pragma checksum "C:\Repos\web-ponto\Web-Ponto\WebPonto\WebPonto\Pages\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5cf0facc0b6cb0ac741d059fe95148608abb709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebPonto.Pages.Pages_login), @"mvc.1.0.razor-page", @"/Pages/login.cshtml")]
namespace WebPonto.Pages
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
#line 1 "C:\Repos\web-ponto\Web-Ponto\WebPonto\WebPonto\Pages\_ViewImports.cshtml"
using WebPonto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5cf0facc0b6cb0ac741d059fe95148608abb709", @"/Pages/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc56ed6d7e1f709aa62c6e7608cf11445109807", @"/Pages/_ViewImports.cshtml")]
    public class Pages_login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-login-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Repos\web-ponto\Web-Ponto\WebPonto\WebPonto\Pages\login.cshtml"
  
    ViewData["Title"] = "Login page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5cf0facc0b6cb0ac741d059fe95148608abb7093354", async() => {
                WriteLiteral(@"
    <section class=""h-100"">
        <div class=""container h-100"">
            <div class=""row justify-content-md-center h-100"">
                <div class=""card-wrapper"">
                    <div class=""brand"">
                        <img src=""https://criticalhits.com.br/wp-content/uploads/2020/03/jutsu-sexy-naruto-1.jpg"""" alt=""logo"" width=""400"" height=""200"">
                    </div>
                    <div class=""card fat"">
                        <div class=""card-body"">
                            <h4 class=""card-title"">Login</h4>
                            <form method=""POST"" class=""my-login-validation"" novalidate="""">
                                <div class=""form-group"">
                                    <label for=""email"">E-Mail Address</label>
                                    <input id=""email"" type=""email"" class=""form-control"" name=""email"" value="""" required autofocus>
                                    <div class=""invalid-feedback"">
                                        E");
                WriteLiteral(@"mail is invalid
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label for=""password"">
                                        Password     
                                        <a href=""forgot.html"" class=""float-right"">
                                            Forgot Password?
                                        </a>
                                    </label>
                                    <input id=""password"" type=""password"" class=""form-control"" name=""password"" required data-eye>
                                    <div class=""invalid-feedback"">
                                        Password is required
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <div class=""custom-checkbox custom-control"">
                        ");
                WriteLiteral(@"                <input type=""checkbox"" name=""remember"" id=""remember"" class=""custom-control-input"">
                                        <label for=""remember"" class=""custom-control-label"">Remember Me</label>
                                    </div>
                                </div>

                                <div class=""form-group m-0"">
                                    <button type=""submit"" class=""btn btn-primary btn-block"">
                                        Login
                                    </button>
                                </div>
                                <div class=""mt-4 text-center"">
                                    Don't have an account? <a href=""register.html"">Create One</a>
                                </div>
                            </form>
                        </div>
                    </div>
                    <div class=""footer"">
                        Copyright &copy; 2017 &mdash; Your Company
                    </div>");
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
    <script src=""js/my-login.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPonto.Pages.loginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPonto.Pages.loginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPonto.Pages.loginModel>)PageContext?.ViewData;
        public WebPonto.Pages.loginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
