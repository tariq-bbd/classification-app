#pragma checksum "C:\Users\bbdnet2244\Documents\GitHub\classification-app\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cdf97cb86b6e55bee99fb48c754e9ab999b024a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\bbdnet2244\Documents\GitHub\classification-app\Views\_ViewImports.cshtml"
using ClassificationApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bbdnet2244\Documents\GitHub\classification-app\Views\_ViewImports.cshtml"
using ClassificationApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cdf97cb86b6e55bee99fb48c754e9ab999b024a", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d3f014a0a06beb6938d4c53232fc9da7a4cfcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\bbdnet2244\Documents\GitHub\classification-app\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("usage", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cdf97cb86b6e55bee99fb48c754e9ab999b024a4463", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cdf97cb86b6e55bee99fb48c754e9ab999b024a5744", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">

    <title>Hello, world!</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cdf97cb86b6e55bee99fb48c754e9ab999b024a7159", async() => {
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div class=""row"">
            <!-- Sidear -->
            <div class=""col-md-2 bg-light d-none d-md-block sidebar"">
                <div class=""left-sidebar"">
                    <ul class=""nav flex-column sidebar-nav"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Candidates
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" vi");
                WriteLiteral(@"ewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Jobs
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Orders
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                      ");
                WriteLiteral(@"          <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Invoices
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        <li class=""nav-item"">
        ");
                WriteLiteral(@"                    <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
              ");
                WriteLiteral(@"          <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
       ");
                WriteLiteral(@"                     </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-r");
                WriteLiteral(@"ule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708");
                WriteLiteral(@"l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi bi-chevron-right"" width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path");
                WriteLiteral(@" fill-rule=""evenodd"" d=""M6.646 3.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L12.293 10 6.646 4.354a.5.5 0 010-.708z"" clip-rule=""evenodd"" /></svg>
                                Reports
                            </a>
                        </li>
                        </li>
                    </ul>
                </div>
            </div>
            <main role=""main"" class=""col-md-9 ml-sm-auto col-lg-10 px-4"">
                <h3>Candidates</h3>
                <hr>
                <div class=""table-responsive"">
                    <table class=""table table-light table-striped "">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">First</th>
                                <th scope=""col"">Last</th>
                                <th scope=""col"">Position</th>
                            </tr>
                        </thead>
                      ");
                WriteLiteral(@"  <tbody>
                            <tr>
                                <th scope=""row"">1</th>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>Project Manager</td>
                            </tr>
                            <tr>
                                <th scope=""row"">2</th>
                                <td>Jacob</td>
                                <td>Thornton</td>
                                <td>JS developer</td>
                            </tr>
                            <tr>
                                <th scope=""row"">3</th>
                                <td>Larry</td>
                                <td>Bird</td>
                                <td>Back-end developer</td>
                            </tr>
                            <tr>
                                <th scope=""row"">4</th>
                                <td>Martin</td>
                                <td>S");
                WriteLiteral(@"mith</td>
                                <td>Back-end developer</td>
                            </tr>
                            <tr>
                                <th scope=""row"">5</th>
                                <td>Kate</td>
                                <td>Mayers</td>
                                <td>Scrum master</td>
                            </tr>
                        </tbody>
                    </table>
                </div>


            </main>
        </div>
");
                WriteLiteral(@"        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Invoice #184382</h5>
                        <p class=""card-text"">Donec nec justo eget felis facilisis fermentum. Aliquam porttitor mauris sit amet orci. Aenean dignissim pellentesque felis.</p>
                        <a href=""#"" class=""btn btn-primary"">Print</a>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Invoice #184386</h5>
                        <p class=""card-text"">Donec nec justo eget felis facilisis fermentum. Aliquam porttitor mauris sit amet orci. Aenean dignissim pellentesque felis.</p>
                        <a href=""#"" class=""btn btn-primary"">Print</a>
                    </div>
                </div>
         ");
                WriteLiteral(@"   </div>
        </div>

        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Invoice #184389</h5>
                        <p class=""card-text"">Donec nec justo eget felis facilisis fermentum. Aliquam porttitor mauris sit amet orci. Aenean dignissim pellentesque felis.</p>
                        <a href=""#"" class=""btn btn-primary"">Print</a>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Invoice #184391</h5>
                        <p class=""card-text"">Donec nec justo eget felis facilisis fermentum. Aliquam porttitor mauris sit amet orci. Aenean dignissim pellentesque felis.</p>
                        <a href=""#"" class=""btn btn-primary"">Print</a>
                    </div>
    ");
                WriteLiteral(@"            </div>
            </div>
        </div>
    </div>
    

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
