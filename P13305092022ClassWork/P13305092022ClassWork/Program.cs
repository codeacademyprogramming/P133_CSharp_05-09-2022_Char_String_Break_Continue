using System;

namespace P13305092022ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Gonderilmis ededin reqemlerinin cemini qaytaran metod - misalcun bu metodu
            //call ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir

            //Console.WriteLine("Ededi Daxil Et");
            //string numStr = Console.ReadLine();
            //int num = int.Parse(numStr);
            //int sumOfNumsDigit = SumOfDigitNums(num);
            //Console.WriteLine($"Ededlerin Cemi: {sumOfNumsDigit}");
            #endregion

            #region Task 2
            //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü
            //pulsuz verilir, ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”
            //.Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək məbləği hesbalayan
            //metod yazin - yəni metodunuz 3 doubel parameter qebul edib en boyuk ikisinin
            //cemini hesablayib qaytarmalidir

            //Console.WriteLine("1-ci Mehsulun Qiymetini Daxil Et");
            //string num1Str = Console.ReadLine();
            //double price1 = double.Parse(num1Str);
            //Console.WriteLine("1-ci Mehsulun Qiymetini Daxil Et");
            //string num2Str = Console.ReadLine();
            //double price2 = double.Parse(num2Str);
            //Console.WriteLine("1-ci Mehsulun Qiymetini Daxil Et");
            //string num3Str = Console.ReadLine();
            //double price3 = double.Parse(num3Str);

            //double sumOfTwoBiggestPrice = SumOfTwoBigesPrice(price1, price2,price3);
            //Console.WriteLine($"Odenilecek Mebleg: {sumOfTwoBiggestPrice}");

            #endregion

            #region Ternory operator
            //if (5 > 3)
            //{
            //    if (8 > 5)
            //    {
            //        Console.WriteLine("");
            //    }
            //    else
            //    {
            //        Console.WriteLine("");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("");
            //}

            //Console.WriteLine(5 > 3 ? 8 > 5 ? "" : "" : "");
            #endregion

            #region Char, String, Break, Continue
            //char symbol = 'a';

            //Console.WriteLine((int)symbol);

            //string word = "P133";

            //var a = word[0];

            //Console.WriteLine((int)word[2]);

            //for (int i = 0; i < 50; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine("False");
            //    }
            //}
            #endregion

            #region Task 4
            Console.WriteLine("1-ci Ededi Daxil Et:");
            string num1Str = Console.ReadLine();
            int num1 = int.Parse(num1Str);
            Console.WriteLine("1-ci Ededi Daxil Et:");
            string num2Str = Console.ReadLine();
            int num2 = int.Parse(num2Str);
            Console.WriteLine("1-ci Ededi Daxil Et:");
            string symbolStr = Console.ReadLine();
            char symbol = char.Parse(symbolStr);

            int result = Calculate(num1, num2, symbol);
            Console.WriteLine($"Netice: {result}");
            Console.WriteLine(result > 0 ? "Netice Musbetdi" : "Netice Menfidi");
            #endregion
        }

        #region Task 1
        //Gonderilmis ededin reqemlerinin cemini qaytaran metod - misalcun bu metodu
        //call ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir
        static int SumOfDigitNums(int num)
        {
            int sum = 0;
            int module = 0;

            while (num > 0)
            {
                module = num % 10;
                sum += module;
                num = (num - module) / 10;
            }

            return sum;
        }
        #endregion

        #region Task 2
        //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü
        //pulsuz verilir, ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”
        //.Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək məbləği hesbalayan
        //metod yazin - yəni metodunuz 3 doubel parameter qebul edib en boyuk ikisinin
        //cemini hesablayib qaytarmalidir

        static double SumOfTwoBigesPrice(double num1, double num2, double num3)
        {
            double sum = 0;

            if (num1 < num2 && num1 < num3)
            {
                sum += (num2 + num3);
            }else if (num2 < num1 && num2 < num3)
            {
                sum += (num1 + num3);
            }
            else if (num3 < num1 && num3 < num2)
            {
                sum += (num1 + num2);
            }

            return sum;
        }

        #endregion

        #region Task 3
        //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod - 3 integer parametr
        //qebul edir ve iclerinde en boyuk hansidirsa onu tapib return edir Eyni
        //sekilde verilmis 4 parametrli ve 5 parametrli ededin en boyuyunu tapan
        //metodlar da yazin (method overloading)

        static int BiggestNum(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if(b > a && b > c)
            {
                return b;
            }
            else if (c > a && c > b)
            {
                return c;
            }
            else
            {
                return 0;
            }
        }

        static int BiggestNum(int a, int b, int c, int d)
        {
            return BiggestNum(a, b, c) > d ? BiggestNum(a, b, c) : d;
        }

        static int BiggestNum(int a, int b, int c, int d,int e)
        {
            int max = BiggestNum(a, b, c,d);

            return max > e ? max : e;

        }

        #endregion

        #region Task 4
        static int Calculate(int num1, int num2, char symbol)
        {
            int result = 0;

            if (symbol == '+')
            {
                result = num1 + num2;
            }
            else if (symbol == '-')
            {
                result = num1 - num2;
            }
            else if (symbol == '*')
            {
                result = num1 * num2;
            }
            else if (symbol == '/')
            {
                result = num1 / num2;
            }

            return result;
        }
        #endregion
    }
}
