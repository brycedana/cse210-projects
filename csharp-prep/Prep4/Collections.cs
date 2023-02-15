List<int> numbers = new List<int>();
        int Number = 0;
        while (Number != 0)
        {
            Console.Write("Enter a number (type 0 to exit): ");
            
            string userResponse = Console.ReadLine();
            Number = int.Parse(userResponse);
            
           
            if (Number != 0)
            {
                numbers.Add(Number);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

       
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");