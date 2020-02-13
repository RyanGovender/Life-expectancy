using Life_expectancy.LogicLayer;
using Life_expectancy.Models;
using System;

namespace Life_expectancy
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int age;
            UserQuestion userQuestion = new UserQuestion();


            do
            {
                Console.WriteLine("Enter your age:");
            } while (!int.TryParse(Console.ReadLine(), out age));

            foreach(var item in QuestionnaireLogic.indexTable)
            {
                Console.WriteLine(QuestionnaireLogic.DisplayQuestion(item.QuestionToAsk,item.QuestionType));// method to add yes or no
                if(item.DataTypes == Models.DataTypes.Integer)
                {
                    var number = Console.ReadLine();
                    while(!int.TryParse(number,out value))
                    {
                        Console.WriteLine("Please enter a valid number");
                        number=Console.ReadLine();
                    }
                   // Console.WriteLine(QuestionnaireLogic.AgeCalculation(item.Id, value));
                    userQuestion.Id.Add(item.Id);
                }
                else if(item.DataTypes == Models.DataTypes.StringValue)
                {
                    if (item.QuestionType == Models.QuestionType.YesOrNoQuestion)
                    {
                        var reply = Console.ReadLine().ToLower();
                        while (!reply.Equals("yes") && !reply.Equals("no"))
                        {
                            Console.WriteLine("Please enter yes or no.");
                            reply = Console.ReadLine().ToLower();
                        }
                       // Console.WriteLine(QuestionnaireLogic.AgeCalculation(item.Id, reply));
                        userQuestion.Id.Add(item.Id);
                    }
                }
            }
            //QuestionnaireLogic.Display();
            Console.WriteLine("Your estimated life expectancy is: " +QuestionnaireLogic.DisplayFinalAge(age));
        }
    }
}
