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
using helperControls.Models;
using helperControls.ViewModel;

namespace helperControls
{
    /// <summary>
    /// Interaction logic for uc_pagination.xaml
    /// </summary>
    public partial class uc_pagination : UserControl
    {
        public uc_pagination()
        {
            InitializeComponent();
            PaginationModel pmodel = new PaginationModel(100,12);
            VMPagination vm = new VMPagination();
            vm.seed(pmodel);
            this.DataContext = vm;
        }
    }
}
