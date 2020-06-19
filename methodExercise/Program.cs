using System;

namespace methodExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        static void Main(string[] args)
        {

            var amountofturkeys = Sum(3, 8);





            //----------------------Exercise 1--------------
            //Name: Jeb
            //Favorite Food: Snack
            //Favorite Animal: Mouse
            //Favorite Hobby: Sleeping

            Console.WriteLine("Hello ya dangus, What's your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Nice to see you, {userName} what is you favorite food?");
            var food = Console.ReadLine();

            Console.WriteLine($"{food} is amazing. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} are such little cuties. What do you like to do?");
            var hobby = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! here is your profile");
            Console.WriteLine($"------------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Food: {food}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Hobby: {hobby}");

            //----------------------Exercise 2-------------


        }   
    }
}
