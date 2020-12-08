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
    /// Логика взаимодействия для StorkView.xaml
    /// </summary>
    public partial class StorkView : UserControl
    {
        public StorkView()
        {
            InitializeComponent();
        }

        private void StorButton_Click(object sender, RoutedEventArgs e)
        {
            StorkModel storkModel=new StorkModel(120, 50, "Черные", 300);
            TextBlockStork.Text = storkModel.Info();
        }

        private void StorButtonSound_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\asus\source\repos\MVVMZoo\MVVMZoo\Sound\stork.wav");
            player.Play();
        }
    }
}
