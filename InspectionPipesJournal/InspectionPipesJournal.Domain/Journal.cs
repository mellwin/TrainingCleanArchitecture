using InspectionPipesJournal.Domain.Contracts;
using System;
using System.Collections.Generic;

namespace InspectionPipesJournal.Domain
{
    public class Journal
    {
        private readonly IJournalRecordsRepo records;

        public Journal(IJournalRecordsRepo records)
        {
            this.records = records;
        }

        public void WriteNewRecord(JournalRecord.IDataForCreate data)
        {
            var record = JournalRecord.CreateNew(data);

            // могут быть какие-то проверки того, возможно ли добавить такую запись в журнал
            // ...

            records.Insert(record);

            // могут быть какие-то доп-действия. 
            // ...
        }

        public void EditRecord(Guid recordId, JournalRecord.IDataForEdit data)
        {
            var record = records.Find(recordId);
            if (record == null)
                throw new RecordNotFoundEx();
            record.Edit(data);
            records.Update(record);
        }

        public void EraseRecord(Guid recordId)
        {
            records.Delete(recordId);
        }

        public static JournalRecord RestoreRecord(JournalRecord.IDataForRestore data)
        {
            return JournalRecord.Restore(data);
        }

        public IEnumerable<JournalRecord> FindRecordsByDay(DateTime day)
        {
            return records.FindAll(day.Date, day.Date.AddDays(1));
        }
    }
}
