using System.Security.Cryptography.X509Certificates;

static void Main(string[] args) { }
    Console.WriteLine("Enter a number"); // Here the console says to Enter a number
int Num = Convert.ToInt32(Console.ReadLine()); // Here is where you input your number which is defined as the Integer Num
if (Num >= 1 && Num <= 10) // If the integer Num is greater and equal to 1 and if it is less or equal to 10
{
    Console.WriteLine("Valid"); //If the number you wrote is true as to say between 1 and 10 it is valid 
        }
else
{
    Console.WriteLine("Invalid"); // If the number is not between 1 and 10 it is invalid
}