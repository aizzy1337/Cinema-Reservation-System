﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public class Seats_Reserved
    {

        public int id { get; set; }
        public int seat_id { get; set; }
        public int reservation_id { get; set; }
        public int screening_id { get; set; }

    }

    public static class reservedSeatsData
    {
        public static List<Seats_Reserved> getAll()
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Seats_Reserved>("dbo.seats_reservedGetAll").ToList();

            }
        }

        public static List<Seats_Reserved> getReservedSeatsByScreeningId(int screeningId)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Seats_Reserved>("dbo.getReservedSeatsByScreeningId @screening_id", new { screening_id = screeningId }).ToList();

            }
        }
    }
}
