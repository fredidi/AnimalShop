using System;

namespace PetShop
{
    class Menu
    {
        AnimalShop menu = new AnimalShop();
        public void Intro()
        {
            string intro = "Welcome to Fredrik's Pet Shop Online!";
            intro += $"\n<<< Current balance is {menu.Balance:C2} >>>";
            intro += "\nPick one of the following options:" +
                "\n[1] Buy Animal." +
                "\n[2] Exit Shop.";
            Console.WriteLine(intro);
        }
        public void RunPetShop()
        { 
            string userInput = Console.ReadLine();
            bool success = int.TryParse(userInput, out int value);
            while (!success && value < 1 || value > 2)                              //Om inte rätt input, loopa runt tills användare anger korrekt option.
            {
                Console.Write("Incorrect option. Please try again: ");
                userInput = Console.ReadLine();
                success = int.TryParse(userInput, out value);
            }
            if (value == 2)
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("\n- These animals are in stock: ");
                menu.ShowAnimalList();                                              //Visa lista på djur
                Console.WriteLine("\n- Which animal do you want to buy?");          //Ber användare välja ett djur
                userInput = Console.ReadLine();                                     //Spara värdet av användare
            }
            Animal requestedAnimal = menu.SellAnimal(userInput);                    //Gå igenom om angiven värde finns i "listan/array".
            if (requestedAnimal == null)
            {
                Console.WriteLine($"\n- Sorry. We don't have '{userInput}'.\n" +    //Om userInput != AnimalType = null
                    $"Thank you for visiting us today.\n" +
                    $"Press ENTER to leave the shop.");
            }
            else
            {
                Console.WriteLine($"\n{requestedAnimal.AnimalType} has been sold for {requestedAnimal.Price:C2}.\n" +
                    $"<<< Current balance is now {menu.Balance:C} >>>\n\t");
                requestedAnimal.ShowAllProperties();
                Console.WriteLine("\n- Thank you for your purchase at Fredrik's Pet Shop Online. You are welcome back!" +
                    "\nPress ENTER to leave the shop.");
            }
        }
    }
}
