using System;

namespace mobile_app_hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 55;
            int flip = 55;
            do
            {
                Console.WriteLine("Pick a number 3-9, pick 0 to end");

                selection = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= selection; i++)
                {
                    for (int j = 1; j <= selection; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.Write("\n");
                }
                do
                {
                    Console.WriteLine("Flip?1) Horizontal, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 0 to go back");
                    flip = Convert.ToInt32(Console.ReadLine());

                    if (flip == 1) {
                        for (int i = selection; i >= 1; i--)
                        {
                            for (int j = 1; j <= selection; j++)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.Write("\n");
                        }

                    }
                    if (flip == 2) {
                        for (int i = selection; i <= 1; i++) {
                            for (int j = selection; j <= 1; j++) {
                                Console.Write(i * j + "\t");
                            }
                            Console.Write("\n");
                        } }
                    if (flip == 3) {
                        for (int i = selection; i >= 1; i++)
                        {
                            for (int j = selection; j <= 1; j++)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.Write("\n");
                        }

                    }
                    if (flip == 4) {
                        for (int i = selection; i >= 1; i++)
                        {
                            for (int j = selection; j <= 1; j--)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.Write("\n");
                        }
                    }
                }
                while (flip !=0);

            }
            while (selection != 0);
           
        }
    }
}
