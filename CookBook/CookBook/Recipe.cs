using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Beatrix Moroz 2018.01.13

namespace CookBook
{
    //Saves data for a recipe as described above in an object
    public class Recipe
    {
        //varibles
        private FoodCategory category;
        private string description;
        private string[] ingredientArray;
        public string name;
        private int currNumOfIng;
               
        //Constructor, one parameter for the max number of ingredients
        public Recipe(int maxNumberOfIngredients)
        {
            ingredientArray = new string[maxNumberOfIngredients];
            DefaultValues();
        }
        //set values
        public void DefaultValues()
        {
            for (int i = 0; i < ingredientArray.Length; i++)
            {
                ingredientArray[i] = string.Empty;
            }
            currNumOfIng = 0;
            name = string.Empty;
            category = FoodCategory.Vegetarian;
            description = string.Empty;
        }

        // Properties
        // getting the chosen category name
        public FoodCategory Category { get { return category; } set {category = value; } }     
        //getting the description of the recipe  
        public string Description { get { return description; } set {description = value; } }
        //getting the ingredients of the recipe
        public string[] Ingredients { get {return ingredientArray; } set { ingredientArray = value; } }
        //getting the name of the recipe
        public string Name { get {return name;} set {name = value; } }
        // the current number of ingredients
        public int CurrentNumOfIngredients { get { return currNumOfIng; } }
        
        // add ingredient method
        public bool AddIngredient(string value)
        {
            ingredientArray[currNumOfIng] = value;
            currNumOfIng++;
            return true;
        }

        // delete ingredient method
        public bool DeleteIngredient(string value)
        {
            ingredientArray[currNumOfIng] = value;
            currNumOfIng--;
            return true;
        }

        // override the ToString method with this one
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No description!";

            string textOut = string.Format("{0, -20} {1, 4} {2, -12} {3, -15}", name, CurrentNumOfIngredients, category.ToString(), descriptionText);

            return textOut;
        }

        // Change the ingredient at the selected position
        public void ChangeIngredientAt(int index, string value)
        {            
                ingredientArray[index] = value;          
        }       
    }
}
