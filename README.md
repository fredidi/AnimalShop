# AnimalShop

This week you will learn more about classes.
For the following material, you should focus on what we talked about in the recorded session.

Watch the following video. Make sure you have watched last week’s videos first.
https://channel9.msdn.com/Series/C-Sharp-Fundamentals-Development-for-Absolute-Beginners/Working-with-Classes-and-Inheritances-in-the-NET-Framework-Class-Library-16

Watch:
https://channel9.msdn.com/Series/C-Sharp-Fundamentals-Development-for-Absolute-Beginners/Understanding-Scope-and-Utilizing-Accessibility-Modifiers-18

Read about classes here:
https://en.wikibooks.org/wiki/C_Sharp_Programming/Classes
Focus on the following headings: Methods, Constructors, Properties.

Also read https://en.wikibooks.org/wiki/C_Sharp_Programming/Objects
And read https://en.wikibooks.org/wiki/C_Sharp_Programming/Encapsulation - the chapters private, protected and public.

Answer the following questions as a comment in your code.
1. When should you use private instead of public?
2. When is it useful to have multiple constructor functions?

Your exercise for this week is to build a simple program with a class hierarchy. Imagine a pet shop, that sells different kinds of animals.

Create a class named AnimalShop that represents the pet shop.

Features:

- Create one class for each animal (at least three) that the shop can sell.
- Each animal class should have at least three properties.
- Also create a class Animal that contains whatever properties all animals have  
  in common. For example, each animal needs a price.
- Make sure that each specific animal class inherits from Animal.
- AnimalShop should have a method "public Animal SellAnimal(string animalType)" that returns an animal of the specified type.
If there is no such animal, for example if the user asks for a "crocodile" but you don't have a class Crocodile, it should return null.
- When an animal is sold, the AnimalShop object should gain money.
- Store the money in a property.
- Finally write a program that tests your classes (Menu).
  - It should create an object of the class AnimalShop.
  - Then buy some animals and print the values of all their properties.

Betygskriterier:

För G:

Alla ovanstående features ska vara implementerade.

För VG:

Alla ovanstående features ska vara implementerade för betyget G samt en extra inlämningsuppgift om interface ska lämnas in.

VG – uppgiften:

Skapa en konsolapplikation.

Gör en klass som heter program1 och en klass som heter program2.
Den ena klassen ska ha en metod run() med returtyp void.
Den andra klassen ska ha en metod Go() också med returtyp void.

I metoderna skriver du ut ”Nu kör vi program 1” respektive ”nu kör vi program 2”.

Skapa objekt för båda klasserna i main() och anropa metoderna.
Kommentera sedan bort anropet till metoderna och metoderna i klasserna.

Gör ett interface som har en metod start(). Implementera (använd) interfacet på båda klasserna.

Gör så att kontraktet för interfacet blir uppfyllt.
Skapa sedan ytterligare ett interface och lägg detta till första klassen. Lägg till valfri metod och se till att alla kontrakt uppfylls
