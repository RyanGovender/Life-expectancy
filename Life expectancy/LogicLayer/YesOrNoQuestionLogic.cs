using Life_expectancy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Life_expectancy.LogicLayer
{
    public class YesOrNoQuestionLogic
    {
        public static List<YesOrNoQuestions> _yesOrNoQuestions = GetAllQuestion();
        private static int _noPosition = 0;
        private static int _yesPostion = 1;
        private static double _returnDefault = 0;
        private static string _positiveResponseValue = "yes";

        public YesOrNoQuestionLogic(int noPosition, int yesPosition,double returnDefault,string positiveResponse)
        {
            _noPosition = noPosition;
            _yesPostion = yesPosition;
            _returnDefault = returnDefault;
            _positiveResponseValue = positiveResponse;
        }

        private static List<YesOrNoQuestions> GetAllQuestion()
        {
            _yesOrNoQuestions = new List<YesOrNoQuestions>
           {
                //new YesOrNoQuestions(6,"Are you male or female?",new List<double>{0,5 }),
               new YesOrNoQuestions(1,"Do you smoke?",new List<double>{12,-5}),
               new YesOrNoQuestions(2,"Do you consider yourself a safe driver?", new List<double>{-2,1 }),
               new YesOrNoQuestions(5,"Do you regularly drive above the speed limit?",new List<double>{2,-1.6}),
               new YesOrNoQuestions(3,"Do you do any sort of drugs?", new List<double>{0,-1.5})
           };
            return _yesOrNoQuestions;
        }

        public static string AddYesOrNo(string question, QuestionType type)
        {
            return type == QuestionType.YesOrNoQuestion ? question + " (Yes/No)" : question;
        }

        public static double AgeCalculation(int id, string value)
        {
            foreach (var item in _yesOrNoQuestions)
            {
                if (item.Id == id)
                {
                    return (value.Equals(_positiveResponseValue)) ?  item.AllValues.ElementAt(_yesPostion) :  item.AllValues.ElementAt(_noPosition);
                }
            }
            return _returnDefault;
        }
    }
}
