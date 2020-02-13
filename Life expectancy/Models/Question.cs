using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.Models
{
    public abstract class Question
    {
        public int Id { get; set; }
        public string QuestionToAsk { get; set; }

        public Question(int id,string question)
        {
            Id = id;
            QuestionToAsk = question;
        }

    }
}
