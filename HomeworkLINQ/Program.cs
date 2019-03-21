using HomeworkLINQ.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLINQ
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
            
            var cristofer = people[19];
            var jack = dogs.Where(dog => dog.Name == "Jack").ToList();
            cristofer.Dogs.AddRange(jack);

            var ellie = dogs.Where(dog => dog.Name == "Ellie").ToList();
            cristofer.Dogs.AddRange(ellie);

            var hank = dogs.Where(dog => dog.Name == "Hank").ToList();
            cristofer.Dogs.AddRange(hank);

            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.

            var freddy = people[17];

            var oscar = dogs.Where(dog => dog.Name == "Oscar").ToList();
            freddy.Dogs.AddRange(oscar);

            var toby = dogs.Where(dog => dog.Name == "Toby").ToList();
            freddy.Dogs.AddRange(toby);

            var chanel = dogs.Where(dog => dog.Name == "Chanel").ToList();
            freddy.Dogs.AddRange(chanel);

            var bo = dogs.Where(dog => dog.Name == "Bo").ToList();
            freddy.Dogs.AddRange(bo);

            var scout = dogs.Where(dog => dog.Name == "Scout").ToList();
            freddy.Dogs.AddRange(scout);

            // 3. Add Trixie, Archie and Max as dogs from Erin

            var erin = people[16];

            var trixie = dogs.Where(dog => dog.Name == "Trixie").ToList();
            erin.Dogs.AddRange(trixie);

            var archie = dogs.Where(dog => dog.Name == "Archie").ToList();
            erin.Dogs.AddRange(archie);

            var max = dogs.Where(dog => dog.Name == "Max").ToList();
            erin.Dogs.AddRange(max);

            // 4. Give Abby and Shadow to Amelia
            var amelia = people[12];

            var abby = dogs.Where(dog => dog.Name == "Abby").ToList();
            erin.Dogs.AddRange(abby);

            var shadow = dogs.Where(dog => dog.Name == "Shadow").ToList();
            erin.Dogs.AddRange(shadow);

            //PART 3 - LINQ
            // 1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER

            var peopleStartsWithR = people.Where(person => person.FirstName.StartsWith("R")).OrderByDescending(person => person.Age).ToList();
            if(peopleStartsWithR.Count > 0){
                foreach (var person in peopleStartsWithR)
                {
                    Console.WriteLine($"First name:{person.FirstName} / Last name:{person.LastName}");
                }
            }
            else Console.WriteLine($"There are no persons starting with that Caracter");
            Console.WriteLine();
            
            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            var brownDogs = dogs.Where(dog => dog.Color == "Brown")
                                                                  .Where(dog => dog.Age > 3)
                                                                  .OrderBy(dog => dog.Age).ToList();
            if (brownDogs.Count > 0)
            {
                foreach (var dogies in brownDogs)
                {
                    Console.WriteLine($"Dog name:{dogies.Name} Age:{dogies.Age}  Color:{dogies.Color}");
                }
            }
            else Console.WriteLine("There is no Brown Dogs");
            
            Console.WriteLine();

            // 3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            var peopleWithMoreDogs = people.Where(find => find.Dogs.Count > 2).OrderByDescending(p => p.FirstName).ToList();

            if (peopleWithMoreDogs.Count > 0)
            {
                foreach (var item in peopleWithMoreDogs)
                {
                    Console.WriteLine($"Name:{item.FirstName} {item.LastName}  Numbers of dogs:{item.Dogs.Count}");
                }
            }
            else Console.WriteLine("There is no persons with more than 2 dog");

            Console.WriteLine();

            // 4. Find and print all Freddy`s dogs names older than 1 year
            var freddyDogNames = freddy.Dogs.Where(dog => dog.Age > 1).Select(dog => dog.Name).ToList();

            foreach (var item in freddyDogNames)
            {
                Console.WriteLine($"Freddy's dogs older than 2 years are:{item}");
            }

            // 5. Find and print Nathen`s first dog
            var nathen = people[15];
            nathen.Dogs.Add(dogs[2]);
            nathen.Dogs.Add(dogs[3]);

            nathen.Dogs.Add(dogs[4]);

            var getNathensDogs = nathen.Dogs.Where(p => p.Name.Length > 0).Select(dog => dog.Name).ToList();
            var getFirstDog = getNathensDogs.FirstOrDefault();
            Console.WriteLine($"Nathens first dog: {getFirstDog}");

            // 6. Find and print all white dogs names from Cristofer, Freddy, Archie and Amelia, ordered by Name - ASCENDING ORDER
            
            var cristofersDogs = cristofer.Dogs.Where(dog => dog.Color == "White").OrderBy(d => d.Name).ToList();
            var freddysDogs = freddy.Dogs.Where(dog => dog.Color == "White").OrderBy(d => d.Name).ToList();
            var erinsDogs = erin.Dogs.Where(dog => dog.Color == "White").OrderBy(d => d.Name).ToList();
            var ameliasDogs = amelia.Dogs.Where(dog => dog.Color == "White").OrderBy(d => d.Name).ToList();

            List<Dog> dogz = new List<Dog>();
            dogz.AddRange(cristofersDogs);
            dogz.AddRange(freddysDogs);
            dogz.AddRange(erinsDogs);
            dogz.AddRange(ameliasDogs);

            foreach (var item in dogz)
            {
                Console.WriteLine($"{item.Name}");
            }

            //cristofersDogs.ForEach(c => Console.WriteLine($"Cristofer's white dogs name {c.Name}"));
            //freddysDogs.ForEach(c => Console.WriteLine($"Freddys's white dogs name {c.Name}"));
            //erinsDogs.ForEach(c => Console.WriteLine($"Erins's white dogs name {c.Name}"));
            //ameliasDogs.ForEach(c => Console.WriteLine($"Amelian's white dogs name {c.Name}"));

            
            Console.ReadLine();
            //PART 4 - Be Creative, PLAY with LINQ :) 
        }
    }
}
