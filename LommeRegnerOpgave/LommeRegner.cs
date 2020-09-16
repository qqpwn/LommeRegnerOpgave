using System;
using System.Runtime.CompilerServices;

namespace LommeRegnerLibrary
{
    public static class LommeRegner
    {

        public static bool IsNumber(this string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }

            char ch = number[0];
            return char.IsDigit(ch);
        }

        public static float Plus(float tal1, float tal2)
        {
            float result = tal1 + tal2;
            return result;
        }

        public static float Minus(float tal1, float tal2)
        {
            float resultat = tal1 - tal2;
            return resultat;
        }

        public static float Gange(float tal1, float tal2)
        {
            float resultat = tal1 * tal2;
            return resultat;
        }

        public static float Dividere(float tal1, float tal2)
        {
            float resultat = tal1 / tal2;
            return resultat;
        }



        public static void Kør()
        {
            Console.WriteLine("Welcome to Maxi's Calculator!\n");
            Console.WriteLine("Press 1 for Addition.");
            Console.WriteLine("Press 2 for Subtraction.");
            Console.WriteLine("Press 3 for Multiplication.");
            Console.WriteLine("Press 4 for Division.\n");

            int valg = Convert.ToInt32(Console.ReadLine());
            bool keepRunnning = true;

            while (keepRunnning)
            {
                switch (valg)
                {
                    case 1:
                        {
                            Console.WriteLine("Input first number for addition:");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Input secound number for addition:");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Result = {LommeRegner.Plus(input1, input2)}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Input first number for subtraction:");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Input secound number for subtraction:");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Result = {LommeRegner.Minus(input1, input2)}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Input first number for multiplication:");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Input secound number for multiplication:");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Result = {LommeRegner.Gange(input1, input2)}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Input first number for division:");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Input secound number for division:");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Result = {LommeRegner.Dividere(input1, input2)}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Input was not an accepted awnser!");
                            Console.ReadKey();
                            break;

                        }
                }
                Console.WriteLine("Press Y to reset or press N to exit");
                if (Console.ReadLine() == "Y")
                {
                    Console.Clear();
                    LommeRegner.Kør();

                }
                else if (Console.ReadLine() == "N")
                {
                    
                    break;
                }
                break;
            }
        }
    }
}
