using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassPractice.Math;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var maru = new Person();
            maru.setName("Tao", "Maru");

            maru.Introduce();

            Calculator calcutron = new Calculator();
            var answer = calcutron.Add(99, 1);
            Console.WriteLine(answer);
            */

            var numbers = new int[3] { 10, 20, 30};
            for (int index = 0; index < numbers.Length; index++) {
                Console.WriteLine(numbers[index]);
            }
        }
    }
}
