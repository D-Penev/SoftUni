namespace MilitaryElite
{
    using System;

    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}