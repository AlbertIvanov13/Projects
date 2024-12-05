

void ReverseTheCase(string input)
{
	for (int i = 0; i < input.Length; i++)
	{
		if (input[i].ToString() == input[i].ToString().ToUpper())
		{
			Console.Write(input[i].ToString().ToLower());
		}
		else if (input[i].ToString() == input[i].ToString().ToLower())
		{
			Console.Write(input[i].ToString().ToUpper());
		}
	}
}

ReverseTheCase("sPoNtAnEoUs");