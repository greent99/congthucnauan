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

        public static List<Recipe> AddRecipe(Recipe t)
        {
            List<Recipe> result = new List<Recipe>();

            List<Recipe> recipes = getDataFromJson("");
            t.id = findMaxId() + 1;
            recipes.Add(t);
            string json = JsonConvert.SerializeObject(recipes.ToArray());
            System.IO.File.WriteAllText(@"C:/WPF/congthucnauan/CongThucNauAn/File/recipe.json", json);
            
            return recipes;
        }
        public static Recipe FindById(int id)
        {
            Recipe result = null;

            List<Recipe> recipes = getDataFromJson("");
            foreach(Recipe recipe in recipes)
            {
                if(recipe.id == id)
                {
                    result = recipe;
                    break;
                }
            }

            return result;
        }

        public static void updateAllData(List<Recipe> list)
        {
            string json = JsonConvert.SerializeObject(list.ToArray());
            System.IO.File.WriteAllText(@"C:/WPF/congthucnauan/CongThucNauAn/File/recipe.json", json);
        }
        public static int findMaxId()
        {
            List<Recipe> recipes = getDataFromJson("");
            return recipes.Count() -1;
        }

        public static BindingList<Recipe> GetAll(List<Recipe> arr)
        {
            var result = new BindingList<Recipe>(arr); 
            return result;
        }

        public static List<Recipe> getFavoriteList()
        {
            List<Recipe> recipes = getDataFromJson("");
            return recipes.Where(item => item.isFavotite == true).ToList();
        }

        public static string ConvertUTF8ToASC(String input)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = input.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
