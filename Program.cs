using System.Runtime.InteropServices;

namespace project_divisibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool NumberController;
            ulong StartingNumber;
            string a;
            bool PrimeNumber;
            do
            {
                Console.Clear();
                Console.Title = "hello";
                Console.WriteLine("hello");
                Console.WriteLine("please press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Title = "divisibility";
                Console.WriteLine("choose one of this services");
                Console.WriteLine("1.Numberatory");
                Console.WriteLine("2.prime number");
                a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("please enter any number ");
                            string RNumber = Console.ReadLine();
                            NumberController = ulong.TryParse(RNumber, out StartingNumber);
                            if (NumberController == true)
                            {
                                NumberFunction NF = new NumberFunction();
                                NF.Number(StartingNumber);
                            }
                            else
                            {
                                ErrorFunction e = new ErrorFunction();
                                e.Error();
                            }

                        } while (NumberController == false);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("please enter any number ");
                        String RawNumber = Console.ReadLine();
                        NumberController = ulong.TryParse(RawNumber, out StartingNumber);
                        if (NumberController == true)
                        {
                            ulong i2;
                            for (i2 = StartingNumber; StartingNumber > 1; i2--)
                            {
                                double DoublesNumber = Math.Sqrt(i2);
                                ulong EstimatedNumber = Convert.ToUInt64(DoublesNumber);
                                ulong i;
                                ulong Remaining;
                                for (i = EstimatedNumber - 1; i > 1; i--)
                                {
                                    Remaining = i2 % i;


                                    if (Remaining == 0)
                                    {
                                        PrimeNumber = false;
                                        break;
                                    }
                                    else if (i == 2 && Remaining != 0)
                                    {
                                        PrimeNumber = true;
                                        Console.Clear();
                                        Console.WriteLine($"{i2} is a prime number");
                                        Console.ReadKey();
                                        break;
                                    }

                                }
                                 
                            }


                           
                        }

                        break;

                }
            } while (a != "1" && a != "2");
        }
    }
}


