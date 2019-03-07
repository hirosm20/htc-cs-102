using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Organism
    {

        public class Animals
        {
            public string Type;
            public int Height;

            public void SayName()
            {
                MessageBox.Show("My name is " + Type);
            }
        }
}
