using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.LogicLayer
{
   public class UserInterfaceLogic
    {
        private static int value;
        private static int age;
        private static int _minValue=0;

        public static int GetUserAge()
        {
            do
            {
                Console.WriteLine("\nEnter your age:");
            } while (!int.TryParse(Console.ReadLine(), out age) || age > QuestionnaireLogic.MaxAge || age < _minValue);

            return age;
        }

        public static void RunProgram()
        {
            Display();

            GetUserAge();

            foreach (var item in QuestionnaireLogic.indexTable)
            {
                Console.WriteLine(YesOrNoQuestionLogic.AddYesOrNo(item.QuestionToAsk, item.QuestionType));

                if (item.DataTypes == Models.DataTypes.Integer)
                {
                    var number = Console.ReadLine();
                    while (!int.TryParse(number, out value) || value > ValueQuestionLogic._maxValueAllowed || value < _minValue)
                    {
                        Console.WriteLine("\nError....Please enter a valid number between 0 - 7");
                        number = Console.ReadLine();
                    }
                    QuestionnaireLogic.AgeCalculation(item.Id, value);
                }
                else if (item.DataTypes == Models.DataTypes.StringValue)
                {
                    if (item.QuestionType == Models.QuestionType.YesOrNoQuestion)
                    {
                        var reply = Console.ReadLine().ToLower();
                        while (!reply.Equals("yes") && !reply.Equals("no"))
                        {
                            Console.WriteLine("Please enter yes or no.");
                            reply = Console.ReadLine().ToLower();
                        }
                        QuestionnaireLogic.AgeCalculation(item.Id, reply);
                    }
                }
            }
            DisplayFinalAge();
        }

        public static void Display()
        {
            Console.WriteLine("-------------Life Expectancy Calculator----------------" +
                "\n\n\n------------Please Enter Values between 0-7 or Yes and No for the questions------------\n\n");
        }

        public static void DisplayFinalAge()
        {
            Console.WriteLine($"\n\n-------------Your estimated life expectancy is: {QuestionnaireLogic.DisplayFinalAge(age)}---------------------------");
        }
    }
}
