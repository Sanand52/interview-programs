using System.Runtime.CompilerServices;

namespace teststring
{
    internal class Program
    {
        public static string reversestring()
        {   
            string str, revstr=null;

            bool a = true;

            while (a == true)
            {
               revstr = null;

                Console.WriteLine("enter string");

                str = Console.ReadLine();

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    revstr = revstr + str[i];
                }

               

                Console.WriteLine("reverse string is {0}", revstr);

                Console.WriteLine("do u want to enter other string? press y for yes n for no");

                string k = Console.ReadLine();

                if (k == "n")
                {
                    a = false;
                }

                
            }
            
            return revstr;
        }

        public static int reverseNos()
        {
            int n,r=0,k;

            Console.WriteLine("enter any no");

            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                k = n % 10;

                r = r*10 + k;

                n = n/10;
            }

            //Console.WriteLine(r);

            return r;
        }

        public static string palindrome()
        {
            int n, k, j =0 , r = 0;

            string result;

            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());

            n = j;

            while (j > 0)
            {
                k = n % 10;

                r = r * 10 + k;

                n = n / 10;
            }

            if (n == j)
            {
                result = "no is palindrome";
            }
            else 
            {
                result = "it is not a palindrome";
            }

            return result;
        }

        public static string ArmstrongNo()
        {
            int n, r = 0, k;

            string result;

            Console.WriteLine("Enter no");
            n = Convert.ToInt32(Console.ReadLine());

            int j = n;

            while (n > 0)
            {
                k = n % 10;
                r = r + k * k * k;
                n = n / 10;
            }

            if (j == r)
            {
                result = "no is armstrong";
            }
            else 
            {
                result = "no is not armstrong";
            }

            return result;
        }

        public static string prime() 
        {
            int n, r = 0, k;

            string result;

            Console.WriteLine("Enter no");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n+1; i++) 
            {
                k = n % i;

                if (k == 0)
                {
                    r++;
                }
            }

            if (r == 2) 
            {
                result = n + " is a prime no";
            }
            else 
            {
                result = n + " is not a prime no";
            }

            return result;
        }

        public static string CountNoofWords() 
        {
            string str, result = null;

            int count = 1,len = 0;

            Console.WriteLine("enter string");
            str = Console.ReadLine();

            while(len <= str.Length - 1)
            {
                if (str[len]==' ' || str[len] == '\n' || str[len] == '\t') 
                { 
                    count++; 
                }

                len++;
            }

            result = "no of words in string is " + count;

            return result;
        }

        static void Main(string[] args)
        {

            //Console.WriteLine(reverseNos());

            //Console.WriteLine(reversestring());

            //Console.WriteLine(palindrome());

            //Console.WriteLine(ArmstrongNo());

            //Console.WriteLine(prime());

            //Console.WriteLine(CountNoofWords());


            Console.ReadLine();

        }
    }
}
