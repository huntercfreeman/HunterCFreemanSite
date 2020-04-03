using HunterCFreemanSite.Interfaces;
using HunterCFreemanSite.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IProgrammingProjectRepository ProgrammingProjectRepository { get; set; }
        public List<ProgrammingProject> ProgrammingProjects { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            ProgrammingProjects = ProgrammingProjectRepository.GetProgrammingProjects();
            ProgrammingProjectRepository.DataChangedEventHandler += ProgrammingProjectRepository_DataChangedEventHandler;
        }

        private void ProgrammingProjectRepository_DataChangedEventHandler(object sender, EventArgs e)
        {
            ProgrammingProjects = ProgrammingProjectRepository.GetProgrammingProjects();
            InvokeAsync(StateHasChanged);
        }
    }
}
