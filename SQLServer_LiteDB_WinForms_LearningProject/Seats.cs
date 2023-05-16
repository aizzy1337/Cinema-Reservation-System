using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public class Seats
    {

        public int id { get; set; }
        public int row { get; set; }
        public int number { get; set; }
        public int room_id { get; set; }

    }

    public static class seatsData
    {
        public static List<Seats> getAll()
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Seats>("dbo.seatsGetAll").ToList();

            }
        }

        public static List<Seats> getSeatsByRoomId(int roomId)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Seats>("dbo.getSeatsByRoomId @room_id", new { room_id = roomId }).ToList();

            }
        }
    }
}
