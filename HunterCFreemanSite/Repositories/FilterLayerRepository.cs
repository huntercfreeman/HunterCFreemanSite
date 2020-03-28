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

        public FilterLayerRepository(IProgrammingProjectRepository programmingProjectRepository)
        {
            _programmingProjectRepository = programmingProjectRepository;
            CalculateFilters();
        }

        Dictionary<string, List<ProgrammingProject>> filters { get; set; }

        public void CalculateFilters()
        {
            List<ProgrammingProject> programmingProjects = _programmingProjectRepository.GetProgrammingProjects();


            List<ProgrammingProject> CProgrammingProjects = new List<ProgrammingProject>();
            CProgrammingProjects.AddRange(programmingProjects.Where(x => x.Tags.Contains("C")).ToList());
            filters.Add("C", CProgrammingProjects);

        }
    }
}
