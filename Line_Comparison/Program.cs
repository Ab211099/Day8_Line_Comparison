namespace Line_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison program");
            Console.WriteLine("Choose the option \n 1.Line Computation program added");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: Class1.LineComputation();break;
            }
        }
    }
}