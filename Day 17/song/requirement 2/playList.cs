using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirement_2
{
    internal class playList
    {
       private string _name;
        List<Song> _songList;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Song> SongList
        {
            get { return _songList; }
            set { _songList = value; }
        }
        public playList()
        {

        }
        public playList(string name, List<Song> songList)
        {
            Name = name;
            SongList = songList;
            
        }
        public void AddsongToPlaylist(Song song)
        {
            SongList.Add(song);
            
        }
        public void Diplaysong() 
        {
            if (SongList.Count > 0)
            {
                foreach (Song song in SongList)
                {
                    Console.WriteLine(song.ToString());
                }
            }
            else { Console.WriteLine("no songs to show"); }
        }

        public bool removefromPlaylist(string name)
        {
            int count = 0;
            foreach (var item in SongList)
            {
                if (item.Name == name)
                {
                    SongList.Remove(item);
                    count = 1; break;

                }
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
