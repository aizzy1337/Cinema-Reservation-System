using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public class Room
    {

        public int id { get; set; }
        public string? name { get; set; }
        public int no_of_seats { get; set; }

    }

    public static class roomData
    {
        public static List<Room> getAll()
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Room>("dbo.roomGetAll").ToList();

            }
        }

        public static Room getRoomByScreeningId(int screeningId)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.QueryFirst<Room>("dbo.getRoomByScreeningId @screening_id", new { screening_id = screeningId });

            }
        }
    }
}
