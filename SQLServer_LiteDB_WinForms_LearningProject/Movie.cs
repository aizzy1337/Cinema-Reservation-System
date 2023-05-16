using Dapper;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public string cast { get; set; }
        public string description { get; set; }
        public int duration_min { get; set; }
    }

    public class moviePicture
    {
        public int id { get; set; }
        public Image poster { get; set; }
    }

    public static class moviesData
    {
        public static List<Movie> getAll()
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.Query<Movie>("dbo.movieGetAll").ToList();

            }
        }

        public static List<moviePicture> getAllPictures()
        {
            List<moviePicture> tempList = new List<moviePicture>();

            using (var connection = new LiteDatabase(DatabaseConnectionHelper.connectionString("LiteDB_Pictures")))
            {
                var images = connection.FileStorage.FindAll();
                Stream imageStream = new MemoryStream();

                foreach (var image in images)
                {
                    image.CopyTo(imageStream);
                    tempList.Add(new moviePicture { id = Int32.Parse(image.Id), poster = Image.FromStream(imageStream) });
                }
            }

            return tempList;
        }

        public static moviePicture getPictureByMovieId(int movieId)
        {
            moviePicture tempMovie = new moviePicture();

            using (var connection = new LiteDatabase(DatabaseConnectionHelper.connectionString("LiteDB_Pictures")))
            {
                var image = connection.FileStorage.FindById(movieId.ToString());
                Stream imageStream = new MemoryStream();

                image.CopyTo(imageStream);
                tempMovie = new moviePicture { id = Int32.Parse(image.Id), poster = Image.FromStream(imageStream) };
            }

            return tempMovie;
        }

        public static Movie getMovieByScreeningId(int screeningId)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                return connection.QueryFirst<Movie>("dbo.getMovieByScreeningId @screening_id", new { screening_id = screeningId });

            }
        }
    }
}

