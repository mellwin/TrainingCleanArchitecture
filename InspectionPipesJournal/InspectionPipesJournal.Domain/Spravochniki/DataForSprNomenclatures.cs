namespace InspectionPipesJournal.Domain.Spravochniki
{
    public class DataForSprNomenclatures : SprNomenclatures.IDataSpr
    {
        public int NomenclatureId { get; set; }
        public double DiameterDifferent { get; set; }

        public DataForSprNomenclatures(int NomenclatureId, double DiameterDifferent)
        {
            this.NomenclatureId = NomenclatureId;
            this.DiameterDifferent = DiameterDifferent;
        }
    }
}
