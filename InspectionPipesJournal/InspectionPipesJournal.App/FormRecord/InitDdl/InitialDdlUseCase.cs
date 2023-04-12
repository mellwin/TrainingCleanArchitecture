using InspectionPipesJournal.Domain.Contracts;

namespace InspectionPipesJournal.App.FormRecord.InitDdl
{
    public class InitialDdlUseCase : AUseCase<IViewInitialDdl, InitialDdlUseCase.Values>
    {
        private readonly ISprRepo sprRepo;

        public InitialDdlUseCase(IViewInitialDdl view, ISprRepo sprRepo) : base(view)
        {
            this.sprRepo = sprRepo;
        }

        public class Values
        { }

        public override void Execute(Values values)
        {
            view.InitDdlOptions(sprRepo.SelectPipeNumberIdList(), sprRepo.SelectPipeTargetDiameterList());
        }
    }
}
