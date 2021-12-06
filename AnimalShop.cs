using System;

namespace PetShop
{
    class AnimalShop
    {
        public Animal[] Animals;
        public decimal Balance { get; set; }    //public för att nå ifrån Program.cs

        public AnimalShop()
        {
            Balance = 30000;
            Animals = new Animal[3];

            Dog myDog = new Dog
            {
                AnimalType = "Dog",
                Name = "Quincie",
                Breed = "Labrador",
                Color = "Red Fox",
                Age = 4,
                Puppy = "Yes",
                Adopted = "No",
                Price = 20000
            };

            Cat myCat = new Cat
            {
                AnimalType = "Cat",
                Name = "Night Fury",
                Breed = "Bombay Cat",
                Color = "Black",
                Age = 8,
                IndoorCat = "Yes",
                Adopted = "Yes",
                Price = 13500
            };

            Fish myFish = new Fish
            {
                AnimalType = "Fish",
                Name = "Fisherman",
                Breed = "Electric Blue Cichlid",
                Color = "Blue",
                Age = 6,
                CanFitInAquarium = "Yes",
                Healthy = "Yes",
                Price = 129
            };

            Animals[0] = myDog;
            Animals[1] = myCat;
            Animals[2] = myFish;
        }

        public Animal SellAnimal(string animalType)
        {
            foreach (var animal in Animals)
            {
                //Om användaren anger animalType så kollar vi i animal-listan om det finns/matchar.
                if (animal.AnimalType.ToLower() == animalType.ToLower())
                {
                    Balance += animal.Price;    //true, då tar vi betalt och sparar i Balance.
                    return animal;
                }
            }
            return null;                        //Om animal inte finns, blir det null. Alltså null = inget värde
        }

        public void ShowAnimalList() //Skall inte returnera någonting. Bara göra.
        {
            foreach (var animal in Animals) //Går igenom listan/array.
            {
                Console.WriteLine(animal.AnimalType);   //Visa djuren som finns i listan.
            }
        }
    }
}

