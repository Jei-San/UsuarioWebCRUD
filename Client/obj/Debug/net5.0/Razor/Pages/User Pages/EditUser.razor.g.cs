#pragma checksum "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\EditUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b10bc52db9a18cba4501826c9727338ecd56ef6"
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
#line 4 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\EditUser.razor"
using UserWebCRUD.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edituser/{id}")]
    public partial class EditUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Usuario</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"FirstName\">Nombre</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "FirstName");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\EditUser.razor"
                                                                     user.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.FirstName = __value, user.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            <br>\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"LastName\">Apellido</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "LastName");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\EditUser.razor"
                                                                    user.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.LastName = __value, user.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-md-4");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\EditUser.razor"
                                                                         () => UpdateUser(user.UserId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "value", "Guardar");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\EditUser.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "value", "Cancelar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\jason\source\repos\UsuarioWebCRUD\UsuarioWebCRUD\Client\Pages\User Pages\EditUser.razor"
       
    [Parameter]
    public string id { get; set; }

    UserInfo user = new UserInfo();

    protected override async Task OnInitializedAsync()
    {
        user = await Http.GetFromJsonAsync<UserInfo>($"api/UserInfoes/{id}");
    }

    protected async Task UpdateUser(int id)
    {
        await Http.PutAsJsonAsync($"api/UserInfoes/{id}", user);
        navigationManager.NavigateTo("userlist");
    }
    void Cancel()
    {
        navigationManager.NavigateTo("userlist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591