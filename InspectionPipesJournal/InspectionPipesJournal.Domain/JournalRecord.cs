using System;
using System.Collections.Generic;
using System.Linq;

namespace InspectionPipesJournal.Domain
{
    public class JournalRecord
    {
        public Guid Id { get; private set; }

        public string PipeNumber { get; private set; }

        public int NomenclatureId { get; private set; }

        public double PipeTargetDiameter { get; private set; }

        public double PipeFactDiameterTeil1 { get; private set; }

        public double PipeFactDiameterTeil2 { get; private set; }

        public double? PipeFactDiameterTeilCentre { get; private set; }

        public double PipeFactDifferentDiameter => CalculatePipeFactDifferentDiameter(PipeFactDiameterTeil1, PipeFactDiameterTeil2, PipeFactDiameterTeilCentre, PipeTargetDiameter);

        public static double CalculatePipeFactDifferentDiameter(double pipeFactDiameterTeil1, double pipeFactDiameterTeil2, double? pipeFactDiameterTeilCentre, double pipeTargetDiameter)
        {
            var allDiams = new List<double> { pipeFactDiameterTeil1, pipeFactDiameterTeil2 };
            if (pipeFactDiameterTeilCentre.HasValue)
                allDiams.Add(pipeFactDiameterTeilCentre.Value);

            return Math.Abs(pipeTargetDiameter - allDiams.Max());
        }

        public double PipeMaxDifferentDiameterOnCreate { get; private set; }

        public string Notes { get; private set; }

        public DateTime DateTimeRecord { get; private set; }

        public bool DiamsOverLimit => PipeFactDifferentDiameter > PipeMaxDifferentDiameterOnCreate;

        private JournalRecord() { }

        internal static JournalRecord CreateNew(IDataForCreate data)
        {
            CheckData(data);

            return new JournalRecord
            {
                Id = Guid.NewGuid(),
                DateTimeRecord = data.DateTimeRecord,
                PipeNumber = data.PipeNumber,
                NomenclatureId = data.NomenclatureId,
                PipeTargetDiameter = data.PipeTargetDiameter,
                PipeFactDiameterTeil1 = data.PipeFactDiameterTeil1,
                PipeFactDiameterTeil2 = data.PipeFactDiameterTeil2,
                PipeFactDiameterTeilCentre = data.PipeFactDiameterTeilCentre,
                PipeMaxDifferentDiameterOnCreate = data.PipeMaxDifferentDiameterOnCreate,
                Notes = data.Notes
            };
        }

        internal static JournalRecord Restore(IDataForRestore data)
        {
            return new JournalRecord
            {
                Id = data.Id,
                DateTimeRecord = data.DateTimeRecord,
                PipeNumber = data.PipeNumber,
                NomenclatureId = data.NomenclatureId,
                PipeTargetDiameter = data.PipeTargetDiameter,
                PipeFactDiameterTeil1 = data.PipeFactDiameterTeil1,
                PipeFactDiameterTeil2 = data.PipeFactDiameterTeil2,
                PipeFactDiameterTeilCentre = data.PipeFactDiameterTeilCentre,
                PipeMaxDifferentDiameterOnCreate = data.PipeMaxDifferentDiameterOnCreate,
                Notes = data.Notes
            };
        }

        internal void Edit(IDataForEdit data)
        {
            CheckData(data);

            DateTimeRecord = data.DateTimeRecord;
            PipeNumber = data.PipeNumber;
            NomenclatureId = data.NomenclatureId;
            PipeTargetDiameter = data.PipeTargetDiameter;
            PipeFactDiameterTeil1 = data.PipeFactDiameterTeil1;
            PipeFactDiameterTeil2 = data.PipeFactDiameterTeil2;
            PipeFactDiameterTeilCentre = data.PipeFactDiameterTeilCentre;
            Notes = data.Notes;
        }

        private static void CheckData(IDataForEdit data)
        {
            // проверяем данные
            if (data.PipeTargetDiameter <= 0)
                throw new InvalidDiameterUseEx("Целевой диаметр");
            if (data.PipeFactDiameterTeil1 <= 0)
                throw new InvalidDiameterUseEx("Диаметр по концу трубы 1");
            if (data.PipeFactDiameterTeil2 <= 0)
                throw new InvalidDiameterUseEx("Диаметр по концу трубы 2");
        }

        public interface IDataForRestore : IDataForCreate
        {
            Guid Id { get; set; }
        }

        public interface IDataForCreate : IDataForEdit
        {
            double PipeMaxDifferentDiameterOnCreate { get; set; }
        }

        public interface IDataForEdit
        {
            string PipeNumber { get; set; }

            int NomenclatureId { get; set; }

            double PipeTargetDiameter { get; set; }

            double PipeFactDiameterTeil1 { get; set; }

            double PipeFactDiameterTeil2 { get; set; }

            double? PipeFactDiameterTeilCentre { get; set; }

            string Notes { get; set; }

            DateTime DateTimeRecord { get; set; }
        }
    }
}
