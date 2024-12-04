Console.Write("Enter the number of players (2-5): ");
int playersNumber = int.Parse(Console.ReadLine());

List<string> players = new List<string>();

for (int i = 1; i <= playersNumber; i++)
{
	Console.Write($"Enter name for Player {i}: ");
	string name = Console.ReadLine();
	players.Add(name);
}

if (players.Count < 2)
{
	playersNumber = int.Parse(Console.ReadLine());
}
else  if (players.Count > 5)
{
	playersNumber = int.Parse(Console.ReadLine());
}

int rounds = playersNumber;

List<string> questions = new List<string>();
questions.Add("Which is the capital of France?");
questions.Add("Which is the capital of Bulgaria?");
questions.Add("Which is the capital of Spain?");

List<string> answers = new List<string>();

int playerOneScore = 0;
int playerTwoScore = 0;
int playerThreeScore = 0;
int playerFourScore = 0;
int playerFiveScore = 0;

for (int i = 1; i <= rounds; i++)
{
	for (int j = 0; j < players.Count; j++)
	{
		Console.WriteLine($"\nRound {i}: {players[j]}'s Turn");
		if (questions[0] == "Which is the capital of France?")
		{
			Console.WriteLine(questions[0]);
			answers.Add("A. Paris");
			answers.Add("B. Madrid");
			answers.Add("C. Berlin");
			answers.Add("D. Amsterdam");

			Console.WriteLine(answers[0]);
			Console.WriteLine(answers[1]);
			Console.WriteLine(answers[2]);
			Console.WriteLine(answers[3]);

			string corrrectAnswer = string.Empty;
			if (answers[0].StartsWith("A"))
			{
				corrrectAnswer = answers[0].First().ToString();
			}

            Console.Write("Enter answer: "); 
			string answer = Console.ReadLine();

			if (answer == corrrectAnswer)
			{
                Console.WriteLine("Correct! You earned 1 point");
				if (j == 0)
				{
					playerOneScore++;
				}
				else if (j == 1)
				{
					playerTwoScore++;
				}
				else if (j == 2)
				{
					playerThreeScore++;
				}
				else if (j == 3)
				{
					playerFourScore++;
				}
				else if (j == 4)
				{
					playerFiveScore++;
				}
			}
			else
			{
                Console.WriteLine("Incorrect answer!");
			}
		}
		if (questions[1] == "Which is the capital of Bulgaria?")
		{
			Console.WriteLine(questions[1]);
			answers.Add("A. Belgrade");
			answers.Add("B. Bucharest");
			answers.Add("C. Sofia");
			answers.Add("D. Athens");

			Console.WriteLine(answers[4]);
			Console.WriteLine(answers[5]);
			Console.WriteLine(answers[6]);
			Console.WriteLine(answers[7]);

			string corrrectAnswer = string.Empty;
			if (answers[2].StartsWith("C"))
			{
				corrrectAnswer = answers[2].First().ToString();
			}

			Console.Write("Enter answer: ");
			string answer = Console.ReadLine();

			if (answer == corrrectAnswer)
			{
				Console.WriteLine("Correct! You earned 1 point");
				if (j == 0)
				{
					playerOneScore++;
				}
				else if (j == 1)
				{
					playerTwoScore++;
				}
				else if (j == 2)
				{
					playerThreeScore++;
				}
				else if (j == 3)
				{
					playerFourScore++;
				}
				else if (j == 4)
				{
					playerFiveScore++;
				}
			}
			else
			{
				Console.WriteLine("Incorrect answer!");
			}
		}
		if (questions[2] == "Which is the capital of Spain?")
		{
			Console.WriteLine(questions[2]);
			answers.Add("A. Lisbon");
			answers.Add("B. Paris");
			answers.Add("C. Berlin");
			answers.Add("D. Madrid");

			Console.WriteLine(answers[8]);
			Console.WriteLine(answers[9]);
			Console.WriteLine(answers[10]);
			Console.WriteLine(answers[11]);

			string corrrectAnswer = string.Empty;
			if (answers[3].StartsWith("D"))
			{
				corrrectAnswer = answers[3].First().ToString();
			}

			Console.Write("Enter answer: ");
			string answer = Console.ReadLine();

			if (answer == corrrectAnswer)
			{
				Console.WriteLine("Correct! You earned 1 point");
				if (j == 0)
				{
					playerOneScore++;
				}
				else if (j == 1)
				{
					playerTwoScore++;
				}
				else if (j == 2)
				{
					playerThreeScore++;
				}
				else if (j == 3)
				{
					playerFourScore++;
				}
				else if (j == 4)
				{
					playerFiveScore++;
				}
			}
			else
			{
				Console.WriteLine("Incorrect answer!");
			}
		}
	}
}

Console.WriteLine("Game over!");
Console.WriteLine("Final scores: ");
for (int i = 0; i < players.Count; i++)
{
	if (players[i] == players[0])
	{
		Console.WriteLine($"{players[i]}: {playerOneScore} points");
	}
	else if (players[i] == players[1])
	{
		Console.WriteLine($"{players[i]}: {playerTwoScore} points");
	}
	else if (players[i] == players[2])
	{
		Console.WriteLine($"{players[i]}: {playerThreeScore} points");
	}
	else if (players[i] == players[3])
	{
		Console.WriteLine($"{players[i]}: {playerFourScore} points");
	}
	else if (players[i] == players[4])
	{
		Console.WriteLine($"{players[i]}: {playerFiveScore} points");
	}
}