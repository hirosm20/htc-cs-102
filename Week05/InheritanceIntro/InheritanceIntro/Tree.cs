using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Tree : Organism
    {
        public int Height;
        public string Type;

        public void Types()
        {
            MessageBox.Show("I am a Treeeeeeeeeeeeee!");
        }



        public Tree()
        {

        }

        public Tree(int height, string type)
        {
            Height = height;
            Type = type;
        }
    }
}
