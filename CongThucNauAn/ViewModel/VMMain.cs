using Haley.Flipper.MVVM.Models;
using helperControls.Models;
using helperControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace CongThucNauAn.ViewModel
{
    class VMMain : ChangeNotifierModel
    {
        private VMPagination _pagination;
        public VMPagination pagination
        {
            get { return _pagination; }
            set { _pagination = value; onPropertyChanged(); }
        }

        private ObservableCollection<Recipe> _top_list;
        public ObservableCollection<Recipe> top_list
        {
            get { return _top_list; }
            set { _top_list = value; onPropertyChanged(); }
        }

        private ObservableCollection<Recipe> _center_list;
        public ObservableCollection<Recipe> center_list
        {
            get { return _center_list; }
            set { _center_list = value; onPropertyChanged(); }
        }

        private ObservableCollection<Recipe> _bottom_list;
        public ObservableCollection<Recipe> bottom_list
        {
            get { return _bottom_list; }
            set { _bottom_list = value; onPropertyChanged(); }
        }

        private List<Recipe> _full_list;
        public List<Recipe> full_list
        {
            get { return _full_list; }
            set { _full_list = value; onPropertyChanged(); }
        }
        public void processPage(object param)
        {
            try
            {
                List<Recipe> page_list = new List<Recipe>();

                int total_pages = pagination.pagination.total_pages;
                int starting_count = total_pages > 0 ? pagination.pagination.items_per_page * (pagination.pagination.current_page - 1) : 0;
                int total_items = pagination.pagination.total_items;
                int items_per_page = pagination.pagination.items_per_page;

                for (int i = starting_count; i < starting_count + items_per_page && i < total_items; i++)
                {
                    page_list.Add(full_list[i]);
                }

                var splitArr = VMMain.SplitList(page_list, 4);
                switch (splitArr.Count)
                {
                    case 1:
                        top_list = new ObservableCollection<Recipe>(splitArr[0]);
                        center_list = new ObservableCollection<Recipe>();
                        bottom_list = new ObservableCollection<Recipe>();
                        break;
                    case 2:
                        top_list = new ObservableCollection<Recipe>(splitArr[0]);
                        center_list = new ObservableCollection<Recipe>(splitArr[1]);
                        bottom_list = new ObservableCollection<Recipe>();
                        break;
                    case 3:
                        top_list = new ObservableCollection<Recipe>(splitArr[0]);
                        center_list = new ObservableCollection<Recipe>(splitArr[1]);
                        bottom_list = new ObservableCollection<Recipe>(splitArr[2]);
                        break;
                    default:
                        top_list = new ObservableCollection<Recipe>();
                        center_list = new ObservableCollection<Recipe>();
                        bottom_list = new ObservableCollection<Recipe>();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _initiation()
        {
            full_list = RecipeDAO.getDataFromJson("");
            top_list = new ObservableCollection<Recipe>();
            center_list = new ObservableCollection<Recipe>();
            bottom_list = new ObservableCollection<Recipe>();
            pagination = new VMPagination();

            PaginationModel model = new PaginationModel(full_list.Count(), 12);
            pagination.seed(model);

            pagination.pagination.PropertyChanged += Pagination_PropertyChanged;

            processPage(null);
        }

        private void Pagination_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "current_page")
            {
                processPage(null);
            }
            if(e.PropertyName == "total_pages")
            {
                
            }
        }

        public void Search_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            PaginationModel model = new PaginationModel(full_list.Count(), 12);
            pagination.seed(model);
            pagination.pagination.PropertyChanged += Pagination_PropertyChanged;

            processPage(null);
        }

        public static List<List<Recipe>> SplitList(List<Recipe> total_array, int nSize = 4)
        {
            List<List<Recipe>> result = new List<List<Recipe>>();
            int i = 0;
            int n = total_array.Count;
            int index = 0;
            List<Recipe> list = new List<Recipe>();

            while (i < n)
            {
                list.Add(total_array[i]);
                if (i == (index + 1) * nSize - 1 || i + 1 == n)
                {
                    index++;
                    result.Add(list);
                    list = new List<Recipe>();
                }


                i++;
            }

            return result;
        }



        public VMMain()
        {
            _initiation();
        }

    }
}
