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
        int ProjectsPassedCSharpFilter { get; set; }
        int ProjectsPassedCFilter { get; set; }
        int ProjectsPassedListsFilter { get; set; }
        int ProjectsPassedTreesFilter { get; set; }
        bool FilterByTreesBool { get; set; }
        bool FilterByDifferentialCalculusBool { get; set; }
        int ProjectsPassedDifferentialCalculusFilter { get; set; }
        int ProjectsPassedIntegralCalculusFilter { get; set; }
        bool FilterByIntegralCalculusBool { get; set; }
        bool FilterByMultivariableCalculusBool { get; set; }
        int ProjectsPassedMultivariableCalculusFilter { get; set; }
        bool FilterByDifferentialEquationsBool { get; set; }
        int ProjectsPassedDifferentialEquationsFilter { get; set; }
        bool FilterByLinearAlgebraBool { get; set; }
        int ProjectsPassedLinearAlgebraFilter { get; set; }
        bool FilterByDiscreteMathBool { get; set; }
        int ProjectsPassedDiscreteMathFilter { get; set; }
        bool FilterByArraysBool { get; set; }
        int ProjectsPassedArraysFilter { get; set; }
        bool FilterByHashBasedBool { get; set; }
        int ProjectsPassedHashBasedFilter { get; set; }
        bool FilterByGraphsBool { get; set; }
        int ProjectsPassedGraphsFilter { get; set; }
        bool FilterByOtherBool { get; set; }
        int ProjectsPassedOtherFilter { get; set; }

        List<ProgrammingProject> GetProgrammingProjects();
        List<ProgrammingProject> GetProgrammingProjectsUnfiltered();
        List<ProgrammingProject> FilterByTitle(string title);

        public event EventHandler DataChangedEventHandler;
        event EventHandler SearchQueryEventHandler;
        event EventHandler FilterByCProgrammingLanguageBoolEventHandler;
        event EventHandler FilterByCSharpProgrammingLanguageBoolBoolEventHandler;
        event EventHandler FilterByListsBoolEventHandler;
        event EventHandler FilterByTreesBoolEventHandler;
        event EventHandler FilterByDifferentialCalculusBoolEventHandler;
        event EventHandler FilterByIntegralCalculusBoolEventHandler;
        event EventHandler FilterByMultivariableCalculusBoolEventHandler;
        event EventHandler FilterByDifferentialEquationsBoolEventHandler;
        event EventHandler FilterByLinearAlgebraBoolEventHandler;
        event EventHandler FilterByDiscreteMathBoolEventHandler;
        event EventHandler FilterByArraysBoolEventHandler;
        event EventHandler FilterByHashBasedBoolEventHandler;
        event EventHandler FilterByGraphsBoolEventHandler;
        event EventHandler FilterByOtherBoolEventHandler;

        public void DataChangedEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByCProgrammingLanguage();
        void SearchQueryEventInvoke(EventArgs e);
        void FilterByCProgrammingLanguageBoolEventInvoke(EventArgs e);
        void FilterByCSharpProgrammingLanguageBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByCSharpProgrammingLanguage();
        void FilterByListsBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByLists();
        List<ProgrammingProject> FilterByTrees();
        void FilterByTreesBoolEventInvoke(EventArgs e);
        void FilterByDifferentialCalculusBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByDifferentialCalculus();
        void FilterByIntegralCalculusBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByIntegralCalculus();
        List<ProgrammingProject> FilterByMultivariableCalculus();
        void FilterByMultivariableCalculusBoolEventInvoke(EventArgs e);
        void FilterByDifferentialEquationsBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByDifferentialEquations();
        List<ProgrammingProject> FilterByLinearAlgebra();
        void FilterByLinearAlgebraBoolEventInvoke(EventArgs e);
        void FilterByDiscreteMathBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByDiscreteMath();
        List<ProgrammingProject> FilterByArrays();
        void FilterByArraysBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByHashBased();
        void FilterByHashBasedBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByGraphs();
        void FilterByGraphsBoolEventInvoke(EventArgs e);
        List<ProgrammingProject> FilterByOther();
        void FilterByOtherBoolEventInvoke(EventArgs e);
    }
}
