#pragma checksum "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ac2a80cdf918a11bb4e6b4990aa25d5555962cc"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Learner.Client.Pages.Authentication
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
#nullable restore
#line 5 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
using Blazor.Learner.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n//Адрес до страницы\r\n//Используем шаблон, разработанной ранее\r\n//Подключаем провайдер авторизации\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1 class=\"h2 font-weight-normal login-title\">\r\n    Login\r\n</h1>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "class", "form-signin");
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
                                             OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 17 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
                                                              loginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.AddMarkupContent(10, "<label for=\"inputUsername\" class=\"sr-only\">User Name</label>\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "inputUsername");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "autofocus", true);
                __builder2.AddAttribute(15, "placeholder", "Username");
                __builder2.AddAttribute(16, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 21 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
                                                                    loginRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.UserName = __value, loginRequest.UserName))));
                __builder2.AddAttribute(18, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                global::__Blazor.Blazor.Learner.Client.Pages.Authentication.Login.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 22 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
                              () => loginRequest.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
                __builder2.AddMarkupContent(23, "<label for=\"inputPassword\" class=\"sr-only\">Password</label>\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "id", "inputPassword");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "placeholder", "Password");
                __builder2.AddAttribute(29, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 25 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
                                                                                                           loginRequest.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.Password = __value, loginRequest.Password))));
                __builder2.AddAttribute(31, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n    ");
                global::__Blazor.Blazor.Learner.Client.Pages.Authentication.Login.TypeInference.CreateValidationMessage_1(__builder2, 33, 34, 
#nullable restore
#line 26 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
                              () => loginRequest.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n\r\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-check m-3");
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputCheckbox>(39);
                __builder2.AddAttribute(40, "id", "inputRememberMe");
                __builder2.AddAttribute(41, "class", "form-check-input");
                __builder2.AddAttribute(42, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 29 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
                                                                                   loginRequest.RememberMe

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.RememberMe = __value, loginRequest.RememberMe))));
                __builder2.AddAttribute(44, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => loginRequest.RememberMe));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.AddMarkupContent(46, "<label class=\"form-check-label\" for=\"inputRememberMe\">Remember Me</label>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n    ");
                __builder2.AddMarkupContent(48, "<button class=\"btn btn-lg btn-primary btn-block\" type=\"submit\">Sign in</button>\r\n\r\n    ");
                __builder2.OpenElement(49, "label");
                __builder2.AddAttribute(50, "class", "text-danger");
#nullable restore
#line 35 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
__builder2.AddContent(51, error);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(53);
                __builder2.AddAttribute(54, "href", "register");
                __builder2.AddAttribute(55, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(56, "\r\n        ");
                    __builder3.AddMarkupContent(57, "<h6 class=\"font-weight-normal text-center\">Create account</h6>\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(60);
            __builder.AddAttribute(61, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.OpenElement(63, "h1");
                __builder2.AddContent(64, "Hello ");
#nullable restore
#line 64 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
__builder2.AddContent(65, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(66, " !!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.AddMarkupContent(68, "<p>Welcome to Blazor Learner.</p>\r\n        ");
                __builder2.OpenComponent<global::Blazor.Learner.Client.Shared.SurveyPrompt>(69);
                __builder2.AddAttribute(70, "Title", "How is Blazor working for you?");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n    ");
            }
            ));
            __builder.AddAttribute(72, "Authorizing", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.AddMarkupContent(74, "<h1>Loading ...</h1>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\samurai jack\OneDrive\Рабочий стол\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
       
    LoginRequest loginRequest { get; set; } = new LoginRequest();
    string error { get; set; }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await authStateProvider.Login(loginRequest);
            navigationManager.NavigateTo("");
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.Blazor.Learner.Client.Pages.Authentication.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591