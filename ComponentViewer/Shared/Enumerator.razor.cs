using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace ComponentViewer.Shared
{
    public partial class Enumerator<T> : ComponentBase
    {
        [Parameter]
        public RenderFragment<T> ChildContent { get; set; }

        [Parameter]
        public IEnumerable<T> Items { get; set; }
    }
}