using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Music_Playlist_Manager_Group42
{
    [Serializable]
    public class Playlist
    {
        //data members
        private string mPlaylistName;
        private DateTime mCreationDate;
        private List<Song> mSongs;

        //constructor
        public Playlist(string playlistName)
        {
            mPlaylistName = playlistName;
            mCreationDate = DateTime.Now;
            mSongs = new List<Song>();
        }

        public Playlist()
        {
            mSongs = new List<Song>();
        }

        //methods
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public bool RemoveSong(Song song)
        {
            return Songs.Remove(song);
        }
        //properties
        public string PlaylistName
        {
            get { return mPlaylistName; }
            set { mPlaylistName = value; }
        }

        public DateTime CreationDate
        {
            get { return mCreationDate; }
            set { mCreationDate = value; }
        }

        public List<Song> Songs
        {
            get { return mSongs; }
            set { mSongs = value; }
        }

    }
}