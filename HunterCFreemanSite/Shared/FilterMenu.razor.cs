using HunterCFreemanSite.Interfaces;
using HunterCFreemanSite.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Shared
{
    public partial class FilterMenu : ComponentBase
    {
        [Inject]
        private IProgrammingProjectRepository ProgrammingProjectRepository { get; set; }

        public int Width { get; set; } = 250;
        public bool IsCollapsed { get; set; }
        public string Height 
        {
            get => IsCollapsed ? "56px" : "100vh";
        }

        public List<ProgrammingProject> ProgrammingProjects { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            ProgrammingProjects = ProgrammingProjectRepository.GetProgrammingProjects();
            ProgrammingProjectRepository.FilterByCProgrammingLanguageBoolEventHandler += ProgrammingProjectRepository_FilterByCProgrammingLanguageBoolEventHandler;
            ProgrammingProjectRepository.FilterByCSharpProgrammingLanguageBoolBoolEventHandler += ProgrammingProjectRepository_FilterByCSharpProgrammingLanguageBoolBoolEventHandler;
            ProgrammingProjectRepository.FilterByListsBoolEventHandler += ProgrammingProjectRepository_FilterByListsBoolEventHandler;
        }

        private void ProgrammingProjectRepository_FilterByListsBoolEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        private void ProgrammingProjectRepository_FilterByCSharpProgrammingLanguageBoolBoolEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        private void ProgrammingProjectRepository_FilterByCProgrammingLanguageBoolEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        private void NotImplemented()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}
