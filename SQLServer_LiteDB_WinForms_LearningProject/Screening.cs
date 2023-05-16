using Dapper;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public class Screening
    {

        public int id { get; set; }
        public int movie_id { get; set; }
        public int room_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
    }

    public static class screeningData
    {
        public static List<Screening> getAll()
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Screening>("dbo.screeningGetAll").ToList();

            }
        }

        public static List<Screening> getScreeningByDate(DateTime _date)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Screening>("dbo.getScreeningByDate @date", new { date = _date }).ToList();

            }
        }
    }
}
