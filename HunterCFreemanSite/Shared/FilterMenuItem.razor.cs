using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Shared
{
    public partial class FilterMenuItem : ComponentBase
    {
        [Parameter]
        public string DisplayText { get; set; }
        public int NumberOfItems { get; set; }
    }
}
