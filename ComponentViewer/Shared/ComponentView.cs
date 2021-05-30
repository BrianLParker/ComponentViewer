using System;
using System.Collections.Generic;
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

        private Dictionary<string, object> parameters;

        [Parameter]
        public Dictionary<string, string> Values { get; set; }

        protected override void OnParametersSet()
        {
            if (Values is null)
            {
                parameters = null;
            }
            else
            {
                parameters = new Dictionary<string, object>();
                foreach (var pair in Values)
                {
                    parameters[pair.Key] = pair.Value;
                }
            }
            base.OnParametersSet();
        }



        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (Type is null)
            {
                if (string.IsNullOrWhiteSpace(TypeString))
                {
                    throw new Exception("You must use either Type or the TypeString paramater");
                }
                Type = Type.GetType(TypeString);
            }

            if (Type is not null)
            {
                builder.OpenComponent(1, Type);

                if (parameters is not null)
                {
                    builder.AddMultipleAttributes(2, parameters);
                }
                builder.CloseComponent();
            }
            base.BuildRenderTree(builder);
        }
    }
}
