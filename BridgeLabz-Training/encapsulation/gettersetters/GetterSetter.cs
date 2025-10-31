using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.encaptulation.gettersetters
{
 
        internal class GetterSetter            //In C#, getters and setters are special methods (called accessors) that control how a property is read (get) and modified (set).
                                               // Can be used to Control access to private fields(encapsulation) and Add validation or logic when reading/writing data
        {

        private int age;   //to store custom getter setters
        private string name1;   //for custom getter setter implementation


            public int Age
            {       //custom getter setters
                get
                {
                    return age;          //gets Age
                }
                set
                {
                    if (value > 0)
                    {
                        age = value;   //sets value to the variable Age
                    }
                    else
                    {
                        Console.WriteLine("Age must be greater than 0");
                    }
                }

            }

            public string Name { get; set; }   //automatic getter setter implementation(shorthand way), it works same as one given below
            public string Name1
            {              //expansion of auto implementaion, its same as above implementation

                get
                {
                    return name1;
                }
                set
                {
                    name1 = value;
                }

            }
        
    

        }
}
