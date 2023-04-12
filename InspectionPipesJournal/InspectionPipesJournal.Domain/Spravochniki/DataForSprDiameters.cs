namespace InspectionPipesJournal.Domain.Spravochniki
{
    public class DataForSprDiameters : SprDiameters.IDataSpr
    {
        public double Diameter { get; set; }

        public DataForSprDiameters(double Diameter)
        {
            this.Diameter = Diameter;
        }
    }
}
