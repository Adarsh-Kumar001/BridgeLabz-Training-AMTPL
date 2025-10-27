using System;

class Animal 
{

    public int NumberOfLegs { get; set; }  //auto implements getter setter
    public string Name { get; set; }      
    public string Colour { get; set; }

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
    public WildAnimals(int n, string name, string colour) : base(n, name, colour)   //new constructor inhertited from base class
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

        WildAnimals tiger = new WildAnimals(0,"not known","not known");  
        tiger.Name = "tiger";        //setter usage
        tiger.NumberOfLegs = 4;          //setter
        tiger.Colour = "orage with black strips";   //setter

        tiger.getAnimalData();

        Console.ReadLine();

    }
}