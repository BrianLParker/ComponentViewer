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


        Type SelectedType => components.FirstOrDefault(a => a.OptionName == selected).type;
        Dictionary<string, object> ComponentParameters => components.FirstOrDefault(a => a.OptionName == selected).parameters;

        public (string OptionName, Type type, Dictionary<string, object> parameters)[] components =
            new (string, Type, Dictionary<string, object>)[]
            {
                ("Survey", typeof(SurveyPrompt), new Dictionary<string, object> { { "Title", "How is Blazor working for you?" } } ),
                ("Fetch Data", typeof(FetchData), new Dictionary<string, object>()),
                ("Counter", typeof(Counter), new Dictionary<string, object>() )
            };
    }
}