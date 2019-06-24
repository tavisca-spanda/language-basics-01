using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            /*var resutlts = FindDigit(args);
            var result = resutlts.Equals(expected) ? "PASS" : "FAIL";*/
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
            //Console.WriteLine(resutlts);

        }

        public static int FindDigit(string equation)
        {
            

            String[] sp_eqn=equation.Split(new char[]{'*','='}); // Spitting the equation
            if(sp_eqn[0].Contains("?"))
            {
                return multiplicant(sp_eqn[1],sp_eqn[2], sp_eqn[0]);
            }
            else if(sp_eqn[1].Contains("?"))
            {
                return multiplicant(sp_eqn[0],sp_eqn[2], sp_eqn[1]);
            }
            else 
            {
                
                int res = Convert.ToInt32(sp_eqn[0])*Convert.ToInt32(sp_eqn[1]);
                string r=Convert.ToString(res);
                string c= sp_eqn[2];
                int pos = c.IndexOf("?");
                
                if(c.Length==r.Length)
                    return Convert.ToInt32(r[pos])-48;
                return -1;


            }
        }
        public static int multiplicant (string a, string b, string c )
        {
            int x= Convert.ToInt32(a);
            int y= Convert.ToInt32(b);

            if(y%x!=0)
                return -1;
            
            int res = y/x;

            string r=Convert.ToString(res);
            int pos = c.IndexOf("?");
            if (c.Length == r.Length)
            {
                return Convert.ToInt32(r[pos])-48;
     

            }
            return -1;

        }
    }
}
