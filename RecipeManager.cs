namespace Assignment5
{
    /// <summary>
    /// A class used to manage recipes. The name says it all.
    /// Written by Sebastian Aspegren
    /// </summary>
    public class RecipeManager
    {
        private Recipe[] recipeList;

        /// <summary>
        /// Constructor that accepts the maximum number or recipes the array should have as a parameter.
        /// </summary>
        /// <param name="maxNumOfRecipes"> maximum number of recipes the array can hold</param>
        public RecipeManager(int maxNumOfRecipes)
        {
            recipeList = new Recipe[maxNumOfRecipes];
        }
        /// <summary>
        /// Method used to fetch a recipe at a specific index
        /// </summary>
        /// <param name="index">index of the recipe we want to fetch</param>
        /// <returns>the recipe or null if the index is out of bounds</returns>
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
            {
                return recipeList[index];
            }
            return null;
        }
        /// <summary>
        /// Method used to remove recipe at specified index
        /// </summary>
        /// <param name="index">index of recipe to be removed</param>
        public void RemoveRecipeAt(int index)
        {
            if (CheckIndex(index))
            {
                recipeList[index] = null;
            }
        }

        /// <summary>
        /// Method used to fetch an array with all recipes without the null values.
        /// </summary>
        /// <returns>an array without the null objects</returns>
        public Recipe[] getNonNullRecipes()
        {
            Recipe[] recipes = new Recipe[CurrentNumOfItems()];
            int counter = 0;
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] != null)
                {
                    recipes[counter] = recipeList[index];
                    counter++;
                }

            }
            return recipes;
        }

        /// <summary>
        /// Method called to check if a given index is within the range of the recipe array.
        /// This is used to make sure the index is not out of bounds.
        /// </summary>
        /// <param name="index">The index we want to confirm is in range of the array</param>
        /// <returns>True if the index is within range, false if it is not</returns>
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < recipeList.Length)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// A method that loops through the recipe array while looking for a null object.
        /// </summary>
        /// <returns>The position of the null object if a null object is found, returns -1 if no null object is found</returns>
        public int FindVacantPosition()
        {
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] == null)
                {
                    return index;
                }
            }
            return -1;
        }

        /// <summary>
        /// Method used to add a new recipe to the recipe array.
        /// </summary>
        /// <param name="name">name of recipe</param>
        /// <param name="category">category of recipe</param>
        /// <param name="ingredients">array of ingredients used</param>
        /// <param name="description">optional description</param>
        /// <returns>true if successful</returns>
        public bool Add(string name, FoodCategory category, string[] ingredients, string description)
        {
            int index = FindVacantPosition();

            if (index != -1)
            {
                Recipe recipe = new Recipe(ingredients.Length);
                recipe.Name = name;
                ingredients.CopyTo(recipe.IngredientArray, 0);
                recipe.Category = category;
                recipe.Description = description;
                recipeList[index] = recipe;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to generate a string array of information about each recipe in a readable fashion.
        /// </summary>
        /// <returns> a string array with a recipe in each position</returns>
        public string[] RecipeListToString()
        {
            string[] recipes = new string[CurrentNumOfItems()];

            for (int i = 0; i < recipes.Length; i++)
            {
                if (recipeList[i] != null)
                {
                    recipes[i] = recipeList[i].ToString();
                }

            }
            return recipes;
        }

        /// <summary>
        /// A method used to count the current number or recipes in the array.
        /// </summary>
        /// <returns>an int with the amount of recipes</returns>
        public int CurrentNumOfItems()
        {
            int count = 0;
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
