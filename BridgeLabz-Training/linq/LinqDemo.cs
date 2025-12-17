using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.linq
{

    public class Student
    {
        public int Id {  get; set; }
        public string Name  { get; set; }
        public int Age { get; set; }
    }

    public class FeesDetails
    {
        public int Id { get; set; }
        public float FeesAmount { get; set; }
    }


    internal class LinqDemo    //linq is used to query data like list, queue, objects, xml...
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 12, 41, 56, 78 };


            //WITHOUT LINQ

            //foreach(int i in numbers)          
            //{
            //    if (i > 10)
            //    {
            //        result.Add(i);
            //    }
            //}

            //WITH LINQ

            var result = numbers.Where(n => n > 10);  //method syntax (more used)

            var result2 = from n in numbers where n > 10 select n;  //query syntax


            //ToList() can be used after Linq function to make them editable, if its read only then its fine as it is.


            //SOME LINQ FUNCTIONS 

            //WHERE -> filtering
            var result3 = numbers.Where(n => n % 2 == 0);

            //SELECT -> selection, transforms data
            var result4 = numbers.Select(n => n * n);
   

            //ORDERBY -> sorting
            var result5 = numbers.OrderBy(n => n);
          

            //ORDERBYDESCENDING -> sorts in reverse order
            var result6 = numbers.OrderByDescending(n => n);
     

            //AGGREGATION -> sum, count, max, min
            var result7 = numbers.Sum(n => n);
           

            //GROUP BY -> groups by 
            var result8 = numbers.GroupBy(n => n < 5);
           


            //before joining creating the lists with Student and FeesDetails structure.

            List<Student> student = new List<Student>()
            {
                new Student{Id=1, Name = "Adarsh", Age = 21},
                new Student{Id=2, Name = "AK", Age = 20},
                new Student{Id=3, Name = "Kumar", Age= 19}
            };

            List<FeesDetails> fees = new List<FeesDetails>()
            {
                new FeesDetails{Id=1, FeesAmount = 20000},
                new FeesDetails{Id=2, FeesAmount = 10000},
                new FeesDetails{Id=3, FeesAmount = 25000}
            };

            //JOIN -> joins two or more structures like List based on commmon field   
            //SYNTAX OF JOIN -> OUTER.Join(INNER, OUTERKEY, INNERKEY, RESULT);

            var result9 = student.Join(
                fees,
                s => s.Id,
                f => f.Id,
                (s, f) => new { s.Name, f.FeesAmount }
                );

            foreach(var i in result9)
            {
                Console.WriteLine(i.Name + " -> " + i.FeesAmount);
            }

        }
    }
}
