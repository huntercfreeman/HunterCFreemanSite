using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Shared
{
    public partial class ActiveFilterItem : ComponentBase
    {
        [Parameter]
        public string DisplayText { get; set; }
        [Parameter]
        public Action RemoveFilter { get; set; }
    }
}
