using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoreLibrary
{
    public class SqlConnector : IDataConnection
    {
        public SubmissionModel CreateSubmission(SubmissionModel model)
        {
            throw new NotImplementedException();
        }

        public List<SubmissionModel> GetSubmissions()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Aden")))
            {
                var sql = "select * from dbo.submissions";

                var results = connection.Query<SubmissionModel>(sql).ToList();

                return results;
            }
        }
    }
}
