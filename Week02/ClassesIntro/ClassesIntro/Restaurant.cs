using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    class Restaurant
    {
        public string Food;
        public int Money;
        public string Name;

        public void Eat()
        {
            MessageBox.Show("The food cost " + Money);
        }

        public void Bathroom()
        {
            MessageBox.Show("I need to go to the bathroom. Let's stop at " + Name);
        }
    }
}
