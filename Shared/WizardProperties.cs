using System;
using System.Collections.Generic;

namespace Shared
{
    public class WizardProperties
    {
        public List<Type> ScreenTypes { get; set; } = new();
        public Dictionary<string, object> Parameters { get; set; } = new();
    }
}
