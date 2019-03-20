using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    public class animatedmovie : Movie
    {

        string AnimationStudio;
        string AnimationType;
        

        public animatedmovie(string animationStudio, string animationType, string title, int releaseYear)
        {
            AnimationStudio = animationStudio;
            AnimationType = animationType;
            Title = title;
            ReleaseYear = releaseYear;
        }

        public override void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            infoString += "\nAnimation Studio: " + this.AnimationStudio;
            infoString += "\nAnimation Type: " + this.AnimationType;
            MessageBox.Show(infoString);
        }   
    }

    
}
