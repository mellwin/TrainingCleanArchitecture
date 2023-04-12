using InspectionPipesJournal.App.FormRecord.Save;
using InspectionPipesJournal.Domain;
using InspectionPipesJournal.Domain.Contracts;
using System;

namespace InspectionPipesJournal.App.FormRecord
{
    public class SaveUseCase : AUseCase<IViewForSave, SaveUseCase.Values>
    {
        private readonly IJournalRecordsRepo journalRecordRepo;

        public SaveUseCase(IViewForSave view, IJournalRecordsRepo journalRecordRepo) : base(view)
        {
            this.journalRecordRepo = journalRecordRepo;
        }

        public class Values
        {
            public OpenMode OpenMode { get; set; }
            public Guid RecordId { get; set; }
        }

        public override void Execute(Values values)
        {
            Journal journal = new Journal(journalRecordRepo);
            if (values.OpenMode == OpenMode.Edit)
                journal.EditRecord(values.RecordId, view.CreateDataForEdit());
            else
                journal.WriteNewRecord(view.CreateDataForAdd());
        }
    }
}
