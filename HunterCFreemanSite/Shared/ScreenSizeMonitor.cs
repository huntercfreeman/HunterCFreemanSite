using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Shared
{
    public class ScreenSizeMonitor : ComponentBase
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        [Inject]
        public SiteState SiteState { get; set; }
        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                SiteState.ScreenWidth = await JSRuntime.InvokeAsync<int>("GetScreenWidth");
                Console.WriteLine(SiteState.ScreenWidth);
            }
            return;
        }
    }
}
