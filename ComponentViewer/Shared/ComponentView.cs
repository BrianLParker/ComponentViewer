using System;
using System.Collections.Generic;
using ComponentViewer.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace ComponentViewer.Shared
{
    public class ComponentView : ComponentBase
    {
        [Parameter]
        public Type Type { get; set; }

        [Parameter]
        public string TypeString { get; set; }

        [Parameter]
        public Dictionary<string, object> Parameters { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if(Type is null)
            {
                if(string.IsNullOrWhiteSpace(TypeString))
                {
                    throw new Exception("You must use either Type or the TypeString paramater");
                }
                Type = Type.GetType(TypeString);
            }

            if (Type is not null)
            {
                builder.OpenComponent(1, Type);

                if (Parameters is not null)
                {
                    builder.AddMultipleAttributes(2, Parameters);
                }
                builder.CloseComponent();
            }
            base.BuildRenderTree(builder);
        }
    }
}
