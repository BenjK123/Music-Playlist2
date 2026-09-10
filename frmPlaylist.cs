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
        //A constructor that will take in the song object from the home form.
        public frmPlaylist(Song song)
        {
            dgvSong.Rows.Add(song);
        }
        // DELIVERABLE 2: Store the entire playlist object instead of just a string name
        Playlist currentPlaylist = null;

        // DELIVERABLE 2: Constructor upgraded to accept the full Playlist object from the Home screen

        string artist, genre, album;
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
            home.ShowDialog();
            this.Hide();
        }
        
       

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            backtohome();
        }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            RefreshPlaylistStats(); 
            lblPlaylistTitle.Text = "PLAYLIST TITLE: " + currentPlaylist;


            string fileName = currentPlaylist + ".txt";

            lblCreationDate.Text = "CREATION DATE: " + DateTime.Now.ToShortDateString();


            // Add sorting options

            cbxSort.Items.Add("Song Title");

            cbxSort.Items.Add("Artist");

            cbxSort.Items.Add("Album");

            cbxSort.Items.Add("Genre");


            // Select the default option

            cbxSort.SelectedIndex = 0;


            // Run sorting when the user changes the option

            cbxSort.SelectedIndexChanged += cbxSort_SelectedIndexChanged;

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

        int selectedIndex;
        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            selectedIndex = dgvSong.CurrentCell.RowIndex;
            song_List.RemoveAt(selectedIndex);
            RefreshPlaylistStats();

        }

        private void btnUploadArtCover_Click(object sender, EventArgs e)
        {
            UploadArtCover();
        }
        BindingList<Song> song_List = new BindingList<Song>();
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if(txtGenre.Text=="" || txtArtist.Text=="" || txtAlbum.Text=="")
            {
                MessageBox.Show("Cannot add empty song !","Error!" +
                    "");
                return;

            }
            artist=txtArtist.Text;
            album=txtAlbum.Text;
            genre = txtGenre.Text;

            Song newSong = new Song();

            OpenFileDialog path = new OpenFileDialog();
            path.ShowDialog();

            newSong.Artist = artist;
            newSong.Album = album;
            newSong.Genre = genre;

            newSong.SongTitle = Path.GetFileName(path.FileName);
            newSong.FilePath = path.FileName;
            

            song_List.Add(newSong);


            dgvSong.DataSource = song_List;
            dgvSong.Columns["FilePath"].Visible = false;

            dgvSong.Columns["SongTitle"].Width = 600;

            Clear();
            RefreshPlaylistStats();
        }
        string selectedFile;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (dgvSong.CurrentRow == null )
            {
                MessageBox.Show("Please choose a song. This is empty!", "Error");
                return;
            }
            if ( dgvSong.SelectedRows.Count > 1)
            {
                MessageBox.Show("Select only one song.", "Error");
                return;
            }
            else
            {
                selectedFile = dgvSong.CurrentRow.Cells["FilePath"].Value.ToString();
                wmpMusicPlayer.URL = selectedFile;
                wmpMusicPlayer.Ctlcontrols.play();
            }
        }

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSort.SelectedItem.ToString() == "Song Title")

            {

                song_List = new BindingList<Song>(

                    song_List.OrderBy(song => song.SongTitle).ToList()

                );

            }

            else if (cbxSort.SelectedItem.ToString() == "Artist")

            {

                song_List = new BindingList<Song>(

                    song_List.OrderBy(song => song.Artist).ToList()

                );

            }

            else if (cbxSort.SelectedItem.ToString() == "Album")

            {

                song_List = new BindingList<Song>(

                    song_List.OrderBy(song => song.Album).ToList()

                );

            }

            else if (cbxSort.SelectedItem.ToString() == "Genre")

            {

                song_List = new BindingList<Song>(

                    song_List.OrderBy(song => song.Genre).ToList()

                );

            }


            // Update the DataGridView

            dgvSong.DataSource = song_List;


            dgvSong.Columns["FilePath"].Visible = false;

            dgvSong.Columns["SongTitle"].Width = 600;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpMusicPlayer.Ctlcontrols.pause();
        }
        public void Clear()
        {

            txtAlbum.Clear();
            txtArtist.Clear();
            txtGenre.Clear();

            txtArtist.Focus();  
        }
    }
}
