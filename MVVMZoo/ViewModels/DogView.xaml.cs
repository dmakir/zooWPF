using System;
using System.Windows;
using System.Windows.Controls;

namespace MVVMZoo.ViewModels
{
    public partial class DogView : UserControl
    {
        public DogView()
        {
            InitializeComponent();
        }

        private void dogButton_Click(object sender, RoutedEventArgs e)
        {
            DogModel dogModel = new DogModel("Барон", "Лабрадор", "Есть", "Золотой", "10.6.2018", true, "Добрый", 100, 20, "Черные");
            TextBlockDog.Text = dogModel.Info();
        }


        private void dogButtonSound_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\asus\source\repos\MVVMZoo\MVVMZoo\Sound\dog.wav");
            player.Play();
        }
    }
}
