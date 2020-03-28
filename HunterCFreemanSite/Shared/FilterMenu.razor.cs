using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Shared
{
    public partial class FilterMenu : ComponentBase
    {
        public int Width { get; set; } = 250;
        public bool IsCollapsed { get; set; }
        public string Height 
        {
            get => IsCollapsed ? "56px" : "100vh";
        }
    }
}
