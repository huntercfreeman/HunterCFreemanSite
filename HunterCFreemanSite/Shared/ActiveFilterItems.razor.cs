using HunterCFreemanSite.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Shared
{
    public partial class ActiveFilterItems : ComponentBase, IDisposable
    {
        [Inject]
        public IProgrammingProjectRepository ProgrammingProjectRepository { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            ProgrammingProjectRepository.SearchQueryEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByCProgrammingLanguageBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByCSharpProgrammingLanguageBoolBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByListsBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByTreesBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByDifferentialCalculusBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByIntegralCalculusBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByMultivariableCalculusBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByDifferentialEquationsBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByLinearAlgebraBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByDiscreteMathBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByArraysBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByHashBasedBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByGraphsBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByOtherBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByOnlineShopBoolEventHandler += FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByBlogBoolEventHandler += FilterSetEventHandler;
        }

        private void FilterSetEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            ProgrammingProjectRepository.SearchQueryEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByCProgrammingLanguageBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByCSharpProgrammingLanguageBoolBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByListsBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByTreesBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByDifferentialCalculusBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByIntegralCalculusBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByMultivariableCalculusBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByDifferentialEquationsBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByLinearAlgebraBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByDiscreteMathBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByArraysBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByHashBasedBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByGraphsBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByOtherBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByOnlineShopBoolEventHandler -= FilterSetEventHandler;
            ProgrammingProjectRepository.FilterByBlogBoolEventHandler -= FilterSetEventHandler;
        }

        

    }
}
