using System;

namespace MPM
{
    class MPM
    {
        static void Main(string[] args)
        {
            string one = "Calculator";
            string two = "Exponent calcultor";
            Console.WriteLine("███╗░░░███╗░░░██████╗░░░░███╗░░░███╗");
            Console.WriteLine("████╗░████║░░░██╔══██╗░░░████╗░████║");
            Console.WriteLine("██╔████╔██║░░░██████╔╝░░░██╔████╔██║");
            Console.WriteLine("██║╚██╔╝██║░░░██╔═══╝░░░░██║╚██╔╝██║");
            Console.WriteLine("██║░╚═╝░██║██╗██║░░░░░██╗██║░╚═╝░██║");
            Console.WriteLine("╚═╝░░░░░╚═╝╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝");
            Console.WriteLine("█▀▄▀█ ░ █▀█ ░ █▀▄▀█   ▀▀   █▀▄▀█ █░█ █░░ ▀█▀ █ ▄▄ █▀█ █░█ █▀█ █▀█ █▀█ █▀ █▀▀ ▄▄ █▀▄▀█ ▄▀█ █▀▀ █░█ █ █▄░█ █▀▀");
            Console.WriteLine("█░▀░█ ▄ █▀▀ ▄ █░▀░█   ▀▀   █░▀░█ █▄█ █▄▄ ░█░ █ ░░ █▀▀ █▄█ █▀▄ █▀▀ █▄█ ▄█ ██▄ ░░ █░▀░█ █▀█ █▄▄ █▀█ █ █░▀█ ██▄");
            Console.WriteLine("   ");
            Console.WriteLine("   ");
            Console.WriteLine("   ");

            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Exponent calculator(has technical difficulties");
            Console.WriteLine("3. Quiz");

            Console.Write("Chose an option (type the full name of the option not the number): ");
            string choice = Console.ReadLine();
            if (choice == "one")
            {
                Calculator();
            }
            else if (choice == "two")
            {
                ExponentCal();
            }
            else if (choice == "Quiz")
            {
                Quiz();
            }
            Console.ReadLine();
        }

        static void Calculator()
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            Console.Write("Would you like to try again?(Y/N): ");
            string yn = Console.ReadLine();
            if (yn == "y")
            {
                Calculator();
            }else if (yn == "n")
            {
                string one = "Calculator";
                string two = "Exponent calcultor"; ;
                string three = "Quiz";
                Console.WriteLine("███╗░░░███╗░░░██████╗░░░░███╗░░░███╗");
                Console.WriteLine("████╗░████║░░░██╔══██╗░░░████╗░████║");
                Console.WriteLine("██╔████╔██║░░░██████╔╝░░░██╔████╔██║");
                Console.WriteLine("██║╚██╔╝██║░░░██╔═══╝░░░░██║╚██╔╝██║");
                Console.WriteLine("██║░╚═╝░██║██╗██║░░░░░██╗██║░╚═╝░██║");
                Console.WriteLine("╚═╝░░░░░╚═╝╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝");
                Console.WriteLine("█▀▄▀█ ░ █▀█ ░ █▀▄▀█   ▀▀   █▀▄▀█ █░█ █░░ ▀█▀ █ ▄▄ █▀█ █░█ █▀█ █▀█ █▀█ █▀ █▀▀ ▄▄ █▀▄▀█ ▄▀█ █▀▀ █░█ █ █▄░█ █▀▀");
                Console.WriteLine("█░▀░█ ▄ █▀▀ ▄ █░▀░█   ▀▀   █░▀░█ █▄█ █▄▄ ░█░ █ ░░ █▀▀ █▄█ █▀▄ █▀▀ █▄█ ▄█ ██▄ ░░ █░▀░█ █▀█ █▄▄ █▀█ █ █░▀█ ██▄");
                Console.WriteLine("   ");
                Console.WriteLine("   ");
                Console.WriteLine("   ");

                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Exponent Calculator(has technical difficulties)");
                Console.WriteLine("3. Quiz");

                Console.Write("Chose an option (type the full name of the option not the number): ");
                string choice = Console.ReadLine();
                if (choice == "Calculator")
                {
                    Calculator();
                }
                else if (choice == "Exponent Calculator")
                {
                    ExponentCal();
                }else if (choice == "Quiz")
                {
                    Quiz();
                }
            }

            Console.ReadLine();
        }
        
