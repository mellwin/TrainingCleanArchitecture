using InspectionPipesJournal.Domain;
using InspectionPipesJournal.Domain.Contracts;
using System.Collections.Generic;

namespace InspectionPipesJournal.App.FormMain.Load
{
    public class LoadUseCase : AUseCase<IViewForLoad, LoadUseCase.Values>
    {
        private readonly IJournalRecordsRepo journalRecordRepo;
        private readonly IViewForLoad view;

        public LoadUseCase(IViewForLoad view, IJournalRecordsRepo journalRecordRepo) : base(view)
        {
            this.journalRecordRepo = journalRecordRepo;
            this.view = view;
        }
        public class Values
        {
        }

        public List<JournalRecord> CreateRecordsListByDate()
        {
            var date = view.GetJournalDate();
            return journalRecordRepo.SelectJournalPage(date);
        }

        public JournalRecord CreateRecordFromTableRow()
        {
            var record = Journal.RestoreRecord(view.CreateDataFromTableRow());
            return record;
        }

        public override void Execute(Values values)
        {
            var records = CreateRecordsListByDate();
            view.RefillTableFromStorage(records);
        }

        public void RefillFormTable()
        {
            var records = CreateRecordsListByDate();
            view.RefillTableFromStorage(records);
        }
    }
}