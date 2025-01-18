//Start of the project :)

Console.WriteLine(value: "Driving around while bored and angry \nYou come upon an fishing rod ready and baited\n\n1.Go Fishing!\n2.Drive Home");
string input = Console.ReadLine();
string name = input;
int question = 1; //Question variable to try and keeps things seperate so it doesn't try to answer the wrong if and so that I can go back to questions from different spots 
string tooBroke = ("Unable to afford your meal, you go home and cry yourself to sleep \nDreaming of horrific fish following you from the corner of your eye");

if (input.Contains("1") && question == 1)
{
    question = 2;
    Console.Clear();
    Console.WriteLine("As you begin to fish you get an odd feeling" +
    "\nThe feeling gets more ominous the longer you fish");
    Console.WriteLine("\n1.Keep Fishing \n2.Drive Home");
    input = Console.ReadLine();

    //Eaten by fish path
    if (input.Contains("1") && question == 2)
    {
        question = 4;
        Console.Clear();
        Console.WriteLine("As you stand on the dock, fishin' you feel a bite\nHowever as you begin to reel a giant fish pops out of the water and eats you whole\nDropping you into it's stomach");
        Console.WriteLine("\n1.Escape through the throat \n2.Escape through the anus \n3.Give up and die");
        input = Console.ReadLine();
        if (input.Contains("1") && question == 4)
        {
            Console.Clear();
            Console.WriteLine("You scrape and claw at the creature's throat but find it's too slippery to get out that way");
            question = 6;
            Console.WriteLine("\n1.Escape through the anus \n2.Give up and die");
            input = Console.ReadLine();
            if (input.Contains("1") && question == 6)
            {
                Console.Clear();
                Console.WriteLine("You squirm through this gargantuan fishes pipes and come out the other end\nYou are then able to swim back to the dock and your car\n");
                question = 3;
                Console.WriteLine("You get in your car and begin to drive home \nOn the way home you feel like you're being followed " +
            "\nAltho you see no cars behind you at this time of night");
                Console.WriteLine("\n1.Stop for a bite to eat at A&W\n2.Continue driving home");
                input = Console.ReadLine();
            }
            else if (input.Contains("2") && question == 6)
            {
                Console.Clear();
                Console.WriteLine("You lay down accepting your fate of being slowly digested by this big ol' fish");
            }
        }
        else if (input.Contains("2") && question == 4)
        {
            Console.Clear();
            Console.WriteLine("You squirm through this gargantuan fishes pipes and come out the other end\nYou are then able to swim back to the dock and your car\n");
            question = 3;
            Console.WriteLine("You get in your car and begin to drive home \nOn the way home you feel like you're being followed " +
        "\nAltho you see no cars behind you at this time of night");
            Console.WriteLine("\n1.Stop for a bite to eat at A&W\n2.Continue driving home");
            input = Console.ReadLine();
        }
        else if (input.Contains("3") && question == 4)
        {
            Console.Clear();
            Console.WriteLine("You lay down accepting your fate of being slowly digested by this big ol' fish");
        }

    }
    else if (input.Contains("2") && question == 2)
    {
        Console.Clear();
        Console.WriteLine("You squirm through this gargantuan fishes pipes and come out the other end\nYou are then able to swim back to the dock and your car\n");
        question = 3;
        Console.WriteLine("You get in your car and begin to drive home \nOn the way home you feel like you're being followed " +
    "\nAltho you see no cars behind you at this time of night");
        Console.WriteLine("\n1.Stop for a bite to eat at A&W\n2.Continue driving home");
        input = Console.ReadLine();
    }
}

//Driving home path
else if (input.Contains("2") && question == 1)
{
    question = 3;
    Console.Clear();
    Console.WriteLine("You get in your car and begin to drive home \nOn the way home you feel like you're being followed " +
        "\nAltho you see no cars behind you at this time of night");
    Console.WriteLine("\n1.Stop for a bite to eat at A&W\n2.Continue driving home");
    input = Console.ReadLine();
}
if (input.Contains("1") && question == 3)
{
    Console.Clear();
    Console.WriteLine("You walk into A&W glance at their menu, but you forgot how many $ you have, how many $ do you have?");
    string moneyText = Console.ReadLine();
    int moneyNumber = int.Parse(moneyText);
    Console.Clear();
    Console.WriteLine($"You have {moneyNumber}$ \n1. Fish Burger Combo 14$ \n2. Cow Burger Combo 16$ \n3. We Have A&W At Home");
    question = 5;
    input = Console.ReadLine();
    if (moneyNumber >= 14 && input.Contains("1") && question == 5)
    {
        Console.Clear();
        Console.WriteLine("As you sit down to eat your tasty fish burger, the fish batter begins to peel off showing eyes and scales \nIt's still alive!" +
            " It's begins to grow incredibly rapidly, even as you run to your car \nIt's already outgrown the A&W, It waddles up and eats your car with you still inside\n");
    }
    else if (moneyNumber < 14 && input.Contains("1") && question == 5)
    {
        Console.Clear();
        Console.WriteLine($"{tooBroke}");
    }
    else if (moneyNumber >= 16 && input.Contains("2") && question == 5)
    {
        Console.Clear();
        Console.WriteLine("After eating your tasty cow burger, you return home and sleep soundly \nComforted by the tasty cow burger in your belly");
    }
    else if (moneyNumber < 16 && input.Contains("2") && question == 5)
    {
        Console.Clear();
        Console.WriteLine($"{tooBroke}");
    }
    else if (input.Contains("3") && question == 5)
    {
        Console.Clear();
        Console.WriteLine($"Content that you don't need that tasty burger, you return home to dream of scary fish");
    }
}
else if (input.Contains("2") && question == 3)
{
    Console.Clear();
    Console.WriteLine("You drive home safely and fall asleep with dreams of horrific fish");
}

