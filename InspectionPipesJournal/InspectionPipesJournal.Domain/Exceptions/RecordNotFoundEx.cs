using System;

namespace InspectionPipesJournal.Domain
{
    [Serializable]
    internal class RecordNotFoundEx : Exception, IUseEx
    {
        public string DefaultMessage => "Запись не найдена. Возможно запись была удалена или никогда не существовала";
    }
}