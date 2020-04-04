﻿using HunterCFreemanSite.Interfaces;
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
            ProgrammingProjectRepository.SearchQueryEventHandler += ProgrammingProjectRepository_SearchQueryEventHandler;
            ProgrammingProjectRepository.FilterByCProgrammingLanguageBoolEventHandler += ProgrammingProjectRepository_FilterByCProgrammingLanguageBoolEventHandler;
        }

        private void ProgrammingProjectRepository_FilterByCProgrammingLanguageBoolEventHandler(object sender, EventArgs e)
        {
            StateHasChanged();
        }

        private void ProgrammingProjectRepository_SearchQueryEventHandler(object sender, EventArgs e)
        {
            StateHasChanged();
        }

        public void Dispose()
        {
            ProgrammingProjectRepository.SearchQueryEventHandler -= ProgrammingProjectRepository_SearchQueryEventHandler;
            ProgrammingProjectRepository.FilterByCProgrammingLanguageBoolEventHandler -= ProgrammingProjectRepository_FilterByCProgrammingLanguageBoolEventHandler;
        }

        

    }
}
