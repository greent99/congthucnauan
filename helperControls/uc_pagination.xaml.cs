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
using Haley.Flipper.MVVM.Models;
using System.ComponentModel;

namespace helperControls 
{
    /// <summary>
    /// Interaction logic for uc_pagination.xaml
    /// </summary>
    public partial class uc_pagination : UserControl, INotifyPropertyChanged
    {
        private VMPagination _pagination;
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public VMPagination pagination
        {
            get { return _pagination; }
            set { _pagination = value;}
        }
        public uc_pagination()
        {
            InitializeComponent();
        }
    }
}
