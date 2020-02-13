using Life_expectancy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Life_expectancy.LogicLayer
{
   public class QuestionnaireLogic
    {
        public static List<Question> indexTable = GetAllIndexs();
        public static double AverageAge = 62;

        public QuestionnaireLogic(int avg)
        {
            AverageAge = avg;
        }
       

        public static List<Question> GetAllIndexs()
        {
            var yesOrNoQuestions = YesOrNoQuestionLogic._yesOrNoQuestions.Cast<Question>().ToList();
            var valueQuestions = ValueQuestionLogic.valueQuestions.Cast<Question>().ToList();
            yesOrNoQuestions.ForEach(item => valueQuestions.Add(item));

            return valueQuestions;
        }


        public static double AgeCalculation(int id,string value)
        {
            foreach (var item in indexTable)
            {
                if (item.Id == id)
                {
                    return (value.Equals("yes")) ? AverageAge += item.AllValues.ElementAt(1) : AverageAge+=item.AllValues.ElementAt(0);
                }
            }
            return AverageAge;
        }

        public static double AgeCalculation(int id, int value)
        {
            foreach (var item in indexTable)
            {
                if (item.Id == id)
                {
                    AverageAge += item.AllValues.ElementAt(0)*value;                }
            }
            return AverageAge;
        }

        public static double DisplayFinalAge(int age)
        {
            return (AverageAge < age)? age : AverageAge;
        }

        public static string DisplayQuestion(string question, QuestionType type)
        {
            return type == QuestionType.YesOrNoQuestion ? question + " (Yes/No)" : question;
        }
        public static void Display()
        {
            foreach(var item in indexTable)
            {
                Console.WriteLine($"Index: {item.Id}");
            }
        }
    }
}
