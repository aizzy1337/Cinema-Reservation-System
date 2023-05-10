using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    internal class Screening
    {

        public int id { get; set; }
        public int movie_id { get; set; }
        public int room_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
    }
}
