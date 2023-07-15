namespace Task68
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A(3, 2));
        }

        static uint A(uint n, uint m)
        {
            if(n == 0)
                return m + 1;
            else 
                if(n != 0 && m == 0)
                    return A(n - 1, 1);
                else
                    return A(n - 1, A(n, m - 1));
        }
    }
}