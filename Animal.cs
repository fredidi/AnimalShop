using System;

namespace PetShop
{
    class Animal
    {
        public string AnimalType { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public virtual void ShowAllProperties()
        {
            string info = $"- Here are some more information about your pet you've just bought:\n\t";
            info += $"Type: {AnimalType}\n\t" +
                $"Name: {Name}\n\t" +
                $"Breed: {Breed}\n\t" +
                $"Color: {Color}\n\t" +
                $"Price: {Price:C}";
            Console.WriteLine(info);
        }
    }
}
