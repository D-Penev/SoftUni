namespace CollectionHierarchy
{
    using System;

    using System.Collections.Generic;

    public class MyList : IMyList
    {
        private List<int> indexes;

        private List<string> data;

        private List<string> removedElements;

        public MyList()
        {
            this.indexes = new List<int>();
            this.data = new List<string>();
            this.removedElements = new List<string>();
        }

        public int Used => this.data.Count;

        public void Add(string element)
        {
            this.data.Insert(0, element);
            this.indexes.Add(0);
        }

        public void Remove()
        {
            string elementToRemove = this.data[0];

            this.data.RemoveAt(0);

            this.removedElements.Add(elementToRemove);
        }

        public override string ToString()
        {
            return $"{String.Join(" ", this.indexes)}";
        }

        public void GetRemovedElements()
        {
            Console.WriteLine($"{String.Join(" ",this.removedElements)}");
        }
    }
}