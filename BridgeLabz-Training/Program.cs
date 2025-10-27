using System;

class Animal 
{

    public int NumberOfLegs;
    public string Name;
    public string Colour;

    public Animal(int n, string name, string colour) {

        this.NumberOfLegs = n;
        this.Name = name;
        this.Colour = colour;
    
    }

    public virtual void getAnimalData() {

        Console.WriteLine($"The animal is: {Name} and it has {NumberOfLegs} legs and it's {Colour} in colour!");

    }


}


class OOPS
{


    static void Main(string[] args)
    {
        Animal a1 = new Animal(4, "dog", "black");

        a1.getAnimalData();

        Console.ReadLine();

    }
}