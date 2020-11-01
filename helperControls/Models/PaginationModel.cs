using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Haley.Flipper.MVVM.Models;

namespace helperControls.Models
{
    public class PaginationModel : ChangeNotifierModel
    {
        private int _total_items;
        public int total_items
        {
            get { return _total_items;  }
            set { _total_items = value;  }
        }
        private int _items_per_page;
        public int items_per_page
        {
            get { return _items_per_page; }
            set { _items_per_page = value; onPropertyChanged(); }
        }
        private int _current_page;
        public int current_page
        {
            get { return _current_page; }
            set 
            {
                if(value < total_pages + 1 && value > 0)
                {
                    _current_page = value; 
                    onPropertyChanged();
                }
            }
        }
        private int _total_pages;
        public int total_pages
        {
            get { return _total_pages; }
            set { _total_pages = value; onPropertyChanged(); }
        }
        public PaginationModel(int totalItemsCount, int pageItemsCount ) {
            total_items = totalItemsCount;
            items_per_page = pageItemsCount;
            total_pages = total_items / items_per_page;
            int r = total_items % items_per_page;
            if (r != 0)
                total_pages++;
            current_page = 1;
        }
    }

    
}
