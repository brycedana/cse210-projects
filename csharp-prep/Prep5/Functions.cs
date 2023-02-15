 static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int NumberSquared = SquareNumber(userNumber);

        DisplayResult(userName, NumberSquared);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Bienvenido!");
    }

    static string PromptUserName()
    {
        Console.Write("Type name here: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }