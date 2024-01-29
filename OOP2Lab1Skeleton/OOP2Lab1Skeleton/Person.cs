using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace OOP2Lab1Skeleton
{
    public class Person
    {
        // Attributes Decleration 
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favouriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }

        // TODO: Declare other attributes
        // ...................

        // Class Constructor
/*        public Person(int personId, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            // Initialize all attributes here
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColour = favouriteColour;
            this.age = age;
            this.isWorking = isWorking;
            // TODO: Complete the initialization 
            // ...................
        }*/

        public Person(int personId1, string firstName1, string lastName1, string favouriteColour1, int age1, bool isWorking1)
        {
            // Initialize all attributes here
            personId = personId1;
            firstName = firstName1;
            lastName = lastName1;
            favouriteColour = favouriteColour1;
            age = age1;
            isWorking = isWorking1;
            // TODO: Complete the initialization 
            // ...................
        }



        // DisplayPersonInfo Method
        public void DisplayPersonInfo()
        {
            // Display the person's information as list
            Console.WriteLine($"\tID: {personId}");
            Console.WriteLine($"\tFirst name: {firstName}");
            Console.WriteLine($"\tLast name: {lastName}");
            Console.WriteLine($"\tFavourite Colour: {favouriteColour}");
            Console.WriteLine($"\tAge: {age}");
            Console.WriteLine($"\tis working? {isWorking}");
            // TODO: print all other information
            // ...................
        }

        // ChangeFavoriteColour Method
        public void ChangeFavoriteColour(string newColour)
        {
            favouriteColour = newColour;
            // TODO: Change the person's favorite color to the new color
            // ...................
        }

        // GetAgeInTenYears Method
        public int GetAgeInTenYears()
        {
            // TODO: Return the age after ten years
            int inTenYearAge = age + 10;
            return inTenYearAge;
        }

        // Override the ToString Method
        public override string ToString()
        {

            // Display person information as sentence
            //Method 1
            if (isWorking)
            {
                return $"\t{personId} : {firstName} {lastName}'s favorite color is {favouriteColour} and is working";
            }
            else
            {
                return $"\t{personId} : {firstName} {lastName}'s favorite color is {favouriteColour} and is not working";
            }


            // Method 2
/*            string workingStatus = IsWorking ? "is working" : "is not working";
            return $"\t{personId} : {firstName} {lastName}'s favorite color is {favouriteColor} and {workingStatus}";*/
        }
    }
}
