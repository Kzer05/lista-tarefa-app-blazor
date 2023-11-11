// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ListaTarefaApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\teste\ListaTarefaApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\teste\ListaTarefaApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\teste\ListaTarefaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\teste\ListaTarefaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\teste\ListaTarefaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\teste\ListaTarefaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\teste\ListaTarefaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\teste\ListaTarefaApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\teste\ListaTarefaApp\_Imports.razor"
using ListaTarefaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\teste\ListaTarefaApp\_Imports.razor"
using ListaTarefaApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\teste\ListaTarefaApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tarefa")]
    public partial class ListaTarefa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\teste\ListaTarefaApp\Pages\ListaTarefa.razor"
       
    string descricaoTarefa;
    List<TarefaItem> tarefas = new List<TarefaItem>();

    protected override async Task OnInitializedAsync()
    {
        tarefas = await _localstorage.GetItemAsync<List<TarefaItem>>("tarefas");
        if (tarefas == null)
            tarefas = new List<TarefaItem>();
    }

    public void Adicionar()
    {
        TarefaItem tarefaItem
            = new TarefaItem()
            {
                Id = Guid.NewGuid(),
                Descricao = descricaoTarefa,
                FlagFeito = false,
                DataCriacao = DateTime.Now
            };
        tarefas.Add(tarefaItem);

        descricaoTarefa = "";

        _localstorage.SetItemAsync("tarefas", tarefas);
    }

    public void Remover(Guid id)
    {
        TarefaItem tarefaSelecionada =
            tarefas.First(t => t.Id == id);

        tarefas.Remove(tarefaSelecionada);

        _localstorage.SetItemAsync("tarefas", tarefas);
    }

    public void MarcarDescarcar(TarefaItem tarefa)
    {
       tarefa.FlagFeito = !tarefa.FlagFeito;

        _localstorage.SetItemAsync("tarefas", tarefas);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localstorage { get; set; }
    }
}
#pragma warning restore 1591