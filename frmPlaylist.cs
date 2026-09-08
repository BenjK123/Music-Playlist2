using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace Music_Playlist_Manager_Group42
{
    public partial class frmPlaylist : Form
    {
        public frmPlaylist()
        {
            InitializeComponent();
        }
        // DELIVERABLE 2: Store the entire playlist object instead of just a string name
        Playlist currentPlaylist = null;

        // DELIVERABLE 2: Constructor upgraded to accept the full Playlist object from the Home screen
        public frmPlaylist(Playlist playlistName)
        {
            InitializeComponent();
            currentPlaylist = playlistName;
        }
        private void UploadArtCover()
        {
            OpenFileDialog uploadArtCover = new OpenFileDialog();
            if (uploadArtCover.ShowDialog() == DialogResult.OK)
            {
                String fileName = uploadArtCover.FileName;
                pbxCoverArt.Image = Image.FromFile(fileName);
            }
        }
        private void backtohome()
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }
        
       

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            backtohome();
        }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            RefreshPlaylistStats();


            string fileName = currentPlaylist.PlaylistName + ".txt";
            lstSongs.Items.Clear();
            if (File.Exists(fileName))
            {
                string[] songs = File.ReadAllLines(fileName);
                for (int i = 0; i < songs.Length; i++)
                {
                    lstSongs.Items.Add(songs[i]);
                }
            }
        }

        // DELIVERABLE 2: Helper method to update playlist information labels automatically across the form
        private void RefreshPlaylistStats()
        {
            if (currentPlaylist != null)
            {
                // DELIVERABLE 2: Read the actual playlist title property directly from the object.
                lblPlaylistTitle.Text = "PLAYLIST TITLE: " + currentPlaylist.PlaylistName;
                // DELIVERABLE 2: Pull the real timestamp date saved inside the object.
                lblCreationDate.Text = "CREATION DATE: " + currentPlaylist.CreationDate.ToShortDateString();
                // DELIVERABLE 2: Display the number of tracks dynamically from the songs collection list
                lblTrackCount.Text = "TRACK COUNT: " + currentPlaylist.Songs.Count.ToString();
            }
        }


        private void btnDeleteSong_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadArtCover_Click(object sender, EventArgs e)
        {
            UploadArtCover();
        }
    }
}
