#pragma checksum "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8707382a6a3d1afa5a702064cdabb1f2070e5aa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
#line 1 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\_ViewImports.cshtml"
using LambdaForums;

#line default
#line hidden
#line 2 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\_ViewImports.cshtml"
using LambdaForums.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8707382a6a3d1afa5a702064cdabb1f2070e5aa8", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c871c8f56f9c78303e7569257ee93ff97f327e", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CELForum.Models.PostIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-newReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(68, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b05f148151d54874b2b5b7702a6c403f", async() => {
                BeginContext(74, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(147, 11, false);
#line 8 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
      Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(158, 10, true);
                WriteLiteral("</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(175, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(177, 3295, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b1ad3d4304147758b3cf08c26240879", async() => {
                BeginContext(183, 188, true);
                WriteLiteral("\r\n    <div class=\"container body-content\">\r\n        <div class=\"row postHeader\">\r\n            <div class=\"postHeading\">\r\n                <span class=\"postIndexTitle\">\r\n                    ");
                EndContext();
                BeginContext(372, 11, false);
#line 15 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
               Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(383, 65, true);
                WriteLiteral("\r\n                </span>\r\n                <span id=\"headingBtn\">");
                EndContext();
                BeginContext(448, 124, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c70d570754db4380a196e763a8f50293", async() => {
                    BeginContext(544, 8, true);
                    WriteLiteral("Back to ");
                    EndContext();
                    BeginContext(553, 15, false);
#line 17 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                                                                                                                         Write(Model.ForumName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 17 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                                                                     WriteLiteral(Model.ForumId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(572, 196, true);
                WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\" id=\"postIndexContent\">\r\n            <div class=\"col-md-3 postAuthorContainer\">\r\n                <div class=\"postAuthorImage\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 768, "\"", 820, 3);
                WriteAttributeValue("", 776, "background-image:url(", 776, 21, true);
#line 23 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
WriteAttributeValue("", 797, Model.AuthorImageUrl, 797, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 818, ");", 818, 2, true);
                EndWriteAttribute();
                BeginContext(821, 25, true);
                WriteLiteral("></div>\r\n                ");
                EndContext();
                BeginContext(846, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fca25cd859de492bab7f96e849966c3d", async() => {
                    BeginContext(926, 16, false);
#line 24 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                                                                          Write(Model.AuthorName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 24 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                                                  WriteLiteral(Model.AuthorId);

#line default
#line hidden
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
                EndContext();
                BeginContext(946, 41, true);
                WriteLiteral("\r\n                <span class=\"postDate\">");
                EndContext();
                BeginContext(988, 13, false);
#line 25 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                  Write(Model.Created);

#line default
#line hidden
                EndContext();
                BeginContext(1001, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 26 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                 if (Model.IsAuthorAdmin)
                {

#line default
#line hidden
                BeginContext(1072, 64, true);
                WriteLiteral("                    <span class=\"isAdmin smaller\">Admin</span>\r\n");
                EndContext();
#line 29 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1155, 140, true);
                WriteLiteral("            </div>\r\n            <div class=\"col-md-9 postContentContainer\">\r\n                <div class=\"postContent\">\r\n                    ");
                EndContext();
                BeginContext(1296, 27, false);
#line 33 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
               Write(Html.Raw(Model.PostContent));

#line default
#line hidden
                EndContext();
                BeginContext(1323, 115, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" id=\"replyDivider\"></div>\r\n\r\n");
                EndContext();
#line 39 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
                BeginContext(1494, 53, true);
                WriteLiteral("            <div class=\"row\">\r\n                <span>");
                EndContext();
                BeginContext(1547, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b91f082251ee458b828be56c3931d308", async() => {
                    BeginContext(1643, 10, true);
                    WriteLiteral("Post Reply");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 42 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1657, 29, true);
                WriteLiteral("</span>\r\n            </div>\r\n");
                EndContext();
#line 44 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1697, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
         if (Model.Replies.Any())
        {
            foreach (var reply in Model.Replies)
            {

#line default
#line hidden
                BeginContext(1810, 165, true);
                WriteLiteral("                <div class=\"row replyContent\">\r\n                    <div class=\"col-md-3 replyAuthorContainer\">\r\n                        <div class=\"postAuthorImage\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 1975, "\"", 2026, 3);
                WriteAttributeValue("", 1983, "background-image:url(", 1983, 21, true);
#line 52 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
WriteAttributeValue("", 2004, reply.AuthorImageUrl, 2004, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 2025, ")", 2025, 1, true);
                EndWriteAttribute();
                BeginContext(2027, 33, true);
                WriteLiteral("></div>\r\n                        ");
                EndContext();
                BeginContext(2060, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4a25cb35034ae1a0e79df697953f1a", async() => {
                    BeginContext(2140, 16, false);
#line 53 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                                                                                  Write(reply.AuthorName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 53 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                                                          WriteLiteral(reply.AuthorId);

#line default
#line hidden
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
                EndContext();
                BeginContext(2160, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 54 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                         if (reply.IsAuthorAdmin)
                        {

#line default
#line hidden
                BeginContext(2240, 106, true);
                WriteLiteral("                            <div class=\"isAdmin smaller\">Admin</div>\r\n                            <br />\r\n");
                EndContext();
#line 58 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2373, 30, true);
                WriteLiteral("                        <span>");
                EndContext();
                BeginContext(2404, 13, false);
#line 59 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                         Write(reply.Created);

#line default
#line hidden
                EndContext();
                BeginContext(2417, 182, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"col-md-9 replyContentContainer\">\r\n                        <div class=\"postContent\">\r\n                            ");
                EndContext();
                BeginContext(2600, 28, false);
#line 63 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                       Write(Html.Raw(reply.ReplyContent));

#line default
#line hidden
                EndContext();
                BeginContext(2628, 86, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 67 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
                BeginContext(2765, 122, true);
                WriteLiteral("            <div class=\"noPosts\">\r\n                <h3>There are no replies to this post.<br /></h3>\r\n            </div>\r\n");
                EndContext();
#line 74 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2898, 20, true);
                WriteLiteral("    </div>\r\n    <h1>");
                EndContext();
                BeginContext(2919, 11, false);
#line 76 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
   Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2930, 35, true);
                WriteLiteral("</h1>\r\n    <div>\r\n        Author : ");
                EndContext();
                BeginContext(2966, 16, false);
#line 78 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
            Write(Model.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(2982, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(2985, 18, false);
#line 78 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                               Write(Model.AuthorRating);

#line default
#line hidden
                EndContext();
                BeginContext(3003, 21, true);
                WriteLiteral(")\r\n        Created : ");
                EndContext();
                BeginContext(3025, 13, false);
#line 79 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
             Write(Model.Created);

#line default
#line hidden
                EndContext();
                BeginContext(3038, 35, true);
                WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(3074, 17, false);
#line 83 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
   Write(Model.PostContent);

#line default
#line hidden
                EndContext();
                BeginContext(3091, 16, true);
                WriteLiteral("\r\n    </div>\r\n\r\n");
                EndContext();
#line 86 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
     if (Model.Replies.Any())
    {
        foreach (var reply in Model.Replies)
        {

#line default
#line hidden
                BeginContext(3202, 50, true);
                WriteLiteral("            <div>\r\n                Reply Author : ");
                EndContext();
                BeginContext(3253, 16, false);
#line 91 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                          Write(reply.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(3269, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(3272, 18, false);
#line 91 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                                             Write(reply.AuthorRating);

#line default
#line hidden
                EndContext();
                BeginContext(3290, 35, true);
                WriteLiteral(")\r\n                Reply Created : ");
                EndContext();
                BeginContext(3326, 13, false);
#line 92 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                           Write(reply.Created);

#line default
#line hidden
                EndContext();
                BeginContext(3339, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
                BeginContext(3363, 43, true);
                WriteLiteral("            <div>\r\n                Reply : ");
                EndContext();
                BeginContext(3407, 18, false);
#line 96 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
                   Write(reply.ReplyContent);

#line default
#line hidden
                EndContext();
                BeginContext(3425, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 98 "D:\WORKS\FullStakAspNetCore\CELForum\CELForum\Views\Post\Index.cshtml"
        }
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(3472, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CELForum.Models.PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
