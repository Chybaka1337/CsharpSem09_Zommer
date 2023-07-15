namespace Task66
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter low bound = ");
            int.TryParse(Console.ReadLine(), out int lowBound);
            Console.Write("Enter up bound = ");
            int.TryParse(Console.ReadLine(), out int upBound);
            Console.WriteLine(Recursive(lowBound, upBound));
        }

        static int Recursive(int lowBound, int upBound) 
        {
            return upBound == lowBound ? upBound : upBound + Recursive(lowBound, --upBound);
        }
    }
}