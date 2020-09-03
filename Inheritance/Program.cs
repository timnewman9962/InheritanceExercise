using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var Parakeet = new Bird() 
            { 
                IsMigratory = false, 
                AvgWingspan = 12, 
                CanFly = true, 
                NumColors = 2
            };
            Parakeet.Age = 18;
            Parakeet.Species = "bird";
            Parakeet.CanDomesticate = true;
            Parakeet.NumLegs = 2;

            DescribeBaseClass(Parakeet);
            Console.WriteLine($"Additionally, it can {(Parakeet.CanFly? "":"not ")}fly, " +
                $"is {(Parakeet.IsMigratory? "":"not ")}migratory, and has a wingspan of {Parakeet.AvgWingspan} inches.  " +
                $"This one has {Parakeet.NumColors} colors.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var Turtle = new Reptile()
            {
                IsVenemous= false,
                type= "fresh-water",
                HasForkedTongue=false,
                IsBanned=false
            };
            Turtle.Age = 42;
            Turtle.Species = "turtle";
            Turtle.CanDomesticate = true;
            Turtle.NumLegs = 4;

            DescribeBaseClass(Turtle);
            Console.WriteLine($"Additionally, it is a {Turtle.type} type, with{(Turtle.HasForkedTongue? "":"out")} a forked tongue, " +
                $"and is {(Turtle.IsVenemous? "":"not ")}venemous.  " +
                $"It is generally {(Turtle.IsVenemous? "":"not ")}banned in the United States");
        }

        public static void DescribeBaseClass(Animal inClass)
        {
            Console.WriteLine($"\nThis type of animal is a {inClass.Species}.\n" +
                $"It is {inClass.Age} months, has {inClass.NumLegs} legs, " +
                $"and can {(inClass.CanDomesticate? "":"not ")}be domesticated.\n");
        }

        public class Animal
        {
            public int Age { get; set; }
            public string Species { get; set; }
            public bool CanDomesticate { get; set; }
            public int NumLegs { get; set; }

        }
        public class Bird : Animal
        {
            public bool IsMigratory { get; set; }
            public int AvgWingspan { get; set; }
            public bool CanFly { get; set; }
            public int NumColors { get; set; }
        }
        public class Reptile : Animal
        {
            public bool IsVenemous { get; set; }
            public string type { get; set; }
            public bool HasForkedTongue { get; set; }
            public bool IsBanned { get; set; }
        }
    }
}
