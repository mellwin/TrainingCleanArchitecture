using InspectionPipesJournal.Domain.Spravochniki;
using System.Collections.Generic;

namespace InspectionPipesJournal.Domain.Contracts
{
    public interface ISprRepo
    {
        List<SprDiameters> SelectPipeTargetDiameterList();
        List<SprNomenclatures> SelectPipeNumberIdList();
    }
}
