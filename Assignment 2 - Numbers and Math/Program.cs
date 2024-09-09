namespace Assignment_2___Numbers_and_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I wll now count my chickens:");
            Console.WriteLine("Hens " + (323 + 5 * 2));
            Console.WriteLine("Roosters " + (25 + 30 / 6));
            Console.WriteLine("six " + 6);
            Console.WriteLine("6 + 6");
            Console.WriteLine("6" + 6);
            Console.WriteLine(6 + 6);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Now i will count the eggs:");
            Console.WriteLine(11 / 2.0);
            Console.WriteLine("Is it true that 3 + 2 < 5 - 7?");
            Console.WriteLine(3 + 2 < 5 - 7);
            Console.WriteLine("What is 3 + 2 " + (3 + 2));
            Console.WriteLine("What is 5 - 7 " + (5 - 7));
            Console.WriteLine("Oh that's why it's " + (3 + 2 < 5 - 7));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Today I worked 8 hours! Let's see how much made! " + (21 * 8).ToString("C"));
            Console.WriteLine("Let's see how much each egg costs!!!! " + (6.0 / 12).ToString("C"));
            Console.WriteLine("I just bought a BLIGHT sweater for 79.99!! Let's see how much it costs after tax!! " + (79.99 * 1.13).ToString("C"));
            Console.WriteLine("My little cousin is 5'6!! Let's see how tall he is in centimeters!!" + Math.Round((2.54 * (5 * 12 + 6)), 2) + "cm");
        }
    }
}
