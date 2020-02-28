namespace PersonInfo
{
    using System;
    using System.Linq;
    public interface IPerson
    {
        string Name { get; }

        int Age { get; }
    }
}