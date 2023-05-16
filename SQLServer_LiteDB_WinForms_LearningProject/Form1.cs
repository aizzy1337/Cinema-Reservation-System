using System.Drawing.Printing;
using static System.Reflection.Metadata.BlobBuilder;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public partial class mainApplication : Form
       { 

        public mainApplication()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            showMovies();
        }

        private void dateForwardButton_Click(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Parse(dateLabel.Text).AddDays(1).ToString("dd/MM/yyyy");
            showMovies();
        }

        private void dateBackwardButton_Click(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Parse(dateLabel.Text).AddDays(-1).ToString("dd/MM/yyyy");
            showMovies();
        }

        private void showMovies()
        {
            this.moviesShowLayoutPanel.Controls.Clear();

            List<Screening> screeningListToday = screeningData.getScreeningByDate(DateTime.Parse(dateLabel.Text));

            foreach (Screening screening in screeningListToday) {

                var movie = moviesData.getMovieByScreeningId(screening.id);
                var picture = moviesData.getPictureByMovieId(movie.id);
                var _room = roomData.getRoomByScreeningId(screening.id);

                var title = new System.Windows.Forms.Label();
                var director = new System.Windows.Forms.Label();
                var cast = new System.Windows.Forms.Label();
                var description = new System.Windows.Forms.Label();
                var duration = new System.Windows.Forms.Label();
                var image = new System.Windows.Forms.PictureBox();
                var button = new System.Windows.Forms.Button();
                var panel = new System.Windows.Forms.FlowLayoutPanel();
                var start = new System.Windows.Forms.Label();
                var end = new System.Windows.Forms.Label();
                var room = new System.Windows.Forms.Label();

                title.Dock = System.Windows.Forms.DockStyle.Top;
                title.Font = new System.Drawing.Font("Roboto Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                title.Location = new System.Drawing.Point(0, 0);
                title.Name = movie.id.ToString();
                title.Text = movie.title;
                title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                title.AutoSize = true;
                title.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);

                director.Dock = System.Windows.Forms.DockStyle.Top;
                director.Font = new System.Drawing.Font("Roboto Black", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                director.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                director.Location = new System.Drawing.Point(0, 0);
                director.Name = movie.id.ToString();
                director.Text = "Re¿yser: " + movie.director;
                director.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                director.AutoSize = true;
                director.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);

                description.Dock = System.Windows.Forms.DockStyle.Top;
                description.Font = new System.Drawing.Font("Roboto Black", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                description.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                description.Location = new System.Drawing.Point(0, 0);
                description.Name = movie.id.ToString();
                description.Text = "Opis: " + movie.description;
                description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                description.AutoSize = true;

                cast.Dock = System.Windows.Forms.DockStyle.Top;
                cast.Font = new System.Drawing.Font("Roboto Black", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                cast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                cast.Location = new System.Drawing.Point(0, 0);
                cast.Name = movie.id.ToString();
                cast.Text = "Obsada: " + movie.cast;
                cast.AutoSize = true;
                cast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;


                duration.Dock = System.Windows.Forms.DockStyle.Top;
                duration.Font = new System.Drawing.Font("Roboto Black", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                duration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                duration.Location = new System.Drawing.Point(0, 0);
                duration.Name = movie.id.ToString();
                duration.Text = "D³ugoœæ: " + movie.duration_min.ToString() + " minut";
                duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                duration.AutoSize = true;

                start.Dock = System.Windows.Forms.DockStyle.Top;
                start.Font = new System.Drawing.Font("Roboto Black", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                start.Location = new System.Drawing.Point(0, 0);
                start.Name = screening.id.ToString();
                start.Text = "Start: " + screening.start_time.ToShortTimeString();
                start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                start.AutoSize = true;

                end.Dock = System.Windows.Forms.DockStyle.Top;
                end.Font = new System.Drawing.Font("Roboto Black", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                end.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                end.Location = new System.Drawing.Point(0, 0);
                end.Name = screening.id.ToString();
                end.Text = "Start: " + screening.end_time.ToShortTimeString();
                end.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                end.AutoSize = true;

                room.Dock = System.Windows.Forms.DockStyle.Top;
                room.Font = new System.Drawing.Font("Roboto Black", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                room.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                room.Location = new System.Drawing.Point(0, 0);
                room.Name = _room.id.ToString();
                room.Text = _room.name;
                room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                room.AutoSize = true;

                image.Width = 200;
                image.Height = 200;
                image.Image = picture.poster;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Name = movie.id.ToString();

                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                button.Location = new System.Drawing.Point(0, 0);
                button.Name = screening.id.ToString();
                button.Size = new System.Drawing.Size(200, 30);
                button.Text = "Kup bilet";
                button.UseVisualStyleBackColor = true;
                button.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
                button.Click += new System.EventHandler(pickMovieButton_Click);

                panel.FlowDirection = FlowDirection.TopDown;
                panel.Name = movie.id.ToString();
                panel.Padding = new System.Windows.Forms.Padding(20);
                panel.Margin = new System.Windows.Forms.Padding(45,20,20,20);
                panel.Size = new System.Drawing.Size(245, 500);
                panel.BackColor = System.Drawing.Color.FromArgb(0,0,50);

                panel.Controls.Add(image);
                panel.Controls.Add(title);
                panel.Controls.Add(director);
                panel.Controls.Add(description);
                panel.Controls.Add(cast);
                panel.Controls.Add(duration);
                panel.Controls.Add(start);
                panel.Controls.Add(end);
                panel.Controls.Add(room);
                panel.Controls.Add(button);

                this.moviesShowLayoutPanel.Controls.Add(panel);

            }

        }

        void pickMovieButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            this.Controls.Remove(repertuarLabel);
            this.Controls.Remove(dateLayoutPanel);
            this.Controls.Remove(moviePickLayoutPanel);
            this.Controls.Remove(moviesShowLayoutPanel);

            this.Controls.Add(roomLabel);
            var room = roomData.getRoomByScreeningId(Int32.Parse(button.Name.ToString()));
            roomLabel.Text = room.name;
            showSeats(room.id);
        }

        private void showSeats(int roomId)
        {

        }
    }
}