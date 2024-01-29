using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace OOP2Lab1Skeleton
{
    public class Person
    {

        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favouriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }


        public Person(int personId1, string firstName1, string lastName1, string favouriteColour1, int age1, bool isWorking1)
        {

            personId = personId1;
            firstName = firstName1;
            lastName = lastName1;
            favouriteColour = favouriteColour1;
            age = age1;
            isWorking = isWorking1;

        }




        public void DisplayPersonInfo()
        {

            Console.WriteLine($"\tID: {personId}");
            Console.WriteLine($"\tFirst name: {firstName}");
            Console.WriteLine($"\tLast name: {lastName}");
            Console.WriteLine($"\tFavourite Colour: {favouriteColour}");
            Console.WriteLine($"\tAge: {age}");
            Console.WriteLine($"\tis working? {isWorking}");

        }


        public void ChangeFavoriteColour(string newColour)
        {
            favouriteColour = newColour;

        }


        public int GetAgeInTenYears()
        {

            int inTenYearAge = age + 10;
            return inTenYearAge;
        }


        public override string ToString()
        {


            if (isWorking)
            {
                return $"\t{personId} : {firstName} {lastName}'s favorite color is {favouriteColour} and is working";
            }
            else
            {
                return $"\t{personId} : {firstName} {lastName}'s favorite color is {favouriteColour} and is not working";
            }



        }
    }
}
