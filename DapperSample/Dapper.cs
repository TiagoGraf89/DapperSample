using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace DapperSample
{

    class DapperTest
    {
        public TimeSpan RunTestOne()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (byte i = 0; i < 20; i++)
                RunCommands();

            watch.Stop();
            return watch.Elapsed;
        }

        public void RunCommands()
        {
            string query = "insert into crm.Showrooms (ShowroomId, ShowroomName, IsActive) values (@ShowroomId, @ShowroomName, @IsActive);";
            List<ShowroomModel> modelList = new List<ShowroomModel>();
            modelList.Add(new ShowroomModel() { ShowroomId = Guid.NewGuid(), ShowroomName = "Showroom 1", IsActive = true });
            modelList.Add(new ShowroomModel() { ShowroomId = Guid.NewGuid(), ShowroomName = "Showroom 2", IsActive = true });
            modelList.Add(new ShowroomModel() { ShowroomId = Guid.NewGuid(), ShowroomName = "Showroom 3", IsActive = true });
            Dapper.SqlMapper.Execute(sqlConnection, query, modelList);
            // Initialize Connection
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                conn.Open();

                // Initialize Model
                ShowroomModel model = new ShowroomModel("Linq to SQL Test");
                string sqlCommand;

                // Insert Record
                sqlCommand = DapperSample.Properties.Resources.InsertCommand;
                Dapper.SqlMapper.Execute(conn, sqlCommand, model);

                // Select Record
                sqlCommand = DapperSample.Properties.Resources.SelectCommand;
                IEnumerable<ShowroomModel> modelList = Dapper.SqlMapper.Query<ShowroomModel>(conn, sqlCommand, new { ShowroomId = model.ShowroomId });
                model = modelList.ElementAt(0);

                // Update Record
                model.IsActive = true;
                sqlCommand = Properties.Resources.UpdateCommand;
                Dapper.SqlMapper.Execute(conn, sqlCommand, model);
            }
        }
    }
}