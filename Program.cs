using System;


using ClassPractice.Math;

namespace ClassPractice
{
    public enum TeamStatus { 
        Registered,
        CheckedIn,
        Disqualified,
        Active
    }
    class Program
    {
        static void Main(string[] args)
        {
            var maru = new Person();
            maru.setName("Tao", "Maru");

            maru.Introduce();

            Calculator calcutron = new Calculator();
            var answer = calcutron.Add(99, 1);
            Console.WriteLine(answer);
            

            var numbers = new int[3] { 10, 20, 30};
            for (int index = 0; index < numbers.Length; index++) {
                Console.WriteLine(numbers[index]);
            }

            string theNums = string.Join("->", numbers);
            Console.WriteLine(theNums);

            var teamAStatus = TeamStatus.CheckedIn;
            Console.WriteLine(teamAStatus); // team status as "checkedIn"
            Console.WriteLine((int)teamAStatus); //team status as ID "1"
            var statusID = 3; // given a status ID...
            Console.WriteLine((TeamStatus)statusID); //team status as "Active"
        }
    }
}
