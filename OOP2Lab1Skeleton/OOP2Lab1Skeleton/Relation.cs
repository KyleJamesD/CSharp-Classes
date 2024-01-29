using System;

namespace OOP2Lab1Skeleton
{
    class Relation
    {
        public char relationType { get; set; }

        public Relation(char r)
        {
            // TODO: Initialize all attributes here
            relationType = r;
        }

        public void ShowRelation(Person p1, Person p2)
        {
            switch (relationType)
            {
                case 's':
                case 'S':
                    Console.WriteLine("Realtionship between " + p1.firstName + " and " + p2.firstName + " is: Sisterhood");
                    break;
                // TODO: write other cases for brotherhood, fatherhood, and motherhood
                case 'b':
                case 'B':
                    Console.WriteLine("Realtionship between " + p1.firstName + " and " + p2.firstName + " is: Brotherhood");
                    break;

                case 'm':
                case 'M':
                    Console.WriteLine("Realtionship between " + p1.firstName + " and " + p2.firstName + " is: Motherhood");
                    break;

                case 'f':
                case 'F':
                    Console.WriteLine("Realtionship between " + p1.firstName + " and " + p2.firstName + " is: Fatherhood");
                    break;
                default:
                    Console.WriteLine("Undefined relationship");
                    break;
            }
        }
    }
}