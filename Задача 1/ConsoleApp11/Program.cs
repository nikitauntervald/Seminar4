using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        double res = 0;
        int NumToSumDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return int.Abs(sum);
        }

        void Loop()
        {
            while (true)
            {
                Console.Write("Enter integer number or 'q' for exit: ");
                string str = Console.ReadLine();
                if (str != null)
                {
                    if (str.ToLower() == "q")
                        break;
                }
                int num;
                if (int.TryParse(str, out num))
                {
                    num = NumToSumDigits(num);
                    if ((num & 0x01) == 0)
                    {
                        Console.WriteLine("Sum of digits is even!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Bad number!");
                }
            }
            Console.WriteLine("[STOP]");
        }


        Console.Clear();
        Loop();
    }
}

