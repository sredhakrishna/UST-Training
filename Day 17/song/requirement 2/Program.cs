using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirement_2
{
    internal class Program
    {
        private static Song s;

        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("enter name of playlist");
            string name=Console.ReadLine();
            playList p = new playList(name,list);

            while (true)
            {
                Console.WriteLine("select 1:Add song ,2:Remove,3:Display");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("enter num of songs");
                        int b = int.Parse(Console.ReadLine());
                        string song;
                        for (int i = 0; i < b; i++)
                        {
                            Console.WriteLine("enter song name,artist,songtype,rating,num of downloads,date of download");
                            song = Console.ReadLine();
                            s = Song.createSong(song);
                            p.AddsongToPlaylist(s);
                        }
                        
                        
                        Console.WriteLine("song added successfully");

                        break;
                    case 3:
                        p.Diplaysong();
                        break;
                    case 2:
                        Console.WriteLine("enter the song to be deleted");
                        string name1= Console.ReadLine();
                        p.removefromPlaylist(name1);
                        break;
                    case 4:

                        break;
                }

            }
        }
    }
}
