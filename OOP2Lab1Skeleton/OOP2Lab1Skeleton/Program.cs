using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP2Lab1Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person_Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person_Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person person_Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person_Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine("Gina’s information as sentence:");
            Console.WriteLine(person_Gina.ToString());

            Console.WriteLine("Mike’s information as list:");
            person_Mike.DisplayPersonInfo();


            person_Ian.ChangeFavoriteColour("White");
            Console.WriteLine("Ian’s information as sentence after changing favourite colour to White");
            Console.WriteLine(person_Ian.ToString());


            Console.WriteLine($"Mary's age in 10 years is:{person_Mary.GetAgeInTenYears()}");


            Relation r1 = new Relation('S');
            r1.ShowRelation(person_Gina, person_Mary);


            Relation r2 = new Relation('B');
            r2.ShowRelation(person_Ian, person_Mike);


            List<Person> people = new List<Person>
            {
                person_Ian,
                person_Gina,
                person_Mike,
                person_Mary
            };

            Console.WriteLine("The average age is: " + calculateAverage(people));

            Person youngestPerson = getYoungestPerson(people);
            Console.WriteLine($"The youngest person is: {youngestPerson.firstName} {youngestPerson.lastName} at age of {youngestPerson.age}");

            Person oldestPerson = getOldestPerson(people);
            Console.WriteLine($"The oldest person is: {oldestPerson.firstName} {oldestPerson.lastName} at age of {oldestPerson.age}");


            Console.WriteLine("List of people with first name starts with M:");

            Console.WriteLine("List of people likes Blue:");
            displayNamesthatLikeBlue(people);

            Console.ReadKey();

        }


        static double calculateAverage(List<Person> people)
        {

            double numerator = 0;
            double denominator = 0;
            foreach (Person person in people)
            {
                numerator += person.age;
                denominator++;
            }

            return numerator / denominator;
        }

        static Person getYoungestPerson(List<Person> people)
        {
            double lowest_age = people.Min(p => p.age);
            Person youngest = people.Find(p => p.age == lowest_age);
            return youngest;
        }


        static Person getOldestPerson(List<Person> people)
        {

            double oldest_age = people.Max(p => p.age);
            Person oldest = people.Find(p => p.age == oldest_age);
            return oldest;
        }


        static void displayNamesthatstartWithM(List<Person> people)
        {

        }


        static void displayNamesthatLikeBlue(List<Person> people)
        {
            foreach (Person person in people)
            {

                if (person.favouriteColour == "Blue") 
                {
                    Console.WriteLine($"\t{person.firstName} {person.lastName}");    
                }
            }
        }
    }
}