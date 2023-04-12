namespace InspectionPipesJournal.Domain.Spravochniki
{
    public class SprDiameters
    {
        public double Diameter { get; private set; }
        private SprDiameters() { }

        internal static SprDiameters RestoreSprDiameters(IDataSpr data)
        {
            return new SprDiameters
            {
                Diameter = data.Diameter
            };
        }

        public interface IDataSpr
        {
            double Diameter { get; set; }
        }
    }
}
