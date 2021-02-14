#pragma checksum "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d62913d68c6694c3b2e42980da014067367cab35"
// <auto-generated/>
#pragma warning disable 1591
namespace UsuarioWebCRUD.Client.Pages.User_Pages
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
#line 4 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
using UserWebCRUD.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Lista de Usuarios</h1>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<p><a href=\"adduser\">Crear un usuario</a></p>");
#nullable restore
#line 11 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
 if (usersList == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "Cargando...");
#nullable restore
#line 13 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
                            
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container mb-3 mt-3");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped table-bordered mydatatable");
            __builder.AddAttribute(7, "style", "width:100%");
            __builder.AddMarkupContent(8, "<thead><tr><th>Nombre</th>\r\n                    <th>Apellido</th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 27 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
                 foreach (var user in usersList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
                             user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
                             user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "class", "btn btn-success");
            __builder.AddAttribute(20, "href", "edituser/" + (
#nullable restore
#line 34 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
                                                                       user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "class", "btn btn-danger");
            __builder.AddAttribute(25, "href", "/deleteuser/" + (
#nullable restore
#line 35 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
                                                                          user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\UserList.razor"
       
    UserInfo[] usersList;

    protected override async Task OnInitializedAsync()
    {
        await LoadData();
    }

    async Task LoadData()
    {
        usersList = await Http.GetFromJsonAsync<UserInfo[]>("api/UserInfoes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
