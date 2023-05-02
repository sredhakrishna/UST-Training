using System;

namespace requirement_2
{
    internal class Song
    {
        private string _name;
        private string _artist;
        private string _songType;
        private double _rating;
        private int _numberOfDownloads;
        private DateTime _dateDownloaded;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
            }
        }
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set
            {
                _numberOfDownloads = value;
            }
        }
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set
            {
                _dateDownloaded = value;
            }
        }
        public Song()
        {

        }
        public Song(string name, string artist, string songType, double rating, int numberOfDownloads, DateTime dateDownloaded)
        {
            Name = name;
            Artist = artist;
            SongType = songType;
            Rating = rating;
            NumberOfDownloads = numberOfDownloads;
            DateDownloaded = dateDownloaded;

        }

        public override string ToString()
        {
            return String.Format("{0} \t{1} \t{2} \t{3} \t{4} \t\t\t\t{5}", _name,_artist,_songType,_rating,_numberOfDownloads,_dateDownloaded.ToString("dd-mm-yyyy",null));
        }
        public static Song createSong(string Song)
        {
            string[] input=Song.Split(',');
            DateTime dt= DateTime.ParseExact(input[5], "dd-mm-yyyy", null);
            Song s=new Song(input[0], input[1], input[2], double.Parse(input[3]), int.Parse(input[4]), dt);
            return s;
        }
        
    }
}