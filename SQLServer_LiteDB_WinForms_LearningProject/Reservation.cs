using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    internal class Reservation
    {

        public int id { get; set; }
        public int screening_id { get; set; }
        public bool reserved { get; set; }
        public bool paid { get; set; }
        public bool active { get; set; }

    }
}
