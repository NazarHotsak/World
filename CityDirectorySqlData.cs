using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;

namespace World
{
    public delegate void AddDataIntoDirectoryHandler(SqlParameters parameters);

    internal class CityDirectorySqlData
    {
        private string _connectionStrings;

        public CityDirectorySqlData(string databaseName)
        {
            //|DataDirectory|
            _connectionStrings = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;

            int onlyBaseDirectory = AppDomain.CurrentDomain.BaseDirectory.IndexOf("\\bin");

            if (onlyBaseDirectory == -1)
            {
                return;
            }

            _connectionStrings = _connectionStrings.Replace(oldValue: "|DataDirectory|", newValue: AppDomain.CurrentDomain.BaseDirectory.Remove(onlyBaseDirectory));
        }

        public DataTable GetDirectoryDataSearchByNameWithForignId(SqlParameters parameters)
        {
            return GetDirectoryDataInSqlTable($"select Id, Name from {parameters.DirectoryName} " +
                $"where {parameters.ForeignIdName} = {parameters.ForeignId} and Name like N'%{parameters.NameSearch}%'");
        }

        public DataTable GetSettlementsDirectoryDataSearchByNameWithForignId(SqlParameters parameters)
        {
            return GetDirectoryDataInSqlTable($"select Id, Name, TypeSettlement from {parameters.DirectoryName} " +
                $"where {parameters.ForeignIdName} = {parameters.ForeignId} and Name like N'%{parameters.NameSearch}%'");
        }

        public DataTable GetDirectoryDataSearchByName(SqlParameters parameters)
        {
            return GetDirectoryDataInSqlTable($"select Id, Name from {parameters.DirectoryName} " +
                $"where Name like N'%{parameters.NameSearch}%'");
        }

        /// <summary>
        /// The GetData does not call Dispose!
        /// </summary>
        /// <param name="directoryName">Table that will be returned.</param>
        /// <returns>DataTable column1 = Id column2 = Name</returns>
        public DataTable GetDirectoryData(string directoryName)
        {
            return GetDirectoryDataInSqlTable($"select Id, Name from {directoryName} order by Id");
        }

        /// <summary>
        /// The GetData does not call Dispose!
        /// </summary>
        /// <param name="directoryName">Table that will be returned.</param>
        /// <param name="foreignIdName">select where foreignIdName == foreignId</param>
        /// <param name="foreignId">select where foreignIdName == foreignId</param>
        /// <returns>DataTable column1 = Id column2 = Name</returns>
        public DataTable GetDirectoryData(string directoryName, string foreignIdName, int foreignId)
        {
            return GetDirectoryDataInSqlTable($"select Id, Name from {directoryName} where {foreignIdName} = {foreignId}");
        }

        /// <summary>
        /// The GetData does not call Dispose!
        /// </summary>
        /// <param name="directoryName">Table that will be returned.</param>
        /// <param name="foreignIdName">select where foreignIdName == foreignId</param>
        /// <param name="foreignId">select where foreignIdName == foreignId</param>
        /// <returns>DataTable column1 = Id column2 = Name</returns>
        public DataTable GetSettlementsDirectoryData(string directoryName, string foreignIdName, int foreignId)
        {
            return GetDirectoryDataInSqlTable($"select Id, Name, TypeSettlement from {directoryName} where {foreignIdName} = {foreignId}");
        }

        public DataTable GetSettlementsDirectoryDataWithPrioritySort(SqlParameters parameters)
        {
            return GetDirectoryDataInSqlTable($"select Id, Name, TypeSettlement from {parameters.DirectoryName} " +
                $"where {parameters.ForeignIdName} = {parameters.ForeignId}" +
                $" order by case TypeSettlement when {parameters.TypeSettlement} then -1 else TypeSettlement end");
        }

        /// <param name="directoryName">Table into which the data will be added</param>
        public void AddDataIntoDirectory(SqlParameters parameters)
        {
            ExecuteSqlExpression($"insert {parameters.DirectoryName} (Name) values (N'{parameters.DataName}')");
        }

        public void AddDataIntoDirectoryWithForeignId(SqlParameters parameters)
        {
            ExecuteSqlExpression($"insert {parameters.DirectoryName} (Name, {parameters.ForeignIdName}) values (N'{parameters.DataName}', {parameters.ForeignId})");
        }

        public void AddDataIntoSettlementDirectory(SqlParameters parameters)
        {
            ExecuteSqlExpression($"insert {parameters.DirectoryName} (Name, {parameters.ForeignIdName}, TypeSettlement) " +
                $"values (N'{parameters.DataName}', {parameters.ForeignId}, {parameters.TypeSettlement})");
        }

        public void DeleteItemFromDirectory(SqlParameters parameters)
        {
            ExecuteSqlExpression($"delete {parameters.DirectoryName} where Id = {parameters.Id}");
        }

        /// <summary>
        /// Executes a sql-expression that is suitable for update, delete, insert.
        /// </summary>
        private void ExecuteSqlExpression(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connectionString: _connectionStrings))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cmdText: sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

        private DataTable GetDirectoryDataInSqlTable(string sqlExpression)
        {
            using (SqlConnection connection = new(_connectionStrings))
            {
                SqlDataAdapter adapter = new(sqlExpression, connection);
                DataTable dataTable = new();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}





