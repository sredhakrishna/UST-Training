using System;

namespace song
{
    public class Song:IComparable<Song>
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
            return String.Format($"name{_name}" + $"Artist{_artist}");
        }

        public int CompareTo(Song other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
