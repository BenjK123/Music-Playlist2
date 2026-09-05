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
            this.btnRemovePlaylist = new System.Windows.Forms.Button();
            this.gbxStatsSelection = new System.Windows.Forms.GroupBox();
            this.pnlLetterhead = new System.Windows.Forms.Panel();
            this.lvPlaylist = new System.Windows.Forms.ListView();
            this.Playlists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbxArtCover1 = new System.Windows.Forms.PictureBox();
            this.pbxArtCover5 = new System.Windows.Forms.PictureBox();
            this.pbxArtCover4 = new System.Windows.Forms.PictureBox();
            this.pbxArtCover3 = new System.Windows.Forms.PictureBox();
            this.pbxArtCover2 = new System.Windows.Forms.PictureBox();
            this.lblPic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.gbxStatsSelection.SuspendLayout();
            this.pnlLetterhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblWelcome.Location = new System.Drawing.Point(375, 178);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(146, 38);
            this.lblWelcome.TabIndex = 17;
            this.lblWelcome.Text = "Welcome ";
            // 
            // picUser
            // 
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(356, 1);
            this.picUser.Margin = new System.Windows.Forms.Padding(4);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(107, 100);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // btnGoToPlaylist
            // 
            this.btnGoToPlaylist.BackColor = System.Drawing.Color.Teal;
            this.btnGoToPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGoToPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnGoToPlaylist.Location = new System.Drawing.Point(110, 544);
            this.btnGoToPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoToPlaylist.Name = "btnGoToPlaylist";
            this.btnGoToPlaylist.Size = new System.Drawing.Size(235, 37);
            this.btnGoToPlaylist.TabIndex = 22;
            this.btnGoToPlaylist.Text = "Go to Playlist";
            this.btnGoToPlaylist.UseVisualStyleBackColor = false;
            this.btnGoToPlaylist.Click += new System.EventHandler(this.btnGoToPlaylist_Click);
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.BackColor = System.Drawing.Color.Teal;
            this.btnCreatePlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCreatePlaylist.ForeColor = System.Drawing.Color.White;
            this.btnCreatePlaylist.Location = new System.Drawing.Point(353, 544);
            this.btnCreatePlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(274, 37);
            this.btnCreatePlaylist.TabIndex = 21;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = false;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(410, 260);
            this.txtPlaylistName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(355, 22);
            this.txtPlaylistName.TabIndex = 20;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblPlaylistName.Location = new System.Drawing.Point(243, 257);
            this.lblPlaylistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(142, 25);
            this.lblPlaylistName.TabIndex = 19;
            this.lblPlaylistName.Text = "Playlist Title: ";
            // 
            // lblTotalPlaylists
            // 
            this.lblTotalPlaylists.AutoSize = true;
            this.lblTotalPlaylists.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalPlaylists.Location = new System.Drawing.Point(20, 33);
            this.lblTotalPlaylists.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPlaylists.Name = "lblTotalPlaylists";
            this.lblTotalPlaylists.Size = new System.Drawing.Size(123, 23);
            this.lblTotalPlaylists.TabIndex = 9;
            this.lblTotalPlaylists.Text = "Total Playlists:";
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.AutoSize = true;
            this.lblTotalSongs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalSongs.Location = new System.Drawing.Point(290, 32);
            this.lblTotalSongs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(107, 23);
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
            this.lblIcon.Location = new System.Drawing.Point(449, 126);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(116, 25);
            this.lblIcon.TabIndex = 25;
            this.lblIcon.Text = "Change Icon";
            this.lblIcon.Click += new System.EventHandler(this.lblIcon_Click);
            // 
            // btnRemovePlaylist
            // 
            this.btnRemovePlaylist.BackColor = System.Drawing.Color.Teal;
            this.btnRemovePlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRemovePlaylist.ForeColor = System.Drawing.Color.White;
            this.btnRemovePlaylist.Location = new System.Drawing.Point(634, 544);
            this.btnRemovePlaylist.Name = "btnRemovePlaylist";
            this.btnRemovePlaylist.Size = new System.Drawing.Size(293, 35);
            this.btnRemovePlaylist.TabIndex = 24;
            this.btnRemovePlaylist.Text = "Remove Playlist";
            this.btnRemovePlaylist.UseVisualStyleBackColor = false;
            this.btnRemovePlaylist.Click += new System.EventHandler(this.btnRemovePlaylist_Click);
            // 
            // gbxStatsSelection
            // 
            this.gbxStatsSelection.Controls.Add(this.lblTotalPlaylists);
            this.gbxStatsSelection.Controls.Add(this.lblTotalSongs);
            this.gbxStatsSelection.Location = new System.Drawing.Point(203, 605);
            this.gbxStatsSelection.Name = "gbxStatsSelection";
            this.gbxStatsSelection.Size = new System.Drawing.Size(604, 91);
            this.gbxStatsSelection.TabIndex = 23;
            this.gbxStatsSelection.TabStop = false;
            this.gbxStatsSelection.Text = "Statistics Section";
            // 
            // pnlLetterhead
            // 
            this.pnlLetterhead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.pnlLetterhead.Controls.Add(this.picUser);
            this.pnlLetterhead.Location = new System.Drawing.Point(101, 23);
            this.pnlLetterhead.Name = "pnlLetterhead";
            this.pnlLetterhead.Size = new System.Drawing.Size(854, 100);
            this.pnlLetterhead.TabIndex = 26;
            // 
            // lvPlaylist
            // 
            this.lvPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Playlists});
            this.lvPlaylist.HideSelection = false;
            this.lvPlaylist.Location = new System.Drawing.Point(110, 290);
            this.lvPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.lvPlaylist.Name = "lvPlaylist";
            this.lvPlaylist.Size = new System.Drawing.Size(655, 231);
            this.lvPlaylist.TabIndex = 27;
            this.lvPlaylist.UseCompatibleStateImageBehavior = false;
            this.lvPlaylist.View = System.Windows.Forms.View.Details;
            // 
            // Playlists
            // 
            this.Playlists.Text = "Playlist";
            this.Playlists.Width = 475;
            // 
            // pbxArtCover1
            // 
            this.pbxArtCover1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxArtCover1.Location = new System.Drawing.Point(820, 329);
            this.pbxArtCover1.Name = "pbxArtCover1";
            this.pbxArtCover1.Size = new System.Drawing.Size(62, 29);
            this.pbxArtCover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArtCover1.TabIndex = 35;
            this.pbxArtCover1.TabStop = false;
            this.pbxArtCover1.Click += new System.EventHandler(this.pbxArtCover1_Click);
            // 
            // pbxArtCover5
            // 
            this.pbxArtCover5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxArtCover5.Location = new System.Drawing.Point(820, 469);
            this.pbxArtCover5.Name = "pbxArtCover5";
            this.pbxArtCover5.Size = new System.Drawing.Size(62, 29);
            this.pbxArtCover5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArtCover5.TabIndex = 37;
            this.pbxArtCover5.TabStop = false;
            this.pbxArtCover5.Click += new System.EventHandler(this.pbxArtCover5_Click);
            // 
            // pbxArtCover4
            // 
            this.pbxArtCover4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxArtCover4.Location = new System.Drawing.Point(820, 434);
            this.pbxArtCover4.Name = "pbxArtCover4";
            this.pbxArtCover4.Size = new System.Drawing.Size(62, 29);
            this.pbxArtCover4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArtCover4.TabIndex = 38;
            this.pbxArtCover4.TabStop = false;
            this.pbxArtCover4.Click += new System.EventHandler(this.pbxArtCover4_Click);
            // 
            // pbxArtCover3
            // 
            this.pbxArtCover3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxArtCover3.Location = new System.Drawing.Point(820, 399);
            this.pbxArtCover3.Name = "pbxArtCover3";
            this.pbxArtCover3.Size = new System.Drawing.Size(62, 29);
            this.pbxArtCover3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArtCover3.TabIndex = 39;
            this.pbxArtCover3.TabStop = false;
            this.pbxArtCover3.Click += new System.EventHandler(this.pbxArtCover3_Click);
            // 
            // pbxArtCover2
            // 
            this.pbxArtCover2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxArtCover2.Location = new System.Drawing.Point(820, 364);
            this.pbxArtCover2.Name = "pbxArtCover2";
            this.pbxArtCover2.Size = new System.Drawing.Size(62, 29);
            this.pbxArtCover2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArtCover2.TabIndex = 40;
            this.pbxArtCover2.TabStop = false;
            this.pbxArtCover2.Click += new System.EventHandler(this.pbxArtCover2_Click);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblPic.Location = new System.Drawing.Point(772, 290);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(294, 23);
            this.lblPic.TabIndex = 41;
            this.lblPic.Text = "Click on the picturebox to insert Cover Art";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 712);
            this.Controls.Add(this.lblPic);
            this.Controls.Add(this.pbxArtCover2);
            this.Controls.Add(this.pbxArtCover3);
            this.Controls.Add(this.pbxArtCover4);
            this.Controls.Add(this.pbxArtCover5);
            this.Controls.Add(this.pbxArtCover1);
            this.Controls.Add(this.lvPlaylist);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnGoToPlaylist);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.btnRemovePlaylist);
            this.Controls.Add(this.gbxStatsSelection);
            this.Controls.Add(this.pnlLetterhead);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.gbxStatsSelection.ResumeLayout(false);
            this.gbxStatsSelection.PerformLayout();
            this.pnlLetterhead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtCover2)).EndInit();
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
        private System.Windows.Forms.Button btnRemovePlaylist;
        private System.Windows.Forms.GroupBox gbxStatsSelection;
        private System.Windows.Forms.Panel pnlLetterhead;
        private System.Windows.Forms.ListView lvPlaylist;
        private System.Windows.Forms.ColumnHeader Playlists;
        private System.Windows.Forms.PictureBox pbxArtCover1;
        private System.Windows.Forms.PictureBox pbxArtCover5;
        private System.Windows.Forms.PictureBox pbxArtCover4;
        private System.Windows.Forms.PictureBox pbxArtCover3;
        private System.Windows.Forms.PictureBox pbxArtCover2;
        private System.Windows.Forms.Label lblPic;
    }
}