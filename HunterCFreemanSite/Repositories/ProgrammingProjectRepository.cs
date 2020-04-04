using HunterCFreemanSite.Interfaces;
using HunterCFreemanSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterCFreemanSite.Repositories
{
    public class ProgrammingProjectRepository : IProgrammingProjectRepository
    {
        private List<ProgrammingProject> _programmingProjects = new List<ProgrammingProject>
        {
            new ProgrammingProject
            {
                Title = "Pathfinding Algorithm Visualizer in C#",
                Description = "A Pathfinding Algorithm Visualizer written in C#",
                Tags = new List<string> { "C#", "CSharp", "Pathfinding", "Pathfinding Algorithms", "Algorithms", "Dijkstra", "AStar", "A*", "Visualize", "Visualizer" },
                ImageURL = "content/images/Untitzzzzled.png",
                HrefURL = "https://huntercfreeman.github.io/"
            },
            new ProgrammingProject
            {
                Title = "Sorting Algorithm Visualizer in C#",
                Description = "A Sorting Algorithm Visualizer written in C#",
                Tags = new List<string> { "C#", "CSharp", "Sorting", "Sorting Algorithms", "Algorithms", "Sort", "Bubble Sort", "Bubble", "Merge Sort", "Merge", "Visualize", "Visualizer" },
                ImageURL = "content/images/zzzUntitled.png",
                HrefURL = "https://huntercfreeman.github.io/"
            },
            new ProgrammingProject
            {
                Title = "Singly Linked List in C",
                Description = "A full implementation of a singly linked list in C written with name collision in mind.",
                Tags = new List<string> { "C", "Datastructures", "Linked List", "Singly Linked List", "Singly", "Collision" },
                ImageURL = "content/images/Untitlesssssd.png",
                HrefURL = "https://github.com/huntercfreeman/singlyLinkedList"
            },
            new ProgrammingProject
            {
                Title = "Doubly Linked List in C",
                Description = "A full implementation of a doubly linked list in C written with name collision in mind.",
                Tags = new List<string> { "C", "Datastructures", "Linked List", "Doubly Linked List", "Doubly", "Collision" },
                ImageURL = "content/images/Untitlesssssd.png",
                HrefURL = "https://github.com/huntercfreeman/doublyLinkedList"
            },
            new ProgrammingProject
            {
                Title = "Binary Search Tree in C",
                Description = "A full implementation of a binary search tree in C written with name collision in mind.",
                Tags = new List<string> { "C", "Datastructures", "Binary Search Tree", "Tree", "Collision" },
                ImageURL = "content/images/Untitlesssssd.png",
                HrefURL = "https://github.com/huntercfreeman/singlyLinkedList"
            },
            new ProgrammingProject
            {
                Title = "Linked List Visualizer in C#",
                Description = "A Linked List Visualizer written in C#",
                Tags = new List<string> { "C#", "CSharp", "Linked List", "Singly Linked List", "Doubly Linked List", "Visualize", "Visualizer" },
                ImageURL = "content/images/Untitlesssssd.png"
            },
            new ProgrammingProject
            {
                Title = "Binary Search Tree Visualizer in C#",
                Description = "A Binary Search Tree Visualizer written in C#",
                Tags = new List<string> { "C#", "CSharp", "Binary Search Tree", "BST", "Tree", "Visualize", "Visualizer" },
                ImageURL = "content/images/Untitlesssssd.png"
            }
        };

        private string _searchQuery;
        public string SearchQuery 
        {
            get => _searchQuery;
            set 
            {
                _searchQuery = value;
                SearchQueryEventInvoke(new EventArgs());
            }
        }
        public event EventHandler SearchQueryEventHandler;

        public void SearchQueryEventInvoke(EventArgs e)
        {
            EventHandler handler = SearchQueryEventHandler;
            handler?.Invoke(this, e);
        }

        private bool _filterByCProgrammingLanguageBool;
        public bool FilterByCProgrammingLanguageBool 
        {
            get => _filterByCProgrammingLanguageBool;
            set
            {
                _filterByCProgrammingLanguageBool = value;
                FilterByCProgrammingLanguageBoolEventInvoke(new EventArgs());
            }
        }
        public event EventHandler FilterByCProgrammingLanguageBoolEventHandler;

        public void FilterByCProgrammingLanguageBoolEventInvoke(EventArgs e)
        {
            EventHandler handler = FilterByCProgrammingLanguageBoolEventHandler;
            handler?.Invoke(this, e);
        }

        private bool _filterByCSharpProgrammingLanguageBool;
        public bool FilterByCSharpProgrammingLanguageBool
        {
            get => _filterByCSharpProgrammingLanguageBool;
            set
            {
                _filterByCSharpProgrammingLanguageBool = value;
                FilterByCSharpProgrammingLanguageBoolEventInvoke(new EventArgs());
            }
        }
        public event EventHandler FilterByCSharpProgrammingLanguageBoolBoolEventHandler;

        public void FilterByCSharpProgrammingLanguageBoolEventInvoke(EventArgs e)
        {
            EventHandler handler = FilterByCSharpProgrammingLanguageBoolBoolEventHandler;
            handler?.Invoke(this, e);
        }

        public List<ProgrammingProject> GetProgrammingProjects()
        {
            if(!string.IsNullOrWhiteSpace(SearchQuery))
            {
                foreach(ProgrammingProject programmingProject in _programmingProjects)
                {
                    programmingProject.PassedSearch = programmingProject.Title.Contains(SearchQuery);
                }
            }
            if(FilterByCProgrammingLanguageBool)
            {
                foreach (ProgrammingProject programmingProject in _programmingProjects)
                {
                    List<string> contains = programmingProject.Tags.Where(x => x.CompareTo("C") == 0).ToList();

                    if (contains.Count > 0) programmingProject.PassedCProgrammingLanguageFilter = true;
                    else programmingProject.PassedCProgrammingLanguageFilter = false;
                }
            }
            if (FilterByCSharpProgrammingLanguageBool)
            {
                foreach (ProgrammingProject programmingProject in _programmingProjects)
                {
                    List<string> contains = programmingProject.Tags.Where(x => x.CompareTo("C#") == 0).ToList();

                    if (contains.Count > 0) programmingProject.PassedCSharpProgrammingLanguageFilter = true;
                    else programmingProject.PassedCSharpProgrammingLanguageFilter = false;
                }
            }
            foreach (ProgrammingProject programmingProject in _programmingProjects)
            {
                programmingProject.PassedAllFilters = programmingProject.PassedSearch && programmingProject.PassedCSharpProgrammingLanguageFilter && programmingProject.PassedCProgrammingLanguageFilter;
            }
            return _programmingProjects.Where(x => x.PassedAllFilters).ToList();
        }

        public List<ProgrammingProject> FilterByTitle(string title)
        {
            SearchQuery = title;
            if(string.IsNullOrWhiteSpace(SearchQuery))
            {
                foreach (ProgrammingProject programmingProject in _programmingProjects)
                {
                    programmingProject.PassedSearch = true;
                }
            }
            DataChangedEventInvoke(new EventArgs());
            return GetProgrammingProjects();
        }

        public List<ProgrammingProject> FilterByCProgrammingLanguage()
        {
            if(FilterByCProgrammingLanguageBool)
            {
                foreach (ProgrammingProject programmingProject in _programmingProjects)
                {
                    programmingProject.PassedCProgrammingLanguageFilter = true;
                }
            }
            FilterByCProgrammingLanguageBool = !FilterByCProgrammingLanguageBool;
            DataChangedEventInvoke(new EventArgs());
            return GetProgrammingProjects();
        }

        public List<ProgrammingProject> FilterByCSharpProgrammingLanguage()
        {
            if (FilterByCSharpProgrammingLanguageBool)
            {
                foreach (ProgrammingProject programmingProject in _programmingProjects)
                {
                    programmingProject.PassedCSharpProgrammingLanguageFilter = true;
                }
            }
            FilterByCSharpProgrammingLanguageBool = !FilterByCSharpProgrammingLanguageBool;
            DataChangedEventInvoke(new EventArgs());
            return GetProgrammingProjects();
        }

        public event EventHandler DataChangedEventHandler;

        public void DataChangedEventInvoke(EventArgs e)
        {
            EventHandler handler = DataChangedEventHandler;
            handler?.Invoke(this, e);
        }

        public List<ProgrammingProject> GetProgrammingProjectsUnfiltered()
        {
            return _programmingProjects;
        }
    }
}
