using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CongThucNauAn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string root = System.AppDomain.CurrentDomain.BaseDirectory;
        public MainWindow()
        {
            InitializeComponent();
        }

        BindingList<Recipe> _list = new BindingList<Recipe>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string filename = $"{root}File/recipe.json";
            var arr = RecipeDAO.getDataFromJson(filename);
            _list = RecipeDAO.GetAll(arr);
            dataListView_1.ItemsSource = _list;
            dataListView_2.ItemsSource = _list;
            dataListView_3.ItemsSource = _list;
        }
    }
}
