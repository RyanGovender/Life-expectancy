using Life_expectancy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Life_expectancy.LogicLayer
{
   public class QuestionnaireLogic
    {
        public static List<Question> indexTable = GetAllIndexs();
        private static double _averageAge = AverageAgeLogic.averageAge;

        public static List<Question> GetAllIndexs()
        {
            var yesOrNoQuestions = YesOrNoQuestionLogic._yesOrNoQuestions.Cast<Question>().ToList();
            var valueQuestions = ValueQuestionLogic.valueQuestions.Cast<Question>().ToList();
            yesOrNoQuestions.ForEach(item => valueQuestions.Add(item));

            return valueQuestions;
        }

        public static double AgeCalculation(int id, string value)
        {
            return _averageAge += YesOrNoQuestionLogic.AgeCalculation(id, value);
        }

        public static double AgeCalculation(int id, int value)
        {
            return _averageAge += ValueQuestionLogic.AgeCalculation(id, value);
        }

        public static double DisplayFinalAge(int age)
        {
            return (_averageAge < age)? age : Math.Round(_averageAge);
        }
    }
}
