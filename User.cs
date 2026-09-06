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
    public class User
    {
        //data members
        private string mUserName;
        private string mPassword;
        private List<Playlist> mPlaylists;
        private List<string> mFavPlaylistName;


        //constructor
        public User(string userName, string password)
        {
            mUserName = userName;
            mPassword = password;
            mPlaylists = new List<Playlist>();
            mFavPlaylistName = new List<string>();

        }

        public User()
        {
            mPlaylists = new List<Playlist>();
            mFavPlaylistName = new List<string>();
        }

        //properties
        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public List<Playlist> Playlists
        {
            get { return mPlaylists; }
            set { mPlaylists = value; }
        }

        public List<string> FavPlaylistName
        {
            get { return mFavPlaylistName; }
            set { mFavPlaylistName = value; }
        }
    }
}
