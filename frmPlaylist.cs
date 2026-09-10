using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Music_Playlist_Manager_Group42
{
    public partial class frmPlaylist : Form
    {
        // One unified property to keep track of the active playlist
        public Playlist CurrentPlaylist { get; set; }

        BindingList<Song> song_List = new BindingList<Song>();
        string artist, genre, album;
        string selectedFile;
        int selectedIndex;

        // Default constructor (required by designer tool)
        public frmPlaylist()
        {
            InitializeComponent();
        }

        // The ONLY constructor that handles receiving the playlist from the Home form
        public frmPlaylist(Playlist selectedPlaylist)
        {
            InitializeComponent();

            // Save the playlist reference
            this.CurrentPlaylist = selectedPlaylist;
            this.Text = selectedPlaylist.PlaylistName;

            // Load any existing songs from the playlist object into the BindingList
            if (this.CurrentPlaylist.Songs != null)
            {
                song_List = new BindingList<Song>(this.CurrentPlaylist.Songs);
            }
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
            // Bind the song list to the grid view
            dgvSong.DataSource = song_List;

            if (dgvSong.Columns["FilePath"] != null)
                dgvSong.Columns["FilePath"].Visible = false;

            if (dgvSong.Columns["SongTitle"] != null)
                dgvSong.Columns["SongTitle"].Width = 600;

            RefreshPlaylistStats();


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

        private void RefreshPlaylistStats()
        {
            if (CurrentPlaylist != null)
            {
                // Sync the collection count
                CurrentPlaylist.Songs = song_List.ToList();
                CurrentPlaylist.NumOfSongs = song_List.Count;

                lblPlaylistTitle.Text = "PLAYLIST TITLE: " + CurrentPlaylist.PlaylistName;
                lblCreationDate.Text = "CREATION DATE: " + CurrentPlaylist.CreationDate.ToShortDateString();
                lblTrackCount.Text = "TRACK COUNT: " + CurrentPlaylist.NumOfSongs.ToString();
            }
        }

        
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
        
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if(txtGenre.Text=="" || txtArtist.Text=="" || txtAlbum.Text=="")
            {
                MessageBox.Show("Please fill in all the fields!","Error!");
                return;

            }
            artist=txtArtist.Text;
            album=txtAlbum.Text;
            genre = txtGenre.Text;

            Song newSong = new Song();

            OpenFileDialog path = new OpenFileDialog();
            path.Filter = "Audio Files|*.mp3;*.wav;*.wma;*.m4a;*.flac|All Files|*.*";
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
        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dgvSong.CurrentCell.Value.ToString()))
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
