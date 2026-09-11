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
            this.cbxSort = new System.Windows.Forms.ComboBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.wmpMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusicPlayer)).BeginInit();
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
            this.lblinfo.Location = new System.Drawing.Point(316, 28);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(310, 52);
            this.lblinfo.TabIndex = 10;
            this.lblinfo.Text = "♫EDIT PLAYLIST ";
            // 
            // pbxCoverArt
            // 
            this.pbxCoverArt.Location = new System.Drawing.Point(5, 21);
            this.pbxCoverArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxCoverArt.Name = "pbxCoverArt";
            this.pbxCoverArt.Size = new System.Drawing.Size(287, 158);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(730, 260);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist Information";
            // 
            // btnUploadArtCover
            // 
            this.btnUploadArtCover.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnUploadArtCover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadArtCover.Location = new System.Drawing.Point(7, 199);
            this.btnUploadArtCover.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadArtCover.Name = "btnUploadArtCover";
            this.btnUploadArtCover.Size = new System.Drawing.Size(285, 54);
            this.btnUploadArtCover.TabIndex = 7;
            this.btnUploadArtCover.Text = "Upload Art Cover";
            this.btnUploadArtCover.UseVisualStyleBackColor = false;
            this.btnUploadArtCover.Click += new System.EventHandler(this.btnUploadArtCover_Click);
            // 
            // lblTrackCount
            // 
            this.lblTrackCount.AutoSize = true;
            this.lblTrackCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTrackCount.Location = new System.Drawing.Point(297, 121);
            this.lblTrackCount.Name = "lblTrackCount";
            this.lblTrackCount.Size = new System.Drawing.Size(194, 24);
            this.lblTrackCount.TabIndex = 6;
            this.lblTrackCount.Text = "🎶 Track Count: 0";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCreationDate.Location = new System.Drawing.Point(300, 80);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(157, 24);
            this.lblCreationDate.TabIndex = 5;
            this.lblCreationDate.Text = "CREATED DATE:";
            // 
            // lblPlaylistTitle
            // 
            this.lblPlaylistTitle.AutoSize = true;
            this.lblPlaylistTitle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblPlaylistTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblPlaylistTitle.Location = new System.Drawing.Point(297, 41);
            this.lblPlaylistTitle.Name = "lblPlaylistTitle";
            this.lblPlaylistTitle.Size = new System.Drawing.Size(166, 24);
            this.lblPlaylistTitle.TabIndex = 4;
            this.lblPlaylistTitle.Text = "PLAYLIST TITLE:";
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.BackColor = System.Drawing.Color.Teal;
            this.btnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHome.Location = new System.Drawing.Point(1, -1);
            this.btnBackToHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(145, 52);
            this.btnBackToHome.TabIndex = 11;
            this.btnBackToHome.Text = "⬅ Back to Home";
            this.btnBackToHome.UseVisualStyleBackColor = false;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // cbxSort
            // 
            this.cbxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.Location = new System.Drawing.Point(804, 93);
            this.cbxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(139, 28);
            this.cbxSort.TabIndex = 13;
            this.cbxSort.Text = "↕ Sort By";
            this.cbxSort.SelectedIndexChanged += new System.EventHandler(this.cbxSort_SelectedIndexChanged);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Red;
            this.btnPause.Location = new System.Drawing.Point(501, 567);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(241, 34);
            this.btnPause.TabIndex = 25;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Green;
            this.btnPlay.Location = new System.Drawing.Point(255, 566);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(240, 34);
            this.btnPlay.TabIndex = 24;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // dgvSong
            // 
            this.dgvSong.AllowUserToAddRows = false;
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Location = new System.Drawing.Point(12, 606);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.RowHeadersWidth = 51;
            this.dgvSong.RowTemplate.Height = 24;
            this.dgvSong.Size = new System.Drawing.Size(1029, 235);
            this.dgvSong.TabIndex = 23;
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSong.ForeColor = System.Drawing.Color.Green;
            this.btnAddSong.Location = new System.Drawing.Point(12, 566);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(237, 34);
            this.btnAddSong.TabIndex = 21;
            this.btnAddSong.Text = "➕ Add Song";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSong.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSong.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteSong.Location = new System.Drawing.Point(759, 567);
            this.btnDeleteSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(237, 34);
            this.btnDeleteSong.TabIndex = 22;
            this.btnDeleteSong.Text = "🗑 Delete Song";
            this.btnDeleteSong.UseVisualStyleBackColor = false;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // wmpMusicPlayer
            // 
            this.wmpMusicPlayer.Enabled = true;
            this.wmpMusicPlayer.Location = new System.Drawing.Point(12, 342);
            this.wmpMusicPlayer.Name = "wmpMusicPlayer";
            this.wmpMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusicPlayer.OcxState")));
            this.wmpMusicPlayer.Size = new System.Drawing.Size(1029, 219);
            this.wmpMusicPlayer.TabIndex = 26;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(975, 157);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(149, 27);
            this.txtArtist.TabIndex = 27;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(975, 277);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(149, 27);
            this.txtAlbum.TabIndex = 29;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(975, 216);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(149, 27);
            this.txtGenre.TabIndex = 28;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.BackColor = System.Drawing.SystemColors.Control;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(801, 157);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(59, 20);
            this.lblArtist.TabIndex = 30;
            this.lblArtist.Text = "Artist: ";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(801, 219);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(60, 20);
            this.lblGenre.TabIndex = 31;
            this.lblGenre.Text = "Genre:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(801, 283);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(66, 20);
            this.lblAlbum.TabIndex = 32;
            this.lblAlbum.Text = "Album: ";
            // 
            // frmPlaylist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 842);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.wmpMusicPlayer);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.dgvSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.cbxSort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPlaylist";
            this.Text = "frmPlaylist";
            this.Load += new System.EventHandler(this.frmPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusicPlayer)).EndInit();
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
        private System.Windows.Forms.ComboBox cbxSort;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnDeleteSong;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusicPlayer;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAlbum;
    }
}