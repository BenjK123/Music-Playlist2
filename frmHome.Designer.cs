namespace Music_Playlist_Manager_Group42
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnGoToPlaylist = new System.Windows.Forms.Button();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.lblTotalPlaylists = new System.Windows.Forms.Label();
            this.lblTotalSongs = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblIcon = new System.Windows.Forms.Label();
            this.gbxStatsSelection = new System.Windows.Forms.GroupBox();
            this.lblEmptyPlaylists = new System.Windows.Forms.Label();
            this.pnlLetterhead = new System.Windows.Forms.Panel();
            this.dgvPlaylists = new System.Windows.Forms.DataGridView();
            this.btnUploadSong = new System.Windows.Forms.Button();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsFavorite = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.gbxStatsSelection.SuspendLayout();
            this.pnlLetterhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblWelcome.Location = new System.Drawing.Point(281, 145);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 30);
            this.lblWelcome.TabIndex = 17;
            this.lblWelcome.Text = "Welcome ";
            // 
            // picUser
            // 
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(267, 1);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(81, 82);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // btnGoToPlaylist
            // 
            this.btnGoToPlaylist.BackColor = System.Drawing.Color.Teal;
            this.btnGoToPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGoToPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnGoToPlaylist.Location = new System.Drawing.Point(12, 457);
            this.btnGoToPlaylist.Name = "btnGoToPlaylist";
            this.btnGoToPlaylist.Size = new System.Drawing.Size(176, 30);
            this.btnGoToPlaylist.TabIndex = 22;
            this.btnGoToPlaylist.Text = "Go to Playlist";
            this.btnGoToPlaylist.UseVisualStyleBackColor = false;
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.BackColor = System.Drawing.Color.Teal;
            this.btnCreatePlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCreatePlaylist.ForeColor = System.Drawing.Color.White;
            this.btnCreatePlaylist.Location = new System.Drawing.Point(306, 213);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(206, 30);
            this.btnCreatePlaylist.TabIndex = 21;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = false;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(128, 218);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(172, 20);
            this.txtPlaylistName.TabIndex = 20;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblPlaylistName.Location = new System.Drawing.Point(8, 218);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(114, 20);
            this.lblPlaylistName.TabIndex = 19;
            this.lblPlaylistName.Text = "Playlist Title: ";
            // 
            // lblTotalPlaylists
            // 
            this.lblTotalPlaylists.AutoSize = true;
            this.lblTotalPlaylists.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalPlaylists.Location = new System.Drawing.Point(15, 27);
            this.lblTotalPlaylists.Name = "lblTotalPlaylists";
            this.lblTotalPlaylists.Size = new System.Drawing.Size(104, 19);
            this.lblTotalPlaylists.TabIndex = 9;
            this.lblTotalPlaylists.Text = "Total Playlists:";
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.AutoSize = true;
            this.lblTotalSongs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalSongs.Location = new System.Drawing.Point(172, 27);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(90, 19);
            this.lblTotalSongs.TabIndex = 10;
            this.lblTotalSongs.Text = "Total Songs:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Screenshot 2026-08-09 105258.png");
            this.imageList1.Images.SetKeyName(1, "Screenshot 2026-08-09 105240.png");
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblIcon.Location = new System.Drawing.Point(337, 102);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(97, 20);
            this.lblIcon.TabIndex = 25;
            this.lblIcon.Text = "Change Icon";
            // 
            // gbxStatsSelection
            // 
            this.gbxStatsSelection.Controls.Add(this.lblEmptyPlaylists);
            this.gbxStatsSelection.Controls.Add(this.lblTotalPlaylists);
            this.gbxStatsSelection.Controls.Add(this.lblTotalSongs);
            this.gbxStatsSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStatsSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.gbxStatsSelection.Location = new System.Drawing.Point(18, 508);
            this.gbxStatsSelection.Margin = new System.Windows.Forms.Padding(2);
            this.gbxStatsSelection.Name = "gbxStatsSelection";
            this.gbxStatsSelection.Padding = new System.Windows.Forms.Padding(2);
            this.gbxStatsSelection.Size = new System.Drawing.Size(494, 74);
            this.gbxStatsSelection.TabIndex = 23;
            this.gbxStatsSelection.TabStop = false;
            this.gbxStatsSelection.Text = "Statistics Section";
            // 
            // lblEmptyPlaylists
            // 
            this.lblEmptyPlaylists.AutoSize = true;
            this.lblEmptyPlaylists.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEmptyPlaylists.Location = new System.Drawing.Point(303, 27);
            this.lblEmptyPlaylists.Name = "lblEmptyPlaylists";
            this.lblEmptyPlaylists.Size = new System.Drawing.Size(113, 19);
            this.lblEmptyPlaylists.TabIndex = 11;
            this.lblEmptyPlaylists.Text = "Empty Playlists:";
            // 
            // pnlLetterhead
            // 
            this.pnlLetterhead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.pnlLetterhead.Controls.Add(this.picUser);
            this.pnlLetterhead.Location = new System.Drawing.Point(76, 19);
            this.pnlLetterhead.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLetterhead.Name = "pnlLetterhead";
            this.pnlLetterhead.Size = new System.Drawing.Size(640, 81);
            this.pnlLetterhead.TabIndex = 26;
            // 
            // dgvPlaylists
            // 
            this.dgvPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylists.Location = new System.Drawing.Point(12, 249);
            this.dgvPlaylists.Name = "dgvPlaylists";
            this.dgvPlaylists.Size = new System.Drawing.Size(500, 202);
            this.dgvPlaylists.TabIndex = 27;
            // 
            // btnUploadSong
            // 
            this.btnUploadSong.BackColor = System.Drawing.Color.Teal;
            this.btnUploadSong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUploadSong.ForeColor = System.Drawing.Color.White;
            this.btnUploadSong.Location = new System.Drawing.Point(608, 457);
            this.btnUploadSong.Name = "btnUploadSong";
            this.btnUploadSong.Size = new System.Drawing.Size(176, 30);
            this.btnUploadSong.TabIndex = 28;
            this.btnUploadSong.Text = "Upload Song";
            this.btnUploadSong.UseVisualStyleBackColor = false;
            this.btnUploadSong.Click += new System.EventHandler(this.btnUploadSong_Click);
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(684, 249);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(100, 20);
            this.txtSongName.TabIndex = 29;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(684, 293);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 20);
            this.txtArtist.TabIndex = 30;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(684, 348);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(100, 20);
            this.txtAlbum.TabIndex = 31;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(684, 403);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(571, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Song Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(621, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Artist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(614, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Album:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(614, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Genre:";
            // 
            // chkIsFavorite
            // 
            this.chkIsFavorite.AutoSize = true;
            this.chkIsFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.chkIsFavorite.Location = new System.Drawing.Point(306, 190);
            this.chkIsFavorite.Name = "chkIsFavorite";
            this.chkIsFavorite.Size = new System.Drawing.Size(83, 20);
            this.chkIsFavorite.TabIndex = 37;
            this.chkIsFavorite.Text = "Favorite";
            this.chkIsFavorite.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 609);
            this.Controls.Add(this.chkIsFavorite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.btnUploadSong);
            this.Controls.Add(this.dgvPlaylists);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnGoToPlaylist);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.gbxStatsSelection);
            this.Controls.Add(this.pnlLetterhead);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.gbxStatsSelection.ResumeLayout(false);
            this.gbxStatsSelection.PerformLayout();
            this.pnlLetterhead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnGoToPlaylist;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label lblTotalPlaylists;
        private System.Windows.Forms.Label lblTotalSongs;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.GroupBox gbxStatsSelection;
        private System.Windows.Forms.Panel pnlLetterhead;
        private System.Windows.Forms.DataGridView dgvPlaylists;
        private System.Windows.Forms.Label lblEmptyPlaylists;
        private System.Windows.Forms.Button btnUploadSong;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsFavorite;
    }
}