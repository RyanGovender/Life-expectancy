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
        public static double MaxAge = 120;
        public static double _max = 7;
        private static int _noPosition = 0;
        private static int _yesPostion = 1;

        public QuestionnaireLogic(int avg, int max,int no,int yes)
        {
            indexTable = GetAllIndexs();
            AverageAge = avg;
            _max = max;
            _noPosition =no;
            _yesPostion =yes;
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
                    return (value.Equals("yes")) ? AverageAge += item.AllValues.ElementAt(_yesPostion) : AverageAge+=item.AllValues.ElementAt(_noPosition);
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
                    return value>=_max? AverageAge += item.AllValues.ElementAt(0) * _max : AverageAge += item.AllValues.ElementAt(0) * value;
                   }
                }
            return AverageAge;
        }

        public static double DisplayFinalAge(int age)
        {
            return (AverageAge < age)? age : Math.Round(AverageAge);
        }

       
        public static void DisplayFinalMessage()
        {
            
        }
    }
}
