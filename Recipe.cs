using System;

namespace Assignment5
{
    /// <summary>
    /// A data structure class acting as a recipe. It has ingredients, a name, a category (see enum FoodCategory) and a description.
    /// Written by Sebastian Aspegren
    /// </summary>
    public class Recipe
    {
        private string[] ingredientArray;
        private string name;
        private FoodCategory category;
        private string description;

        /// <summary>
        /// Constructor that needs to know the limit of ingredients for the recipe.
        /// </summary>
        /// <param name="maxNumOfIngredients">an int representing the maximum amount of ingredients.</param>
        public Recipe(int maxNumOfIngredients)
        {
            IngredientArray = new string[maxNumOfIngredients];
            DefaultValues();
        }

        /// <summary>
        /// Method used to populate fields with default values.
        /// </summary>
        public void DefaultValues()
        {
            for (int index = 0; index < IngredientArray.Length; index++)
            {
                IngredientArray[index] = string.Empty;
            }
            name = string.Empty;
            category = FoodCategory.Vegetarian;
            description = string.Empty;
        }

        /// <summary>
        /// A method that loops through the ingredient array while looking for a null or empty string.
        /// </summary>
        /// <returns>The position of the empty or null string if a null or empty string is found, returns -1 if no null or empty string is found</returns>
        public int FindVacantPosition()
        {
            for (int index = 0; index < IngredientArray.Length; index++)
            {
                if (string.IsNullOrEmpty(IngredientArray[index]))
                {
                    return index;
                }

            }
            return -1;
        }

        /// <summary>
        /// A method used to print out a string with information about all ingredients while removing null or empty values.
        /// </summary>
        /// <returns>a string with all the ingredients</returns>
        public string toStringIngredients()
        {
            if (getNonNullIngredients().Length == 0)
            {
                return "No Ingredients!";
            }
            string ingredients = "";
            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(IngredientArray[i]))
                    ingredients += IngredientArray[i] + ", ";
            }

            return ingredients.Substring(0, ingredients.Length - 2); ;
        }

        /// <summary>
        /// Method used to fetch an array with all ingredients without the null values.
        /// </summary>
        /// <returns>an array without the null or empty strings</returns>
        public string[] getNonNullIngredients()
        {
            string[] currentIngredients = new string[getCurrentNumOfIngredients()];
            for (int index = 0; index < IngredientArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(IngredientArray[index]))
                {
                    currentIngredients[index] = ingredientArray[index];
                }

            }
            return currentIngredients;
        }

        /// <summary>
        /// Method used to add an ingredient to the ingredient array.
        /// </summary>
        /// <param name="ingredient">A string representing the ingredient to be added to the array</param>
        /// <returns>True if the ingredient was successfully added, returns false if there was no vacant positions in the array for the ingredient</returns>
        public bool AddIngredient(string ingredient)
        {
            int index = FindVacantPosition();
            if (index != -1)
            {
                IngredientArray[index] = ingredient;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method called to check if a given index is within the range of the ingredient array.
        /// This is used to make sure the index is not out of bounds.
        /// </summary>
        /// <param name="index">The index we want to confirm is in range of the array</param>
        /// <returns>True if the index is within range, false if it is not</returns>
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < IngredientArray.Length)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// A method used to count the current number of ingredients in the ingredient array.
        /// </summary>
        /// <returns>The amount of strings that is not empty or null, i.e the amount of ingredients.</returns>
        public int getCurrentNumOfIngredients()
        {
            int count = 0;
            for (int index = 0; index < IngredientArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(IngredientArray[index]))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Overridden ToString method so we can print out information about the Recipe class instance in a neat way.
        /// </summary>
        /// <returns>A formatted string regarding name, number of ingredients, category and description</returns>
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description!";

            return string.Format("{0, -18} {1, -4} {2, -12} {3, -15}", name, getCurrentNumOfIngredients(), category.ToString(), descriptionText);
        }

        /// <summary>
        /// Method used to edit a ingredient at a certain index.
        /// </summary>
        /// <param name="index">The index of the ingredient to be edited</param>
        /// <param name="newIngredient">The string representing the new ingredient that will replace the old one</param>
        /// <returns>True if the ingredient is successfully replaced, false if it failed</returns>
        public bool ChangeIngredientAt(int index, string newIngredient)
        {
            if (CheckIndex(index))
            {
                IngredientArray[index] = newIngredient;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Property for the field description to let other classes access it safely.
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        /// <summary>
        /// Property for the field category to let other classes access it safely.
        /// </summary>
        public FoodCategory Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        /// <summary>
        /// Property for the field name to let other classes access it safely.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// A getter that returns the maximum amount of ingedients the recipe can have.
        /// </summary>
        public int MaxNumOfIngredients
        {
            get { return IngredientArray.Length; }
        }

        /// <summary>
        /// Property for the ingredient array.
        /// </summary>
        public string[] IngredientArray
        {
            get
            {
                return ingredientArray;
            }

            set
            {
                ingredientArray = value;
            }
        }
    }
}
