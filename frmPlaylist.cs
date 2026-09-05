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

        String currentPlaylist = "";
        public frmPlaylist(String playlistName)
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
            
            lblPlaylistTitle.Text = "PLAYLIST TITLE: " + currentPlaylist;

            string fileName = currentPlaylist + ".txt";
           lblCreationDate.Text = "CREATION DATE: " + DateTime.Now.ToShortDateString();


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

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUploadArtCover_Click(object sender, EventArgs e)
        {
            UploadArtCover();
        }
    }
}