        static void ExponentCal()
        {
            Console.WriteLine("Welcome to the Exponent calculator!");
            Console.Write("Enter the base number: ");
            int basenum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the exponent number: ");
            int exponum = Convert.ToInt32(Console.ReadLine());
            // figure out how to pass the basenum and exponum variables to Answer method
            Console.ReadLine();
        }

        static void answer(int basenum, int exponum)
        {

        }

        static void Quiz()
        {
            double s = 0; // this variable is for the user's score during the quiz
            Console.WriteLine("Welcome to the quiz!");
            Console.Write("1. 7x - 4 = 10  solve for x: ");
            double ans = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. 15 / 3 =:");
            double ans2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. 5^3 = : ");
            double ans3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("4. 5^2 + 10 = : ");
            double ans4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("5. 15 / 5 = : ");
            double ans5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("6. 5689 * 5^0 = : ");
            double ans6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("7. 10 + 10 = : ");
            double ans7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("8. -50 + 50 + 50 = : ");
            double ans8 = Convert.ToDouble(Console.ReadLine());
            Console.Write("9. 6 * 9 + 10 + 5*1 = : ");
            double ans9 = Convert.ToDouble(Console.ReadLine());
            Console.Write("10. 420 + 69.69 = : ");
            double ans10 = Convert.ToDouble(Console.ReadLine());

            if(ans == 2)
            {
                s++;
            }else if(ans2 == 5)
            {
                s++;
            }else if(ans3 == 125)
            {
                s++;
            }else if(ans4 == 35)
            {
                s++;
            }else if(ans5 == 3)
            {
                s++;
            }else if(ans6 == 5689)
            {
                s++;
            }else if(ans7 == 20)
            {
                s++;
            }else if(ans8 == 50)
            {
                s++;
            }else if(ans9 == 69)
            {
                s++;
            }else if(ans10 == 489.69)
            {
                s++;
            }
            Console.WriteLine("your score is " + s + "/10");
            Console.WriteLine(s + "/10 is " + s / 10 * 100 + "%");
            Console.Write("main menu?(Y/N): ");
            string yn = Console.ReadLine();
            if (yn == "y")
            {
                string one = "Calculator";
                string two = "Exponent calcultor";
                Console.WriteLine("███╗░░░███╗░░░██████╗░░░░███╗░░░███╗");
                Console.WriteLine("████╗░████║░░░██╔══██╗░░░████╗░████║");
                Console.WriteLine("██╔████╔██║░░░██████╔╝░░░██╔████╔██║");
                Console.WriteLine("██║╚██╔╝██║░░░██╔═══╝░░░░██║╚██╔╝██║");
                Console.WriteLine("██║░╚═╝░██║██╗██║░░░░░██╗██║░╚═╝░██║");
                Console.WriteLine("╚═╝░░░░░╚═╝╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝");
                Console.WriteLine("█▀▄▀█ ░ █▀█ ░ █▀▄▀█   ▀▀   █▀▄▀█ █░█ █░░ ▀█▀ █ ▄▄ █▀█ █░█ █▀█ █▀█ █▀█ █▀ █▀▀ ▄▄ █▀▄▀█ ▄▀█ █▀▀ █░█ █ █▄░█ █▀▀");
                Console.WriteLine("█░▀░█ ▄ █▀▀ ▄ █░▀░█   ▀▀   █░▀░█ █▄█ █▄▄ ░█░ █ ░░ █▀▀ █▄█ █▀▄ █▀▀ █▄█ ▄█ ██▄ ░░ █░▀░█ █▀█ █▄▄ █▀█ █ █░▀█ ██▄");
                Console.WriteLine("   ");
                Console.WriteLine("   ");
                Console.WriteLine("   ");

                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Exponent calculator(has technical difficulties");
                Console.WriteLine("3. Quiz");

                Console.Write("Chose an option (type the full name of the option not the number): ");
                string choice = Console.ReadLine();
                if (choice == "one")
                {
                    Calculator();
                }
                else if (choice == "two")
                {
                    ExponentCal();
                }
                else if (choice == "Quiz")
                {
                    Quiz();
                }
            }

            Console.ReadLine();
        }
    }
}