using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Intro();
            menu.RunPetShop();

            /* 
             * 1. When should you use private instead of public?
             * You should always use private in a class to keep it within the internal class. You should only use public if you want to reach it outside its class.
             * 
             * 
             * 2. When is it useful to have multiple constructor functions?
             * It's useful if you want to e.g. create different objects in a class. Multiple constructors make it convenient if you
             * e.g. want to create another object but only use part of the parameters that you've already pre-setup from beginning.
            */

        }
    }
}
