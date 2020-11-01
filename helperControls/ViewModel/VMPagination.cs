using Haley.Flipper.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using helperControls.Models;

namespace helperControls.ViewModel
{
    public class VMPagination : ChangeNotifierModel
    {
        #region Property

        private PaginationModel _pagination;
        public PaginationModel pagination
        {
            get { return _pagination; }
            set { _pagination = value; onPropertyChanged(); }
        }
        #endregion

        #region Command
        public ICommand cmd_change_page { get; set; }
        #endregion

        #region CommandMethod
        public void changePage(object obj)
        {
            try
            {
                int parameter = int.Parse((string)obj);

                int newpage = 1;

                switch(parameter)
                {
                    case 0:
                        newpage = _pagination.current_page; // Get current page
                        newpage--;
                        if (newpage < 1)
                            newpage = 1;
                        _pagination.current_page = newpage;
                        break;
                    case 1:
                        newpage = _pagination.current_page; // Get current page
                        newpage++;
                        if (newpage > _pagination.total_pages)
                            newpage = _pagination.total_pages;
                        _pagination.current_page = newpage;
                        break;
                }
                
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Method

        private void initiation()
        {
            cmd_change_page = new FlipperDelegateCommand(changePage, null);
        }

        public void seed(PaginationModel pagination)
        {
            _pagination = pagination;
        }

        #endregion

        public VMPagination() 
        { 
            initiation(); 
        }
    }
}
