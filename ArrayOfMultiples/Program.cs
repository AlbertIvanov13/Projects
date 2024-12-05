

void ArrayOfMultiples(int num, int length)
{
	int[] array = new int[length];

	array[0] = num;

	int nextNumber = num;

	for (int i = 1; i <= array.Length - 1; i++)
	{
		array[i] = nextNumber += num;
		nextNumber = array[i];
	}

    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

ArrayOfMultiples(17, 6);