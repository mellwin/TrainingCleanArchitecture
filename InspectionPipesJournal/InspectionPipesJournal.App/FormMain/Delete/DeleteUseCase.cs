using InspectionPipesJournal.Domain.Contracts;

namespace InspectionPipesJournal.App.FormMain.Delete
{
    public class DeleteUseCase : AUseCase<IViewForDelete, DeleteUseCase.Values>
    {
        private readonly IJournalRecordsRepo journalRecordRepo;
        private readonly IViewForDelete view;
        public DeleteUseCase(IViewForDelete view, IJournalRecordsRepo journalRecordRepo) : base(view)
        {
            this.journalRecordRepo = journalRecordRepo;
            this.view = view;
        }
        public class Values
        { }

        public override void Execute(Values values)
        {
            var recordId = view.CreateDataFromTableRow().Id;
            journalRecordRepo.Delete(recordId);
        }
    }
}
