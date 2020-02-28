namespace CollectionHierarchy
{
    using System;

    public interface IMyList
    {
        int Used { get; }

        void Add(string element);

        void Remove();
    }
}