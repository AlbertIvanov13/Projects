
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

int biggestNumber = 0;
int index = 0;

for (int i = 0; i < newArray.Count; i++)
{

	//if (i == newArray.Count)
	//{

	//}
	//if (i == newArray.Count)
	//{
	//	if (newArray[i + 1] > biggestNumber)
	//	{
	//		biggestNumber = newArray[i + 1];
	//		Console.WriteLine($"The biggest number is {biggestNumber} with index {index}");
	//	}
	//	else
	//	{
	//		Console.WriteLine($"The biggest number is {biggestNumber} with index {index}");
	//	}
	//}
	//else
	//{
	//	if (i == newArray.Count - 1)
	//	{
	//		if (newArray[i] > newArray[i - 1] && newArray[i] > biggestNumber)
	//		{
	//			biggestNumber = newArray[i];
	//			index = i;
	//			Console.WriteLine($"The biggest number is {biggestNumber} with index {index}");
	//		}
	//	}
	//	else
	//	{
	//		if (newArray[i] > newArray[i + 1] && newArray[i] > biggestNumber)
	//		{
	//			biggestNumber = newArray[i];
	//			index = i;
	//		}
	//	}
	//}
}