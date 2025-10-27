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

    public void getAnimalData() {

        Console.WriteLine($"The animal is: {Name} and it has {NumberOfLegs} legs and it's {Colour} in colour!");

    }

    public virtual void Desc()
    {
        Console.WriteLine("Its Animal");
    }


}

class WildAnimals : Animal
{
    public WildAnimals(int n, string name, string colour) : base(n, name, colour) 
    {

       //data saved

    }

    public override void Desc()
    {
        Console.WriteLine("Its Wild Animal");
    }

}


class OOPS
{


    static void Main(string[] args)
    {
        Animal dog = new Animal(4, "dog", "black");

        dog.getAnimalData();
        dog.Desc();

        WildAnimals lion = new WildAnimals(4, "lion", "yellow");

        lion.getAnimalData();
        lion.Desc();

        Console.ReadLine();

    }
}