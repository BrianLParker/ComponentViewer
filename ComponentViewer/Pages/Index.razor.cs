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
        Dictionary<string, object> ComponentParameters => components.FirstOrDefault(a => a.typeName == selected).parameters;

        public (string OptionName, string typeName, Dictionary<string, object> parameters)[] components =
            new (string, string, Dictionary<string, object>)[]
            {
                ("Survey", "ComponentViewer.Shared.SurveyPrompt", new Dictionary<string, object> { { "Title", "Leave your money on the fridge" } } ),
                ("Fetch Data", "ComponentViewer.Pages.FetchData", new Dictionary<string, object>()),
                ("Counter", "ComponentViewer.Pages.Counter", new Dictionary<string, object>() ),
                ("Brian Parker", "ComponentViewer.Shared.StackFlare", new Dictionary<string, object>() ),
                ("Bounce", "ComponentViewer.Shared.BounceDemo", new Dictionary<string, object>() )
            };
    }
}