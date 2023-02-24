namespace MaxMIn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //double max = MaxMin.MaximumIntNum(1.2,2.5,3.8); 
            //Console.WriteLine("{0} Greatest than Two ",max);

            //int Max = MaxMin.MaximumIntNum(12, 25, 38);
            //Console.WriteLine("{0} Greatest than Two ", Max);

            string str = "Amit";
            string str1 = "Sagar";
            string str2 = "Krishna";

            string Max = MaxMin.MaximumIntNum(str,str1,str2);
            Console.WriteLine(Max);

            //Console.WriteLine("String Length of First : " + str.Length);
            //Console.WriteLine("String Length of Second : " + str1.Length);
            //Console.WriteLine("String Length of Third: " + str2.Length);

        }
    }
}