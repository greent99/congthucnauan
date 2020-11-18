using CongThucNauAn.ViewModel;
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
using System.Diagnostics;
using helperControls.Models;
using helperControls.ViewModel;
using Haley.Flipper.MVVM.Models;
using System.Xml;

namespace CongThucNauAn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private string root = System.AppDomain.CurrentDomain.BaseDirectory;
        private  VMMain VmMain;

        public MainWindow()
        {
            InitializeComponent();
            VmMain = new VMMain();
            this.DataContext = VmMain;
            VmMain.PropertyChanged += Filter_PropertyChanged;
        }

        BindingList<Recipe> _list = new BindingList<Recipe>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string filename = $"{root}File/recipe.json";
            var arr = RecipeDAO.getDataFromJson(filename);
            _list = RecipeDAO.GetAll(arr);
           
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            var keyword = KeywordInput.Text;
            VmMain.full_list = RecipeDAO.filter(keyword);
        }

        private void ReloadBtn_Click(object sender, RoutedEventArgs e)
        {
            VmMain.full_list = RecipeDAO.getDataFromJson("");
        }

        public void Filter_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "full_list")
                VmMain.Search_PropertyChanged(sender,e);
        }

        void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            XmlElement recipe = ((ListViewItem)sender).Content as XmlElement;

            if (recipe == null)
            {
                return;
            }

            MessageBox.Show("Oke");
            
        }

        void AddToFavorite(object sender, EventArgs e)
        {
            var item = (Button)sender;

            item.Visibility = Visibility.Hidden;


        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addScreen = new AddRecipe();
            addScreen.Show();
        }
    }
}
