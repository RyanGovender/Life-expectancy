using Life_expectancy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.LogicLayer
{
    public class YesOrNoQuestionLogic
    {
        public static List<YesOrNoQuestions> _yesOrNoQuestions = GetAllQuestion();

        public static List<YesOrNoQuestions> GetAllQuestion()
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

        public static string DisplayQuestion(string question, QuestionType type)
        {
            return type == QuestionType.YesOrNoQuestion ? question + " (Yes/No)" : question;
        }
    }
}
