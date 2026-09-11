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

            cmbView.SelectedIndex = 0;

            dgvPlaylists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            StatsInsights();

            currentUser = userName;

            lblWelcome.Text = "Welcome, " + currentUser + "!";

            LoadPlaylists();


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

            for (int i = 0; i < Playlists.Count; i++)
            {
                if (Playlists[i].PlaylistName == playlistName)
                {
                    MessageBox.Show("A playlist with that name already exists.");
                    return;
                }
            }

            Playlist playlist = new Playlist(playlistName, false);

            Playlists.Add(playlist);
            dgvPlaylists.DataSource = Playlists;

            txtPlaylistName.Clear();


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

            if (Playlists.Count == 0)
            {
                MessageBox.Show("Please create a playlist first.");
                return;
            }

            OpenFileDialog openAudio = new OpenFileDialog();
            openAudio.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

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

                SavePlaylists();
                dgvPlaylists.Refresh();

                StatsInsights();

                txtSongName.Clear();
                txtArtist.Clear();
                txtAlbum.Clear();
                txtGenre.Clear();

                MessageBox.Show("Song uploaded successfully");
            }
        }
        private void StatsInsights()
        {
            int totalPlaylists = Playlists.Count;
            int totalSongs = 0;
            int favouritePlaylists = 0;

            for (int i = 0; i < Playlists.Count; i++)
            {
                int songCount = Playlists[i].Songs.Count;
                totalSongs += songCount;

                if (Playlists[i].IsFavorite)
                {
                    favouritePlaylists++;
                }
            }

            lblTotalPlaylists.Text = "Total Playlists: " + totalPlaylists;
            lblTotalSongs.Text = "Total Songs: " + totalSongs;
            lblFavouritePlaylist.Text = "Total Favourite Playlist(s): " + favouritePlaylists.ToString();
        }

        private void SavePlaylists()
        {
            try
            {
                using (FileStream outFile = new FileStream("playlists.ser", FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    bFormatter.Serialize(outFile, Playlists);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        private void LoadPlaylists()
        {
            try
            {
                using (FileStream inFile = new FileStream("playlists.ser", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    Playlists.Clear();

                    BindingList<Playlist> holdList = (BindingList<Playlist>)bFormatter.Deserialize(inFile);

                    for (int i = 0; i < holdList.Count; i++)
                    {
                        Playlists.Add(holdList[i]);
                    }

                }
            }
            catch (FileNotFoundException)
            {
                // No file yet
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading: " + ex.Message);
            }

            dgvPlaylists.DataSource = Playlists;
        }
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbView.SelectedIndex == 0)
            {

                ShowAllPlaylists();
            }
            else if (cmbView.SelectedIndex == 1)
            {

                ShowFavouritesOnly();
            }
        }
        private void ShowAllPlaylists()
        {
            dgvPlaylists.DataSource = null;
            dgvPlaylists.DataSource = Playlists;
        }
        private void ShowFavouritesOnly()
        {
            BindingList<Playlist> favourites = new BindingList<Playlist>();

            for (int i = 0; i < Playlists.Count; i++)
            {
                if (Playlists[i].IsFavorite == true)
                {
                    favourites.Add(Playlists[i]);
                }
            }

            if (favourites.Count == 0)
            {
                MessageBox.Show("You have no favourite playlists.");
                // Reset to All Playlists
                cmbView.SelectedIndex = 0;
                return;
            }

            dgvPlaylists.DataSource = null;
            dgvPlaylists.DataSource = favourites;
        }

        private void btnRemovePlaylist_Click(object sender, EventArgs e)
        {
            if (dgvPlaylists.CurrentRow == null)
            {
                MessageBox.Show("Please select a playlist to remove.");
                return;
            }

            Playlist selected = (Playlist)dgvPlaylists.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show(
                "Delete '" + selected.PlaylistName + "'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                Playlists.Remove(selected);
                SavePlaylists();

                dgvPlaylists.DataSource = null;
                dgvPlaylists.DataSource = Playlists;

                StatsInsights();
                MessageBox.Show("Playlist removed.");
            }
        }

        private void btnGoToPlaylist_Click(object sender, EventArgs e)
        {
            if (dgvPlaylists.CurrentRow == null)
            {
                MessageBox.Show("Please select a playlist.");
                return;
            }

            Playlist selected = (Playlist)dgvPlaylists.CurrentRow.DataBoundItem;
            frmPlaylist playlistForm = new frmPlaylist(selected);
            this.Hide();
            playlistForm.ShowDialog();
            this.Show();

            // Refresh after closing
            SavePlaylists();
            StatsInsights();
        }

        private void chkIsFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvPlaylists.CurrentRow == null)
            {

                chkIsFavorite.Checked = false;
                return;
            }

            Playlist selected = (Playlist)dgvPlaylists.CurrentRow.DataBoundItem;


            selected.IsFavorite = chkIsFavorite.Checked;

            SavePlaylists();


            dgvPlaylists.Refresh();

            StatsInsights();
        }

        private void dgvPlaylists_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlaylists.CurrentRow == null)
            {
                chkIsFavorite.Checked = false;
                return;
            }

        }
    }
}
