using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace ComponentViewer.Pages
{
    public partial class Index : ComponentBase
    {
        private string selected = "ComponentViewer.Shared.StackFlare";
        private Dictionary<string, string> Values => components.FirstOrDefault(a => a.typeName == selected).parameters;

        public (string OptionName, string typeName, Dictionary<string, string> parameters)[] components =
            new (string, string, Dictionary<string, string>)[]
            {
                ( "Survey", "ComponentViewer.Shared.SurveyPrompt", new Dictionary<string, string> { { "Title", "Leave your money on the fridge. 🍺" } } ),
                ( "Fetch Data", "ComponentViewer.Pages.FetchData", null),
                ( "Counter", "ComponentViewer.Pages.Counter", null ),
                ( "Brian Parker", "ComponentViewer.Shared.StackFlare", null ),
                ( "Bounce", "ComponentViewer.Shared.BounceDemo", null )
            };
    }
}