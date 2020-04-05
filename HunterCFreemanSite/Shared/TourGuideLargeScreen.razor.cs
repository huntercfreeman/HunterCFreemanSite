using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Shared
{
    public partial class TourGuideLargeScreen : ComponentBase
    {
        [Inject]
        public SiteState SiteState { get; set; }
        public bool EndTour { get; set; }
        public int TourPart { get; set; }
    }
}
