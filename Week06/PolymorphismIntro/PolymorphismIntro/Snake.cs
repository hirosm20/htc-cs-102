using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Snake : Animal
    {
        public bool IsPoisonous;

        public override void Speak()
        {
            Sssss();
        }

        public void Sssss()
        {
            MessageBox.Show("Sssss");
        }

        public Snake() { }

        public Snake(int height, string name, bool isPoisonous, int weight)
        {
            this.IsPoisonous = isPoisonous;
            this.Height = height;
            this.Name = name;
            this.Weight = weight;
        }
    }
}