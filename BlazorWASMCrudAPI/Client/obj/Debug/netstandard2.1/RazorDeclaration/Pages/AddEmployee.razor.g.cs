#pragma checksum "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2bd82a1de5f0702dec89d6cde9d8c758cca868c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWASMCrudAPI.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using BlazorWASMCrudAPI.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\_Imports.razor"
using BlazorWASMCrudAPI.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\Pages\AddEmployee.razor"
using BlazorWASMCrudAPI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addemployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\sethm\source\repos\WebAPIBlazor\BlazorWASMCrudAPI\Client\Pages\AddEmployee.razor"
       
    EmployeeInfo emp = new EmployeeInfo();
    protected async Task CreateEmployee()
    {
        await Http.PostAsJsonAsync("https://localhost:44305/api/EmployeeInfoes", emp);
        NavigationManager.NavigateTo("employeeList");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("employeeList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
