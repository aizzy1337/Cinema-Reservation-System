using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    internal class Movie
    {

        public int id { get; set; }
        public string? title { get; set; }
        public string? director { get; set; }
        public string? cast { get; set; }
        public string? description { get; set; }
        public int duration_min { get; set; }
        public Image? poster { get; set;}

    }
}
