namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;

    public interface ILieutenantGeneral : IPrivate
    {
        List<ISoldier> Privates { get; }


    }
}