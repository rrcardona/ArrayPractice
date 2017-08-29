using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an Array
            //Data type[] nameOfArray = { elements};
            //int[] myArray = { 1, 2, 3, 4, 5, 6 };
            //string[] students = { "Brad", "Amy", "Jackie","Ric","Mike"};
            //Console.WriteLine(students[4]);
            //Console.WriteLine(students[0]);
            //Create an array of10 vacation spots. Print the first and the last vacation spot. 
            //Create an array of ages of 3 children you know. Print out each age
            //gpa on a 4.0 scale of 8 students
            //first letter of your peers names who are sitting next to you

            //string[] vacationSpots = { "Florida", "California", "Denver", "North Carolina", "Japan", "Puerto Rico", "Nevada", "Texas", "New York", "Illinois" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);
            //Console.WriteLine(vacationSpots[vacationSpots.Length-1]); this is how you get the last element in the array

            //int[] childrenAges = {12, 10, 0 };
            //Console.WriteLine(childrenAges[0]);
            //Console.WriteLine(childrenAges[1]);
            //Console.WriteLine(childrenAges[2]);

            //When you DONT KNOW the elements of your array up front
            //DataType[] nameOfArray = new dataType[#ofElements]
            //float[] gpa = new float[8];

            //char[] peerInitials = { 'd', 'S', 'A' };
            //Console.WriteLine(peerInitials);
            //Console.WriteLine(peerInitials[0]);
            //Console.WriteLine(peerInitials[1]);
            //Console.WriteLine(peerInitials[2]);

            //Declare and initialize an array for the days of the week
            //Declare and initialize an array of student ages using the New Keyword

            //string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //Console.WriteLine(daysOfTheWeek[0]);
            //Console.WriteLine(daysOfTheWeek[1]);
            //Console.WriteLine(daysOfTheWeek.Length);
            //Console.WriteLine(daysOfTheWeek[0]);
            //daysOfTheWeek.SetValue("Funday", 0);
            //Console.WriteLine(daysOfTheWeek[0]);          

            //int[] studentAges = new int[5];
            //studentAges[0] = 15;
            //studentAges[1] = 25;
            //studentAges[2] = 30;
            //studentAges[3] = 40;
            //studentAges[4] = 55;
            //studentAges[5] = 65;

            //string[] birthMonths = { "December", "July", "May", "July" };
            //Console.WriteLine(Array.IndexOf(birthMonths,"July"));
            //Console.WriteLine(Array.LastIndexOf(birthMonths,"July"));

            //int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[numbers.Length-1]);

            string[] firstNames = new string[5];
            firstNames[0] = "Dana";
            firstNames[1] = "Stacey";
            firstNames[2] = "Amy";
            firstNames[3] = "Mike";
            firstNames[4] = "Mel";
            Console.WriteLine(Array.IndexOf(firstNames,"Dana"));
            

            //int[] luckyNumbers = { 7, 11, 15, 3, 7, 15, 11, 3 };
            //Console.WriteLine(Array.LastIndexOf(luckyNumbers,"15"));

            char[] alphabetCharacters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            Console.WriteLine(alphabetCharacters[0]);
            Array.Reverse(alphabetCharacters);
            Console.WriteLine(alphabetCharacters[0]);

            string[] studentsNames = { "Dana", "Stacey", "Amy", "Mike" };
            Console.WriteLine(studentsNames[0]);
            Array.Sort(studentsNames);
            Console.WriteLine(studentsNames[0]);

            int[] luckyNumbers = { 15, 7, 22, 5, 43, 45, 23, 3, 42, 17 };
            Array.Sort(luckyNumbers);
            Console.WriteLine(luckyNumbers[0] + " " + luckyNumbers[luckyNumbers.Length-1]);









        }



    }
}
