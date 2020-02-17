using Life_expectancy.Models;
using System.Collections.Generic;

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
        public static int _maxValueAllowed = 7;
        private static double _returnDefault = 0;

        public ValueQuestionLogic(int maxValueAllowed, double defaultReturnAmount)
        {
            valueQuestions = GetAllQuestions();
            _maxValueAllowed = maxValueAllowed;
            _returnDefault = defaultReturnAmount;
        }

        private static List<ValueQuestion> GetAllQuestions()
        {
            valueQuestions = new List<ValueQuestion>
            {
                new ValueQuestion(7,"What would you rate you Overal Health?",1.8),
                new ValueQuestion(10,"In a week how many times do you exercise?",0.6),
                new ValueQuestion(11,"In a week how many times do you drink?",0.25),
            };
            return valueQuestions;
        }

        public static double AgeCalculation(int id, int value)
        {
            foreach (var item in valueQuestions)
            {
                if (item.Id == id)
                {
                    return value >= _maxValueAllowed ?item.Value * _maxValueAllowed :item.Value * value;
                }
            }
            return _returnDefault;
        }
    }
}
