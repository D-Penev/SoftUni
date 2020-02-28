namespace BirthdayCelebrations.Interfaces
{
    using System;
    using System.Linq;
    public interface IBirthDate
    {
        string BirthDate { get; }

        bool CheckBirthDate(string fromInput);
    }
}