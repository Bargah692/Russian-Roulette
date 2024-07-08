Console.WriteLine("-------------------------------");
Console.WriteLine("Russian Roulette");
Console.WriteLine("-------------------------------");

Random random = new Random();
int ChamberChosen = 0;


while (ChamberChosen < 1 || ChamberChosen > 6)
{
    Console.WriteLine("Pick a Chamber. (1-6)");
    if (int.TryParse(Console.ReadLine(), out int result) && result >= 1 && result <= 6)
    {
        ChamberChosen = result;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
    }
}

int BulletChamber = random.Next(1, 7);
bool playAgain = true;
bool Looped = false;

while (playAgain)
{
    if (ChamberChosen == BulletChamber)
    {
        Console.WriteLine("Bang!");
        Console.Beep();
        playAgain = false;
    }
    else
    {
        Console.WriteLine("Click.\nShoot Again? (y,n)");
        string response = Console.ReadLine().ToLower();

        if (response == "n")
        {
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
            playAgain = false;
        }
        else
        {
            BulletChamber++;
            if (BulletChamber > 6)
            {
                BulletChamber = 1;
            }
            Looped = true;
        }
    }
}

Console.ReadKey();
