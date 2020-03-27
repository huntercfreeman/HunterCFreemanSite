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

        public List<ProgrammingProject> GetProgrammingProjects()
        {
            return _programmingProjects;
        }

        public List<ProgrammingProject> GetProgrammingProjectsByTitle(string title)
        {
            return _programmingProjects.Where(x => x.Title.Contains(title)).ToList();
        }
    }
}
