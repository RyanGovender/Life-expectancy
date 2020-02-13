using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.Models
{
   public class StringQuestion: Question
    {
        public List<string> ListOfPossibleAnswers { get; set; }

        public StringQuestion(int id,string question,List<string> possibleAnswers):base(id,question)
        {
            ListOfPossibleAnswers = possibleAnswers;
        }
    }
}
