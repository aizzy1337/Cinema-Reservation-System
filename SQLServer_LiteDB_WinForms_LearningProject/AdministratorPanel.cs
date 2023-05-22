using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public partial class AdministratorPanel : Form
    {
        private string[] files;

        public AdministratorPanel()
        {
            InitializeComponent();
        }

        private void screeningMenuButton_Click(object sender, EventArgs e)
        {
            loadScreenings();
            loadMoviesInComboBox();
            loadRoomsInComboBox();
            this.Controls.Add(screeningSplitConatiner);
            this.Controls.Remove(moviesSplitContainer);
            this.Controls.Remove(roomsSplitContainer);
            this.Controls.Add(this.topMenuStrip);
            
        }

        private void AdministratorPanel_Load(object sender, EventArgs e)
        {
            loadScreenings();
            loadMoviesInComboBox();
            loadRoomsInComboBox();
        }

        private void loadScreenings()
        {
            allScrenningsListView.Items.Clear();

            var allScreenings = screeningData.getAll();

            foreach (var screening in allScreenings)
            {
                string[] stringArray = {screening.id.ToString(), screening.start_time.ToString(),
                    screening.end_time.ToString(), screening.movie_id.ToString(), screening.room_id.ToString()};
                var listViewItem = new ListViewItem(stringArray);
                allScrenningsListView.Items.Add(listViewItem);
            }
        }

        private void pickStartDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void loadMoviesInComboBox()
        {
            movieComboBox.Items.Clear();

            var allMovies = moviesData.getAll();

            foreach (var movie in allMovies)
            {
                string movieString = movie.id.ToString() + " | " + movie.title + " | " + movie.duration_min.ToString() + " min";
                movieComboBox.Items.Add(movieString);
            }
        }

        private void loadRoomsInComboBox()
        {
            roomPickComboBox.Items.Clear();

            var allRooms = roomData.getAll();

            foreach (var room in allRooms)
            {
                string roomString = room.id.ToString() + " | " + room.name + " | " + room.no_of_seats.ToString() + " siedzeń";
                roomPickComboBox.Items.Add(roomString);
            }
        }

        private void movieComboBox_DropDown(object sender, EventArgs e)
        {
            loadMoviesInComboBox();
        }

        private void roomPickComboBox_DropDown(object sender, EventArgs e)
        {
            loadRoomsInComboBox();
        }

        private void deleteScreeningButton_Click(object sender, EventArgs e)
        {
            if(allScrenningsListView.SelectedItems.Count == 1)
            {

            }
            else
            {
                MessageBox.Show("Należy wybrać seans!");
            }
        }

        private void addScreeningButton_Click(object sender, EventArgs e)
        {
            if(movieComboBox.SelectedIndex > -1 && roomPickComboBox.SelectedIndex > -1)
            {
                var movie = movieComboBox.SelectedItem.ToString().Split(" ");
                var room = roomPickComboBox.SelectedItem.ToString().Split(" ");
                screeningData.insertScreening(Int32.Parse(movie[0]), Int32.Parse(room[0]), startTimeDatePicker.Value);
                loadScreenings();
            }
            else
            {
                MessageBox.Show("Należy wybrać wszystkie opcje!");
            }
        }

        private void dropImagesPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void dropImagesPanel_DragDrop(object sender, DragEventArgs e)
        {
            files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            dropImagesPanel.BackColor = Color.Green;
        }

        private void loadMovies()
        {
            moviesListView.Items.Clear();

           var allMovies = moviesData.getAll(); 
           var allMoviePictures = moviesData.getAllPictures();

            ImageList imageListSmall = new ImageList();
            imageListSmall.ImageSize = new Size(50, 50);


            foreach (var movie in allMoviePictures)
            {
                imageListSmall.Images.Add(movie.poster);
            }

            int i = 0;
            foreach (var movie in allMovies)
            {
                string[] stringArray = {
                movie.id.ToString(),
                movie.id.ToString(),
                movie.title,
                movie.director,
                movie.cast,
                movie.description,
                movie.duration_min.ToString(),
                };
                var listViewItem = new ListViewItem(stringArray, i);
                moviesListView.Items.Add(listViewItem);
                i++;
            }

            moviesListView.SmallImageList = imageListSmall;

        }

        private void movieAddButton_Click(object sender, EventArgs e)
        {
            if(titleTextBox.Text != "" && directorTextBox.Text != ""
                && castTextBox.Text != "" && descriptionTextBox.Text != ""
                && durationTextBox.Text != "" && files.Count() != 0)
            {
                moviesData.insertMovie(titleTextBox.Text, directorTextBox.Text, castTextBox.Text,
                    descriptionTextBox.Text, Int32.Parse(durationTextBox.Text), files[0]);
                loadMovies();
            }
            else
            {
                MessageBox.Show("Brakuje wartośći!");
            }
        }

        private void movieMenuButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(screeningSplitConatiner);
            this.Controls.Remove(roomsSplitContainer);
            this.Controls.Add(moviesSplitContainer);
            loadMovies();
            this.Controls.Add(this.topMenuStrip);
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            if (roomNameTextBox.Text != "" && noOfSeatsTextBox.Text != ""
                && noOfSeatsInRowTextBox.Text != "")
            {
                roomData.insertRoom(roomNameTextBox.Text, Int32.Parse(noOfSeatsTextBox.Text));

                var rooms = roomData.getAll();

                seatsData.insertSeats(rooms.Last().id, Int32.Parse(noOfSeatsTextBox.Text), 0, Int32.Parse(noOfSeatsInRowTextBox.Text));

                loadRooms();
            }
            else
            {
                MessageBox.Show("Brakuje wartośći!");
            }
        }

        private void loadRooms()
        {
            roomsListView.Items.Clear();

            var rooms = roomData.getAll();

            foreach (var room in rooms)
            {
                string[] stringArray = {
                room.id.ToString(),
                room.name,
                room.no_of_seats.ToString()
                };

                var listViewItem = new ListViewItem(stringArray);
                roomsListView.Items.Add(listViewItem);
            }

        }

        private void roomMenuButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(screeningSplitConatiner);
            this.Controls.Add(roomsSplitContainer);
            this.Controls.Remove(moviesSplitContainer);
            loadRooms();
            this.Controls.Add(this.topMenuStrip);
        }
    }
}
