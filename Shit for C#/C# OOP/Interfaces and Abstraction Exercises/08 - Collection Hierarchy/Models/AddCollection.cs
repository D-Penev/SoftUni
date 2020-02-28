namespace CollectionHierarchy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class AddCollection : IAddCollection
    {
        private List<string> data;

        private List<int> indexes;

        public AddCollection()
        {
            this.data = new List<string>();
            this.indexes = new List<int>();
        }

        public void Add(string element)
        {
            int index = this.data.Count;

            this.data.Add(element);

            this.indexes.Add(index);
        }

        public override string ToString()
        {
            return $"{String.Join(" ", this.indexes)}";
        }
    }
}