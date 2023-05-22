using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public class Reservation
    {

        public int id { get; set; }
        public int screening_id { get; set; }
        public bool reserved { get; set; }
        public bool paid { get; set; }
        public bool active { get; set; }

    }

    public static class ReservationData
    {
        public static void insertReservation(int screeningID, int _reserved, int _paid, int _active)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                connection.Query("dbo.reservationInsert @screening_id, @reserved, @paid, @active", new { screening_id = screeningID, reserved = _reserved, paid = _paid, active = _active });

            }
        }

        public static List<Reservation> getReservationsByScreeningID(int screeningID)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Reservation>("dbo.getReservationsByScreeningId @screening_id", new { screening_id = screeningID }).ToList();

            }
        }
    }
}
