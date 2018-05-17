#pragma checksum "D:\CoreApp\BlazorTestApp\TestApp\BlazorDemoApp\Pages\ChildComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfd20258d38cea943ac59ea43af8eaa739fb0429"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazorDemoApp;
    using BlazorDemoApp.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    public class ChildComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h4");
            builder.AddContent(1, "This is Child Component");
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "br");
            builder.CloseElement();
            builder.AddContent(4, "\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(OnClick));
            builder.AddContent(7, "Click Me(child component)");
            builder.CloseElement();
            builder.AddContent(8, "\n\n");
        }
        #pragma warning restore 1998
#line 5 "D:\CoreApp\BlazorTestApp\TestApp\BlazorDemoApp\Pages\ChildComponent.cshtml"
            
    public Action OnSomeEvent { get; set; }

    private void OnClick()
    {
        OnSomeEvent?.Invoke();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
