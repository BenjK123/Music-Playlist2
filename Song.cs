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
        //data members
        private string mSongTitle;
        private string mArtist;
        private TimeSpan mDuration;
        private string mGenre;
        private string mAlbum;
        private string mFilePath;

        
        //comstructor
        public Song(string SongTitle, string Artist, TimeSpan Duration, string FilePath)
        {
            mSongTitle = SongTitle;
            mArtist = Artist;
            mDuration = Duration;
            mFilePath = FilePath;
        }

        

        
        //properties
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

        public TimeSpan Duration
        {
            get { return mDuration; }
            set { mDuration = value; }
        }

        public string Genre
        {
            get { return mGenre; }
            set { mGenre = value; }
        }

        public string Album
        {
            get { return mAlbum; }
            set { Album = value; }
        }

        public string FilePath
        {
            get { return mFilePath; }
            set { FilePath = value; }
        }
    }
}
