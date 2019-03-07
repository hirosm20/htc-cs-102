using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Snake : Animals
    {
        public void Sssss()
        {
            MessageBox.Show("Sssss!");
        }



        public Snake()
        {

        }

        public Snake(int height, string name)
        {
            Height = height;
            Name = name;
        }
    }
}
