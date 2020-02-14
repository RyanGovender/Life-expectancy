using Life_expectancy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.LogicLayer
{
   public enum DataTypes
    {
        Integer = 0,
        StringValue = 1,
    }
    public class ValueQuestionLogic
    {
        public static List<ValueQuestion> valueQuestions = GetAllQuestions();

        private static List<ValueQuestion> GetAllQuestions()
        {
            valueQuestions = new List<ValueQuestion>
            {
                new ValueQuestion(7,"What would you rate you Overal Health?",new List<double>{1.8}),
                new ValueQuestion(10,"In a week how many times do you exercise?",new List<double>{0.6}),
                new ValueQuestion(11,"In a week how many times do you drink?",new List<double>{0.25}),

            };
            return valueQuestions;
        }
    }
}
