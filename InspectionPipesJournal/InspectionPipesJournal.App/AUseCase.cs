namespace InspectionPipesJournal.App
{
    public abstract class AUseCase<TView, TValues>
    {
        protected readonly TView view;

        protected AUseCase(TView view)
        {
            this.view = view;
        }

        public abstract void Execute(TValues values);
    }
}
