namespace Line_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison program");
            Console.WriteLine("Choose the option \n 1.Line Computation program added \n 2.Line comparison between two line \n 3.line compared by points \n 4.line compared by comparison method");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: Class1.LineComputation();break;
                case 2: Class2.LineComparison();break;
                case 3: Class3.LineEquality();break;
                case 4: Class4.ComparisonMethod();break;
            }
        }
    }
}