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
        private string mPlaylistName;
        private List<Song> mSongs;
        private int mNumOfSongs;
        private DateTime mCreationDate;
        private bool mIsFavorite;

        public string PlaylistName
        {
            get { return mPlaylistName; }
            set { mPlaylistName = value; }
        }

        public List<Song> Songs
        {
            get { return mSongs; }
            set { mSongs = value; }
        }

        public int NumOfSongs
        {
            get { return mNumOfSongs; }
            set { mNumOfSongs = value; }
        }

        public DateTime CreationDate
        {
            get { return mCreationDate; }
            set { mCreationDate = value; }
        }

        public bool IsFavorite
        {
            get { return mIsFavorite; }
            set { mIsFavorite = value; }
        }

        public Playlist()
        {
            mPlaylistName = "";
            mSongs = new List<Song>();
            mCreationDate = DateTime.Now;
            mNumOfSongs = 0;
            mIsFavorite = false;
        }

        public Playlist(string playlistName, bool isFavorite)
        {
            mPlaylistName = playlistName;
            mSongs = new List<Song>();
            mCreationDate = DateTime.Now;
            mNumOfSongs = 0;
            mIsFavorite = isFavorite;
        }

    }
}