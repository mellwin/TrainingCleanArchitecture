using InspectionPipesJournal.Domain;
using System;

namespace InspectionPipesJournal.App.FormMain.Load
{
    public class FormMainValues : JournalRecord.IDataForRestore
    {
        public Guid Id { get; set; }
        public double PipeMaxDifferentDiameterOnCreate { get; set; }
        public string PipeNumber { get; set; }
        public int NomenclatureId { get; set; }
        public double PipeTargetDiameter { get; set; }
        public double PipeFactDiameterTeil1 { get; set; }
        public double PipeFactDiameterTeil2 { get; set; }
        public double? PipeFactDiameterTeilCentre { get; set; }
        public string Notes { get; set; }
        public DateTime DateTimeRecord { get; set; }
    }
}
