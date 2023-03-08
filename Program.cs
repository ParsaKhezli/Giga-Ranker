internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter your mark");

        int x;

        x = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("enter your mark");

            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case < 10:
                    Console.WriteLine("Failed");


                    break;
                case < 15:
                    Console.WriteLine("Rank C");


                    break;
                case < 17:
                    Console.WriteLine("Rank B");
                    ;

                    break;
                case <= 20:
                    Console.WriteLine("Rank A");


                    break;
                default:
                    Console.WriteLine("invalid Number");
                    break;
            }




            




        }

        while (true);

        {
            

        }
    }
}