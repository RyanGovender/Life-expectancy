using Life_expectancy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.LogicLayer
{
   public class StringQuestionLogic
    {
        public static List<StringQuestion> _stringQuestions = GetAllQuestions();
        private static List<string> _yesOrNoList = ReturnYesOrNoList();

        public static List<StringQuestion> GetAllQuestions()
        {
           return _stringQuestions = new List<StringQuestion>
            {
                new StringQuestion(1,"Hi",_yesOrNoList)
            };
        }

        private static List<string> ReturnYesOrNoList()
        {
          return  _yesOrNoList = new List<string>
            {
                "yes",
                "no"
            };
        }
    }
}
