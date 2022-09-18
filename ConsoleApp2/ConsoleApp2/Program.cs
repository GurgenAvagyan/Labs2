namespace ConsoleApp2
{

    class MyClass
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double euro = 34, dollar = 103.5, hrivna = 657.3;
            Console.WriteLine("From euro to dollars: " + euro + " euro are " + 1.04 * euro + " dollars");
            Console.WriteLine("From euro to hrivna: " + euro + " euro are " + 36.73 * euro + " hriven'");
            Console.WriteLine("============================================================================");
            Console.WriteLine("From dollars to euro: " + dollar + " dollars are " + 0.96 * dollar + " euro");
            Console.WriteLine("From dollars to hrivna: " + dollar + " dollars are " + 36.9 * dollar + " hriven'");
            Console.WriteLine("============================================================================");
            Console.WriteLine("From hrivna to euro: " + hrivna + " hrinen' are " + 0.027 * hrivna + " euro");
            Console.WriteLine("From hrivna to dollars: " + hrivna + " hrinen' are " + 0.02 * hrivna + " dollars");
            Console.WriteLine();
            //int Number1 = int.Parse(Console.ReadLine());
            //if (Number1 % 2 == 0)
            //{
            //    Console.WriteLine("chetnoe");
            //}
            //else
            //{
            //    Console.WriteLine("ne chetnoe");
            //}


            //bool k = true;
            //while (k)
            //{
            //    k = false;
            //    Console.Write("Print first number: ");
            //    double firstNum = double.Parse(Console.ReadLine());
            //    Console.Write("Print second number: ");
            //    double secondNum = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Choose one of these signs:  +  -  *  /");
            //    string sign = Console.ReadLine();
            //    switch (sign)
            //    {
            //        case "+":
            //            double sum = firstNum + secondNum;
            //            Console.WriteLine(firstNum + "+" + secondNum + "=" + sum);
            //            k = true;
            //            break;
            //        case "-":
            //            double difference = firstNum - secondNum;
            //            Console.WriteLine(firstNum + "-" + secondNum + "=" + difference);
            //            k = true;
            //            break;
            //        case "*":
            //            double product = firstNum * secondNum;
            //            Console.WriteLine(firstNum + "*" + secondNum + "=" + product);
            //            k = true;
            //            break;
            //        case "/":
            //            double quotient = firstNum / secondNum;
            //            Console.WriteLine(firstNum + "/" + secondNum + "=" + quotient);
            //            k = true;
            //            break;
            //        default:
            //            Console.WriteLine("Please, can you print any sign correctly? Currently, you haven't printed sign!");
            //            k = true;
            //            break;
            //    }
            //}

            //while (true)
            //{
            //    try
            //    {
            //        Console.Clear();
            //        Console.Write("Print first number: ");
            //        double firstNum = double.Parse(Console.ReadLine());
            //        Console.Write("Print second number: ");
            //        double secondNum = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Choose one of these signs:  +  -  *  /");
            //        string sign = Console.ReadLine();
            //        if (sign == "+")
            //        {
            //            double sum = firstNum + secondNum;
            //            Console.WriteLine(firstNum + "+" + secondNum + "=" + sum);
            //            Console.WriteLine("------------------------------------------------");
            //        }
            //        else if (sign == "-")
            //        {
            //            double difference = firstNum - secondNum;
            //            Console.WriteLine(firstNum + "-" + secondNum + "=" + difference);
            //            Console.WriteLine("------------------------------------------------");
            //        }
            //        else if (sign == "*")
            //        {
            //            double product = firstNum * secondNum;
            //            Console.WriteLine(firstNum + "*" + secondNum + "=" + product);
            //            Console.WriteLine("------------------------------------------------");
            //        }
            //        else if (sign == "/")
            //        {
            //            double quotient = firstNum / secondNum;
            //            Console.WriteLine(firstNum + "/" + secondNum + "=" + quotient);
            //            Console.WriteLine("------------------------------------------------");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please, can you print any sign correctly? Currently, you haven't printed sign!");
            //            Console.WriteLine("------------------------------------------------");
            //        }
            //        Console.ReadLine();

            //    }
            //    catch(Exception)
            //    {
            //        Console.WriteLine("Mistake! Please, print the number correctly!");
            //    }   
            //}

            int[] arr = { 23, 4, 3, 22, 89, 43 };
            int countEven = 0, countOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            Console.WriteLine("Count of even numbers equals " + countEven);
            Console.WriteLine("Count of odd numbers equals " + countOdd);











        }

    }
}