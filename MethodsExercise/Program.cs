namespace MethodsExercise
{
    public class Program
    {
        public static string AskName() // Exercise 1 method
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        public static string AskDesc() //Exercise 1 method
        {
            Console.WriteLine("What is a good word to describe you?");
            return Console.ReadLine();
        }
        
        public static string AskPlace() // Exercise 1 method
        {
            Console.WriteLine("Name a place you may like to visit.");
            return Console.ReadLine();
        }
        
        public static string AskDrink() // Exercise 1 method
        {
            Console.WriteLine("What is your favorite drink?");
            return Console.ReadLine();
        }

        public static int Add(int num1, int num2) //Exercise 2 adding method
        {
            return num1 + num2;
        }
        
        public static int Sub(int num1, int num2) //Exercise 2 subtracting method
        {
            return num1 - num2;
        }
        
        public static int Mult(int num1, int num2) //Exercise 2 multiplying method
        {
            return num1 * num2;
        }
        
        public static int Div(int num1, int num2) //Exercise 2 dividing method
        {
            return num1 / num2;
        }
        
       
        
        
        static void Main(string[] args)
        {
            // Assigning variables for exercise 1
            string name = AskName();
            string desc = AskDesc();
            string place = AskPlace();
            string drink = AskDrink();
            
            // Exercise 1 output
            Console.WriteLine($"Greetings {name} the {desc}, welcome to {place}. Let me get you {drink} to drink.");
            
            // Exercise 2 
            Console.WriteLine("Enter an integer");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter another integer");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($" Added: {Add(num1, num2)}\n Subtracted: {Sub(num1, num2)}\n Multiplied: {Mult(num1, num2)}\n Divided: {Div(num1, num2)}\n");
        }
    }
}