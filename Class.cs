using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FirstSeeSharp
    {
        public enum CarType
        {
            Toyota = 1,
            Honda = 2,
            Ford = 3,
        }

        public static void Main(string[] args)
        {
            int myInt = 10;
            float myFloat = 10f;
            bool myBoolean = true;
            string myName = "nesta";
            char myChar = 'n';
            double myDouble = 15.2;

            var x = 10;
            var y = 15;
            Console.WriteLine(x + y);

            CarType myCarType = CarType.Honda;

            string myString = "192029";
            int newInt = Convert.ToInt32(myString);
            Console.WriteLine(newInt);

            if(myBoolean)
            {
                Console.WriteLine("This boolean value must've been true!");
            } else
            {
                Console.WriteLine("This boolean value must've been false!");
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numbers2 = new int[10];
            Console.WriteLine(numbers.Length);
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 10, 20, 30 };
            jaggedArray[1] = new int[] { 40, 50, 60, 70 };
            jaggedArray[2] = new int[] { 80, 90, 100, 110, 120 };

            List<int> numbers3 = new List<int>();
            numbers3.Add(22);
            numbers3.Add(33);

            List<int> arr = new List<int>();
            int[] array = { 1, 2, 3 };
            arr.AddRange(array);

            arr.Remove(33);
            Console.WriteLine(arr.Count);
            arr.RemoveAt(0);

            List<string> meat = new List<string>();
            meat.Add("shrip");
            meat.Add("burger");

            List<string> vegetables = new List<string>();
            vegetables.Add("asparagus");
            vegetables.Add("celery");

            List<string> food = meat;
            meat.AddRange(vegetables);

            Dictionary<string, long> carRegistration = new Dictionary<string, long>();
            carRegistration.Add("Altima", 29283929);
            carRegistration.Add("Nissan", 22920209);
            carRegistration.Add("BMW", 11119200);
            carRegistration["BMW"] = 9292828;
            if (carRegistration.ContainsKey("BMW"))
            {
                Console.WriteLine(carRegistration["BMW"]);
            }

            string example = String.Empty;
            string name = "1929019201";
            string exName = example + name;

            int[] nums = { 1, 2, 3, 4 };
            for(int i = 0; i < nums.Length; i++)
            {
                if(i == 3)
                {
                    Console.WriteLine(nums[i]);
                } else
                {
                    Console.WriteLine(nums[i]);
                }
            }

            string[] cars = { "Audi", "BMW", "Merc", "Jag", "Aston" };
            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }

            int n = 0;
            while(n == 0)
            {
                Console.WriteLine("N is 0");
                n++;
            }


        }
    }
}
