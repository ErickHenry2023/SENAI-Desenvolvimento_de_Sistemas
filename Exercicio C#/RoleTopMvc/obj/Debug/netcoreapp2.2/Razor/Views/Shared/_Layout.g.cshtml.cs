#pragma checksum "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\_ViewImports.cshtml"
using RoleTopMvc;

#line default
#line hidden
#line 2 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\_ViewImports.cshtml"
using RoleTopMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ccfed822cdb494cb5c6328d53d281b0ff3feb2e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a1b6a35e855e3bf7e86af114d09287816f6194", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMvc.ViewModels.BaseViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-barradenav.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-galeria.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-cadastro.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-orcamento.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
  
    var nav= (string) ViewData ["Nav"];
    var foot= (string) ViewData ["Footer"];

#line default
#line hidden
            BeginContext(141, 42, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            EndContext();
            BeginContext(183, 1265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e6754", async() => {
                BeginContext(189, 253, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Rolê Top</title>\r\n    <link href=\"\" rel=\"icon\" type=\"image/x-icon\" />\r\n\r\n    ");
                EndContext();
                BeginContext(442, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e7416", async() => {
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
                EndContext();
                BeginContext(499, 185, true);
                WriteLiteral(" \r\n\r\n    <link href=\"https://fonts.googleapis.com/css?family=Londrina+Solid:900%7COpen+Sans\" rel=\"stylesheet\">\r\n    <script src=\"https://kit.fontawesome.com/349a64cb04.js\"></script>\r\n\r\n");
                EndContext();
#line 23 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
     if("Home".Equals(@Model.NomeView))
    {

#line default
#line hidden
                BeginContext(732, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(740, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e9230", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 25 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
                                                      ;
    }
    else if("Galeria".Equals(@Model.NomeView))
    {

#line default
#line hidden
                BeginContext(851, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(859, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e10801", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 29 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
                                                              ;
    }
    else if("Cliente".Equals(@Model.NomeView))
    {

#line default
#line hidden
                BeginContext(978, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(986, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e12381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 33 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
                                                            ;
    }
    else if("Cadastro".Equals(@Model.NomeView))
    {

#line default
#line hidden
                BeginContext(1104, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(1112, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e13962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 37 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
                                                               ;
    }
    else if("Orcamento".Equals(@Model.NomeView))
    {

#line default
#line hidden
                BeginContext(1234, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(1242, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e15547", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 41 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
                                                                ;
    }
    else if("Dashboard".Equals(@Model.NomeView))
    {

#line default
#line hidden
                BeginContext(1365, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(1373, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e17133", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 45 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
                                                                ;
    }

#line default
#line hidden
                BeginContext(1439, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(1448, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1452, 5973, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e19464", async() => {
                BeginContext(1458, 185, true);
                WriteLiteral("\r\n\r\n    <!-- <script async defer crossorigin=\"anonymous\"\r\n        src=\"https://connect.facebook.net/es_LA/sdk.js#xfbml=1&version=v5.0\"></script> -->\r\n\r\n\r\n    <div id=\"topo\">\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1643, "\'", 1679, 1);
#line 57 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1650, Url.Action("Index", "Home" ), 1650, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1680, 77, true);
                WriteLiteral("> <img src=\"img/logo.png\" alt=\"logo\" title=\"HOME\"> </a>\r\n    </div>\r\n\r\n    \r\n");
                EndContext();
#line 61 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
     if("nav".Equals(nav)){
        Html.RenderPartial("_Nav");

#line default
#line hidden
                BeginContext(1823, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(1831, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e20875", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 63 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
                                                      ;
    }

#line default
#line hidden
                BeginContext(1887, 272, true);
                WriteLiteral(@"

    <header>
        <!-- <nav class=""menu"">
            <ul>

                <!---------------RESPONSIVEL--------------->
            

        <!---------------RESPONSIVEL--------------->

        <div class=""banner"">
        </div>

    </header>


");
                EndContext();
                BeginContext(2160, 12, false);
#line 82 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2172, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 84 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
     if("foot".Equals(foot)){
        Html.RenderPartial("_Footer");

#line default
#line hidden
                BeginContext(2247, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2255, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ccfed822cdb494cb5c6328d53d281b0ff3feb2e23315", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 86 "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Shared\_Layout.cshtml"
                                                      ;
    }

#line default
#line hidden
                BeginContext(2311, 5107, true);
                WriteLiteral(@"

    <!-- <footer>
        <address>
            Endereço: Rua Alameda Barão de Limeira, 539 - Santa Cecilia, São Paulo -SP, 01202-001
            <br>
            Telefone: (11) 3273-5000
            <br>
            Email: roletop@senai.com
        </address>

        <section id=""local"">
            <div class=""section-container"">
                <iframe
                    src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410""
                    width=""100%"" height=""20%"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
            </div>
        </section>


        </div>

        <div id=""rodape"">
            <img src=""img/logo.png"" alt=""logo"" title=""role top"">

            <div class");
                WriteLiteral(@"=""Esque"">

                <div class=""icone"">

                    <div id=""icone-telefone"">
                        <i class=""fas fa-phone-alt""> </i>
                        <p>(11) 3273-5000</p>
                    </div>

                    <div id=""icone-mapa"">
                        <i class=""fas fa-map-marker-alt""></i>
                        <p>Rua Alameda Barão de Limeira, 539 - Santa Cecilia, São Paulo</p>
                    </div>

                    <div id= ""icone-relogio"">
                            <i class=""fas fa-clock""></i>
                            <p>Seg à Dom -8:00 às 00:00</p>
                    </div>
                </div>
            </div>

            <div class=""Direi"">

            </div>

        </div>




    </footer> -->


    <!---------------JAVA S INICIO--------------->

    <!-- <style>
		.modal-container {
			width: 100vw;
			height: 100vh;
			background: rgba(0,0,0,.5);
			position: fixed;
			top: 0px;
			left: 0px;
			");
                WriteLiteral(@"z-index: 2000;
			display: none;
			justify-content: center;
			align-items: center;
		}

		.modal-container.mostrar {
			display: flex;
		}

		.modal {
			background: white;
			width: 60%;
			min-width: 300px;
			padding: 40px;
			border: 10px solid #988b7a;
			box-shadow: 0 0 0 10px white;
			position: relative;
		}

		keyframes modal {
			from {
				opacity: 0;
				transform: translate3d(0, -60px, 0);
			}
			to {
				opacity: 1;
				transform: translate3d(0, 0, 0);
			}
		}

		.mostrar .modal {
			animation: modal .3s;
		}

		.fechar {
			position: absolute;
			font-size: 1.2em;
			top: -30px;
			right: -30px;
			width: 50px;
			height: 50px;
			border-radius: 50%;
			border: 4px solid white;
			background: #988b7a;
			color: white;
			font-family: ""PT Mono"", monospace;
			cursor: pointer;
			box-shadow: 0 4px 4px 0 rgba(0,0,0,.3);
		}
	</style>

	<div id=""modal-promocao"" class=""modal-container"">
		<div class=""modal"">
			<button class=""fechar"">x</butto");
                WriteLiteral(@"n>
			<h3 class=""subtitulo"">Cadastre-se na Newsletter</h3>
			<form>
				<input type=""text"" class=""input"" placeholder=""Email"">
				<input type=""button"" class=""button"" value=""Cadastrar"">
			</form>
		</div>
	</div>

	<script>
	
		function iniciaModal(modalID) {
			if(localStorage.fechaModal !== modalID) {
				const modal = document.getElementById(modalID);
				if(modal) {
					modal.classList.add('mostrar');
					modal.addEventListener('click', (e) => {
						if(e.target.id == modalID || e.target.className == 'fechar') {
							modal.classList.remove('mostrar');
							localStorage.fechaModal = modalID;
						}
					});
				}
			}
		}

		const logo = document.querySelector('.contato .button');
		logo.addEventListener('click', () => iniciaModal('modal-promocao'));

		document.addEventListener('scroll', () => {
			if(window.pageYOffset > 800) {
				iniciaModal('modal-promocao')
			}
		})

	</script> -->
    <!---------------JAVA S FIM--------------->

    <!---------------RE");
                WriteLiteral(@"SPONSIVEL--------------->

    <script>
        function toggleMobileMenu() {
            var ul = document.querySelector(""nav ul"");
            var commonButtons = document.querySelectorAll(""nav .bt-common-menu"");
            var icon = document.querySelector("".icon > i"");

            ul.classList.toggle(""mobile-mode"");

            if (icon.classList.contains(""fa-bars"")) {
                icon.classList.remove(""fa-bars"");
                icon.classList.remove(""fa"");

                icon.classList.add(""fas"");
                icon.classList.add(""fa-bars"");
            } else {
                icon.classList.remove(""fas"");
                icon.classList.remove(""fa-bars"");

                icon.classList.add(""fa"");
                icon.classList.add(""fa-bars"");
            }

            for (var button of commonButtons) {
                button.classList.toggle(""active"");
            }

        }

    </script>

    <!---------------RESPONSIVEL--------------->

");
                EndContext();
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
            BeginContext(7425, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMvc.ViewModels.BaseViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
