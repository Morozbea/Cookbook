using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Beatrix Moroz 2018.01.13

namespace CookBook
{
    //FormMain  Displays forms to the user to give recipe details
    public partial class Form1 : Form
    {
        private const int maxNumOfIngredients = 5;
        private const int maxNumberOfRecipes = 5;       
        private RecipeManager recipeManager;
        private Recipe currRecipe;        
        string textData;
        // Constructor
        public Form1()
        {           
            InitializeComponent();
            currRecipe = new Recipe(maxNumOfIngredients);
            recipeManager = new RecipeManager(maxNumberOfRecipes);
            InitializeGUI();
        }

        // default values when starting the program
        private void InitializeGUI()
        {
            AddRecipeButton.Enabled = false;
            comboBox1AddIngr.Items.Clear();
            comboBox1AddIngr.Items.AddRange(Enum.GetNames(typeof(FoodCategory)));
            this.comboBox1AddIngr.SelectedIndex = (int)FoodCategory.Fish;
            label1.Text = "Recipe Details";
        }      

        //Write / add the recipe to the listbox
        private void UpdateGUI()
        {           
            listBox1DEtails.Items.Clear();
            for (int i = 0; i < recipeManager.NumOfItems; i++)
            {
                listBox1DEtails.Items.Add(recipeManager.GetRecipeString(i));
            }           
        }

        // opens Form2 (FormIngredients), 
        private void AddIngrButton_Click(object sender, EventArgs e)
        {
            if (!ReadInput())
            {
                return;
            }
            Form2 form2 = new Form2(currRecipe);
            DialogResult dlgResult = form2.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                currRecipe = form2.Recipe;
                //check if ingredients was added or not, if they were enable tha add recipe button 
                if(currRecipe.CurrentNumOfIngredients <= 0)
                {
                    MessageBox.Show("No Ingredients specified!");                   
                    UpdateGUI();
                    AddRecipeButton.Enabled = true;
                }
                else
                {
                    AddRecipeButton.Enabled = true;                  
                }                
            }            
        }

        // add the recipe (name, category, desciption and ingredients) (to the listbox)
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            if (recipeManager.NumOfItems > maxNumberOfRecipes - 1)
            {
                MessageBox.Show("no more place!");
                return;
            }
            
            if (!ReadInput())
                return;
            currRecipe.Category = (FoodCategory)comboBox1AddIngr.SelectedIndex;
            currRecipe.Name = textBox1.Text.Trim();
            currRecipe.Description = richTextBox1.Text.Trim();
            currRecipe.Description = richTextBox1.Text;
            recipeManager.Add(currRecipe);
            UpdateGUI();            
            currRecipe = new Recipe(maxNumOfIngredients);
            textBox1.Text = String.Empty;
            richTextBox1.Text = String.Empty;
            if (currRecipe.CurrentNumOfIngredients == 0)
            {
                AddRecipeButton.Enabled = false;
            }
        }

        //checkinput for the name and the description if it is empty or not
        private bool ReadInput()
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("The Describe your recept or/and the name of the receipe is empty!", "Input Error", MessageBoxButtons.OK);
            }
            else
            {
                textData = textBox1.Text;
                            }
            return true;
        }

        //When a recept is selected, then show the name, details, and the ingredients detailed in the other listbox (listbox for the recept details)
        private void listBox1DEtails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1DEtails.SelectedIndex > -1)
            {
                Recipe help = recipeManager.GetRecipeAt(listBox1DEtails.SelectedIndex);
                listBox1.Items.Clear();
                listBox1.Items.Add(help.Name);
                listBox1.Items.Add("");
                for (int i = 0; i < help.CurrentNumOfIngredients; i++)
                {
                    listBox1.Items.Add(help.Ingredients[i]);
                }
                listBox1.Items.Add("");
                listBox1.Items.Add(help.Category.ToString());
                listBox1.Items.Add("");
                listBox1.Items.Add(help.Description);
            }
        }
    }
}
