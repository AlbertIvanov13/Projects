namespace QuestionGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> questions = new List<string>();
			questions.Add("Which is the capital of France?");
			questions.Add("Which is the capital of Bulgaria?");
			questions.Add("Which is the capital of Spain?");
			Questions questionss = new Questions("", questions, "");

            Console.WriteLine(string.Join(" \n", questions));
		}
	}

	public class Questions
	{
		public string QuestionText { get; set; }

		public List<string> Options { get; set; }

		public string CorrectAnswer { get; set; }

		public Questions(string text, List<string> options, string correctAnswer)
		{
			QuestionText = text;
			Options = options;
			CorrectAnswer = correctAnswer;
		}
	}
}
