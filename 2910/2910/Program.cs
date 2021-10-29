using System;

namespace _2910
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Home home1 = new Home(3,1,"122A5", "0777777777", "Baku");
            //Console.WriteLine(home1.toString());
            Home home2 = new Home(7, 2, "326C5", "0555555555", "Ganja");
            //Console.WriteLine(home2.toString());
            Home home3 = new Home(6, 2, "565D7", "0702222222", "Sumqayit");
            //Console.WriteLine(home3.toString());

            
            Home[] arrHome = new Home[3];
            arrHome[0] = home1;
            arrHome[1] = home2;
            arrHome[2] = home3;
            //Console.WriteLine(arrHome[0]);
            //Console.WriteLine(arrHome[1]);
            //Console.WriteLine(arrHome[2]);

            //for (int i = 0; i < arrHome.Length; i++)
            //{
            //    Console.WriteLine(arrHome[i].seher);
            //}*/

            Console.Write("Please enter the number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the power: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{b} power of {a} is " + MyMath.MyPow(a, b));




        }
    }

}
