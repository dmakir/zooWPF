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
using MVVMZoo.ViewModels.Bird;

namespace MVVMZoo.ViewModels
{
    /// <summary>
    /// Логика взаимодействия для ChickenView.xaml
    /// </summary>
    public partial class ChickenView : UserControl
    {
        public ChickenView()
        {
            InitializeComponent();
        }

        private void buttonChicken_Click(object sender, RoutedEventArgs e)
        {
           ChickenModel chickenModel=new ChickenModel(15, 5, "Золотой", 1);
           TextBlockChiclen.Text = chickenModel.Info();
        }

        private void buttonChickenSound_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\asus\source\repos\MVVMZoo\MVVMZoo\Sound\chicken.wav");
            player.Play();
        }
    }
}
