using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Animals> animal = new List<Animals>();
            // Define a new List of dogs
            //List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            //// Add the dogs to the list
            //dogs.Add(dog1);
            //dogs.Add(dog2);

            //// Loop through the list and call a method on the objects
            //foreach (Dog d in dogs)
            //{
            //    d.SayName();
            //}

            Duck duck1 = new Duck(25, "Sir Quacks");
            Duck duck2 = new Duck(45, "Quack Sparrow");
            Duck duck3 = new Duck(35, "James Pond");


            //List<Duck> ducks = new List<Duck>();
            animal.Add(duck1);
            animal.Add(duck2);
            animal.Add(duck3);


            foreach (Duck duck in ducks)
            {
                duck.SayName();
            }

            Frog frog1 = new Frog(5, "Kermit");
            Frog frog2 = new Frog(7, "Lollihops");
            Frog frog3 = new Frog(9, "Frogger");

            List<Frog> frogs = new List<Frog>();
            animal.Add(frog1);
            animal.Add(frog2);
            animal.Add(frog3);

            foreach (Frog frog in frogs)
            {
                frog.SayName();
            }

            Snake snake1 = new Snake(1, "Severus Snake");
            Snake snake2 = new Snake(5, "Nope Rope");
            Snake snake3 = new Snake(5, "Nagini");

            List<Snake> snakes = new List<Snake>();
            animal.Add(snake1);
            animal.Add(snake2);
            animal.Add(snake3);

            //foreach (Snake snake in snakes)
            //{
            //    snake.SayName();
            //}
            foreach (Animals animal in animals) ;

        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void Sssss_Button_Click(object sender, RoutedEventArgs e)
        {
            Snake snake = new Snake();
            snake.Sssss();
        }

        
    }
}
