namespace _1._5Uzduotis_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 4, 5, 6 };

        
            foreach (int i in GetFactorials(list))
            {
                Console.WriteLine(i);
            }

        }
        public static List<int> GetFactorials(List<int> list)
        {
            List<int> fac = new List<int>();
            
            foreach (int number in list)
            {
                int factorials = 1;


                for (int i = 1; i <= number; i++)
                {
                factorials *= i;
                }
                fac.Add(factorials);
            }
            return fac;
        }
    }
}