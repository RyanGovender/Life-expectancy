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
        private static double AverageAge = 62;
        public static int MaxAge = 123;

        public QuestionnaireLogic(double avgAge,int maxAge)
        {
            indexTable = GetAllIndexs();
            MaxAge = maxAge;
            AverageAge = avgAge;
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
          return AverageAge += YesOrNoQuestionLogic.AgeCalculation(id, value);
        }

        public static double AgeCalculation(int id, int value)
        {
            return AverageAge += ValueQuestionLogic.AgeCalculation(id, value);
        
        }

        public static double DisplayFinalAge(int age)
        {
            return (AverageAge < age)? age : Math.Round(AverageAge);
        }
    }
}
