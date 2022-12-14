// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
