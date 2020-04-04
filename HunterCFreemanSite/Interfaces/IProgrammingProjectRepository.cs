﻿using HunterCFreemanSite.Models;
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
    }
}
