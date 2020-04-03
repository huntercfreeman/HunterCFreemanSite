using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Models
{
    public class ProgrammingProject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public List<string> Tags { get; set; }
        public string HrefURL { get; set; }
        public bool Display { get; set; }
        public bool PassedSearch { get; set; } = true;
        public bool PassedCSharpFilter { get; set; } = true;
        public bool PassedAllFilters { get; set; } = true;
        public bool PassedCProgrammingLanguageFilter { get; set; } = true;
    }
}
