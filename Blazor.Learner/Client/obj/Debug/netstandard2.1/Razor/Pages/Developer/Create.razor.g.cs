#pragma checksum "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c23f10c72b6b69f68738f738f0b38caff677425"
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
#line 1 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/developer/create")]
    public partial class Create : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create</h3>\n\n");
            __builder.OpenComponent<global::Blazor.Learner.Client.Pages.Developer.Form>(1);
            __builder.AddAttribute(2, "ButtonText", "Create Developer");
            __builder.AddAttribute(3, "dev", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Blazor.Learner.Shared.Models.Developer>(
#nullable restore
#line 7 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\Create.razor"
                                          dev

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\Create.razor"
                            CreateDeveloper

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Client\Pages\Developer\Create.razor"
       
    Developer dev = new Developer();
    async Task CreateDeveloper()
    {
        await http.PostAsJsonAsync("api/developer", dev);
        uriHelper.NavigateTo("developer");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591