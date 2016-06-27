using System;
using System.Windows.Forms;

namespace Assignment5
{
    /// <summary>
    /// The main class and form that handles the interactions between classes, logical operations and majority of graphical work.
    /// Written by Sebastian Aspegren
    /// </summary>
    public partial class MainForm : Form
    {
        private const int numOfIngredients = 20;
        private const int MaxNumOfRecipes = 50;

        private Recipe currentRecipe = new Recipe(numOfIngredients);
        private RecipeManager recipeManager = new RecipeManager(MaxNumOfRecipes);

        /// <summary>
        /// Constructor to call methods related to initiation of the program.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitGUI();
        }

        /// <summary>
        /// Method used to prepare the combobox with preselected values
        /// </summary>
        private void InitGUI()
        {
            string[] names = Enum.GetNames(typeof(FoodCategory));
            cBoxCategory.Items.AddRange(names);
            cBoxCategory.SelectedIndex = (int)FoodCategory.Vegetarian;
        }

        /// <summary>
        /// Called when the user clicks the button to add a recipe. If the input is valid the AddRecipe method is called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (CheckInput())
                AddRecipe();
        }

        /// <summary>
        /// Method that reads input and saves it to a field then passes it to the recipemanager.
        /// </summary>
        private void AddRecipe()
        {
            currentRecipe.Category = (FoodCategory)cBoxCategory.SelectedIndex;
            currentRecipe.Name = txtBoxRecipeName.Text.Trim();
            if (string.IsNullOrEmpty(txtBoxDesc.Text))
                currentRecipe.Description = "No Description!";
            else
                currentRecipe.Description = txtBoxDesc.Text;
            recipeManager.Add(currentRecipe.Name, currentRecipe.Category, currentRecipe.IngredientArray, currentRecipe.Description);
            UpdateGUI();
            currentRecipe.DefaultValues();
        }

        /// <summary>
        /// Method that validates the name of the recipe.
        /// </summary>
        /// <returns> true if the input is acceptable, otherwise false</returns>
        private bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txtBoxRecipeName.Text))
            {
                return true;
            }
            MessageBox.Show("Type in something that makes sense!");
            return false;
        }

        /// <summary>
        /// Method called when the button to add ingredients is clicked. it opens the form to input ingredients.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            FormIngredient formIngredients = new FormIngredient(currentRecipe);
            DialogResult dlgResult = formIngredients.ShowDialog();
        }

        /// <summary>
        /// Method used to update the user interface after it has been affected by input from the user.
        /// </summary>
        private void UpdateGUI()
        {
            string[] recipeListStrings = recipeManager.RecipeListToString();
            listBoxRecipes.Items.Clear();
            listBoxRecipes.Items.AddRange(recipeManager.getNonNullRecipes());
        }

        /// <summary>
        /// Method called when the button to edit a recipe is clicked. First we check so the user selected something, 
        /// ask them if they are sure then we replace the recipe with the current input in the textfields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            int index = listBoxRecipes.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Select an item from the listbox!", "Error");
            }
            else if (CheckInput())
            {
                DialogResult dlg = MessageBox.Show("Sure to Edit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    recipeManager.RemoveRecipeAt(index);
                    AddRecipe();
                    UpdateGUI();
                }
                else if (dlg == DialogResult.No)
                {

                }
                else
                {
                    MessageBox.Show("Somethign went wrong", "Error");
                }
            }
        }

        /// <summary>
        /// Method called if something in the listbox of recipes is clicked. If a recipe is clicked we display information regarding it in locked textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxDetails.Text = recipeManager.GetRecipeAt(listBoxRecipes.SelectedIndex).Description;
                txtBoxRecipeIngredients.Text = recipeManager.GetRecipeAt(listBoxRecipes.SelectedIndex).toStringIngredients();
            }
            catch (NullReferenceException)
            {

            }

        }

        /// <summary>
        /// Method called when the button for deleting a recipe is clicked. We check for human errors then delete the item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRecipe_Click(object sender, EventArgs e)
        {
            int index = listBoxRecipes.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Select an item from the listbox!", "Error");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Sure to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    recipeManager.RemoveRecipeAt(index);
                    UpdateGUI();
                }
                else if (dlg == DialogResult.No)
                {

                }
                else
                {
                    MessageBox.Show("Somethign went wrong", "Error");
                }
            }
        }
    }
}
