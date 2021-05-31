using System.Net.Http;
using ComponentViewer.Models;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using System;
using System.Linq;

namespace ComponentViewer.Views.Shared
{
    public partial class DecisionNodeViewer
    {
        private string nodeValue;

        [Inject]
        HttpClient Http { get; set; }

        [Inject]
        NavigationManager Navigation { get; set; }

        DecisionNode DecisionNode { get; set; } = new DecisionNode { Decisions = Array.Empty<DecisionMap>() };
        protected override async Task OnInitializedAsync()
        {
            DecisionNode = await Http.GetFromJsonAsync<DecisionNode>("sample-data/decision-information.json");
        }

        public string NodeValue
        {
            get => nodeValue; 
            set
            {
                nodeValue = value;            
                Navigation.NavigateTo(PageRoute);              
            }
        }
        private DecisionMap DecisionMap => DecisionNode.Decisions.FirstOrDefault(a => a.Value == nodeValue);
        private string PageRoute => $"{DecisionMap?.Page}{DecisionMap?.ParameterString}";
    }
}