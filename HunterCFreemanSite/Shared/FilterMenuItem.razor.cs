﻿using Microsoft.AspNetCore.Components;
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
        [Parameter]
        public Action Filter { get; set; }
        [Parameter]
        public Func<bool> IsChecked { get; set; }
        [Parameter]
        public int NumberOfItems { get; set; }
        
    }
}
