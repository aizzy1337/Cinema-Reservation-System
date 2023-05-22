namespace SQLServer_LiteDB_WinForms_LearningProject
{
    partial class AdministratorPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.screeningMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.movieMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.roomMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.screeningSplitConatiner = new System.Windows.Forms.SplitContainer();
            this.allScrenningsListView = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.start_time = new System.Windows.Forms.ColumnHeader();
            this.end_time = new System.Windows.Forms.ColumnHeader();
            this.movieID = new System.Windows.Forms.ColumnHeader();
            this.roomID = new System.Windows.Forms.ColumnHeader();
            this.allScreeningsLabel = new System.Windows.Forms.Label();
            this.addScreeningButton = new System.Windows.Forms.Button();
            this.roomPickComboBox = new System.Windows.Forms.ComboBox();
            this.roomIdLabel = new System.Windows.Forms.Label();
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.movieIdLabel = new System.Windows.Forms.Label();
            this.startTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pickStartDateLabel = new System.Windows.Forms.Label();
            this.addScreeningLabel = new System.Windows.Forms.Label();
            this.moviesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.moviesListView = new System.Windows.Forms.ListView();
            this.Poster = new System.Windows.Forms.ColumnHeader();
            this.movie_id = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Director = new System.Windows.Forms.ColumnHeader();
            this.Cast = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.Duration = new System.Windows.Forms.ColumnHeader();
            this.movieLabel = new System.Windows.Forms.Label();
            this.dropImagesPanel = new System.Windows.Forms.Panel();
            this.posterLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.castTextBox = new System.Windows.Forms.TextBox();
            this.castLabel = new System.Windows.Forms.Label();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.movieAddButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addMovieLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.roomsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.roomsListView = new System.Windows.Forms.ListView();
            this.room_id = new System.Windows.Forms.ColumnHeader();
            this.roomName = new System.Windows.Forms.ColumnHeader();
            this.noOfSeats = new System.Windows.Forms.ColumnHeader();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.noOfSeatsInRowTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.seatsNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addRoomLabel = new System.Windows.Forms.Label();
            this.topMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screeningSplitConatiner)).BeginInit();
            this.screeningSplitConatiner.Panel1.SuspendLayout();
            this.screeningSplitConatiner.Panel2.SuspendLayout();
            this.screeningSplitConatiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesSplitContainer)).BeginInit();
            this.moviesSplitContainer.Panel1.SuspendLayout();
            this.moviesSplitContainer.Panel2.SuspendLayout();
            this.moviesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsSplitContainer)).BeginInit();
            this.roomsSplitContainer.Panel1.SuspendLayout();
            this.roomsSplitContainer.Panel2.SuspendLayout();
            this.roomsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenuStrip
            // 
            this.topMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.topMenuStrip.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screeningMenuButton,
            this.movieMenuButton,
            this.roomMenuButton});
            this.topMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.topMenuStrip.Size = new System.Drawing.Size(1257, 33);
            this.topMenuStrip.TabIndex = 0;
            this.topMenuStrip.Text = "Menu";
            // 
            // screeningMenuButton
            // 
            this.screeningMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.screeningMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.screeningMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.screeningMenuButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.screeningMenuButton.Name = "screeningMenuButton";
            this.screeningMenuButton.Size = new System.Drawing.Size(73, 27);
            this.screeningMenuButton.Text = "Seans";
            this.screeningMenuButton.Click += new System.EventHandler(this.screeningMenuButton_Click);
            // 
            // movieMenuButton
            // 
            this.movieMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.movieMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.movieMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movieMenuButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.movieMenuButton.Name = "movieMenuButton";
            this.movieMenuButton.Size = new System.Drawing.Size(60, 27);
            this.movieMenuButton.Text = "Film";
            this.movieMenuButton.Click += new System.EventHandler(this.movieMenuButton_Click);
            // 
            // roomMenuButton
            // 
            this.roomMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.roomMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.roomMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomMenuButton.Name = "roomMenuButton";
            this.roomMenuButton.Size = new System.Drawing.Size(58, 27);
            this.roomMenuButton.Text = "Sala";
            this.roomMenuButton.Click += new System.EventHandler(this.roomMenuButton_Click);
            // 
            // screeningSplitConatiner
            // 
            this.screeningSplitConatiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screeningSplitConatiner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.screeningSplitConatiner.Location = new System.Drawing.Point(0, 33);
            this.screeningSplitConatiner.Margin = new System.Windows.Forms.Padding(5);
            this.screeningSplitConatiner.Name = "screeningSplitConatiner";
            // 
            // screeningSplitConatiner.Panel1
            // 
            this.screeningSplitConatiner.Panel1.Controls.Add(this.allScrenningsListView);
            this.screeningSplitConatiner.Panel1.Controls.Add(this.allScreeningsLabel);
            // 
            // screeningSplitConatiner.Panel2
            // 
            this.screeningSplitConatiner.Panel2.Controls.Add(this.addScreeningButton);
            this.screeningSplitConatiner.Panel2.Controls.Add(this.roomPickComboBox);
            this.screeningSplitConatiner.Panel2.Controls.Add(this.roomIdLabel);
            this.screeningSplitConatiner.Panel2.Controls.Add(this.movieComboBox);
            this.screeningSplitConatiner.Panel2.Controls.Add(this.movieIdLabel);
            this.screeningSplitConatiner.Panel2.Controls.Add(this.startTimeDatePicker);
            this.screeningSplitConatiner.Panel2.Controls.Add(this.pickStartDateLabel);
            this.screeningSplitConatiner.Panel2.Controls.Add(this.addScreeningLabel);
            this.screeningSplitConatiner.Size = new System.Drawing.Size(1257, 657);
            this.screeningSplitConatiner.SplitterDistance = 611;
            this.screeningSplitConatiner.SplitterWidth = 6;
            this.screeningSplitConatiner.TabIndex = 1;
            // 
            // allScrenningsListView
            // 
            this.allScrenningsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(84)))));
            this.allScrenningsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allScrenningsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.start_time,
            this.end_time,
            this.movieID,
            this.roomID});
            this.allScrenningsListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.allScrenningsListView.ForeColor = System.Drawing.SystemColors.Window;
            this.allScrenningsListView.FullRowSelect = true;
            this.allScrenningsListView.Location = new System.Drawing.Point(0, 63);
            this.allScrenningsListView.MultiSelect = false;
            this.allScrenningsListView.Name = "allScrenningsListView";
            this.allScrenningsListView.Size = new System.Drawing.Size(611, 594);
            this.allScrenningsListView.TabIndex = 1;
            this.allScrenningsListView.UseCompatibleStateImageBehavior = false;
            this.allScrenningsListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // start_time
            // 
            this.start_time.Text = "START";
            this.start_time.Width = 190;
            // 
            // end_time
            // 
            this.end_time.Text = "KONIEC";
            this.end_time.Width = 190;
            // 
            // movieID
            // 
            this.movieID.Text = "ID FILMU";
            this.movieID.Width = 90;
            // 
            // roomID
            // 
            this.roomID.Text = "ID SALI";
            this.roomID.Width = 75;
            // 
            // allScreeningsLabel
            // 
            this.allScreeningsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.allScreeningsLabel.Location = new System.Drawing.Point(0, 0);
            this.allScreeningsLabel.Name = "allScreeningsLabel";
            this.allScreeningsLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.allScreeningsLabel.Size = new System.Drawing.Size(611, 63);
            this.allScreeningsLabel.TabIndex = 0;
            this.allScreeningsLabel.Text = "Wszystkie seanse";
            this.allScreeningsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addScreeningButton
            // 
            this.addScreeningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addScreeningButton.Location = new System.Drawing.Point(244, 481);
            this.addScreeningButton.Name = "addScreeningButton";
            this.addScreeningButton.Size = new System.Drawing.Size(146, 36);
            this.addScreeningButton.TabIndex = 8;
            this.addScreeningButton.Text = "Dodaj seans";
            this.addScreeningButton.UseVisualStyleBackColor = true;
            this.addScreeningButton.Click += new System.EventHandler(this.addScreeningButton_Click);
            // 
            // roomPickComboBox
            // 
            this.roomPickComboBox.FormattingEnabled = true;
            this.roomPickComboBox.Location = new System.Drawing.Point(194, 397);
            this.roomPickComboBox.Name = "roomPickComboBox";
            this.roomPickComboBox.Size = new System.Drawing.Size(256, 31);
            this.roomPickComboBox.TabIndex = 7;
            this.roomPickComboBox.DropDown += new System.EventHandler(this.roomPickComboBox_DropDown);
            // 
            // roomIdLabel
            // 
            this.roomIdLabel.AutoSize = true;
            this.roomIdLabel.Location = new System.Drawing.Point(258, 360);
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(117, 23);
            this.roomIdLabel.TabIndex = 6;
            this.roomIdLabel.Text = "Wybierz salę";
            // 
            // movieComboBox
            // 
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Location = new System.Drawing.Point(194, 289);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(256, 31);
            this.movieComboBox.TabIndex = 5;
            this.movieComboBox.DropDown += new System.EventHandler(this.movieComboBox_DropDown);
            // 
            // movieIdLabel
            // 
            this.movieIdLabel.AutoSize = true;
            this.movieIdLabel.Location = new System.Drawing.Point(258, 254);
            this.movieIdLabel.Name = "movieIdLabel";
            this.movieIdLabel.Size = new System.Drawing.Size(115, 23);
            this.movieIdLabel.TabIndex = 4;
            this.movieIdLabel.Text = "Wybierz film";
            // 
            // startTimeDatePicker
            // 
            this.startTimeDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.startTimeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeDatePicker.Location = new System.Drawing.Point(194, 185);
            this.startTimeDatePicker.Name = "startTimeDatePicker";
            this.startTimeDatePicker.ShowUpDown = true;
            this.startTimeDatePicker.Size = new System.Drawing.Size(256, 30);
            this.startTimeDatePicker.TabIndex = 3;
            // 
            // pickStartDateLabel
            // 
            this.pickStartDateLabel.AutoSize = true;
            this.pickStartDateLabel.Location = new System.Drawing.Point(194, 144);
            this.pickStartDateLabel.Name = "pickStartDateLabel";
            this.pickStartDateLabel.Size = new System.Drawing.Size(256, 23);
            this.pickStartDateLabel.TabIndex = 2;
            this.pickStartDateLabel.Text = "Wybierz godzinę rozpoczęcia";
            this.pickStartDateLabel.Click += new System.EventHandler(this.pickStartDateLabel_Click);
            // 
            // addScreeningLabel
            // 
            this.addScreeningLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addScreeningLabel.Location = new System.Drawing.Point(0, 0);
            this.addScreeningLabel.Name = "addScreeningLabel";
            this.addScreeningLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.addScreeningLabel.Size = new System.Drawing.Size(640, 63);
            this.addScreeningLabel.TabIndex = 1;
            this.addScreeningLabel.Text = "Dodaj seans";
            this.addScreeningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moviesSplitContainer
            // 
            this.moviesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesSplitContainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moviesSplitContainer.Location = new System.Drawing.Point(0, 33);
            this.moviesSplitContainer.Margin = new System.Windows.Forms.Padding(5);
            this.moviesSplitContainer.Name = "moviesSplitContainer";
            // 
            // moviesSplitContainer.Panel1
            // 
            this.moviesSplitContainer.Panel1.Controls.Add(this.moviesListView);
            this.moviesSplitContainer.Panel1.Controls.Add(this.movieLabel);
            // 
            // moviesSplitContainer.Panel2
            // 
            this.moviesSplitContainer.Panel2.Controls.Add(this.dropImagesPanel);
            this.moviesSplitContainer.Panel2.Controls.Add(this.posterLabel);
            this.moviesSplitContainer.Panel2.Controls.Add(this.durationTextBox);
            this.moviesSplitContainer.Panel2.Controls.Add(this.durationLabel);
            this.moviesSplitContainer.Panel2.Controls.Add(this.descriptionTextBox);
            this.moviesSplitContainer.Panel2.Controls.Add(this.descriptionLabel);
            this.moviesSplitContainer.Panel2.Controls.Add(this.castTextBox);
            this.moviesSplitContainer.Panel2.Controls.Add(this.castLabel);
            this.moviesSplitContainer.Panel2.Controls.Add(this.directorTextBox);
            this.moviesSplitContainer.Panel2.Controls.Add(this.directorLabel);
            this.moviesSplitContainer.Panel2.Controls.Add(this.titleTextBox);
            this.moviesSplitContainer.Panel2.Controls.Add(this.movieAddButton);
            this.moviesSplitContainer.Panel2.Controls.Add(this.titleLabel);
            this.moviesSplitContainer.Panel2.Controls.Add(this.addMovieLabel);
            this.moviesSplitContainer.Size = new System.Drawing.Size(1257, 657);
            this.moviesSplitContainer.SplitterDistance = 803;
            this.moviesSplitContainer.SplitterWidth = 6;
            this.moviesSplitContainer.TabIndex = 2;
            // 
            // moviesListView
            // 
            this.moviesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(84)))));
            this.moviesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moviesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Poster,
            this.movie_id,
            this.Title,
            this.Director,
            this.Cast,
            this.Description,
            this.Duration});
            this.moviesListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.moviesListView.ForeColor = System.Drawing.SystemColors.Window;
            this.moviesListView.FullRowSelect = true;
            this.moviesListView.Location = new System.Drawing.Point(0, 63);
            this.moviesListView.MultiSelect = false;
            this.moviesListView.Name = "moviesListView";
            this.moviesListView.Size = new System.Drawing.Size(803, 594);
            this.moviesListView.TabIndex = 1;
            this.moviesListView.UseCompatibleStateImageBehavior = false;
            this.moviesListView.View = System.Windows.Forms.View.Details;
            // 
            // Poster
            // 
            this.Poster.Text = "Plakat";
            // 
            // movie_id
            // 
            this.movie_id.Text = "ID";
            // 
            // Title
            // 
            this.Title.Text = "TYTUŁ";
            this.Title.Width = 190;
            // 
            // Director
            // 
            this.Director.Text = "Reżyser";
            this.Director.Width = 190;
            // 
            // Cast
            // 
            this.Cast.Text = "Obsada";
            this.Cast.Width = 90;
            // 
            // Description
            // 
            this.Description.Text = "Opis";
            this.Description.Width = 75;
            // 
            // Duration
            // 
            this.Duration.Text = "Długość (min)";
            // 
            // movieLabel
            // 
            this.movieLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movieLabel.Location = new System.Drawing.Point(0, 0);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.movieLabel.Size = new System.Drawing.Size(803, 63);
            this.movieLabel.TabIndex = 0;
            this.movieLabel.Text = "Wszystkie filmy";
            this.movieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropImagesPanel
            // 
            this.dropImagesPanel.AllowDrop = true;
            this.dropImagesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.dropImagesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dropImagesPanel.Location = new System.Drawing.Point(143, 516);
            this.dropImagesPanel.Name = "dropImagesPanel";
            this.dropImagesPanel.Size = new System.Drawing.Size(197, 58);
            this.dropImagesPanel.TabIndex = 19;
            this.dropImagesPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropImagesPanel_DragDrop);
            this.dropImagesPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropImagesPanel_DragEnter);
            // 
            // posterLabel
            // 
            this.posterLabel.AutoSize = true;
            this.posterLabel.Location = new System.Drawing.Point(159, 490);
            this.posterLabel.Name = "posterLabel";
            this.posterLabel.Size = new System.Drawing.Size(105, 15);
            this.posterLabel.TabIndex = 18;
            this.posterLabel.Text = "Plakat (Upuść plik)";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(103, 430);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(255, 23);
            this.durationTextBox.TabIndex = 17;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(172, 404);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(82, 15);
            this.durationLabel.TabIndex = 16;
            this.durationLabel.Text = "Długość (min)";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(103, 343);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(255, 23);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(202, 317);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(31, 15);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Opis";
            // 
            // castTextBox
            // 
            this.castTextBox.Location = new System.Drawing.Point(103, 262);
            this.castTextBox.Name = "castTextBox";
            this.castTextBox.Size = new System.Drawing.Size(255, 23);
            this.castTextBox.TabIndex = 13;
            // 
            // castLabel
            // 
            this.castLabel.AutoSize = true;
            this.castLabel.Location = new System.Drawing.Point(190, 236);
            this.castLabel.Name = "castLabel";
            this.castLabel.Size = new System.Drawing.Size(47, 15);
            this.castLabel.TabIndex = 12;
            this.castLabel.Text = "Obsada";
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(103, 174);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(255, 23);
            this.directorTextBox.TabIndex = 11;
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(190, 148);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(46, 15);
            this.directorLabel.TabIndex = 10;
            this.directorLabel.Text = "Reżyser";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(103, 89);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(255, 23);
            this.titleTextBox.TabIndex = 9;
            // 
            // movieAddButton
            // 
            this.movieAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieAddButton.Location = new System.Drawing.Point(172, 594);
            this.movieAddButton.Name = "movieAddButton";
            this.movieAddButton.Size = new System.Drawing.Size(130, 36);
            this.movieAddButton.TabIndex = 8;
            this.movieAddButton.Text = "Dodaj film";
            this.movieAddButton.UseVisualStyleBackColor = true;
            this.movieAddButton.Click += new System.EventHandler(this.movieAddButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(201, 63);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 15);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Tytuł";
            // 
            // addMovieLabel
            // 
            this.addMovieLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addMovieLabel.Location = new System.Drawing.Point(0, 0);
            this.addMovieLabel.Name = "addMovieLabel";
            this.addMovieLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.addMovieLabel.Size = new System.Drawing.Size(448, 63);
            this.addMovieLabel.TabIndex = 1;
            this.addMovieLabel.Text = "Dodaj film";
            this.addMovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Dodaj plik";
            // 
            // roomsSplitContainer
            // 
            this.roomsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsSplitContainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomsSplitContainer.Location = new System.Drawing.Point(0, 33);
            this.roomsSplitContainer.Margin = new System.Windows.Forms.Padding(5);
            this.roomsSplitContainer.Name = "roomsSplitContainer";
            // 
            // roomsSplitContainer.Panel1
            // 
            this.roomsSplitContainer.Panel1.Controls.Add(this.roomsListView);
            this.roomsSplitContainer.Panel1.Controls.Add(this.roomsLabel);
            // 
            // roomsSplitContainer.Panel2
            // 
            this.roomsSplitContainer.Panel2.Controls.Add(this.noOfSeatsInRowTextBox);
            this.roomsSplitContainer.Panel2.Controls.Add(this.label1);
            this.roomsSplitContainer.Panel2.Controls.Add(this.noOfSeatsTextBox);
            this.roomsSplitContainer.Panel2.Controls.Add(this.roomNameTextBox);
            this.roomsSplitContainer.Panel2.Controls.Add(this.addRoomButton);
            this.roomsSplitContainer.Panel2.Controls.Add(this.seatsNumberLabel);
            this.roomsSplitContainer.Panel2.Controls.Add(this.label4);
            this.roomsSplitContainer.Panel2.Controls.Add(this.addRoomLabel);
            this.roomsSplitContainer.Size = new System.Drawing.Size(1257, 657);
            this.roomsSplitContainer.SplitterDistance = 614;
            this.roomsSplitContainer.SplitterWidth = 6;
            this.roomsSplitContainer.TabIndex = 2;
            // 
            // roomsListView
            // 
            this.roomsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(84)))));
            this.roomsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.room_id,
            this.roomName,
            this.noOfSeats});
            this.roomsListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsListView.ForeColor = System.Drawing.SystemColors.Window;
            this.roomsListView.FullRowSelect = true;
            this.roomsListView.Location = new System.Drawing.Point(0, 63);
            this.roomsListView.MultiSelect = false;
            this.roomsListView.Name = "roomsListView";
            this.roomsListView.Size = new System.Drawing.Size(614, 594);
            this.roomsListView.TabIndex = 1;
            this.roomsListView.UseCompatibleStateImageBehavior = false;
            this.roomsListView.View = System.Windows.Forms.View.Details;
            // 
            // room_id
            // 
            this.room_id.Text = "ID";
            // 
            // roomName
            // 
            this.roomName.Text = "NAZWA";
            this.roomName.Width = 190;
            // 
            // noOfSeats
            // 
            this.noOfSeats.Text = "LICZBA MIEJSC";
            this.noOfSeats.Width = 190;
            // 
            // roomsLabel
            // 
            this.roomsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsLabel.Location = new System.Drawing.Point(0, 0);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.roomsLabel.Size = new System.Drawing.Size(614, 63);
            this.roomsLabel.TabIndex = 0;
            this.roomsLabel.Text = "Wszystkie sale";
            this.roomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noOfSeatsInRowTextBox
            // 
            this.noOfSeatsInRowTextBox.Location = new System.Drawing.Point(211, 318);
            this.noOfSeatsInRowTextBox.Name = "noOfSeatsInRowTextBox";
            this.noOfSeatsInRowTextBox.Size = new System.Drawing.Size(227, 23);
            this.noOfSeatsInRowTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Liczba miejsc w rzędzie";
            // 
            // noOfSeatsTextBox
            // 
            this.noOfSeatsTextBox.Location = new System.Drawing.Point(211, 225);
            this.noOfSeatsTextBox.Name = "noOfSeatsTextBox";
            this.noOfSeatsTextBox.Size = new System.Drawing.Size(227, 23);
            this.noOfSeatsTextBox.TabIndex = 10;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(211, 133);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(227, 23);
            this.roomNameTextBox.TabIndex = 9;
            // 
            // addRoomButton
            // 
            this.addRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomButton.Location = new System.Drawing.Point(254, 406);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(146, 36);
            this.addRoomButton.TabIndex = 8;
            this.addRoomButton.Text = "Dodaj salę";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // seatsNumberLabel
            // 
            this.seatsNumberLabel.AutoSize = true;
            this.seatsNumberLabel.Location = new System.Drawing.Point(263, 199);
            this.seatsNumberLabel.Name = "seatsNumberLabel";
            this.seatsNumberLabel.Size = new System.Drawing.Size(77, 15);
            this.seatsNumberLabel.TabIndex = 4;
            this.seatsNumberLabel.Text = "Liczba miejsc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nazwa sali";
            // 
            // addRoomLabel
            // 
            this.addRoomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRoomLabel.Location = new System.Drawing.Point(0, 0);
            this.addRoomLabel.Name = "addRoomLabel";
            this.addRoomLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.addRoomLabel.Size = new System.Drawing.Size(637, 63);
            this.addRoomLabel.TabIndex = 1;
            this.addRoomLabel.Text = "Dodaj salę";
            this.addRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdministratorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1257, 690);
            this.Controls.Add(this.screeningSplitConatiner);
            this.Controls.Add(this.topMenuStrip);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.topMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdministratorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorPanel";
            this.Load += new System.EventHandler(this.AdministratorPanel_Load);
            this.topMenuStrip.ResumeLayout(false);
            this.topMenuStrip.PerformLayout();
            this.screeningSplitConatiner.Panel1.ResumeLayout(false);
            this.screeningSplitConatiner.Panel2.ResumeLayout(false);
            this.screeningSplitConatiner.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screeningSplitConatiner)).EndInit();
            this.screeningSplitConatiner.ResumeLayout(false);
            this.moviesSplitContainer.Panel1.ResumeLayout(false);
            this.moviesSplitContainer.Panel2.ResumeLayout(false);
            this.moviesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesSplitContainer)).EndInit();
            this.moviesSplitContainer.ResumeLayout(false);
            this.roomsSplitContainer.Panel1.ResumeLayout(false);
            this.roomsSplitContainer.Panel2.ResumeLayout(false);
            this.roomsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsSplitContainer)).EndInit();
            this.roomsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip topMenuStrip;
        private ToolStripMenuItem screeningMenuButton;
        private ToolStripMenuItem movieMenuButton;
        private ToolStripMenuItem roomMenuButton;
        private SplitContainer screeningSplitConatiner;
        private ListView allScrenningsListView;
        private Label allScreeningsLabel;
        private ColumnHeader ID;
        private ColumnHeader start_time;
        private ColumnHeader end_time;
        private ColumnHeader movieID;
        private ColumnHeader roomID;
        private DateTimePicker startTimeDatePicker;
        private Label pickStartDateLabel;
        private Label addScreeningLabel;
        private ComboBox movieComboBox;
        private Label movieIdLabel;
        private ComboBox roomPickComboBox;
        private Label roomIdLabel;
        private Button addScreeningButton;
        private SplitContainer moviesSplitContainer;
        private ListView moviesListView;
        private ColumnHeader movie_id;
        private ColumnHeader Title;
        private ColumnHeader Director;
        private ColumnHeader Cast;
        private ColumnHeader Description;
        private Label movieLabel;
        private Button movieAddButton;
        private Label titleLabel;
        private Label addMovieLabel;
        private ColumnHeader Duration;
        private ColumnHeader Poster;
        private Label posterLabel;
        private TextBox durationTextBox;
        private Label durationLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox castTextBox;
        private Label castLabel;
        private TextBox directorTextBox;
        private Label directorLabel;
        private TextBox titleTextBox;
        private OpenFileDialog openFileDialog1;
        private Panel dropImagesPanel;
        private SplitContainer roomsSplitContainer;
        private ListView roomsListView;
        private ColumnHeader room_id;
        private ColumnHeader roomName;
        private ColumnHeader noOfSeats;
        private Label roomsLabel;
        private Button addRoomButton;
        private Label seatsNumberLabel;
        private Label label4;
        private Label addRoomLabel;
        private TextBox roomNameTextBox;
        private TextBox noOfSeatsInRowTextBox;
        private Label label1;
        private TextBox noOfSeatsTextBox;
    }
}