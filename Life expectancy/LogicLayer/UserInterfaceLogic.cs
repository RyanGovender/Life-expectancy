using System;

namespace Life_expectancy.LogicLayer
{
   public class UserInterfaceLogic
    {
        private static int value;
        private static int age;
        private static int _minValue=0;
        private static int _getCountryCode = 0;

        private static void GetAverageAge()
        {
            AverageAgeLogic.DisplayCountyCode();
            do
            {
                Console.WriteLine("Please Enter A Vaild County Code From The Above List.");

            } while (!int.TryParse(Console.ReadLine(), out _getCountryCode) || !AverageAgeLogic.CheckIfIdExist(_getCountryCode));

            AverageAgeLogic.SetAverageAge(_getCountryCode);
        }

        private static int GetUserAge()
        {
            do
            {
              Console.WriteLine("\nEnter your age:");

            } while (!int.TryParse(Console.ReadLine(), out age) || age > AverageAgeLogic.maxAge || age < _minValue);

            return age;
        }

        public static void RunProgram()
        {
            GetAverageAge();

            GetUserAge();

            Display();

            foreach (var item in QuestionnaireLogic.indexTable)
            {
                Console.WriteLine(YesOrNoQuestionLogic.AddYesOrNo(item.QuestionToAsk, item.QuestionType));

                if (item.DataTypes == Models.DataTypes.Integer)
                {
                    var number = Console.ReadLine();
                    while (!int.TryParse(number, out value) || value > ValueQuestionLogic._maxValueAllowed || value < _minValue)
                    {
                        Console.WriteLine($"\nError....Please enter a valid number between {_minValue} - {ValueQuestionLogic._maxValueAllowed}");
                        number = Console.ReadLine();
                    }
                    QuestionnaireLogic.AgeCalculation(item.Id, value);
                }
                else if (item.DataTypes == Models.DataTypes.StringValue)
                {
                    if (item.QuestionType == Models.QuestionType.YesOrNoQuestion)
                    {
                        var reply = Console.ReadLine().ToLower();
                        while (!reply.Equals(YesOrNoQuestionLogic._positiveResponse) && !reply.Equals(YesOrNoQuestionLogic._negativeResponse))
                        {
                            Console.WriteLine($"Please enter {YesOrNoQuestionLogic._positiveResponse} or {YesOrNoQuestionLogic._negativeResponse}.");
                            reply = Console.ReadLine().ToLower();
                        }
                        QuestionnaireLogic.AgeCalculation(item.Id, reply);
                    }
                }
            }
            DisplayFinalAge();
        }

        private static void Display()
        {
            Console.WriteLine($"-------------Life Expectancy Calculator----------------" +
                $"\n\n\n------------Please Enter Values between  {_minValue} - {ValueQuestionLogic._maxValueAllowed} or  {YesOrNoQuestionLogic._positiveResponse} and {YesOrNoQuestionLogic._negativeResponse} for the questions------------\n\n");
        }

        private static void DisplayFinalAge()
        {
            Console.WriteLine($"\n\n-------------Your estimated life expectancy is: {QuestionnaireLogic.DisplayFinalAge(age)}---------------------------");
        }
    }
}
