#pragma checksum "C:\Users\erick.h.apaza.conde\Desktop\RoleTopMvc\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2eb0dbab0c0b388ce62750a91778f12ce715b96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2eb0dbab0c0b388ce62750a91778f12ce715b96", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a1b6a35e855e3bf7e86af114d09287816f6194", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4398, true);
            WriteLiteral(@"<main>

    <table>

        <thead>
            <tr>
                <td class=""iconcor""><i class=""fas fa-user-plus""></i></td>
                </div>
                <td class=""iconcor""><i class=""fas fa-user-slash""></i></td>
                </div>
            </tr>

            <tr>
                <th rowspan=""2"">Usuarios</th>
                <th colspan=""2"">Usuarios Bloqueado</th>

            </tr>
        </thead>
        <tfoot>

            </tr>
        </tfoot>
        <tbody>
            <tr>
                <td>Cesar Sportore</td>
                <td>Alexandre Fukaya</td>

            </tr>
            <tr>
                <td>Alexandre Fukaya</td>
                <td>Cesar Sportore</td>
            </tr>

        <tfoot>
            <tr>
                <td colspan=""6"">
                    <p>............................</p>
                </td>
            </tr>
        </tfoot>

        </tbody>
    </table>
    </section>


    <div>
        <sect");
            WriteLiteral(@"ion id=""status-pedidos"">
            <h3>Status dos pedidos</h3>
            <div id=""painel"">
                <div class=""box-status-pedidos aprovados"">
                    <h4>Aprovados</h4>
                    <p>2</p>
                </div>
                <div class=""box-status-pedidos pendentes"">
                    <h4>Pendentes</h4>
                    <p>6</p>
                </div>
                <div class=""box-status-pedidos reprovados"">
                    <h4>Reprovados</h4>
                    <p>1</p>
                </div>
            </div>
        </section>
        <br>
        <br>
        <hr>

        <!-----------------------------Lista de Eventos----------------------------->
        <section id=""lista-pedidos"">
            <h3>Lista de Eventos</h3>
            <table class=""opa"">
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome</th>
                        <th rowspan=""2"">Tipo de evento</th>
                  ");
            WriteLiteral(@"      <th colspan=""2"">Data</th>
                        <th>Situação</th>
                        <th colspan=""2"">Status</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""6"">
                            <p>Eventos atualizados em 10/09/2019 às 10:40</p>
                        </td>
                    </tr>
                </tfoot>
                <tbody>

                    <tr>
                        <td>Rita Magalhoes</td>
                        <td>Casamento</td>
                        <td>14/09/2019-Sabado</td>
                        <td>Horario:14:30-5:30 </td>
                        <td><button class=""button""> Aprovar </button> <button class=""button""> Reprovar</button></td>
                        <td><i class=""fas fa-check""></i></td>
                    </tr>

                    <tr>
                        <td>Astolfo Pereira</td>
                        <td>Balada</td>
       ");
            WriteLiteral(@"                 <td>13/09/2019-Sexta</td>
                        <td>Horario: 19:00-3:00</td>
                        <td><button class=""button""> Aprovar</button> <button class=""button""> Reprovar</button></td>
                        <td><i class=""fas fa-times""></i></td>


                    </tr>
                    <tr>
                        <td>Andre Chagas</td>
                        <td>Show</td>
                        <td>Pendente...</td>
                        <td>Pendente...</td>
                        <td><button class=""button""> Aprovar</button> <button class=""button""> Reprovar</button></td>
                        <td><i class=""fas fa-check""></i></td>
                    </tr>
                    <tr>
                        <td>Barbara Santos</td>
                        <td>Festa Empresarial</td>
                        <td>12/09/2019-Quinta</td>
                        <td>Horario: 16:00-9:00</td>
                        <td><button class=""button""> Aprovar</button> <b");
            WriteLiteral(@"utton class=""button""> Reprovar</button></td>
                        <td><i class=""fas fa-check""></i></td>
                    </tr>

                </tbody>
            </table>
        </section>
        <!-----------------------------Lista de Eventos----------------------------->

</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
