namespace InspectionPipesJournal.Domain.Spravochniki
{
    public class SprNomenclatures
    {
        public int NomenclatureId { get; private set; }
        public double DiameterDifferent { get; private set; }
        private SprNomenclatures() { }


        internal static SprNomenclatures RestoreSprNomenclatures(IDataSpr data)
        {
            return new SprNomenclatures
            {
                NomenclatureId = data.NomenclatureId,
                DiameterDifferent = data.DiameterDifferent
            };
        }

        public interface IDataSpr
        {
            int NomenclatureId { get; set; }
            double DiameterDifferent { get; set; }
        }
    }
}
