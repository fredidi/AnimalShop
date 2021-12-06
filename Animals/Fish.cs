using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Fish : Animal
    {
        public string CanFitInAquarium { get; set; }
        public string Healthy { get; set; }
        public int Age { get; set; }

        public override void ShowAllProperties()
        {
            base.ShowAllProperties();
            string info = $"\tAquarium Fish: {CanFitInAquarium}\n\t" +
                $"Healthy: {Healthy}\n\t" +
                $"Age: {Age} months old\n\t";
            Console.WriteLine(info);
        }
    }
}
