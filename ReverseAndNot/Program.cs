

using System.Linq;

void ReverseAndNot(int number)
{
	string result = number.ToString();
	char[] chars = result.ToCharArray();

	Array.Reverse(chars);

    Console.WriteLine(string.Join("", chars) + result);
}

ReverseAndNot(123456789);