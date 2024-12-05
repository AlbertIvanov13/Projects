
Console.Write($"Enter a number (or 0 for exit): ");

int number = int.Parse(Console.ReadLine());

int arraySize = 0;

int[] array = new int[arraySize];

List<int> newArray = new List<int>(arraySize);
newArray.Add(number);

while (number != 0)
{
	Console.Write($"Enter a number (or 0 for exit): ");

	number = int.Parse(Console.ReadLine());

	if (number == 0)
	{
		break;
	}

	arraySize++;

	newArray.Add(number);
}

newArray.ToArray();

int biggestNumber = 0;
int smallestNumber = 0;

bool bigNumber = false;
bool smallNumber = true;
bool smallNumber2 = true;
bool notFound = false;
int index = 0;

for (int i = 0; i < newArray.Count; i++)
{
	if (i == newArray.Count - 1)
	{
		if (newArray[i] > biggestNumber)
		{
			Console.WriteLine($"The biggest number is {newArray[i]} with index {i}");
			break;
		}

		if (bigNumber)
		{
			Console.WriteLine($"The biggest number is {biggestNumber} with index {index}");
		}
	}
	else
	{
		if (newArray[i] > newArray[i + 1])
		{
			if (newArray[i] > biggestNumber)
			{
				biggestNumber = newArray[i];
				index = i;
				bigNumber = true;
			}
			if (i == newArray.Count - 1)
			{
				if (newArray[i] > biggestNumber)
				{
					biggestNumber = newArray[i];
					index = i;
					bigNumber = true;
				}
			}
			else if (biggestNumber > newArray[i])
			{
				biggestNumber = biggestNumber;
				index = index;
				bigNumber = true;
			}
		}
	}
}

for (int i = 0; i < newArray.Count; i++)
{
	if (i == newArray.Count - 1)
	{
		if (newArray[i] < smallestNumber)
		{
			Console.WriteLine($"The smallest number is {newArray[i]} with index {i}");
			break;
		}

		if (smallNumber)
		{
			Console.WriteLine($"The smallest number is {smallestNumber} with index {index}");
		}
	}
	else
	{
		if (newArray[i] < newArray[i + 1])
		{
			if (smallestNumber > newArray[i])
			{
				smallestNumber = newArray[i];
				index = i;
				smallNumber = true;
			}
			if (i == newArray.Count - 1)
			{
				if (newArray[i] < smallestNumber)
				{
					smallestNumber = newArray[i];
					index = i;
					smallNumber = true;
				}
			}

			else if (smallestNumber < newArray[i])
			{
				if (smallNumber2)
				{
					smallestNumber = newArray[i];
					index = i;
					smallNumber2 = false;
					smallNumber = true;
				}
			}
		}
	}
}