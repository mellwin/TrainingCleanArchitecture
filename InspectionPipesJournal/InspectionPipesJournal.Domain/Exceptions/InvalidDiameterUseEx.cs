using System;

namespace InspectionPipesJournal.Domain
{
    [Serializable]
    internal class InvalidDiameterUseEx : Exception, IUseEx
    {
        public string DefaultMessage => $"Некорректное значение в параметре '{DiamName}'";

        public string DiamName { get; }

        public InvalidDiameterUseEx(string diamName)
        {
            DiamName = diamName;
        }
    }
}