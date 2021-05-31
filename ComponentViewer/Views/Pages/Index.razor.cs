using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ComponentViewer.Models;

namespace ComponentViewer.Views.Pages
{
    public partial class Index : ComponentBase
{
        [Inject] HttpClient Http { get; set; }


        private Guid? optionId;
        private Dictionary<string, string> Values => ComponentMaps.FirstOrDefault(a => a.Id == optionId).ComponentParameters;
        private string typeName => ComponentMaps.FirstOrDefault(a => a.Id == optionId).ComponentType;

        public ComponentMap[] ComponentMaps = Array.Empty<ComponentMap>();

        protected override async Task OnInitializedAsync()
        {
            ComponentMaps = await Http.GetFromJsonAsync<ComponentMap[]>("sample-data/viewdata.json");
            optionId = ComponentMaps[0].Id;
        }
    }
}