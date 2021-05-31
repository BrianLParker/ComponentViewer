using System;
using System.Collections.Generic;

namespace ComponentViewer.Models
{
    public class ComponentMap
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string DisplayName { get; set; }
        public string ComponentType { get; set; }
        public Dictionary<string, string> ComponentParameters { get; set; }

    }
}