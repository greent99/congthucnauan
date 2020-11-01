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

            using (StreamReader r = new StreamReader("D:/HocTap/Nam 4/Lap trinh Windows/Project/1/congthucnauan/CongThucNauAn/File/recipe.json"))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<Recipe>>(json);
            }

            return result;
        }

        public static BindingList<Recipe> GetAll(List<Recipe> arr)
        {

            var result = new BindingList<Recipe>(arr); 
            return result;
        }
    }
}
