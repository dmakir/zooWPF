using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using UserControl = System.Windows.Controls.UserControl;


namespace MVVMZoo.ViewModels
{
    public partial class CatView : UserControl
    {
        public CatView()
        {
            InitializeComponent();
        }

        private void buttonCat_Click(object sender, RoutedEventArgs e)
        {
            CatModel catModel = new CatModel("Барсик", "Ашера", "Есть", "Золотой в пятно", true, "2.3.2019", "Злобный", 20, 32, "Зеленый");
            TextBlockCat.Text = catModel.Inf();
        }

        private void buttonCatSound_click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\asus\source\repos\MVVMZoo\MVVMZoo\Sound\cat.wav");
            player.Play();
        }

    }
}
