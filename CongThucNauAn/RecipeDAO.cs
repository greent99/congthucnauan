using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            var asciiKeyword = ConvertUTF8ToASC(keyword.ToLower());
            List<Recipe> recipes = getDataFromJson("");
            //result = recipes.Where(x => x.title.ToLower().Contains(keyword)).ToList();
            foreach(Recipe recipe in recipes)
            {
                var asciiTitle = ConvertUTF8ToASC(recipe.title.ToLower());
                if (asciiTitle.Contains(asciiKeyword))
                    result.Add(recipe);
            }

            return result;
        }

        public static BindingList<Recipe> GetAll(List<Recipe> arr)
        {

            var result = new BindingList<Recipe>(arr); 
            return result;
        }

        public static string ConvertUTF8ToASC(String input)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = input.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
