namespace SQLServer_LiteDB_WinForms_LearningProject
{
    partial class mainApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.repertuarLabel = new System.Windows.Forms.Label();
            this.administratorLoginLabel = new System.Windows.Forms.Button();
            this.dateLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dateBackwardButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateForwardButton = new System.Windows.Forms.Button();
            this.moviePickLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.moviesShowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dateLayoutPanel.SuspendLayout();
            this.moviesShowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // repertuarLabel
            // 
            this.repertuarLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.repertuarLabel.Font = new System.Drawing.Font("Roboto Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.repertuarLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repertuarLabel.Location = new System.Drawing.Point(0, 0);
            this.repertuarLabel.Name = "repertuarLabel";
            this.repertuarLabel.Size = new System.Drawing.Size(1257, 80);
            this.repertuarLabel.TabIndex = 0;
            this.repertuarLabel.Text = "REPERTUAR";
            this.repertuarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // administratorLoginLabel
            // 
            this.administratorLoginLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.administratorLoginLabel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.administratorLoginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.administratorLoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.administratorLoginLabel.Location = new System.Drawing.Point(0, 650);
            this.administratorLoginLabel.Name = "administratorLoginLabel";
            this.administratorLoginLabel.Size = new System.Drawing.Size(1257, 40);
            this.administratorLoginLabel.TabIndex = 1;
            this.administratorLoginLabel.Text = "Zaloguj się jako administrator";
            this.administratorLoginLabel.UseVisualStyleBackColor = true;
            // 
            // dateLayoutPanel
            // 
            this.dateLayoutPanel.Controls.Add(this.dateBackwardButton);
            this.dateLayoutPanel.Controls.Add(this.dateLabel);
            this.dateLayoutPanel.Controls.Add(this.dateForwardButton);
            this.dateLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateLayoutPanel.Location = new System.Drawing.Point(0, 80);
            this.dateLayoutPanel.Name = "dateLayoutPanel";
            this.dateLayoutPanel.Size = new System.Drawing.Size(1257, 30);
            this.dateLayoutPanel.TabIndex = 2;
            // 
            // dateBackwardButton
            // 
            this.dateBackwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateBackwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateBackwardButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBackwardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateBackwardButton.Location = new System.Drawing.Point(460, 3);
            this.dateBackwardButton.Margin = new System.Windows.Forms.Padding(460, 3, 3, 3);
            this.dateBackwardButton.Name = "dateBackwardButton";
            this.dateBackwardButton.Size = new System.Drawing.Size(75, 27);
            this.dateBackwardButton.TabIndex = 2;
            this.dateBackwardButton.Text = "<";
            this.dateBackwardButton.UseVisualStyleBackColor = true;
            this.dateBackwardButton.Click += new System.EventHandler(this.dateBackwardButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLabel.Location = new System.Drawing.Point(541, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.dateLabel.Size = new System.Drawing.Size(175, 33);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "00.00.0000";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateForwardButton
            // 
            this.dateForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateForwardButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateForwardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateForwardButton.Location = new System.Drawing.Point(722, 3);
            this.dateForwardButton.Name = "dateForwardButton";
            this.dateForwardButton.Size = new System.Drawing.Size(75, 27);
            this.dateForwardButton.TabIndex = 1;
            this.dateForwardButton.Text = ">";
            this.dateForwardButton.UseVisualStyleBackColor = true;
            this.dateForwardButton.Click += new System.EventHandler(this.dateForwardButton_Click);
            // 
            // moviePickLayoutPanel
            // 
            this.moviePickLayoutPanel.AutoScroll = true;
            this.moviePickLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviePickLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.moviePickLayoutPanel.Name = "moviePickLayoutPanel";
            this.moviePickLayoutPanel.Size = new System.Drawing.Size(1257, 0);
            this.moviePickLayoutPanel.TabIndex = 3;
            // 
            // moviesShowLayoutPanel
            // 
            this.moviesShowLayoutPanel.Controls.Add(this.moviePickLayoutPanel);
            this.moviesShowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesShowLayoutPanel.Location = new System.Drawing.Point(0, 110);
            this.moviesShowLayoutPanel.Name = "moviesShowLayoutPanel";
            this.moviesShowLayoutPanel.Size = new System.Drawing.Size(1257, 540);
            this.moviesShowLayoutPanel.TabIndex = 4;
            // 
            // mainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1257, 690);
            this.Controls.Add(this.moviesShowLayoutPanel);
            this.Controls.Add(this.dateLayoutPanel);
            this.Controls.Add(this.administratorLoginLabel);
            this.Controls.Add(this.repertuarLabel);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainApplication";
            this.Text = "Kino XYZ";
            this.dateLayoutPanel.ResumeLayout(false);
            this.dateLayoutPanel.PerformLayout();
            this.moviesShowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label repertuarLabel;
        private Button administratorLoginLabel;
        private FlowLayoutPanel dateLayoutPanel;
        private Button dateBackwardButton;
        private Label dateLabel;
        private Button dateForwardButton;
        private FlowLayoutPanel moviePickLayoutPanel;
        private FlowLayoutPanel moviesShowLayoutPanel;
    }
}