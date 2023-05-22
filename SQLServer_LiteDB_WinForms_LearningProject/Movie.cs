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

        public static void insertMovie(string _title, string _director, string _cast, string _description, int _duration_min, string file)
        {
            using (var connection = new SqlConnection(DatabaseConnectionHelper.connectionString("SQLServer")))
            {

                connection.Query("dbo.movieInsert @title, @director, @cast, @description, @duration_min", new { title = _title, director = _director, cast = _cast, description = _description, duration_min = _duration_min });

            }

            var movies = getAll();

            using (var connection = new LiteDatabase(DatabaseConnectionHelper.connectionString("LiteDB_Pictures")))
            {
                connection.FileStorage.Upload(movies.Last().id.ToString(), file);
            }
        }
    }
}