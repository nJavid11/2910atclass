using System;
using System.Collections.Generic;
using System.Text;

namespace _2910
{
    class MyMath
    {
        public static int MyPow(int a, int b)
        {

            int pow = 1;
            for (int i = 1; i <= b; i++)
            {
                
                
                    pow = pow * a;
                

            }
            return pow;
        }
        public static double MyPow(double a, double b)
        {
            double pow = 1;
            for (int i = 1; i <= b; i++)
            {
                pow = pow * a;


            }
            return pow;
        }

        public static float MyPow(float a, float b)
        {
            float pow = 1;
            for (int i = 1; i <= b; i++)
            {
               
                
                    pow = pow * a;
                

            }
            return pow;
        }
    }
}
