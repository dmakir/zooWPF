using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using MVVMZoo.ViewModels;

namespace MVVMZoo.ShowViews.Animal
{
    /// <summary>
    /// Логика взаимодействия для TigerShowView.xaml
    /// </summary>
    public partial class TigerShowView : UserControl
    {
        public TigerShowView()
        {
            InitializeComponent();
        }

        private void buttonTiger_Click(object sender, RoutedEventArgs e)
        {
           TigerModel tigerModel=new TigerModel("Лес", "2.6.2019", 150, 70, "Зеленые");
           TextBlockTiger.Text = tigerModel.Info();
        }

        private void buttonTigerSound_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\asus\source\repos\MVVMZoo\MVVMZoo\Sound\tigr-tigr.wav");
            player.Play();
        }
    }
}
