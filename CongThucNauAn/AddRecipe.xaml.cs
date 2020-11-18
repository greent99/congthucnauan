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
using System.Windows.Shapes;
using CongThucNauAn.ViewModel;
using helperControls.Models;
using helperControls.ViewModel;
using Haley.Flipper.MVVM.Models;

namespace CongThucNauAn
{
    /// <summary>
    /// Interaction logic for AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Window
    {
        private List<string> steps;
        public AddRecipe()
        {
            InitializeComponent();
            //VmMain = vm;
            steps = new List<string>();
        }

        private void SelectFile_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                FileInput.Text = filename;
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var title = InputTitle.Text;
            var url = InputUrl.Text;
            var image = FileInput.Text;
            var description = InputDescription.Text;
            Recipe recipe = new Recipe(title, url, image, description, steps);
            RecipeDAO.AddRecipe(recipe);
            MessageBox.Show("Success");
            this.Close();
            
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            var step = InputStep.Text;
            steps.Add(step);
            InputSteps.Text += "\n" + step;
            InputStep.Text = "";
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
