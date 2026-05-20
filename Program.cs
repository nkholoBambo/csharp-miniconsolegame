int playerHealth = 100;
int enemyHealth = 100;

while (playerHealth > 0 && enemyHealth > 0)
{
    Console.WriteLine("Choose your action:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Defend");
    Console.WriteLine("3. Heal");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            int playerDamage = new Random().Next(10, 20);
            enemyHealth -= playerDamage;
            Console.WriteLine($"Damage dealt: {playerDamage}");
            break;
        case "2":
            Console.WriteLine("You defend against the next attack!");
            break;
        case "3":
            int healAmount = new Random().Next(6, 10);
            playerHealth += healAmount;
            Console.WriteLine($"You healed yourself for {healAmount} health!");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            continue;
    }

    if (enemyHealth > 0)
    {
        int enemyDamage = new Random().Next(10, 20);
        playerHealth -= enemyDamage;
        Console.WriteLine($"The enemy attacked you for {enemyDamage} damage!");
    }
}

if (playerHealth <= 0)
{
    Console.WriteLine("You have been defeated!");
}
else
{
    Console.WriteLine("Congratulations! You have defeated the enemy!");
}