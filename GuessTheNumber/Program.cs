Console.WriteLine("Welcome to the GuessTheNumber game!\n");
Console.WriteLine("Try to guess the number between 1 and 100.\n");

//Creating an object of the class Random
Random randomNumber = new Random();

//Initializing a variable which generates a random number between 1 and 100
int number = randomNumber.Next(1, 100);

//Storing the number of the tries of the player for guessing the number
int tries = 10;
Console.WriteLine($"You have {tries} tries.\n");

//Entering the number that we are guessing
Console.Write("Enter a number: ");
int guessNumber = int.Parse(Console.ReadLine());

//Initializing booleans to check if the number is high, low or the number is the same as the random number.
//Initially all booleans are assigned as true
bool isHigh = true;
bool isLow = true;
bool isGuessed = true;

//If our number is bigger than the random number
if (guessNumber > number)
{
	//We are reducing the number of tries with 1
	tries--;
	//The "isHigh" boolean is assigned as true, which will be useful later
	isHigh = true;
	//On the console is displayed "Too high!", because our number is bigger than the random number
	Console.WriteLine("\nToo high!");
}
//If our number is smaller than the random number
else if (guessNumber < number)
{
	//We are reducing the number of tries with 1
	tries--;
	//The "isLow" boolean is assigned as true, which will be useful later
	isLow = true;
	//On the console is displayed "Too low!", because our number is lower than the random number
	Console.WriteLine("\nToo low!");
}
//If our number is the same as the random number
if (guessNumber == number)
{
	//We are reducing the number of tries with 1
	tries--;
	//The "isGuessed" boolean is assigned as false, because we are not getting into another if statement, which is covered later
	isGuessed = false;
	//We are displaying on the console that our number is the same with the random number
	Console.WriteLine($"You guessed! The number is {number}");
	//The program is asking us if we want to play again
	Console.Write("Do you want to play againg? (yes/no): ");
	string answer = Console.ReadLine();
	if (answer == "yes")
	{
		tries = 10;
		Guessing();
	}
	else if (answer == "no")
	{
		Console.WriteLine("Thank you for playing!");
		Environment.Exit(0);
	}
	else
	{
		Environment.Exit(0);
	}
}

for (int i = 0; i < tries;)
{
	Console.Write("\nEnter a number: ");
	guessNumber = int.Parse(Console.ReadLine());
	if (guessNumber > number)
	{
		tries--;
		Console.WriteLine("\nToo high!");
	}
	else if (guessNumber < number)
	{
		tries--;
		Console.WriteLine("\nToo low!");
	}
	else if (isGuessed)
	{
		Console.WriteLine($"\nYou guessed! The number is {number}");
		Console.Write("\nDo you want to play againg? (yes/no): ");
		string answer = Console.ReadLine();
		if (answer == "yes")
		{
			tries = 10;
			Guessing();
		}
		else if (answer == "no")
		{
			Console.WriteLine("\nThank you for playing!");
			Environment.Exit(0);
		}
		else 
		{
			Environment.Exit(0);
		}
	}

	if (tries == 0)
	{
		Console.WriteLine($"\nYou don't have more tries!");
		Console.Write("\nDo you want to restart the game? (yes/no): ");
		string answer = Console.ReadLine();
		if (answer == "yes")
		{
			tries = 10;
			Guessing();
		}
		else if (answer == "no")
		{
			Console.WriteLine("\nThank you for playing!");
			Environment.Exit(0);
		}
		else
		{
			Environment.Exit(0);
		}
	}
}
void Guessing()
{
	Random randomNumber = new Random();

	int number = randomNumber.Next(1, 100);

	Console.WriteLine($"\nYou have {tries} tries.");

	for (int i = 1; i < tries;)
	{
		Console.Write("\nEnter a number: ");
		guessNumber = int.Parse(Console.ReadLine());
		if (guessNumber > number)
		{
			tries--;
			Console.WriteLine("\nToo high!");
		}
		else if (guessNumber < number)
		{
			tries--;
			Console.WriteLine("\nToo low!");
		}
		else if (isGuessed)
		{
			Console.WriteLine($"\nYou guessed! The number is {number}");
			Console.Write("\nDo you want to play againg? (yes/no): ");
			string answer = Console.ReadLine();
			if (answer == "yes")
			{
				tries = 10;
				randomNumber = new Random();

				number = randomNumber.Next(1, 100);

				Console.WriteLine($"\nYou have {tries} tries.");
			}
			else if (answer == "no")
			{
				Console.WriteLine("\nThank you for playing!");
				Environment.Exit(0);
			}
			else
			{
				Environment.Exit(0);
			}
		}
	}
}