#pragma checksum "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf7c2c8c43b5f34e8eda272afcf7d7866408c41"
// <auto-generated/>
#pragma warning disable 1591
namespace UsuarioWebCRUD.Client.Pages.Profession_Page
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using UsuarioWebCRUD.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\_Imports.razor"
using UsuarioWebCRUD.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor"
using UserWebCRUD.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/professionlist")]
    public partial class ProfessionList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Lista de Profesiones</h2>");
#nullable restore
#line 8 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor"
 if (professionList == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "Cargando...");
#nullable restore
#line 10 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor"
                            
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container mb-3 mt-3");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-striped table-bordered mydatatable");
            __builder.AddAttribute(6, "style", "width:100%");
            __builder.AddMarkupContent(7, "<thead><tr><th>Profesiones</th></tr></thead>\r\n            ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 22 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor"
                 foreach (var profession in professionList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 25 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor"
                             profession.ProfessionName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\Profession Page\ProfessionList.razor"
       
    ProfessionInfo[] professionList;

    //protected override async Task OnInitializedAsync()
    //{
       // await LoadData();
    //}

    //async Task LoadData()
    //{
        //professionList = await Http.GetFromJsonAsync<ProfessionInfo[]>("api/ProfessionInfoes");
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591