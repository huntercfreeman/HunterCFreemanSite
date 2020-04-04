using HunterCFreemanSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Interfaces
{
    public interface IProgrammingProjectRepository
    {
        string SearchQuery { get; set; }
        bool FilterByCProgrammingLanguageBool { get; set; }
        bool FilterByCSharpProgrammingLanguageBool { get; set; }
        bool FilterByListsBool { get; set; }

        List<ProgrammingProject> GetProgrammingProjects();
        List<ProgrammingProject> GetProgrammingProjectsUnfiltered();
        List<ProgrammingProject> FilterByTitle(string title);

        public event EventHandler DataChangedEventHandler;
        event EventHandler SearchQueryEventHandler;
        event EventHandler FilterByCProgrammingLanguageBoolEventHandler;
        event EventHandler FilterByCSharpProgrammingLanguageBoolBoolEventHandler;
        event EventHandler FilterByListsBoolEventHandler;

        public void DataChangedEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByCProgrammingLanguage();
        void SearchQueryEventInvoke(EventArgs e);
        void FilterByCProgrammingLanguageBoolEventInvoke(EventArgs e);
        void FilterByCSharpProgrammingLanguageBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByCSharpProgrammingLanguage();
        void FilterByListsBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByLists();
    }
}
