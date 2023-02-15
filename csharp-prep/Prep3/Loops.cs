 Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int answer = 0;

        // We could also use a do-while loop here...
        while (answer != magicNumber)
        {
            Console.Write("What is your guess? ");

            answer = int.Parse(Console.ReadLine());

            if (magicNumber > answer)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < answer)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Yep, that's it!");
            }

        }                    