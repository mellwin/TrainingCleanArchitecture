using System;
using System.Collections.Generic;

namespace InspectionPipesJournal.Domain.Contracts
{
    public interface IJournalRecordsRepo
    {
        void Insert(JournalRecord record);
        JournalRecord Find(Guid recordId);
        void Update(JournalRecord record);
        void Delete(Guid recordId);
        IEnumerable<JournalRecord> FindAll(DateTime date, DateTime dateTime);
        List<JournalRecord> SelectJournalPage(DateTime date);
    }
}
