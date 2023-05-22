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

        public static void insertSeats(int roomId, int numberOfSeats, int numberOfRows, int numberOfSeatsInOneRow)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {
                int stop = 1;

                numberOfRows = (numberOfSeats / numberOfSeatsInOneRow) + 1;

                for (int i = 1; i <= numberOfRows; i++)
                {
                    for (int j = 1; j <= numberOfSeatsInOneRow; j++)
                    {
                        if (stop <= numberOfSeats)
                        {
                            connection.Query("dbo.seatsInsert @row, @number, @room_id", new { row = i, number = stop, room_id = roomId });
                        }
                        else break;
                        stop++;
                    }
                }

            }
        }
    }
}
