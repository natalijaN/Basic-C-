using System.Collections.Generic;
using System;
using ClassLibrary;
using System.Linq;

namespace Homework
{ 

    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Sculptor),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, Race.Collie),
                new Dog("Buddy", "Brown", 1, Race.Doberman),
                new Dog("Max", "Olive", 1, Race.Plott),
                new Dog("Archie", "Black", 2, Race.Mutt),
                new Dog("Oscar", "White", 1, Race.Mudi),
                new Dog("Toby", "Maroon", 3, Race.Bulldog),
                new Dog("Ollie", "Silver", 4, Race.Dalmatian),
                new Dog("Bailey", "White", 4, Race.Pointer),
                new Dog("Frankie", "Gray", 2, Race.Pug),
                new Dog("Jack", "Black", 5, Race.Dalmatian),
                new Dog("Chanel", "Black", 1, Race.Pug),
                new Dog("Henry", "White", 7, Race.Plott),
                new Dog("Bo", "Maroon", 1, Race.Boxer),
                new Dog("Scout", "Olive", 2, Race.Boxer),
                new Dog("Ellie", "Brown", 6, Race.Doberman),
                new Dog("Hank", "Silver", 2, Race.Collie),
                new Dog("Shadow", "Silver", 3, Race.Mudi),
                new Dog("Diesel", "Brown", 1, Race.Bulldog),
                new Dog("Abby", "Black", 1, Race.Dalmatian),
                new Dog("Trixie", "White", 8, Race.Pointer),
            };


            //==============================
            // TODO Homework requirements
            //==============================

            //PART 1
            // 1. Structure the solution (create class library and move classes and enums accordingly)

            //PART 2
            // 1. Take person Cristofer and add Jack, Ellie and Hank as his dogs.
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            // 3. Add Trixie, Archie and Max as dogs from Erin
            // 4. Give Abby and Shadow to Amelia

            foreach (var person in people)
            {
                person.Dogs = new List<Dog>();
            }
            
            //Cristofer

            var Jack = dogs.Where(d => d.Name == "Jack").FirstOrDefault();
            var Ellie = dogs.Where(d => d.Name == "Ellie").FirstOrDefault();         
            var Hank = dogs.Where(d => d.Name == "Hank").FirstOrDefault();
           
            var Cristofer = people.Where(p => p.FirstName == "Cristofer").FirstOrDefault();

            Cristofer.Dogs = new List<Dog>();

            Cristofer.Dogs.Add(Jack);
            Cristofer.Dogs.Add(Ellie);
            Cristofer.Dogs.Add(Hank);


            //Freddy

            var Oscar = dogs.Where(d => d.Name == "Oscar").FirstOrDefault();         
            var Toby = dogs.Where(d => d.Name == "Toby").FirstOrDefault();       
            var Chanel = dogs.Where(d => d.Name == "Chanel").FirstOrDefault();      
            var Bo = dogs.Where(d => d.Name == "Bo").FirstOrDefault();
            var Scout = dogs.Where(d => d.Name == "Scout").FirstOrDefault();

            var Freddy = people.Where(p => p.FirstName == "Freddy").FirstOrDefault();

            Freddy.Dogs = new List<Dog>();

            Freddy.Dogs.Add(Oscar);
            Freddy.Dogs.Add(Toby);
            Freddy.Dogs.Add(Chanel);
            Freddy.Dogs.Add(Bo);
            Freddy.Dogs.Add(Scout);

            //Erin

            var Trixie = dogs.Where(d => d.Name == "Trixie").FirstOrDefault();
            var Archie = dogs.Where(d => d.Name == "Archie").FirstOrDefault();
            var Max = dogs.Where(d => d.Name == "Max").FirstOrDefault();

            var Erin = people.Where(p => p.FirstName == "Erin").FirstOrDefault();

            Erin.Dogs = new List<Dog>();


            Erin.Dogs.Add(Trixie);
            Erin.Dogs.Add(Archie);
            Erin.Dogs.Add(Max);

            //Amelia

            var Abby = dogs.Where(d => d.Name == "Abby").FirstOrDefault();
            var Shadow = dogs.Where(d => d.Name == "Shadow").FirstOrDefault();

            var Amelia = people.Where(p => p.FirstName == "Amelia").FirstOrDefault();

            Amelia.Dogs = new List<Dog>();

            Amelia.Dogs.Add(Abby);
            Amelia.Dogs.Add(Shadow);


            //PART 3 - LINQ
            // 1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER

            var peopleNameWithR = people.Where(p => p.FirstName.StartsWith("R")).OrderByDescending(p => p.Age)
                                         .Select(p => p.FirstName).ToList();

            if(peopleNameWithR.Count == 0)
            {
                Console.WriteLine(@"There aren`t people who`s names starts with ""R""!");
            }
            else
            {
                Console.WriteLine(@"People who`s names starts with ""R"" are:");
                foreach (var names in peopleNameWithR)
                {
                    Console.WriteLine(names);
                }
            }

            Console.WriteLine();    
            Console.ReadLine();
            Console.WriteLine();
            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER

            var dogsNames = dogs.Where(d => d.Color == "Brown" && d.Age > 3).OrderBy(d => d.Age)
                                .Select(d => d.Name).ToList();

            if (dogsNames.Count == 0)
            {
                Console.WriteLine("There aren`t dogs with that specifications!");
            }
            else
            {
                Console.WriteLine("Dogs which are brown and have more than 3 years are:");
                foreach (var names in dogsNames)
                {
                    Console.WriteLine(names);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();

            // 3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER

            var peopleWithDogs = people.Where(p => p.Dogs.Count > 2).OrderByDescending(p => p.FirstName).ToList();

            Console.WriteLine("Person with more than 2 dogs:");
            foreach (var personWithDog in peopleWithDogs)
            {
                Console.WriteLine(personWithDog.FirstName);
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();

            // 4. Find and print all Freddy`s dogs names older than 1 year

            var freddyDogs = Freddy.Dogs.Where(d => d.Age > 1).Select(d => d.Name).ToList();

            Console.WriteLine("Freddy`s dogs orlder than 1 year old:");

            foreach (var dog in freddyDogs)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();

            // 5. Find and print Nathen`s first dog

            var Nathen = people.Where(p => p.FirstName == "Nathen").FirstOrDefault();

            var nathenDogs = Nathen.Dogs.FirstOrDefault();

            if(nathenDogs == null)
            {
                Console.WriteLine("Nathen has no dogs!");
            }
            else
            {
                Console.WriteLine("Nathen`s first dog " + nathenDogs.Name);
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();


            // 6. Find and print all white dogs names from Cristofer, Freddy, Archie and Amelia, ordered by Name - ASCENDING ORDER


            var whiteDogsC = Cristofer.Dogs.Where(d => d.Color == "White").ToList();
            var whiteDogsF = Freddy.Dogs.Where(d => d.Color == "White").ToList();
            var whiteDogsE = Erin.Dogs.Where(d => d.Color == "White").ToList();
            var whiteDogsA = Amelia.Dogs.Where(d => d.Color == "White").ToList();

            var whiteDogs = new List<string>();

            Console.WriteLine("White dogs names:");
            foreach (var dog in whiteDogsC)
            {
                whiteDogs.Add(dog.Name);
            }
   
            foreach (var dog in whiteDogsF)
                {
                    whiteDogs.Add(dog.Name);
                }

            foreach (var dog in whiteDogsE)
            {
                whiteDogs.Add(dog.Name);
            }

            foreach (var dog in whiteDogsA)
            {
                whiteDogs.Add(dog.Name);
            }

            var orderedList = whiteDogs.OrderBy(d => d).ToList();

            foreach (var whiteDog in orderedList)
            {
                Console.WriteLine(whiteDog);
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();

            //PART 4 - Be Creative, PLAY with LINQ :) 
        }
    }
}

