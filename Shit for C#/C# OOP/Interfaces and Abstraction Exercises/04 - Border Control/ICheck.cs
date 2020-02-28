namespace BorderControl
{
    using System;
    using System.Linq;

    public interface ICheck
    {
        string Id { get; }

        void CheckId(string stringToCheck,string idFromInput);
    }
}