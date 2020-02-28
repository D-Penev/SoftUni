namespace MilitaryElite
{
    using System;

    public interface IMission
    {
        string CodeName { get; }

        string Status { get; }

        void CompleteMission();
    }
}