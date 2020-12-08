using System;
using System.IO;
using MVVMZoo.ViewModels;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace MVVMZoo
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ShowViewModel();
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AddViewModel();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
           Microsoft.Win32.OpenFileDialog dialog=new OpenFileDialog();
           dialog.Filter = "Text DocumentText documents (*.txt)|*.txt|All files (*.*)|*.*";
           dialog.FilterIndex = 2;
           Nullable<bool> result = dialog.ShowDialog();

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AllSound_Click(object sender, RoutedEventArgs e)
        {
            CatModel catModel=new CatModel();
            
        }
    }
}
