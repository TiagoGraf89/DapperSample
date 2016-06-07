using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DapperSample
{
    class ADO
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
            // Initialize Connection
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                conn.Open();

                // Initialize Model
                ShowroomModel model = new ShowroomModel("Linq to SQL Test");
                string query;
 
                // Insert Record
                using (SqlCommand command = conn.CreateCommand())
                {
                    query = DapperSample.Properties.Resources.InsertCommand;
                    command.CommandText = query;
                    command.Parameters.Add("@ShowroomId", SqlDbType.UniqueIdentifier).Value = model.ShowroomId;
                    command.Parameters.Add("@ShowroomName", SqlDbType.VarChar).Value = model.ShowroomName;
                    command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = model.IsActive;
                    command.ExecuteNonQuery();
                }

                // Select Record
                using (SqlCommand command = conn.CreateCommand())
                {
                    query = DapperSample.Properties.Resources.SelectCommand;
                    command.CommandText = query;
                    command.Parameters.Add("@ShowroomId", SqlDbType.UniqueIdentifier).Value = model.ShowroomId;
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        model.ShowroomId = Guid.Parse(reader["ShowroomId"].ToString());
                        model.ShowroomName = reader["ShowroomName"].ToString();
                        model.IsActive = reader["IsActive"].ToString() == "1" ? true : false;
                    }
                    reader.Close();
                }

                // Update Record
                using (SqlCommand command = conn.CreateCommand())
                {
                    model.IsActive = true;
                    query = Properties.Resources.UpdateCommand;
                    command.CommandText = query;
                    command.Parameters.Add("@ShowroomId", SqlDbType.UniqueIdentifier).Value = model.ShowroomId;
                    command.Parameters.Add("@ShowroomName", SqlDbType.VarChar).Value = model.ShowroomName;
                    command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = model.IsActive;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}