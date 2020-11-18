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
            if (e.PropertyName == "full_list" || e.PropertyName == "favorite_list")
                VmMain.Search_PropertyChanged(sender,e);
        }

        void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            var item = (sender as ListViewItem).DataContext;
            if (item != null)
            {
                
            }


        }

        void AddToFavorite(object sender, EventArgs e)
        {
            var item = (Button)sender;
            var stackpanel = (StackPanel)item.Content;

            foreach(var element in stackpanel.Children)
            {
                TextBlock textbox = element as TextBlock;
                if(textbox != null)
                {
                    var id = Int32.Parse(textbox.Text);
                    if (VmMain.full_list[id].isFavotite == false)
                    {
                        VmMain.full_list[id].LikeImageSource = "Images/Icon/heart-24-red.png";
                        VmMain.full_list[id].isFavotite = true;
                    }
                    else
                    {
                        VmMain.full_list[id].LikeImageSource = "Images/Icon/heart-24.png";
                        VmMain.full_list[id].isFavotite = false;
                    }
                }
                RecipeDAO.updateAllData(VmMain.full_list);
                break;
            }
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addScreen = new AddRecipe();
            addScreen.Show();
        }

        private void FavoriteBtn_Click(object sender, RoutedEventArgs e)
        {
            VmMain.full_list = RecipeDAO.getFavoriteList();
        }
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            VmMain.full_list = RecipeDAO.getDataFromJson("");
        }
    }
}
