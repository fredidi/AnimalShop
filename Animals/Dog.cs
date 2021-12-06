using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Dog : Animal
    {
        public string Puppy { get; set; }
        public string Adopted { get; set; }
        public int Age { get; set; }

        public override void ShowAllProperties()
        {
            base.ShowAllProperties();

            string info = $"\tPuppy: {Puppy}\n\t" +
                $"Adopted: {Adopted}\n\t" +
                $"Age: {Age} months young\n\t";
            Console.WriteLine(info);
        }
    }
}
