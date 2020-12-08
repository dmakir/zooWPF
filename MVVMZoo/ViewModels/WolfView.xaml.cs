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

namespace MVVMZoo.ViewModels
{
    /// <summary>
    /// Логика взаимодействия для WolfView.xaml
    /// </summary>
    public partial class WolfView : UserControl
    {
        public WolfView()
        {
            InitializeComponent();
        }

        private void buttonWolf_Click(object sender, RoutedEventArgs e)
        {
            WolfModel wolfModel=new WolfModel("Лес", "2.5.2018", 150, 30, "Серые", true);
            TextBlockWolf.Text = wolfModel.Info();
        }

        private void buttonWolfSound_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\asus\source\repos\MVVMZoo\MVVMZoo\Sound\wolf.wav");
            player.Play();
        }
    }
}
