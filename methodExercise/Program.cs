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

        public static int  Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }
        
        static void Main(string[] args)
        {

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
            var sumAnswer = Sum(10, 34);
            Console.WriteLine($"Jeb added 2 cups of mice to get {sumAnswer} total mice");

            var multiPly = Multiply(44, 3);
            Console.WriteLine($"He dropped the cup and the 44 mice multiplied into {multiPly}!");



        }   
    }
}
