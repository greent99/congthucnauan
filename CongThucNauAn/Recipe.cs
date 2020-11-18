using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongThucNauAn
{
    class Recipe
    {
        public string title { get; set; }
        public string description { get; set; }
        public string youtubeUrl { get; set; }
        public string image { get; set; }
        public List<string> steps { get; set; }
        public Boolean isFavotite { get; set; }
        public Recipe(String title, String url, String image, String description, List<string> steps)
        {
            this.title = title;
            this.youtubeUrl = url;
            this.image = image;
            this.description = description;
            this.steps = steps;
        }
    }
}
