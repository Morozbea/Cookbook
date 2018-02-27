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
    //FormIngredients
    public partial class Form2 : Form
    {
        // Variables
        private Recipe m_recipe;
        string textData;
        private bool m_cancelled = false;
        private const int maxNumOfIngredients = 5;
        // Constructor
        public Form2(Recipe recipe)
        {
            InitializeComponent();
            
            if (recipe == null)
            {
                MessageBox.Show("Object not created! Kill the programmer!");
                this.Close();
            }
            m_recipe = recipe;

            if (string.IsNullOrEmpty(m_recipe.name))
                this.Text = "No Recipe Name";
            else
                this.Text = m_recipe.name + "Add Ingredients";
            InitializeGUI();
        }
        //Get the recipe
        public Recipe Recipe
        {
            get { return m_recipe; }
            set
            {
                if (value != null)
                m_recipe = value;
            }
        }     
        //Set values at the start
        private void InitializeGUI()
        {           
            listBox1.Items.Clear();
            NrOfIngForm2Lbl.Text = m_recipe.CurrentNumOfIngredients.ToString();
        }
        //check input
        private bool ReadInput() 
        {           
            textData = textBox1ingeredientsform2.Text;            
            return true;
        }

        // select an ingredient and show it in the textbox where we write the ingredient that we add
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                textBox1ingeredientsform2.Text = m_recipe.Ingredients[listBox1.SelectedIndex];
            }
        }

        // Check if there is any ingredient written in the textbox
        string CheckIngredients()
        {
            string text = textBox1ingeredientsform2.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("No text!", "Error!");
                return null;
            }
            return text;
        }

        // Add ingredient
        private void Form2Addbutton1_Click(object sender, EventArgs e)
        {
            if (!ReadInput())
                return;
            string ingredient = CheckIngredients();
           
            listBox1.Items.Add(textBox1ingeredientsform2.Text); // add the ingredient in the listbox

            textBox1ingeredientsform2.Clear(); // Clear the textbox when the ingredient is added
          
            if (!string.IsNullOrEmpty(ingredient))
            {
                m_recipe.AddIngredient(ingredient);  // add the ingredient list in the textbox updated
                UpdateGUI();
            }
            if (m_recipe.CurrentNumOfIngredients > maxNumOfIngredients - 1)
            {
                MessageBox.Show("No more place!");
                return;
            }
        }

        // show the number of ingredients that was added.
        private void UpdateGUI()
        {
            NrOfIngForm2Lbl.Text = m_recipe.CurrentNumOfIngredients.ToString();
        }

        // Ok button when the ingredients are added (close form 2)
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (m_recipe.CurrentNumOfIngredients <= 0)
            {
                MessageBox.Show("No ingredients given.", "Alert");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cancel button (close form 2)
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }        

        // check if any added ingredient is selected, showing in the textbox the selected one and if it is changed ->
        // Change the text in the listbox
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing is selected!");
                return;
            }
            // the selected ingredience is showed in the textbox for showing what I want to edit
            m_recipe.Ingredients[listBox1.SelectedIndex] = textBox1ingeredientsform2.Text;
            //Update the ingredients list 
            UpdateList(); 
            listBox1.SelectedIndex = -1;
            textBox1ingeredientsform2.Text = "";
        }

        private void UpdateList()
        {
            // first clear the list
            listBox1.Items.Clear();
            // and add the ingredints to the listbox
            for (int i = 0; i < m_recipe.CurrentNumOfIngredients; i++)
            {
                listBox1.Items.Add(m_recipe.Ingredients[i]);
            }
        }

        // Delete button, check if any added ingredient is selected, and delete it
        private void buttonDelete_Click(object sender, EventArgs e)
        {           
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing is Selected!");
                return;
            }

            string ingredient = CheckIngredients();
            // getting the number of ingredients added
            int all = m_recipe.CurrentNumOfIngredients;
            // after deleting an item needs the ingredients pushed one in the array to get the right place
            // all ingredients will be moved forward one
            for (int i = listBox1.SelectedIndex ; i < all - 1; i++)
            {
                m_recipe.ChangeIngredientAt(i, m_recipe.Ingredients[i + 1]);
            }
            all--;
            // delete ingredient from list
            m_recipe.DeleteIngredient(ingredient);
            // clear the listbox before update
            listBox1.Items.Clear();
            // add list to the listbox
            for (int i = 0; i < all; i++)
            {
                listBox1.Items.Add(m_recipe.Ingredients[i]);
            }

            listBox1.SelectedIndex = -1;
            textBox1ingeredientsform2.Text = "";
        }
    }
}
