using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Music_Playlist_Manager_Group42
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        string currentUser;
        public frmHome(string userName)
        {
            InitializeComponent();

            dgvPlaylists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            StatsInsights();

            currentUser = userName;

            lblWelcome.Text = "Welcome, " + currentUser + "!";

        }
        BindingList<Playlist> Playlists = new BindingList<Playlist>();
        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            string playlistName = txtPlaylistName.Text;
            if (playlistName == "")
            {
                MessageBox.Show("Please enter the name of your playlist!");
                return;
            }

            bool isFavorite = chkIsFavorite.Checked;
            Playlist playlist;
            playlist = new Playlist(playlistName, isFavorite);

            Playlists.Add(playlist);
            dgvPlaylists.DataSource = Playlists;

            txtPlaylistName.Clear();
            chkIsFavorite.Checked = false;

            StatsInsights();

        }

        private void btnUploadSong_Click(object sender, EventArgs e)
        {
            string songName = txtSongName.Text;
            string artist = txtArtist.Text;
            string album = txtAlbum.Text;
            string genre = txtGenre.Text;

            if (songName == "" || artist == "" || album == "" || genre == "")
            {
                MessageBox.Show("Please enter all fields!");
                return;
            }

            OpenFileDialog openAudio = new OpenFileDialog();

            if (openAudio.ShowDialog() == DialogResult.OK)
            {
                string audioFilePath = openAudio.FileName;

                Song song;
                song = new Song(songName, artist, album, genre, audioFilePath);

                for (int i = 0; i < dgvPlaylists.SelectedRows.Count; i++)
                {
                    int selectedIndex = dgvPlaylists.SelectedRows[i].Index;
                    Playlists[selectedIndex].Songs.Add(song);
                    Playlists[selectedIndex].NumOfSongs = Playlists[selectedIndex].Songs.Count;
                }

                dgvPlaylists.Refresh();

                StatsInsights();

                txtSongName.Clear();
                txtArtist.Clear();
                txtAlbum.Clear();
                txtGenre.Clear();

                MessageBox.Show("Song uploaded successfully!");
            }
        }
        private void StatsInsights()
        {
            int totalPlaylists = Playlists.Count;
            int totalSongs = 0;
            int emptyPlaylists = 0;

            for (int i = 0; i < Playlists.Count; i++)
            {
                int songCount = Playlists[i].Songs.Count;
                totalSongs += songCount;

                if (songCount == 0)
                {
                    emptyPlaylists++;
                }
            }

            lblTotalPlaylists.Text = "Total Playlists: " + totalPlaylists;
            lblTotalSongs.Text = "Total Songs: " + totalSongs;
            lblEmptyPlaylists.Text = "Empty Playlists: " + emptyPlaylists;
        }

        public void GoToPlaylist()
        {
            if (dgvPlaylists.SelectedRows.Count > 0)
            {
                // 1. Grab the full Playlist object linked to the selected row
                var selectedPlaylist = (Music_Playlist_Manager_Group42.Playlist)dgvPlaylists.SelectedRows[0].DataBoundItem;

                this.Hide();

                // 2. Pass the playlist directly to the updated constructor
                frmPlaylist myForm = new frmPlaylist(selectedPlaylist);

                myForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please select a playlist from the list first.");
            }
        }

        private void btnGoToPlaylist_Click(object sender, EventArgs e)
        {
            GoToPlaylist();
        }
    }
}
