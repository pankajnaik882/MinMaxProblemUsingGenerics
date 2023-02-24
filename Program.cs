using System.Runtime.ExceptionServices;

namespace MaxMIn
{ 
    public class Program
    { 
       
        public static void Main(string[] args)
        {

            MaxMin<int> max = new MaxMin<int>(10,20,30);
            int c = max.maxvalue();
            Console.WriteLine(c);
        
            //int a = MaxMin<int>.Maximum(10, 20, 30);
            //double b = MaxMin<double>.Maximum(10.20, 20.03, 30.2);
            //char c = MaxMin<char>.Maximum('A', 'C', 'B');
            //Console.WriteLine("Greatest Int : " + a);
            //Console.WriteLine("Greatest Double : " + b);
            //Console.WriteLine("Greatest Char : " + c);
           

            //max.Maximum(10, 20, 30);
            //int b = max.maxvalue();
            //Console.WriteLine(b);
            //double max = MaxMin.MaximumIntNum(1.2,2.5,3.8); 
            //Console.WriteLine("{0} Greatest than Two ",max);

            //int Max = MaxMin.MaximumIntNum(12, 25, 38);
            //Console.WriteLine("{0} Greatest than Two ", Max);

            /* string str = "Amit";
             string str1 = "Sagar";
             string str2 = "Krishna";

             string Max = MaxMin.MaximumIntNum(str,str1,str2);
             Console.WriteLine(Max); */

            //Console.WriteLine("String Length of First : " + str.Length);
            //Console.WriteLine("String Length of Second : " + str1.Length);
            //Console.WriteLine("String Length of Third: " + str2.Length);

        }
    }
}