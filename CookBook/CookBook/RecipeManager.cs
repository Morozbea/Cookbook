using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Beatrix Moroz 2018.01.13

namespace CookBook
{
    // defines an array of recipes
    // Saves a number of recipes in another object(write the class RecipeManager
    class RecipeManager
    {
        //Use an array with element of the type Recipe in the class RecipeManager.
        Recipe[] recipeList;
        int numberOfItems; 
        int max;

        //Constructor
        public RecipeManager(int maxNumberOfElements) 
        {
            recipeList = new Recipe[maxNumberOfElements];
            numberOfItems = 0;
            max = maxNumberOfElements;
        }

        // the number of the recipes
        public int NumOfItems { get { return numberOfItems; } }
        
        // add the recept to the list
        public bool Add(Recipe newRecipe)
        { 
            
            recipeList[numberOfItems] = newRecipe;
            numberOfItems++;
            return true;
        }

        public bool CheckIndex(int index)
        {
            return true;
        }

        // Get the recipe at index (the selected place in the list)
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return recipeList[index];
            else return null;
        }        

        // get the chosen recipe in the selected place (index) in the list
        public string GetRecipeString(int index)
        {
            return recipeList[index].Name + "                " + recipeList[index].CurrentNumOfIngredients.ToString() + "                  " + recipeList[index].Category.ToString();
        }

        public string GetRecipeDetailedString(int index)
        {
           
            return recipeList[index].Name + "    " + recipeList[index].Ingredients + "         " + recipeList[index].Category.ToString() + "        " + recipeList[index].Description.ToString();
        }
    }
}
