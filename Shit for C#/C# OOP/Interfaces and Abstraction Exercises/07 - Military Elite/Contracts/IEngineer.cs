namespace MilitaryElite
{
    using System;

    using System.Collections.Generic;

    public interface IEngineer : ISpecializedSoldier
    {
        List<IRepair> Repairs { get; }
    }
}