// Name - Vinh Huynh
// Date - September 9, 2022

using System; 

internal class Program
{
    private static void Main(string[] args)
    {
        
        try
        {
            Console.WriteLine("Enter an integer value between 1 and 100");
            int input1 = int.Parse(Console.ReadLine());
            
            // Checks if users enter a integer between 0 and 100
            if ((input1 > 0) && (input1 < 100))
            {
                Console.WriteLine("What is the number series: Even or Odd?");
                string input2 = Console.ReadLine();

                Console.WriteLine("Interger Input: " + input1.ToString());
                Console.WriteLine("String Input: " + input2.ToString());
                Console.WriteLine("Output");
                Console.WriteLine("You have selected the even series. The numbers between 0 and " + input1 + " are:");

                for (int i = 0; i <= input1; i++)
                {
                    int even = 2 * i;
                    int odd = 2 * i + 1;

                    if ((input2 == "Even") || (input2 == "even"))
                    {

                        if (even > input1)
                        {

                            break;
                        }
                        else
                        {
                            Console.WriteLine(even.ToString());
                        }
                    }
                    else if ((input2 == "Odd") || (input2 == "odd"))
                    {
                        if (odd > input1)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(odd.ToString());
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: Enter an integer between 1 and 100");
            }
        }
        catch
        {
            Console.WriteLine("Please enter an integer between 1 and 100");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}