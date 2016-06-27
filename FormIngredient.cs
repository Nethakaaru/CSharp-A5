using System;
using System.Windows.Forms;

namespace Assignment5
{
    /// <summary>
    /// A class used to receive input from the user regarding the ingredients or the recipe.
    /// Written by Sebastian Aspegren
    /// </summary>
    public partial class FormIngredient : Form
    {
        private Recipe currentRecipe;

        /// <summary>
        /// The constructor for the form. It sets the title for the window, prepares the field and GUI.
        /// </summary>
        /// <param name="currentRecipe">The recipe we want to add ingredients to</param>
        public FormIngredient(Recipe currentRecipe)
        {
            InitializeComponent();
            this.currentRecipe = currentRecipe;

            if (string.IsNullOrEmpty(currentRecipe.Name))
            {
                this.Text = "No Recipe Name";
            }
            else
            {
                this.Text = currentRecipe.Name + " Add Ingredients";
            }
            InitGUI();
        }

        /// <summary>
        /// A method used to setup the user interface by clearing lists and similar things.
        /// </summary>
        private void InitGUI()
        {
            if (currentRecipe.IngredientArray == null)
            {
                currentRecipe.IngredientArray = new string[currentRecipe.MaxNumOfIngredients];
            }
            listBoxIngredients.Items.Clear();
            listBoxIngredients.Items.AddRange(currentRecipe.getNonNullIngredients());
            lblNoOfIngredients.Text = currentRecipe.getCurrentNumOfIngredients().ToString();
        }

        /// <summary>
        /// Called when the user clicks the add button. If there is text in the box the ingredient will be added to the current recipe, otherwise a warning is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxAddIngredient.Text))
            {
                currentRecipe.AddIngredient(txtBoxAddIngredient.Text);
                lblNoOfIngredients.Text = currentRecipe.getCurrentNumOfIngredients().ToString();
                listBoxIngredients.Items.Add(txtBoxAddIngredient.Text);
            }
            else
            {
                MessageBox.Show("Input something!");
            }
        }
    }
}
