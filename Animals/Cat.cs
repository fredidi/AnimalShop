using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Cat : Animal
    {
        public string IndoorCat { get; set; }
        public string Adopted { get; set; }
        public int Age { get; set; }

        public override void ShowAllProperties()
        {
            base.ShowAllProperties();
            string info = $"\tIndoor Cat: {IndoorCat}\n\t" +
                            $"Adopted: {Adopted}\n\t" +
                            $"Age: {Age} years old\n\t";
            Console.WriteLine(info);
        }
    }
}
