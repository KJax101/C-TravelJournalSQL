using System;
using System.Collections.Generic;

namespace TravelJournal
{
    class Journal
    {
        private List<Entry> entries;
        public Journal()
        //this is the constructor, it has same name as the class "Journal"
        {
            entries = new List<Entry>();
            //new by itself is used to creates an object
        }
        public void AddEntry(Entry newEntry)
        {
            //we put argument type, and then name
            entries.Add(newEntry);
        }
        public void PrintEntries()
        {
            Console.Clear();
            foreach (var entry in entries)
            {
                entry.PrintEntry();
            }
        }
        public void PromptEntry()
        {
            int PageNumber = entries.Count + 1;
            Console.Write("Location: ");
            string LocationEntry = Console.ReadLine();
            Console.Write("Comments: ");
            string CommentsEntry = Console.ReadLine();
            Entry entry = new Entry();
            entry.PageNumber = PageNumber;
            entry.Location = LocationEntry;
            entry.Comments = CommentsEntry;
            AddEntry(entry);
        }
    }
    class Entry
    {
        public string Author
        {
            //Name is the Property
            get; set;
        }
        public int PageNumber
        {
            get; set;
            //this is another/faster way to do what we did on line 9-12 
            //so that the age property will behave the same as the name property
            //getting the Age
            //private set is used as a shortcut 
        }

        public String Comments
        {
            get; set;
        }
        public String Location
        {
            get; set;
        }

        public void PrintEntry()
        {
            //this function is 'void' because we are not returning any values
            Console.WriteLine("Location: " + Location);
            Console.WriteLine("Comments: " + Comments);
            Console.WriteLine("Author - " + Author);
            Console.WriteLine("\npage " + PageNumber);
            //\n means new line, \t means tab
        }

        public Entry()
        {
            // this is the Constructor. it is has the same name as the class and
            // constructor functions have no return type, all others have return types
            //is called any time the class is created
            // here we set values for the data
            Author = "Guest User";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Journal travelJ = new Journal();
            travelJ.PromptEntry();
            travelJ.PrintEntries();
        }

    }
}
