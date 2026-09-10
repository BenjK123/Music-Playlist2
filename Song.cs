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
    public class Song
    {
        private string mSongTitle;
        private string mArtist;
        private string mAlbum;
        private string mGenre;
        private string mFilePath;

        public string SongTitle
        {
            get { return mSongTitle; }
            set { mSongTitle = value; }
        }
        public string Artist
        {
            get { return mArtist; }
            set { mArtist = value; }
        }
        public string Album
        {
            get { return mAlbum; }
            set { mAlbum = value; }
        }
        public string Genre
        {
            get { return mGenre; }
            set { mGenre = value; }
        }
        public string FilePath
        {
            get { return mFilePath; }
            set { mFilePath = value; }
        }

        public Song()
        {
            mSongTitle = "";
            mArtist = "";
            mAlbum = "";
            mGenre = "";
            mFilePath = "";
        }
        public Song(string songName, string artist, string album, string genre, string filePath)
        {
            mSongTitle = songName;
            mArtist = artist;
            mAlbum = album;
            mGenre = genre;
            mFilePath = filePath;
        }
    }
}
