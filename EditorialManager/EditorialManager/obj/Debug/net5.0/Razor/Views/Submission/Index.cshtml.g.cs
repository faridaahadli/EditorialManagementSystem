#pragma checksum "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Submission_Index), @"mvc.1.0.view", @"/Views/Submission/Index.cshtml")]
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
#line 1 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\_ViewImports.cshtml"
using EditorialManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\_ViewImports.cshtml"
using EditorialManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
using EditorialManager.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
using App.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
using App.Core.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a", @"/Views/Submission/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b2ac83cfa46bcaa90b84d15ee5a2cee8b6efe04", @"/Views/_ViewImports.cshtml")]
    public class Views_Submission_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleInsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control-file"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectedFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exampleFormControlTextarea1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "submission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
  
    ViewData["Title"] = "Submission page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a8461", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"selectedFile\">Choose file you append (only .pdf supported)</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a8853", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ArticleFile);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a10774", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 14 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ArticleFile);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    <div class=""col-md-12 p-3"">
        <div class=""card"">
            <div class=""card-body"">
                <p>
                    Please select the article type
                </p>
                <div class=""form-group"">
                    <label for=""articleType"">Select Article Type</label>
                    <select class=""form-control"" id=""articleType"" name=""articleTypeId"">
");
#nullable restore
#line 25 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                         foreach (var item in (IEnumerable<ArticleType>)ViewData["types"])
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a13260", async() => {
#nullable restore
#line 27 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>
        </div>

    </div>
    
    <div class=""col-md-12 p-3"">
        <div class=""card"">
            <div class=""card-body"">
                <p>
                    Please select the editor you would like to handle your manuscript.
                </p>
                <div class=""form-group"">
                    <label for=""userId"">Select Editor</label>
                    <select class=""form-control"" id=""userId"" name=""editorId"">
");
#nullable restore
#line 45 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                         foreach (var item in (IEnumerable<AppUser>)ViewData["editors"])
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a16362", async() => {
#nullable restore
#line 47 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                                                Write(item.Firstname);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 47 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                                                                Write(item.LastName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>
        </div>
</div>
        <div class=""col-md-12 p-3"">
            <div class=""card"">
                <div class=""card-body"">
              
                            <label for=""exampleFormControlTextarea1"">If you have any note for the editor.</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a19255", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 59 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Note);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfd1f5c3ef8f179e9cdbcad273ac69486f19c04a21084", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 60 "C:\Users\EHEDLI FARIDA\Desktop\Editorialmanager\EditorialManager\EditorialManager\Views\Submission\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Note);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

                    </div>
                </div>
         
        <div class=""form-group"">
            <p>Do you want other authors can review your article?</p>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" name=""radioSelectYes"" id=""radioSelectYes"">
                <label class=""form-check-label"" for=""flexRadioDefault1"">
                    Yes
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" name=""radioSelectNo"" id=""radioSelectNo"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    No
                </label>
            </div>
        </div>
        <div class=""col-md-12 p-2"">
            <button type=""submit"" id=""formSubmit"" class=""btn  btn-primary"">Submit</button>
        </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#radioSelectNo"").prop(""checked"", true)
        //var opposes = [];
        //$(""#sgsBtn"").on('click', function (e) {

        //    var text = ""<tr>"" +
        //        ""<td>"" + $(""#sgsFirst"").val() + ""</td>"" +
        //        ""<td>"" + $(""#sgsLast"").val() + ""</td>"" +
        //        ""<td>"" + $(""#sgsEmail"").val() + ""</td>"" +
        //        ""<td>"" + ""<button type='button' class='btn rowDlt btn-outline-danger'>Delete</button>"" +
        //        ""</td>"" +
        //        ""</tr>""

        //    var skill = {
        //        ""name"": $(""#sgsFirst"").val(),
        //        ""surname"": $(""#sgsLast"").val(),
        //        ""email"": $(""#sgsEmail"").val()
        //    }

        //    opposes.push(skill)
        //    var test = JSON.stringify(opposes);
        //    console.log(test)

        //    console.log(opposes)
        //    $(""#sgsFirst"").val("""")
        //    $(""#sgsLast"").val("""")
        //    $(""#sgsEmail"").val("""")
        //    $(""#sgsBody");
                WriteLiteral(@""").append(text)
        //    DeleteRow()
        //})
        //$(""#opsBtn"").on('click', function (e) {
        //    console.log(""hello"")
        //    var text = ""<tr>"" +
        //        ""<td>"" + $(""#opsFirst"").val() + ""</td>"" +
        //        ""<td>"" + $(""#opsLast"").val() + ""</td>"" +
        //        ""<td>"" + $(""#opsEmail"").val() + ""</td>"" +
        //        ""<td>"" + ""<button type='button' class='btn rowDlt btn-outline-danger'>Delete</button>"" +
        //        ""</td>"" +
        //        ""</tr>""
        //    $(""#opsFirst"").val("""")
        //    $(""#opsLast"").val("""")
        //    $(""#opsEmail"").val("""")
        //    $(""#opsBody"").append(text)
        //    DeleteRow()
        //})

        //function DeleteRow() {
        //    $("".rowDlt"").on('click', function (e) {
        //        $(this).closest(""tr"").remove();
        //    })
        //}

        //$('#formSubmit').on('click', function () {
        //    console.log(opposes);
        //    $.ajax({
        //  ");
                WriteLiteral(@"      url: ""/Submission/TableDataIns"",
        //        type: ""POST"",
        //        data: JSON.stringify(opposes),
        //        //contentType: ""application/json"",
        //        error: function (e) {
        //            console.log(""olmaadiddididi"")
        //        },
        //        success: function (data) {
        //            alert(data);
        //        }
        //    });
        //})
        $(""#radioSelectYes"").on(""click"", function () {
            console.log(""jakld"")
            if (!$(this).attr(""checked"")) {
                $(this).prop(""checked"", true)
                $(this).val(true)
                $(""#radioSelectNo"").prop(""checked"", false)
            } else {
                $(this).prop(""checked"", false)
                $(this).val(false)
                $(""#radioSelectNo"").prop(""checked"", true)
            }

        })
        $(""#radioSelectNo"").on(""click"", function () {
            console.log(""jakld false"")
            if (!$(this).attr");
                WriteLiteral(@"(""checked"")) {
                $(""#radioSelectYes"").prop(""checked"", false)
                $(this).prop(""checked"", true)
               
            } else {
               
                $(""#radioSelectYes"").prop(""checked"", true)
                $(this).prop(""checked"", false)
            }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleInsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
