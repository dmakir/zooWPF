using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using MVVMZoo.ADD.FileServise;
using MVVMZoo.ADD.Model;

namespace MVVMZoo.ViewModels
{
    /// <summary>
    /// Логика взаимодействия для AddViewModel.xaml
    /// </summary>
    public partial class AddViewModel : UserControl
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private BindingList<TodoModel> _todoDataList;
        private FleService _fleService;

        public AddViewModel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fleService = new FleService(PATH);
            try
            {
                _todoDataList = _fleService.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // Close();
            }
            dgTodoList.ItemsSource = _todoDataList;
            _todoDataList.ListChanged += _todoDataList_ListChanged;

        }

        private void _todoDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted ||
                e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fleService.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   // Close();
                }
            }
        }
    }
}
