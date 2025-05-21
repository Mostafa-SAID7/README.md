namespace REDACTED_PROJECT_NAME
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool? isAhmed = null;
            Console.WriteLine("Are you Ahmed? : (Y,N)");
            char result =Convert.ToChar( Console.ReadLine());
            
            if (result == 'Y' || result == 'y')
            {
                isAhmed = true;
            }
            else if (result == 'N' || result == 'n')
            {
                isAhmed = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
                return;
            }
            Console.WriteLine($"Is Ahmed: {isAhmed}");
        }
    }
}