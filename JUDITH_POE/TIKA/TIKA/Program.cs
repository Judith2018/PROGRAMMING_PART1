// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        // Displays the current Foreground color 
        Console.ForegroundColor = ConsoleColor.Cyan;
        //create the instance of the class
        Recipe recipe1 = new Recipe();
        while (true)
        {
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("\nWelcome!");
            Console.WriteLine("************************************************************************************");
            Console.WriteLine("Select one of the following\n 1.Recipe details\n 2.Display the recipe\n 3.Scale recipe quantities\n 4.Reset quantites \n 5.Clear recipe\n 6.Exit");
            Console.WriteLine("************************************************************************************");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    recipe1.EnterData();
                    break;
            
                case "2":
                    recipe1.DisplayRecipe();
                    break;
                case "3":
                    Console.WriteLine("Select a scale of 0.5, 2, or 3");
                    double scale = Convert.ToDouble(Console.ReadLine());
                    recipe1.RecipeQauntity(scale);
                    break;
                case "4":
                    recipe1.ResetScale();
                    break;
                case "5":
                    recipe1.ClearRecipe();
                    break;
                case "6":
                   Environment.Exit(0);
                    break;
            }
            

        }


        }
    }
//the Recipe class stores the arrays 

    class Recipe
    {
        private String[] ingredients;
        private double[] quantity;
        private string[] units;
        private string[] steps;


        public Recipe()
        {
            
            ingredients = new String[0];
            quantity = new double[0];
            units = new string[0];
            steps = new string[0];
        }
        //this method stores the data the user will enter
        public void EnterData()
        {

            int ingredientsNo = Convert.ToInt32(Console.ReadLine());

            ingredients = new string[ingredientsNo];
            quantity = new double[ingredientsNo];
            units = new string[ingredientsNo];

            for (int i = 0; i < ingredientsNo; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");

                Console.Write("\nEnter ingredient name: ");
                ingredients[i] = Console.ReadLine();

                Console.Write("\nEnter ingredient quantity: ");
                quantity[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter unit of measurement: ");
                units[i] = Console.ReadLine();

                ingredients[i] = $"{quantity} {units} of {ingredients}";
            }
            //gathering recipe steps
            Console.Write("\nEnter the number of steps: ");
            int stepsNo = Convert.ToInt32(Console.ReadLine());

            steps = new string[stepsNo];
            for (int j = 0; j < stepsNo; j++)
            {
                Console.Write($"Enter step {j + 1}: ");
                steps[j] = Console.ReadLine();
            }

        }
    //this method will store the recipe details
        public void DisplayRecipe()
        {
            Console.WriteLine("\nHere is your recipe:");
            Console.WriteLine("Ingredients:");
            for(int i = 0;i < ingredients.Length;i++)
            {
                Console.WriteLine($"- {quantity[i]}{units[i]}   {ingredients[i]}");
            }
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{steps[i]}");
            }
        }
        //this method calculates the recipe quantity
        public void RecipeQauntity(double scale)
        {
            for (int i = 0; i < quantity.Length; i++)

            {
                quantity[i] *= scale;
            }
        }
    //this resets the recipe quantity 
        public void ResetScale()
        {
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] /= 2;
            }
        }
        //clearRecipe clears the whole recipe
        public void ClearRecipe()
        {
        Console.WriteLine("Are you sure you want to clear if no click 0 or yes click 1");
        int Num = Convert.ToInt32(Console.ReadLine());
        if(Num == 1)

            ingredients = new String[0];
            quantity = new double[0];
            units = new string[0];
            steps = new string[0];
        }

    }



      
