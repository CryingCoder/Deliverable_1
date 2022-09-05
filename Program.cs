public class Deliverable1
{

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            int People = int.Parse(Console.ReadLine());

            double Slices = People * 2;
            double PB = People * 2;
            double Jelly = People * 4;

            double totalSlices = Math.Ceiling(Slices / 28);
            double totalPB = Math.Ceiling(PB / 32);
            double totalJelly = Math.Ceiling(Jelly / 48);

            Console.WriteLine(Slices + " slices of bread");
            Console.WriteLine(PB + " tablespoons of peanut butter");
            Console.WriteLine(Jelly + " teaspoons of jelly");
            Console.WriteLine("which is...");
            Console.WriteLine(totalSlices + " loaves of bread");
            Console.WriteLine(totalPB + " jars of peanut butter");
            Console.WriteLine(totalJelly + " jars of jelly");

            while (true)
            {
                Console.WriteLine("` Would you like to restart? Enter yes or y to continue, or enter any other key to exit");
                string Response = Console.ReadLine();
                if (Response == "y" || Response == "Y" || Response == "Yes" || Response == "YES" || Response == "yes")
                    break;
                else
                    Console.WriteLine("Goodbye!");
                return;
            }
        }
    }
}