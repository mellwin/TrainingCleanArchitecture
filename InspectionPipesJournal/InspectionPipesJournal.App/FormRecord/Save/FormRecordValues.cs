using InspectionPipesJournal.Domain;
using System;

namespace InspectionPipesJournal.App.FormRecord.Save
{
    public class FormRecordValues : JournalRecord.IDataForRestore
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

        public FormRecordValues(string pipeNumber, int NomenclatureId, double pipeTargetDiameter, double pipeFactDiameterTeil1, double pipeFactDiameterTeil2,
            double? pipeFactDiameterTeilCentre, string notes, DateTime DateTimeRecord)
        {
            this.PipeNumber = pipeNumber;
            this.NomenclatureId = NomenclatureId;
            this.PipeTargetDiameter = pipeTargetDiameter;
            this.PipeFactDiameterTeil1 = pipeFactDiameterTeil1;
            this.PipeFactDiameterTeil2 = pipeFactDiameterTeil2;
            this.PipeFactDiameterTeilCentre = pipeFactDiameterTeilCentre;
            this.Notes = notes;
            this.DateTimeRecord = DateTimeRecord;
        }
        public FormRecordValues(string pipeNumber, int NomenclatureId, double pipeTargetDiameter, double pipeFactDiameterTeil1, double pipeFactDiameterTeil2,
            double? pipeFactDiameterTeilCentre, double pipeMaxDifferentDiameterOnCreate, string notes, DateTime DateTimeRecord)
        {
            this.PipeMaxDifferentDiameterOnCreate = pipeMaxDifferentDiameterOnCreate;
            this.PipeNumber = pipeNumber;
            this.NomenclatureId = NomenclatureId;
            this.PipeTargetDiameter = pipeTargetDiameter;
            this.PipeFactDiameterTeil1 = pipeFactDiameterTeil1;
            this.PipeFactDiameterTeil2 = pipeFactDiameterTeil2;
            this.PipeFactDiameterTeilCentre = pipeFactDiameterTeilCentre;
            this.Notes = notes;
            this.DateTimeRecord = DateTimeRecord;
        }
    }
}
