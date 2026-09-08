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
        //Declaring variables
        string currentUser;
        int totalSongs = 0;
        //Method
        public frmHome(string userName)
        {
            InitializeComponent();

            currentUser = userName;

            lblWelcome.Text = "Welcome, " + currentUser + "!";

        }

       
        public void GoToPlaylist()
        {
            this.Hide();
            frmPlaylist myForm = new frmPlaylist();
            myForm.ShowDialog();
            this.Show();

        }

        //Method using the streamWrite to be able to save each playlist to the text file.
        private void SavePlaylist(string playlistName)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Playlists.txt", true);

                sw.WriteLine(playlistName);

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Method to load the existing playlists
        private void LoadPlaylists()
        {
            try
            {
                if (File.Exists("Playlists.txt"))
                {
                    StreamReader sr = new StreamReader("Playlists.txt");

                    while (!sr.EndOfStream)
                    {
                        lvPlaylist.Items.Add(sr.ReadLine());
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Loads the existing playlists
        private void frmHome_Load(object sender, EventArgs e)
        {
           LoadPlaylists();
        }


        private void UpdateStatistics()
        {
            lblTotalPlaylists.Text =
                "Total Playlists   : " + lvPlaylist.Items.Count;

            lblTotalSongs.Text =
                "Total Songs       : " + totalSongs;

        }

        private void IconChange()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)

                { picUser.Image = Image.FromFile(ofd.FileName); }
            }
        }

       
        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            if (txtPlaylistName.Text == "")
            {
                MessageBox.Show("Please enter a playlist name.");
                return;
            }

            else
            {
                ListViewItem item = new ListViewItem(txtPlaylistName.Text); // Create a new playlist item
                
                lvPlaylist.Items.Add(item); // Add the playlist to the ListView
                txtPlaylistName.Clear();

               UpdateStatistics();

               SavePlaylist(txtPlaylistName.Text); //Saves Playlist using SW Method
            }

        }
      
        private void btnRemovePlaylist_Click(object sender, EventArgs e)
        {
            if (lvPlaylist.Items.Count > 0)
                lvPlaylist.Items.Remove(lvPlaylist.SelectedItems[0]);
        }

        private void btnGoToPlaylist_Click(object sender, EventArgs e)
        {
            if (lvPlaylist.SelectedItems.Count > 0)
            {
                string playlistName = lvPlaylist.SelectedItems[0].Text;
                // DELIVERABLE 2: Turn the selected playlist name into an object before opening the playlist form
                Playlist chosenPlaylist = new Playlist(playlistName);
                frmPlaylist playlist = new frmPlaylist(chosenPlaylist);

                playlist.Show();
                this.Hide();
            }
        }

        private void lblIcon_Click(object sender, EventArgs e)
        {
            IconChange();
        }

        private void pbxArtCover1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())

            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)

                { pbxArtCover1.Image = Image.FromFile(ofd.FileName); }
            }
            
        }

        private void pbxArtCover2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())

            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)

                { pbxArtCover2.Image = Image.FromFile(ofd.FileName); }
            }
        }

        private void pbxArtCover3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())

            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)

                { pbxArtCover3.Image = Image.FromFile(ofd.FileName); }
            }
        }

        private void pbxArtCover4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())

            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)

                { pbxArtCover4.Image = Image.FromFile(ofd.FileName); }
            }
        }

        private void pbxArtCover5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())

            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)

                { pbxArtCover5.Image = Image.FromFile(ofd.FileName); }
            }
        }

    }
}
