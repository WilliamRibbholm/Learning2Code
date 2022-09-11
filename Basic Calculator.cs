namespace Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ShowMenu = true;  
            while (ShowMenu)
            {
                ShowMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {     
            char op;
            
            Console.Clear();
            Console.WriteLine("-------Welcome to the Calculator!-------");
            Console.WriteLine("Choose your operation down below.\n");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Divison\n");
            Console.WriteLine("0) Press to exit\n");
            Console.Write("Select an option: ");
            
            
            op = Console.ReadLine()[0];

            switch(op) 
            {
                case '1':
                    Addition();
                    break;
                case '2':
                    Subtraction();
                    break;
                case '3':
                    Multiplication();
                    break;
                case '4':
                    Division();
                    break;
                case '0':
                    Console.Clear();
                    return false;                    
                    break;
                default:
                    Console.WriteLine("{0} is an invalid selection",op);                    
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    break;
            
            
            
            }

            return true;
        }
        static void Addition() 
        {
            double num1, num2;
            Console.WriteLine("Pick your first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pick your second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",num1,num2,(num1+num2));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
        static void Subtraction() 
        {
            double num1, num2;
            Console.WriteLine("Pick your first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pick your second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }    
        static void Multiplication() 
        {
            double num1, num2;
            Console.WriteLine("Pick your first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pick your second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
        static void Division() 
        {
            double num1, num2;
            num2 = 0;
            Console.WriteLine("Pick your first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            while(num2 == 0)    // When num2 equals to zero, you will get the error message of that it can't be divided by zero.
            {
                Console.WriteLine("Pick your second number:");
                num2 = Convert.ToDouble(Console.ReadLine());
                
                if(num2 == 0) 
                { 
                    Console.WriteLine("You can't divide by zero.");
                }
            }
            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2).ToString("F3"));  // F3 converts it to three decimals
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }    
    }
}