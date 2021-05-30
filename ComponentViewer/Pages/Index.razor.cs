using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Components;
using ComponentViewer.Shared;
using System.Linq;

namespace ComponentViewer.Pages
{
    public partial class Index : ComponentBase
    {
        string selected;


        string SelectedType => components.FirstOrDefault(a => a.OptionName == selected).typeName;
        Dictionary<string, object> ComponentParameters => components.FirstOrDefault(a => a.OptionName == selected).parameters;

        public (string OptionName, string typeName, Dictionary<string, object> parameters)[] components =
            new (string, string, Dictionary<string, object>)[]
            {
                ("Survey", "ComponentViewer.Shared.SurveyPrompt", new Dictionary<string, object> { { "Title", "How is Blazor working for you?" } } ),
                ("Fetch Data", "ComponentViewer.Pages.FetchData", new Dictionary<string, object>()),
                ("Counter", "ComponentViewer.Pages.Counter", new Dictionary<string, object>() )
            };
    }
}