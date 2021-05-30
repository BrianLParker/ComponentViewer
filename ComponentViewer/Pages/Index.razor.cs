using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace ComponentViewer.Pages
{
    public partial class Index : ComponentBase
    {
        private string selected = "ComponentViewer.Shared.StackFlare";

        private Dictionary<string, object> ComponentParameters => components.FirstOrDefault(a => a.typeName == selected).parameters;

        public (string OptionName, string typeName, Dictionary<string, object> parameters)[] components =
            new (string, string, Dictionary<string, object>)[]
            {
                ( "Survey", "ComponentViewer.Shared.SurveyPrompt", new Dictionary<string, object> { { "Title", "Leave your money on the fridge" } } ),
                ( "Fetch Data", "ComponentViewer.Pages.FetchData", new Dictionary<string, object>()),
                ( "Counter", "ComponentViewer.Pages.Counter", new Dictionary<string, object>() ),
                ( "Brian Parker", "ComponentViewer.Shared.StackFlare", new Dictionary<string, object>() ),
                ( "Bounce", "ComponentViewer.Shared.BounceDemo", new Dictionary<string, object>() )
            };
    }
}