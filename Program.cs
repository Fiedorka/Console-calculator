using System;

namespace MyApplication
{
    class Calculator
    {
        


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a;
                double b;
                string oper;
                double result1;
                double result2;
                double result3;
                double result4;
                string again;

                try
                {
                Console.WriteLine("Введите первое число:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = double.Parse(Console.ReadLine());
                    
                }
                catch (Exception)
                { Console.WriteLine("Unsupported format");
                    Console.Write("Press any button to continue");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите действие:(/ для деления, * для умножения, + для сложения, - для вычитания");
                oper = Convert.ToString(Console.ReadLine());

                
              

                if (oper == "*")
                {
                    result1 = a * b;
                    Console.WriteLine("Result "+result1);
                }
                else if (oper == "+")
                {
                    result2 = a + b;
                    Console.WriteLine("Result " + result2);
                }
                else if (oper == "/")
                {
                    result3 = a / b;
                    if (b == 0)
                        Console.WriteLine("0");
                    else
              
                    Console.WriteLine("Result " + result3);

                }
                else if (oper == "-")
                {
                    result4 = a - b;
                    Console.WriteLine("Result " + result4);
                }
                else
                {
                    Console.WriteLine("Ощибка, такого оператора не существует");
                }

                Console.Write("Press any button to continue");
                Console.ReadLine(); 

            }
        }

       
    }
}