
namespace Assignment3_2_4
{
    internal class Program
    {
        //  Write a function that takes 4 numbers as input to calculate the total and average.
        static void Main(string[] args)
        {
            double avg;
            double total;
            Console.WriteLine("Please enter four numbers");
            Console.Write("Number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 3: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 4: ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            CalculateAvgAndTotal(out avg, out total, num1, num2, num3, num4);
            Console.WriteLine($"Numbers: { num1 }, { num2 }, { num3 }, { num4 }");
            Console.WriteLine($"Average: { avg }");
            Console.WriteLine($"Total: { total }");

        }

        // Takes two out params for avg and total of numbers, and a params array to collect the numbers
        static void CalculateAvgAndTotal(out double avg, out double total, params double[] arr)
        {
            total = 0;
            foreach (var num in arr) 
            {
                total += num;
            }
            avg = total / arr.Length;
        }
    }
}
