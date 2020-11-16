using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongThucNauAn
{
    class RecipeDAO
    {
        public static List<Recipe> getDataFromJson(string filename)
        {
            List<Recipe> result = null;

            using (StreamReader r = new StreamReader("C:/WPF/congthucnauan/CongThucNauAn/File/recipe.json"))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<Recipe>>(json);
            }

            return result;
        }

        public static List<Recipe> filter(string keyword)
        {
            List<Recipe> result = new List<Recipe>();

            List<Recipe> recipes = getDataFromJson("");
            result = recipes.Where(x => x.title.Contains(keyword)).ToList();

            return result;
        }

        public static BindingList<Recipe> GetAll(List<Recipe> arr)
        {

            var result = new BindingList<Recipe>(arr); 
            return result;
        }
    }
}
