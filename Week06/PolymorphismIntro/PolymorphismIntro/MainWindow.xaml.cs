using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Animal> Animals;
        public MainWindow()
        {
            InitializeComponent();

            Animals = new ObservableCollection<Animal>();

            Frog frog = new Frog(4, "Kermit", false, 1);
            Duck duck = new Duck(10, "James Pond", 5);
            Dog dog = new Dog("Pure Bred English Golden Retriever", 30, "Ellie", 75);
            Snake snake = new Snake(1, "Nope Rope", true, 2);
            Animals.Add(frog);
            Animals.Add(duck);
            Animals.Add(dog);

            lvAnimals.ItemsSource = Animals;
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
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

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal animal in Animals)
            {
                animal.SayName();
            }
        }

        private void Snake_Button_Click(object sender, RoutedEventArgs e)
        {
            Snake snake = new Snake();
            snake.Sssss();
        }

        private void lvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {

            }
        }
    }
}

   
     
