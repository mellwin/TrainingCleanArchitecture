using InspectionPipesJournal.Domain;
using InspectionPipesJournal.Domain.Spravochniki;
using System.Collections.Generic;

namespace InspectionPipesJournal.App.FormRecord.Save
{
    public interface IViewForSave
    {
        DataForEdit CreateDataForEdit();
        DataForCreate CreateDataForAdd();
    }
}
