using InspectionPipesJournal.Domain;
using InspectionPipesJournal.Domain.Contracts;
using InspectionPipesJournal.Domain.Spravochniki;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace InspectionPipesJournal.DAL
{
    public class SprRepo : ISprRepo
    {

        private readonly DB db = new DB();
        public List<SprDiameters> SelectPipeTargetDiameterList()
        {
            string queryString = "select * from TRAIN_SPR_JOURNAL_DIAMS t";
            DataTable dataTable = db.GetQueryResult(queryString);
            List<SprDiameters> diameters = new List<SprDiameters>();
            diameters = dataTable.AsEnumerable().Select(MapToSprDiameterRecord).OrderBy(ob => ob.Diameter).ToList();

            return diameters;
        }
        public List<SprNomenclatures> SelectPipeNumberIdList()
        {
            string queryString = "select * from TRAIN_SPR_JOURNAL_NUMS t";
            DataTable dataTable = db.GetQueryResult(queryString);
            List<SprNomenclatures> nomenclatures = new List<SprNomenclatures>();
            nomenclatures = dataTable.AsEnumerable().Select(MapToSprNomenclaturesRecord).OrderBy(ob => ob.NomenclatureId).ToList();
            return nomenclatures;
        }

        private SprDiameters MapToSprDiameterRecord(DataRow row)
        {
            SprDiameters record = Spr.RestoreDiameters(new DataForSprDiameters(
                Convert.ToDouble(row["DIAMETER"])
            ));
            return record;
        }
        private SprNomenclatures MapToSprNomenclaturesRecord(DataRow row)
        {
            SprNomenclatures record = Spr.RestoreNomenclatures(new DataForSprNomenclatures(
                Convert.ToInt32(row["NOMENCLATURE_ID"]),
                Convert.ToDouble(row["DIAMETER_DIFFERENT"])
            ));
            return record;
        }
    }
}
