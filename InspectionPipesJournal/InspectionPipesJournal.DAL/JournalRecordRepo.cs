using InspectionPipesJournal.Domain;
using InspectionPipesJournal.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace InspectionPipesJournal.DAL
{
    public class JournalRecordRepo : IJournalRecordsRepo
    {
        private readonly DB db = new DB();

        public List<JournalRecord> SelectJournalPage(DateTime date)
        {
            string queryString = @"select tj.id,
                                           tj.pipenum,
                                           tj.nomenclature_id,
                                           tj.target_diameter,
                                           tj.fact_diameter_teil1,
                                           tj.fact_diameter_teil2,
                                           tj.fact_diameter_teil_centre,
                                           tj.different_diameter        as maxdifferentdiameter,
                                           jn.diameter_different        as factdifferentdiameter,
                                           tj.notes,
                                           tj.datetime_record
                                      from train_journal tj
                                      join train_spr_journal_nums jn
                                        on tj.nomenclature_id = jn.nomenclature_id
                                     where tj.datetime_record between :dateTimeStart and :dateTimeEnd";

            List<JournalRecord> records = new List<JournalRecord>();

            var dateTimeStart = date.Date;
            var dateTimeEnd = dateTimeStart.Date.AddDays(1);

            DataTable dataTable = db.GetQueryResult(queryString, CreateSqlParamsForSelectByDate(dateTimeStart, dateTimeEnd));

            records = dataTable.AsEnumerable().Select(MapToRecord).OrderBy(ob => ob.DateTimeRecord).ToList();
            return records;
        }

        private JournalRecord MapToRecord(DataRow row)
        {
            JournalRecord record = Journal.RestoreRecord(new DtoDataForRestore(
                Guid.Parse(row["ID"].ToString()),
                row["pipenum"].ToString(),
                Convert.ToInt32(row["nomenclature_id"]),
                Convert.ToDouble(row["target_diameter"]),
                Convert.ToDouble(row["fact_diameter_teil1"]),
                Convert.ToDouble(row["fact_diameter_teil2"]),
                Convert.ToDouble(row["fact_diameter_teil_centre"]),
                Convert.ToDouble(row["factdifferentdiameter"]),
                row["notes"].ToString(),
                Convert.ToDateTime(row["datetime_record"])
            ));

            return record;
        }

        public void Insert(JournalRecord record)
        {
            string queryString = @"insert into TRAIN_JOURNAL
                                (ID, PIPENUM, NOMENCLATURE_ID, TARGET_DIAMETER, FACT_DIAMETER_TEIL1, FACT_DIAMETER_TEIL2, FACT_DIAMETER_TEIL_CENTRE, DIFFERENT_DIAMETER, NOTES, DATETIME_RECORD)
                                values(:id, :pipeNumber, :NomenclatureId, :pipeTargetDiameter, :pipeFactDiameterTeil1, :pipeFactDiameterTeil2, :pipeFactDiameterTeilCentre, :pipeFactDifferentDiameter, :notes, :DateTimeRecord)";

            //REV: сделать отдельный метод для выполнения изменений в БД ExecuteChanges (ExecuteNoneQuery)
            db.ExecuteChanges(queryString, CreateSqlParamsForSave(record));
        }

        public void Update(JournalRecord record)
        {
            string queryString = @"update TRAIN_JOURNAL t
                                    set PIPENUM = :pipeNumber,
                                        NOMENCLATURE_ID = :NomenclatureId,
                                        TARGET_DIAMETER = :pipeTargetDiameter,
                                        FACT_DIAMETER_TEIL1 = :pipeFactDiameterTeil1,
                                        FACT_DIAMETER_TEIL2 = :pipeFactDiameterTeil2,
                                        FACT_DIAMETER_TEIL_CENTRE = :pipeFactDiameterTeilCentre,
                                        DIFFERENT_DIAMETER = :pipeFactDifferentDiameter,
                                        NOTES = :notes,
                                        DATETIME_RECORD = :DateTimeRecord
                                    where t.id = :id";

            db.ExecuteChanges(queryString, CreateSqlParamsForSave(record));
        }

        public void Delete(Guid recordId)
        {
            string queryString = @"delete from TRAIN_JOURNAL t
                                    where t.id = :id";

            db.ExecuteChanges(queryString, new Dictionary<string, object> { ["id"] = recordId.ToString() });
        }

        public Dictionary<string, object> CreateSqlParamsForSave(JournalRecord record)
        {
            var paramsDict = new Dictionary<string, object>
            {
                ["id"] = record.Id.ToString(),
                ["pipeNumber"] = record.PipeNumber,
                ["NomenclatureId"] = record.NomenclatureId,
                ["pipeTargetDiameter"] = record.PipeTargetDiameter,
                ["pipeFactDiameterTeil1"] = record.PipeFactDiameterTeil1,
                ["pipeFactDiameterTeil2"] = record.PipeFactDiameterTeil2,
                ["pipeFactDiameterTeilCentre"] = record.PipeFactDiameterTeilCentre,
                ["pipeFactDifferentDiameter"] = record.PipeFactDifferentDiameter,
                ["notes"] = record.Notes,
                ["DateTimeRecord"] = record.DateTimeRecord,
            };
            return paramsDict;
        }

        private Dictionary<string, object> CreateSqlParamsForSelectByDate(DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            var paramsDict = new Dictionary<string, object>
            {
                ["dateTimeStart"] = dateTimeStart,
                ["dateTimeEnd"] = dateTimeEnd
            };

            return paramsDict;
        }

        public JournalRecord Find(Guid recordId)
        {
            string queryString = @"select * from train_journal t
                                    where t.id = :recordId";

            DataRow dr = db.GetQueryResult(queryString, new Dictionary<string, object> { ["recordId"] = recordId.ToString() }).Rows[0];

            JournalRecord record = Journal.RestoreRecord(new DtoDataForRestore(

                Guid.Parse(dr["ID"].ToString()),
                dr["PIPENUM"].ToString(),
                Convert.ToInt32(dr["NOMENCLATURE_ID"].ToString()),
                Convert.ToDouble(dr["TARGET_DIAMETER"].ToString()),
                Convert.ToDouble(dr["FACT_DIAMETER_TEIL1"].ToString()),
                Convert.ToDouble(dr["FACT_DIAMETER_TEIL2"].ToString()),
                Convert.ToDouble(dr["FACT_DIAMETER_TEIL_CENTRE"].ToString()),
                Convert.ToDouble(dr["DIFFERENT_DIAMETER"].ToString()),
                dr["NOTES"].ToString(),
                DateTime.ParseExact(dr["DATETIME_RECORD"].ToString(), "dd.MM.yyyy HH:mm:ss", null)
            ));

            return record;
        }

        public IEnumerable<JournalRecord> FindAll(DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            string queryString = @"select tj.id,
                                           tj.pipenum,
                                           tj.nomenclature_id,
                                           tj.target_diameter,
                                           tj.fact_diameter_teil1,
                                           tj.fact_diameter_teil2,
                                           tj.fact_diameter_teil_centre,
                                           tj.different_diameter        as maxdifferentdiameter,
                                           jn.diameter_different        as factdifferentdiameter,
                                           tj.notes,
                                           tj.datetime_record
                                      from train_journal tj
                                      join train_spr_journal_nums jn
                                        on tj.nomenclature_id = jn.nomenclature_id
                                     where tj.datetime_record between :dateTimeStart and :dateTimeEnd";
            List<JournalRecord> records = new List<JournalRecord>();

            DataTable dataTable = db.GetQueryResult(queryString, CreateSqlParamsForSelectByDate(dateTimeStart, dateTimeEnd));

            records = dataTable.AsEnumerable().Select(MapToRecord).OrderBy(ob => ob.DateTimeRecord).ToList();
            return records;
        }
    }
}
