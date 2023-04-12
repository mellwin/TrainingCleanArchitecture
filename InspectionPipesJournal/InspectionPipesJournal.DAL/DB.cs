using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace InspectionPipesJournal.DAL
{
    public class DB
    {
        public DataTable GetQueryResult(string queryString)
        {
            return GetQueryResult(queryString, null);
        }

        public void ExecuteChanges(string queryString, Dictionary<string, object> dbParamsDict)
        {
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = conn.CreateCommand();
            cmd.BindByName = true;
            cmd.CommandText = queryString;
            try
            {
                if (dbParamsDict != null)
                    cmd.Parameters.AddRange(dbParamsDict.Select(item => new OracleParameter(item.Key, item.Value)).ToArray());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось выполнить запрос на получение данных из БД Oracle.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        public DataTable GetQueryResult(string queryString, Dictionary<string, object> dbParamsDict)
        {
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = conn.CreateCommand();
            cmd.BindByName = true;
            cmd.CommandText = queryString;
            try
            {
                DataTable dt = new DataTable();
                if (dbParamsDict != null)
                    cmd.Parameters.AddRange(dbParamsDict.Select(item => new OracleParameter(item.Key, item.Value)).ToArray());
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось выполнить запрос на получение данных из БД Oracle.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        private OracleConnection OpenConnection()
        {
            OracleConnection connection = new OracleConnection(GetConnectionString());
            connection.Open();
            return connection;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["testDB"].ConnectionString;
        }

    }
}