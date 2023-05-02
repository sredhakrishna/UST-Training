using song;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirement_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<Song> songs = new List<Song> {
        new Song("kannil kannil","ssss","melody",8,10, DateTime.Parse("12-10-2022")),
        new Song("pandora","ssss","pop",8,10, DateTime.Parse("21-10-2022")),
        new Song("whistle","ssss","melody",8,10, DateTime.Parse("12-10-2022"))

        };

            songs.Sort();
            foreach (Song s in songs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
