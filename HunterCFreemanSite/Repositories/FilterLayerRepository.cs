using HunterCFreemanSite.Interfaces;
using HunterCFreemanSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Repositories
{
    public class FilterLayerRepository : IFilterLayer
    {
        private readonly IProgrammingProjectRepository _programmingProjectRepository;
        private readonly List<ProgrammingProject> _programmingProjects;
        public FilterLayerRepository(IProgrammingProjectRepository programmingProjectRepository)
        {
            _programmingProjectRepository = programmingProjectRepository;
            _programmingProjects = _programmingProjectRepository.GetProgrammingProjects();
            CalculateFilters();
        }

        public bool FilterOnC { get; set; }

        Dictionary<string, List<ProgrammingProject>> filters { get; set; }

        public void CalculateFilters()
        {
            List<ProgrammingProject> CProgrammingProjects = new List<ProgrammingProject>();
            CProgrammingProjects.AddRange(_programmingProjects.Where(x => x.Tags.Contains("C")).ToList());
            filters.Add("C", CProgrammingProjects);

        }

        public void ApplyFilters()
        {
            List<ProgrammingProject> programmingProjects = new List<ProgrammingProject>();

            if(FilterOnC)
                foreach(ProgrammingProject programmingProject in filters["C"])
                {
                    programmingProject.Display = true;
                }

        }

        public void TurnFilterOff(string filter)
        {
            foreach (ProgrammingProject programmingProject in filters[filter])
            {
                programmingProject.PassedCFilter = false;
                programmingProject.Display = false || programmingProject.PassedCFilter || programmingProject.PassedCFilter;
            }
        }

        public event EventHandler<List<ProgrammingProject>> FilterStateChanged;

        public void FilterStateChangedEventInvoke(List<ProgrammingProject> e)
        {
            EventHandler<List<ProgrammingProject>> handler = FilterStateChanged;
            handler?.Invoke(this, e);
        }

    }
}
