using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Animal
{
    public void AnimalMethod()
    {
        Console.WriteLine("I am an Animal");
    }
}

class Dog : Animal
{
    public void DogMethod()
    {
        Console.WriteLine("I have four legs");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of the Dog class
        Dog myDog = new Dog();

        // Calling methods from both classes
        myDog.AnimalMethod();
        myDog.DogMethod();

        // Displaying the desired output
        Console.WriteLine("I am an animal and I have four legs");
    }
}
