#pragma checksum "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71d238cce2dfff2a4fb483b0162613b5ea010cf9"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Learner.Client.Pages.Developer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/developer")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Developers</h3>\n");
            __builder.AddMarkupContent(1, "<small>Add as many developers as you wish.</small>\n");
            __builder.AddMarkupContent(2, "<div class=\"form-group\">\n    <a class=\"btn btn-success\" href=\"developer/create\"><i class=\"oi oi-plus\"></i> Create New</a>\n</div>\n<br>\n\n");
#nullable restore
#line 12 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
 if (developers == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "Loading...");
#nullable restore
#line 14 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
                           
}
else if (developers.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "No Records Found.");
#nullable restore
#line 18 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.AddMarkupContent(9, @"<thead>
            <tr>
                <th>Id</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Email</th>
                <th>Experience (Years)</th>
                <th></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\n");
#nullable restore
#line 34 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
             foreach (Developer dev in developers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 37 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(16, dev.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 38 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(19, dev.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 39 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(22, dev.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 40 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(25, dev.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.OpenElement(27, "td");
#nullable restore
#line 41 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(28, dev.Experience);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddMarkupContent(31, "\n                        ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "btn btn-success");
            __builder.AddAttribute(34, "href", "developer/edit/" + (
#nullable restore
#line 43 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
                                                                         dev.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-danger");
            __builder.AddAttribute(39, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
                                                                   () => Delete(dev.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#nullable restore
#line 47 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
#nullable restore
#line 51 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\FetchData.razor"
       
    Developer[] developers { get; set; }
    protected override async Task OnInitializedAsync()
    {
        developers = await client.GetFromJsonAsync<Developer[]>("api/developer");
    }

    async Task Delete(int developerId)
    {
        var dev = developers.First(x => x.Id == developerId);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {dev.FirstName}'s ({dev.Id}) Record?"))
        {
            await client.DeleteAsync($"api/developer/{developerId}");
            await OnInitializedAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
