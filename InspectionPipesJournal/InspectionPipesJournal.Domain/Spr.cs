using InspectionPipesJournal.Domain.Contracts;
using InspectionPipesJournal.Domain.Spravochniki;

namespace InspectionPipesJournal.Domain
{
    public class Spr
    {
        private readonly ISprRepo records;

        public Spr(ISprRepo records)
        {
            this.records = records;
        }

        public static SprDiameters RestoreDiameters(SprDiameters.IDataSpr data)
        {
            return SprDiameters.RestoreSprDiameters(data);
        }
        public static SprNomenclatures RestoreNomenclatures(SprNomenclatures.IDataSpr data)
        {
            return SprNomenclatures.RestoreSprNomenclatures(data);
        }
    }
}
