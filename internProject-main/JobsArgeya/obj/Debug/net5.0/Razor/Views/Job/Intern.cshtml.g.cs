#pragma checksum "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c01a4fe442da748f568db9275018d0897c7f60a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Intern), @"mvc.1.0.view", @"/Views/Job/Intern.cshtml")]
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
#line 1 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01a4fe442da748f568db9275018d0897c7f60a4", @"/Views/Job/Intern.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818629c6ef42b152e17f9394f18714f552c98264", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Intern : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplyModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Belirtilmemiş", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Erkek", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Kadın", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Job/Intern"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
  
    ViewData["Title"] = "Stajyerlik Başvurusu";
    ViewData["BreadcrumbTitle"] = "Stajyerlik Başvurusu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
 if (TempData["successMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 10 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
   Write(TempData["successMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 12 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
 if (TempData["dangerMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        ");
#nullable restore
#line 16 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
   Write(TempData["dangerMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 18 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css"" integrity=""sha512-aOG0c6nPNzGk+5zjwyJaoRUgCdOrfSDhmMID2u4+OIslr0GjpLKo7Xm0Ao3xmpM4T8AmIouRkqwj1nrdVsLKEQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
");
            }
            );
            WriteLiteral("\n<section class=\"tools\">\n    <div class=\"container\">\n        <div class=\"t-row\">\n            <div class=\"d-table-cell\">\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("style", " style=\"", 866, "\"", 988, 8);
            WriteAttributeValue("", 874, "margin-top:25px;", 874, 16, true);
            WriteAttributeValue(" ", 890, "margin-bottom:25px;", 891, 20, true);
            WriteAttributeValue(" ", 910, "background-color:", 911, 18, true);
#nullable restore
#line 27 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 928, ViewData["SiteColor"], 928, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 950, ";", 950, 1, true);
            WriteAttributeValue(" ", 951, "border-color:", 952, 14, true);
#nullable restore
#line 27 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 965, ViewData["SiteColor"], 965, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 987, ";", 987, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" href=""/"" title=""Geri"">
                    <span style=""line-height: 12px; font-size: 20px;"">&#x2190;</span> Geri Git
                </a>
            </div>
        </div>
    </div>
</section>
<div class=""container"">
    <div class=""title text-center"">
        <h1>Başvuru Formu</h1>
        <p>
            Hem gelişmek hem de öğrenmek mi istiyorsun? Projeler geliştirip kendini iş hayatına alıştırmak mı istiyorsun?
            <br />Önünde mükemmel duran bir fırsat var.
        </p>
    </div>
    <div class=""job-apply-form"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01a4fe442da748f568db9275018d0897c7f60a49761", async() => {
                WriteLiteral(@"
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""FullName""><b>Adınız ve Soydınız: *</b></label>
                <input name=""FullName"" class=""form-control"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""Phone""><b>Telefon Numaranız: *</b></label>
                <input name=""Phone"" class=""form-control"" required placeholder=""05XXXXXXXXX"">
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""Email""><b>E-Mail Adresiniz: *</b></label>
                <input type=""email"" name=""Email"" class=""form-control"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label><b>Cinsiyetiniz *</b></label>
                <select name=""Gender"" class=""form-control"" required>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01a4fe442da748f568db9275018d0897c7f60a410980", async() => {
                    WriteLiteral("Lütfen Bir Seçim Yapınız!");
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
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01a4fe442da748f568db9275018d0897c7f60a412241", async() => {
                    WriteLiteral("Belirtmek İstemiyorum");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01a4fe442da748f568db9275018d0897c7f60a413498", async() => {
                    WriteLiteral("Erkek");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01a4fe442da748f568db9275018d0897c7f60a414739", async() => {
                    WriteLiteral("Kadın");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""University""><b>Okuduğunuz Okul: *</b></label>
                <input name=""University"" class=""form-control"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""Faculty""><b>Okuduğunuz Bölüm ve Sınıf: *</b></label>
                <input name=""Faculty"" class=""form-control"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label for=""InternStartDate""><b>Staj Başlangıç Tarihi: *</b></label>
                <input class=""form-control"" id=""InternStartDate"" name=""InternStartDate"" autocomplete=""off"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label for=""InternEndDate""><b>Staj Bitiş Tarihi: *</b></label>
                <input class=""form-control"" id=""InternEndDate"" name=""InternEndDate");
                WriteLiteral(@""" autocomplete=""off"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""Resume""><b>Öz Yazı: *</b></label>
                <textarea name=""Resume"" class=""form-control"" required></textarea>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label for=""FormFile""><b>Özgeçmiş / CV Yükle (Sadece PDF uzantılı dosyalar kabul edilmektedir) *</b></label>
                <input type=""file"" class=""form-control-file"" name=""FormFile"" accept=""application/pdf"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <img style=""display: inline-block; width: 180px; height: 50px; "" id=""imgCaptcha""");
                BeginWriteAttribute("src", " src=\"", 4555, "\"", 4618, 2);
                WriteAttributeValue("", 4561, "/argeya-captcha?", 4561, 16, true);
#nullable restore
#line 90 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 4577, DateTime.Now.ToString("ddMMyyyyHHmmsss"), 4577, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                <a class=\"btn btn-sm small gray\"");
                BeginWriteAttribute("style", " style=\"", 4671, "\"", 4878, 19);
                WriteAttributeValue("", 4679, "display:", 4679, 8, true);
                WriteAttributeValue(" ", 4687, "inline-block;", 4688, 14, true);
                WriteAttributeValue(" ", 4701, "padding:", 4702, 9, true);
                WriteAttributeValue(" ", 4710, "8px;", 4711, 5, true);
                WriteAttributeValue(" ", 4715, "cursor:", 4716, 8, true);
                WriteAttributeValue(" ", 4723, "pointer;", 4724, 9, true);
                WriteAttributeValue(" ", 4732, "vertical-align:", 4733, 16, true);
                WriteAttributeValue(" ", 4748, "top;", 4749, 5, true);
                WriteAttributeValue(" ", 4753, "background-color:", 4754, 18, true);
#nullable restore
#line 91 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 4771, ViewData["SiteColor"], 4771, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4793, ";", 4793, 1, true);
                WriteAttributeValue(" ", 4794, "border-color:", 4795, 14, true);
#nullable restore
#line 91 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 4808, ViewData["SiteColor"], 4808, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4830, ";", 4830, 1, true);
                WriteAttributeValue(" ", 4831, "color:", 4832, 7, true);
                WriteAttributeValue(" ", 4838, "#fff", 4839, 5, true);
                WriteAttributeValue(" ", 4843, "!important;", 4844, 12, true);
                WriteAttributeValue(" ", 4855, "text-decoration:", 4856, 17, true);
                WriteAttributeValue(" ", 4872, "none;", 4873, 6, true);
                EndWriteAttribute();
                WriteLiteral(@" onclick=""var today = new Date(); document.getElementById('imgCaptcha').src = '/argeya-captcha?r=' + today; return false;"">
                    <i class=""fa fa-refresh"" aria-hidden=""true"" style=""font-size: 30px;""></i>
                </a>
                <input type=""text"" name=""captcha"" id=""captcha"" required/>
            </div>
            <button type=""submit"" class=""btn btn-primary w-100""");
                BeginWriteAttribute("style", " style=\"", 5274, "\"", 5359, 6);
                WriteAttributeValue("", 5282, "background-color:", 5282, 17, true);
#nullable restore
#line 96 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 5299, ViewData["SiteColor"], 5299, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5321, ";", 5321, 1, true);
                WriteAttributeValue(" ", 5322, "border-color:", 5323, 14, true);
#nullable restore
#line 96 "C:\Users\root\Desktop\internProject-main\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 5336, ViewData["SiteColor"], 5336, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5358, ";", 5358, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Başvur</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"" integrity=""sha512-uto9mlQzrs59VwILcLiRYeLKPPbS/bT71da/OEBYEwcdNUk8jYIy+D176RYoop1Da+f9mvkYrmj5MCLZWEtQuA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script>
        $(document).ready(function () {

            $(function () {
                $(""#InternStartDate"").datepicker({
                    minDate: 0,
                    dateFormat: 'dd.mm.yy',
                    monthNames: [""Ocak"", ""Şubat"", ""Mart"", ""Nisan"", ""Mayıs"", ""Haziran"", ""Temmuz"", ""Ağustos"", ""Eylül"", ""Ekim"", ""Kasım"", ""Aralık""],
                    dayNamesMin: [""Pa"", ""Pt"", ""Sl"", ""Ça"", ""Pe"", ""Cu"", ""Ct""]
                });
                $(""#InternEndDate"").datepicker({
                    minDate: 0,
                    dateFormat: 'dd.mm.yy',
                    monthNa");
                WriteLiteral(@"mes: [""Ocak"", ""Şubat"", ""Mart"", ""Nisan"", ""Mayıs"", ""Haziran"", ""Temmuz"", ""Ağustos"", ""Eylül"", ""Ekim"", ""Kasım"", ""Aralık""],
                    dayNamesMin: [""Pa"", ""Pt"", ""Sl"", ""Ça"", ""Pe"", ""Cu"", ""Ct""]
                });

                $('#InternStartDate').change(function () {
                    startDate = $(this).datepicker('getDate');
                    $(""#internEndDate"").datepicker(""option"", ""minDate"", startDate);
                });
                $('#InternEndDate').change(function () {
                    endDate = $(this).datepicker('getDate');
                    $(""#internStartDate"").datepicker(""option"", ""maxDate"", endDate);
                });
            });
        })
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591