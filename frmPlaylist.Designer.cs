namespace Music_Playlist_Manager_Group42
{
    partial class frmPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaylist));
            this.lblinfo = new System.Windows.Forms.Label();
            this.pbxCoverArt = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUploadArtCover = new System.Windows.Forms.Button();
            this.lblTrackCount = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblPlaylistTitle = new System.Windows.Forms.Label();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.cbxSort = new System.Windows.Forms.ComboBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblinfo.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblinfo.Location = new System.Drawing.Point(235, 32);
            this.lblinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(248, 42);
            this.lblinfo.TabIndex = 10;
            this.lblinfo.Text = "♫EDIT PLAYLIST ";
            // 
            // pbxCoverArt
            // 
            this.pbxCoverArt.Location = new System.Drawing.Point(4, 17);
            this.pbxCoverArt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxCoverArt.Name = "pbxCoverArt";
            this.pbxCoverArt.Size = new System.Drawing.Size(215, 128);
            this.pbxCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCoverArt.TabIndex = 2;
            this.pbxCoverArt.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.btnUploadArtCover);
            this.groupBox1.Controls.Add(this.lblTrackCount);
            this.groupBox1.Controls.Add(this.lblCreationDate);
            this.groupBox1.Controls.Add(this.lblPlaylistTitle);
            this.groupBox1.Controls.Add(this.pbxCoverArt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(87, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(554, 211);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist Information";
            // 
            // btnUploadArtCover
            // 
            this.btnUploadArtCover.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnUploadArtCover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadArtCover.Location = new System.Drawing.Point(5, 162);
            this.btnUploadArtCover.Name = "btnUploadArtCover";
            this.btnUploadArtCover.Size = new System.Drawing.Size(214, 44);
            this.btnUploadArtCover.TabIndex = 7;
            this.btnUploadArtCover.Text = "Upload Art Cover";
            this.btnUploadArtCover.UseVisualStyleBackColor = false;
            this.btnUploadArtCover.Click += new System.EventHandler(this.btnUploadArtCover_Click);
            // 
            // lblTrackCount
            // 
            this.lblTrackCount.AutoSize = true;
            this.lblTrackCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTrackCount.Location = new System.Drawing.Point(223, 98);
            this.lblTrackCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrackCount.Name = "lblTrackCount";
            this.lblTrackCount.Size = new System.Drawing.Size(154, 19);
            this.lblTrackCount.TabIndex = 6;
            this.lblTrackCount.Text = "🎶 Track Count: 0";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCreationDate.Location = new System.Drawing.Point(225, 65);
            this.lblCreationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(125, 19);
            this.lblCreationDate.TabIndex = 5;
            this.lblCreationDate.Text = "CREATED DATE:";
            // 
            // lblPlaylistTitle
            // 
            this.lblPlaylistTitle.AutoSize = true;
            this.lblPlaylistTitle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblPlaylistTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblPlaylistTitle.Location = new System.Drawing.Point(223, 33);
            this.lblPlaylistTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaylistTitle.Name = "lblPlaylistTitle";
            this.lblPlaylistTitle.Size = new System.Drawing.Size(135, 19);
            this.lblPlaylistTitle.TabIndex = 4;
            this.lblPlaylistTitle.Text = "PLAYLIST TITLE:";
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.BackColor = System.Drawing.Color.Teal;
            this.btnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHome.Location = new System.Drawing.Point(1, -1);
            this.btnBackToHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(109, 42);
            this.btnBackToHome.TabIndex = 11;
            this.btnBackToHome.Text = "⬅ Back to Home";
            this.btnBackToHome.UseVisualStyleBackColor = false;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // lstSongs
            // 
            this.lstSongs.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(87, 322);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(331, 173);
            this.lstSongs.TabIndex = 16;
            // 
            // cbxSort
            // 
            this.cbxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.Location = new System.Drawing.Point(200, 505);
            this.cbxSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(105, 24);
            this.cbxSort.TabIndex = 13;
            this.cbxSort.Text = "↕ Sort By";
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSong.ForeColor = System.Drawing.Color.Green;
            this.btnAddSong.Location = new System.Drawing.Point(87, 505);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(109, 42);
            this.btnAddSong.TabIndex = 14;
            this.btnAddSong.Text = "➕ Add Song";
            this.btnAddSong.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSong.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSong.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteSong.Location = new System.Drawing.Point(309, 505);
            this.btnDeleteSong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(109, 41);
            this.btnDeleteSong.TabIndex = 15;
            this.btnDeleteSong.Text = "🗑 Delete Song";
            this.btnDeleteSong.UseVisualStyleBackColor = false;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 560);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.cbxSort);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnDeleteSong);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPlaylist";
            this.Text = "frmPlaylist";
            this.Load += new System.EventHandler(this.frmPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.PictureBox pbxCoverArt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUploadArtCover;
        private System.Windows.Forms.Label lblTrackCount;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblPlaylistTitle;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.ComboBox cbxSort;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnDeleteSong;
    }
}