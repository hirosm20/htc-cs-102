using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string MovieName;
        private int ReleaseYear;
        private double RottenTomatoes;

        public Movie (string name, int releaseYear, double rottenTomatoes)
        {
            this.MovieName = name;
            this.ReleaseYear = releaseYear;
            this.RottenTomatoes = rottenTomatoes;
        }

        public void ShowMovie()
        {

            
            MessageBox.Show(MovieName + ReleaseYear);
        }
    }
}
