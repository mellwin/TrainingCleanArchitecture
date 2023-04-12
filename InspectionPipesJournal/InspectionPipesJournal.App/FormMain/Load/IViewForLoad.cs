using InspectionPipesJournal.Domain;
using System;
using System.Collections.Generic;

namespace InspectionPipesJournal.App.FormMain.Load
{
    public interface IViewForLoad
    {
        DtoDataForRestore CreateDataFromTableRow();
        DateTime GetJournalDate();
        void OpenFormForChangeRercod();
        void RefillTableFromStorage(List<JournalRecord> records);
    }
}
