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
using MVVMZoo.ShowViews.Animal;
using MVVMZoo.ViewModels;

namespace MVVMZoo.ShowViews
{
    /// <summary>
    /// Логика взаимодействия для ShowView.xaml
    /// </summary>
    public partial class ShowView : UserControl
    {
        public ShowView()
        {
            InitializeComponent();
        }

        private void CatView_Click(object sender, RoutedEventArgs e)
        {
            DataContext=new CatViewModel();
        }

        private void DogView_Click(object sender, RoutedEventArgs e)
        {
            DataContext=new DogViewModel();
        }

        private void TigerView_click(object sender, RoutedEventArgs e)
        {
           DataContext=new TigerShowView();
        }

        private void WolfView_click(object sender, RoutedEventArgs e)
        {
            DataContext=new WolfViewModel();
        }

        private void ChickenView_click(object sender, RoutedEventArgs e)
        {
            DataContext=new ChickenViewModel();
        }

        private void StorkView_click(object sender, RoutedEventArgs e)
        {
            DataContext=new StorkViewModel();
        }
    }
}
