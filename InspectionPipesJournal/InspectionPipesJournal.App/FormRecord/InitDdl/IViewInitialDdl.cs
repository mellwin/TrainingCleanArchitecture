using InspectionPipesJournal.Domain.Spravochniki;
using System.Collections.Generic;

namespace InspectionPipesJournal.App.FormRecord.InitDdl
{
    public interface IViewInitialDdl
    {
        void InitDdlOptions(List<SprNomenclatures> ddlNomList, List<SprDiameters> ddlDiamList);
    }
}
