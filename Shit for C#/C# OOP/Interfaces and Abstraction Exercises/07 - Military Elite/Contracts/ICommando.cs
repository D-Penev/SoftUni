namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;

    public interface ICommando : ISpecializedSoldier
    {
        List<IMission> Missions { get; }
    }
}