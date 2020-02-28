namespace MilitaryElite
{
    using System;

    public interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }
    }
}