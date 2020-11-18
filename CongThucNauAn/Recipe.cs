using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongThucNauAn
{
    class Recipe : INotifyPropertyChanged
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string youtubeUrl { get; set; }
        public string image { get; set; }
        public List<string> steps { get; set; }
        public Boolean isFavotite { get; set; }
        private String like_image_source;
        public String LikeImageSource 
        { 
            get { return like_image_source; }
            set { like_image_source = value; OnPropertyChanged("LikeImageSource"); } 
        }
        public Recipe(String title, String url, String image, String description, List<string> steps)
        {
            this.title = title;
            this.youtubeUrl = url;
            this.image = image;
            this.description = description;
            this.steps = steps;
            this.LikeImageSource = "Images/Icon/heart-24.png";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
