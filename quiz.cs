using System;
using System.Collections.Generic;

public class Quiz
{
	public string Question{get; set;}
	public bool ABCD{get; set;}
	public string Answer{get; set;}
	public Quiz(string question, bool abcd, string answer){
		Question = question;
		ABCD = abcd;
		Answer = answer;
	}
	
	
	public static bool CheckAnswer(Quiz question, string answer){
		if(question.Answer == answer){
			return true;
		}else{return false;}
	}
	
	public static void AskQuestion(Quiz question){
		Console.Write(question.Question);
		if (CheckAnswer(question, Console.ReadLine().ToLower()) == true){
			Console.WriteLine("Correct!");
		}else{Console.WriteLine("Incorrect, the answer was " + question.Answer);}
	}
	
	public static Quiz ChooseQuestion(List<Quiz> array){
		Random Rand = new Random();
		int num = Rand.Next(0, array.Count);
		return array[num];
	}
}

public class Program
{
	public static void Main()
	{
		
		Quiz one = new Quiz("Does 2 + 1 equal 3?", false, "yes");
		Quiz two = new Quiz("Which one says 'hi'? \na) bye \nb) no \nc) hi \nd) yes", true, "c");
		Quiz three = new Quiz("Are you on a computer?", false, "yes");
		Quiz four = new Quiz("What coding language was this made with?", false, "c#");
		Quiz five = new Quiz("What speaking language is this in?", false, "english");
		Quiz six = new Quiz("What planet are you on? \na) Earth \nb) Mars \nc) Venus \nd) Jupiter", true, "a");
		
		List<Quiz> questions = new List<Quiz>{one, two, three, four, five, six};
    
    while(a==true){
			Quiz.AskQuestion(Quiz.ChooseQuestion(questions));
		}
	}
}
