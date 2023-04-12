using System;

namespace InspectionPipesJournal.Domain
{
    public class DtoDataForRestore : JournalRecord.IDataForRestore
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

        public DtoDataForRestore(Guid id, string pipeNumber, int NomenclatureId, double pipeTargetDiameter, double pipeFactDiameterTeil1, double pipeFactDiameterTeil2,
            double? pipeFactDiameterTeilCentre, double pipeMaxDifferentDiameterOnCreate, string notes, DateTime DateTimeRecord)
        {
            this.Id = id;
            this.PipeNumber = pipeNumber;
            this.NomenclatureId = NomenclatureId;
            this.PipeTargetDiameter = pipeTargetDiameter;
            this.PipeFactDiameterTeil1 = pipeFactDiameterTeil1;
            this.PipeFactDiameterTeil2 = pipeFactDiameterTeil2;
            this.PipeFactDiameterTeilCentre = pipeFactDiameterTeilCentre;
            this.PipeMaxDifferentDiameterOnCreate = pipeMaxDifferentDiameterOnCreate;
            this.Notes = notes;
            this.DateTimeRecord = DateTimeRecord;
        }

        public DtoDataForRestore(DateTime DateTimeRecord)
        {
            this.DateTimeRecord = DateTimeRecord;
        }
    }
}
