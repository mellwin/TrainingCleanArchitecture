using InspectionPipesJournal.Domain;
using System;

namespace InspectionPipesJournal
{
    class RecordNotSelectedUseEx : Exception, IUseEx
    {
        public string DefaultMessage => "Не выбрана запись!";
    }
}
